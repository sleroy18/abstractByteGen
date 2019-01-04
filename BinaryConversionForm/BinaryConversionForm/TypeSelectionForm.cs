using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace BinaryConversionForm
{
    public partial class TypeSelectionForm : Form
    {
        private BinaryWriter bw;
        private object currentStruct;
        Logic l = new Logic();
        public TypeSelectionForm()
        {
            InitializeComponent();
        }

        private void addTypeBtn_Click(object sender, EventArgs e)
        {
            using (FillStructForm fsf = new FillStructForm(this, structTypeCB.Text))
            {
                fsf.ShowDialog();
            }
        }

        public void generateByteDoc(object currentStruct)
        {
            this.currentStruct = currentStruct;
            createBinaryFile();

            //test object overwrites object sent by form
            //this.currentStruct = new structs.testClass(
            //    new int[] { 1, 2, 3 }, 
            //    new structs.innerTestClass[] { new structs.innerTestClass(1)},
            //    new int[][] { new int[2] { 1, 2 }, new int[2] { 3, 4 } },
            //    5,
            //    6,
            //    "hello world",
            //    (byte)'a',
            //    (byte)'b',
            //    15
            //);

            findStructInfo();           
            bw.Close();
        }

        private bool createBinaryFile()
        {
            try
            {
                bw = new BinaryWriter(new FileStream("mydata", FileMode.Create));
                return true;
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot create file.");
                return false;
            }
        }

        private bool writeToBinary(byte b)
        {
            try
            {
                bw.Write(b);
                return true;
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot write to file.");
                return false;
            }
        }

        private bool writeToBinary(byte[] b)
        {
            try
            {
                bw.Write(b);
                return true;
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot write to file.");
                return false;
            }
        }         

        /// <summary>
        /// writes the enum value of the struct type and proceeds to findPropTypeInfo()
        /// </summary>
        /// <param name="propInfo"></param>
        public void findStructInfo(PropertyInfo propInfo = null)
        {
            Type structType;
            if(propInfo != null)
            {
                structType = propInfo.PropertyType.GetElementType();
            }
            else
            {
                structType = this.currentStruct.GetType();
            }
            byte structFlag = (byte)(Enums.StructTypes)Enum.Parse(typeof(Enums.StructTypes), structType.Name);
            writeToBinary(structFlag);

            findPropTypeInfo();
        }

        /// <summary>
        /// writes the enum value of each property of the struct type along with if the property is signed, 
        /// is repeated several time and if there is an array of those values. It then proceeds to findPropertyValue()
        /// </summary>
        /// <param name="obj"></param>
        public void findPropTypeInfo(object obj = null)
        {
            PropertyInfo[] propInfoArr;
            if (obj == null)
            {
                propInfoArr = this.currentStruct.GetType().GetProperties();
            }
            else
            {
                propInfoArr = obj.GetType().GetProperties();
            }
            //this is messy. can it be divided out to be made its own function for getRepFlag()?
            int repCounter = 0;
            for (int i = 0; i < propInfoArr.Length; i++)
            {
                Property prop = new Property();
                prop.propInfo = propInfoArr[i];
                prop.type = propInfoArr[i].PropertyType;
                prop = generatePropFlags(prop);
                if (repCounter > 0)
                {
                    repCounter--;
                }
                else
                {
                    if (i <= propInfoArr.Length - 2)
                    {
                        for (int j = i + 1; j < propInfoArr.Length; j++)
                        {
                            if (propInfoArr[i].PropertyType == propInfoArr[j].PropertyType)
                            {
                                repCounter++;
                                prop.repFlag = 64;
                            }
                            else
                            {
                                break;
                            }
                        }                      
                    }
                    writeToBinary(prop.constructTypeByte());
                    if (repCounter > 0)
                    {
                        writeToBinary((byte)repCounter);
                    }
                }
                if(prop.arrFlag == 32)
                {
                    if(prop.propInfo.PropertyType == typeof(string) )
                    {
                        findArrayValues(prop.propInfo.GetValue(this.currentStruct).ToString().ToCharArray());
                    }
                    else
                    {
                        findArrayValues((Array)prop.propInfo.GetValue(this.currentStruct));
                    }
                }
                else
                {                    
                    findPropertyValue(prop, obj);                
                }                             
            }
        }

        /// <summary>
        /// writes the value, in byte(s) or if the value is a User-Defined-Type, directs
        /// the value back to findPropertyTypeInfo()
        /// </summary>
        /// <param name="prop"></param>
        /// <param name="parentObj"></param>
        public void findPropertyValue(Property prop, object parentObj = null)
        {
            Enums.StructTypes structType;
            //if property type is a struct type
            if (Enum.TryParse(prop.GetType().Name, out structType))
            {
                writeToBinary((byte)structType);
                findPropTypeInfo(prop.type);
            }
            else
            {
                if(parentObj == null)
                {                    
                    writeUnknownType(prop.propInfo.GetValue(this.currentStruct), prop.propInfo.PropertyType);
                }
                else
                {
                    writeUnknownType(prop.propInfo.GetValue(parentObj), prop.propInfo.PropertyType);
                }
            }
        }

        /// <summary>
        /// writes the individual array values. If the value is a nested array then it is sent back
        /// through this function. If the values in the array are a User-Defined-Type they are sent
        /// to the findPropTypeInfo() function to extract all values of that type.
        /// </summary>
        /// <param name="propArr"></param>
        /// <param name="isNested"></param>
        public void findArrayValues(Array propArr, bool isNested = false)
        {
            if (isNested)
            {
                Property prop = new Property();
                prop.type = propArr.GetType();
                prop = generatePropFlags(prop);
                writeToBinary(prop.constructTypeByte());
            }
            writeToBinary((byte)propArr.Length);
            if(propArr.GetType().GetElementType() == typeof(char))
            {
                writeToBinary(Encoding.UTF8.GetBytes((char[])propArr));
            }
            else
            {
                foreach (var item in propArr)
                {
                    Enums.StructTypes structType;
                    //if property type is a struct type
                    if (Enum.TryParse(item.GetType().Name, out structType))
                    {
                        byte test = (byte)structType;
                        findPropTypeInfo(item);
                    }
                    else if (l.IsPropertyACollection(item.GetType()))
                    {
                        findArrayValues((Array)item, true);
                    }
                    else
                    {
                        Type arrType = propArr.GetType().GetElementType();
                        writeUnknownType(item, arrType);
                    }
                }
            }                
        }

        public void writeUnknownType(object obj, Type t)
        {
            //cannot dynmically convert type to a type unknown at runtime. Must be explicit cast
            //if anyone finds the way to do this please send to sleroy18@jcu.edu because I was miserable scouring the internet for the solution
            if (t == typeof(byte))
            {
                writeToBinary((byte)obj);
            }
            else if(t == typeof(char))
            {
                writeToBinary(Encoding.UTF8.GetBytes(obj.ToString().ToCharArray()));
            }
            else if (t == typeof(sbyte))
            {
                writeToBinary(BitConverter.GetBytes((sbyte)obj));
            }
            else if (t == typeof(UInt16))
            {
                writeToBinary(BitConverter.GetBytes((UInt16)obj));
            }
            else if (t == typeof(Int16))
            {
                writeToBinary(BitConverter.GetBytes((Int16)obj));
            }
            else if (t == typeof(UInt32))
            {
                writeToBinary(BitConverter.GetBytes((UInt32)obj));
            }
            else if (t == typeof(Int32))
            {
                writeToBinary(BitConverter.GetBytes((Int32)obj));
            }
            else if (t == typeof(UInt64))
            {
                writeToBinary(BitConverter.GetBytes((UInt64)obj));
            }
            else if (t == typeof(Int64))
            {
                writeToBinary(BitConverter.GetBytes((Int64)obj));
            }
        }

        /// <summary>
        /// This function determines if the data type of the propertyinfo sent is signed or unsigned.
        /// Signed types have nonzero MinValue constant, which will convert into true during boolean cast.
        /// </summary>
        /// <param name="prop"></param>
        /// <returns>a value added to the typeByte to show if the data is signed or not</returns>
        public byte getSigFlag(Type propType)
        {
            if (propType.IsPrimitive)
            {
                if (Convert.ToBoolean(propType.GetField("MinValue").GetValue(null))){
                    return 128;
                }
            }           
            return 0;
        }

        public byte getArrayFlag(Type propType)
        {
            if (l.IsPropertyACollection(propType))
            {
                return 32;
            }
            return 0;
        }

        public byte getDataFlag(Type propType)
        {           
            Enums.DataTypes propDataType;
            //Noraml Data Type
            if (Enum.TryParse(propType.Name, out propDataType))
            {
                return (byte)propDataType;
            }
            //Data Type is an Array
            else if (getArrayFlag(propType) == 32)
            {
                Enums.StructTypes structDataType;
                //Data Type is a normal Array
                if (Enum.TryParse(propType.GetElementType().Name, out propDataType))
                {
                    return (byte)propDataType;
                }
                //Data Type is an Array of Structs
                else if (Enum.TryParse(propType.GetElementType().Name, out structDataType))
                {
                    return (byte)Enums.DataTypes.User_Defined_Type;
                }
                return (byte)Enums.DataTypes.Collection;
            }
            //If not a normal type or array then must be a struct
            return (byte)Enums.DataTypes.User_Defined_Type;
        }

        public Property generatePropFlags(Property prop)
        {
            Type propType = prop.type;
            prop.arrFlag = getArrayFlag(propType);

            //if the type being sent here is also an array then to get the type that the array is needs to be sent to sigFlag and dataFlag
            if (l.IsPropertyACollection(propType))
            {
                propType = propType.GetElementType();
            }

            prop.sigFlag = getSigFlag(propType);
            prop.dataFlag = getDataFlag(propType);
                    
            return prop;            
        }
    }
}