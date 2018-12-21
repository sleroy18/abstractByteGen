using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryConversionForm
{
    public partial class TypeSelectionForm : Form
    {
        private const int verticalBuffer = 10;
        private const int horizontalBuffer = 8;
        private const int labelHeight = 20;
        private const int labelWidth = 100;
        private static int nextX = horizontalBuffer;
        private static int nextY = 40;
        private BinaryWriter bw;
        private object currentStruct;
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

        public void addBinaryDisplay(Object currentStruct)
        {
            this.currentStruct = currentStruct;
            List<Property> props = new List<Property>();
            Type structType = this.currentStruct.GetType();
            //string partialStructType = structType.ToString().Split('.')[structType.ToString().Split('.').Length - 1];
            UInt16 sectionFlag = (UInt16)(Enums.StructTypes)Enum.Parse(typeof(Enums.StructTypes), structType.Name);
            createBinaryFile();
            this.currentStruct = new structs.testClass(new int[] { 1, 2, 3 }, new structs.innerTestClass[] { new structs.innerTestClass(1)});
            generateByteDoc();

            foreach (PropertyInfo prop in this.currentStruct.GetType().GetProperties())
            {
                props.AddRange(getPropertyValues(prop));
            }

            List<string> strListArr = generateByteStrings(props);    
            //come back
            //string displayBytes = fillByte(Convert.ToString(sectionFlag, 2)) + fillDisplayByte(strListArr);
           
            //binary file logic
            writeToBinary(BitConverter.GetBytes(sectionFlag));
            writeToBinary(BitConverter.GetBytes((byte)props.Count));
            writeListToBinary(props);
            
            //for (int i = 0; i < propList.Count; i++)
            //{
            //    int typeVal = i;
            //    if(propList[i].Count > 0){
            //        typeVal += propertyArr[i][0].byteSigFlag;
            //        if (propertyArr[i].Count > 1)
            //        {
            //            typeVal += 64;
            //            //must write typeByte before length
            //            writeToBinary(BitConverter.GetBytes((byte)typeVal));
            //            //# reps
            //            writeToBinary(BitConverter.GetBytes((byte)propertyArr[i].Count));

            //            //write each byte[] val after the length of how many there are
            //            foreach (Property p in propertyArr[i])
            //            {
            //                writeToBinary(p.value);
            //            }
            //        }
            //        else
            //        {
            //            writeToBinary(BitConverter.GetBytes(typeVal));
            //            //if == 1 just write index 0
            //            writeToBinary(propertyArr[i][0].value);
            //        }
            //    }  
            //}

            bw.Close();

            createLabel(structType.Name);
            nextX += horizontalBuffer + labelWidth;
            //createTB(structType.Name, displayBytes);
            nextX -= (horizontalBuffer + labelWidth);
            nextY += verticalBuffer + labelHeight;
        }

        private string fillByte(string s)
        {
            while (s.Length < 8)
            {
                s = "0" + s;
            }
            return s;
        }

        private string fillByte(string s, int p)
        {
            while (s.Length < p)
            {
                s = "0" + s;
            }
            return s;
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

        public void writeListToBinary(List<Property> props)
        {
            foreach (Property prop in props)
            {
                if((int)prop.typeFlag == (int)Enums.DataTypes.Collection)
                {

                }
            }
        }

        public void createLabel(string type)
        {
            Label label = new Label()
            {
                Name = type + "Label",
                Text = type,
                Location = new Point(nextX, nextY),
                Width = labelWidth,
                Height = labelHeight
            };
            mainContainer.HorizontalScroll.Value = 0;
            mainContainer.Controls.Add(label);
        }

        public void createTB(string type, string text)
        {
            TextBox tb = new TextBox()
            {
                Name = type + "TB",
                Text = text,
                Location = new Point(nextX, nextY),
                Height = 20,
                Width = 500
            };
            mainContainer.Controls.Add(tb);
        }

        public List<Property> getPropertyValues(PropertyInfo propInfo)
        {
            Logic l = new Logic();
            Type propType = propInfo.PropertyType;
            List<Property> props = new List<Property>();
            Property prop = new Property();
            if (l.IsPropertyACollection(propInfo.PropertyType))
            {
                if (propInfo.PropertyType.ToString().Contains(".structs."))
                {
                    //Come Back
                    //    var collection = (List<object>)propInfo.GetValue(currentStruct);
                    //    foreach(var item in collection)
                    //    }
                    //    }                   
                }
                else
                {
                    //var collection = (Array)propInfo.GetValue(currentStruct);
                    //foreach (var item in collection)
                    //{
                    //    string s = item.ToString();
                    //    Convert.ChangeType(s, propInfo.PropertyType.GetElementType());

                    //    //prop.value = ObjectToByteArray(item);
                    //    if(Enum.IsDefined(typeof(Enums.DataTypes), item.GetType().ToString()))
                    //    {                     
                    //        prop.typeFlag = (UInt16)Enum.Parse(typeof(Enums.DataTypes), item.GetType().ToString());
                    //        if (prop.typeFlag % 2 != 0)
                    //        {
                    //            prop.sigFlag = (int)Enums.Signature.Signed;
                    //            prop.byteSigFlag = 128;
                    //        }
                    //    }
                    //}
                }
            }
            else
            {
                //if (propType == typeof(byte))
                //{
                //    prop.value = new byte[] { (byte)propInfo.GetValue(currentStruct) };
                //}
                //else if (propType == typeof(byte[]))
                //{
                //    prop.value = (byte[])currentStruct.GetType().GetProperty(propInfo.Name).GetValue(currentStruct);
                //}
                //else if (propType == typeof(UInt16))
                //{
                //    prop.value = BitConverter.GetBytes((UInt16)currentStruct.GetType().GetProperty(propInfo.Name).GetValue(currentStruct));
                //}
                //else if (propType == typeof(UInt32))
                //{
                //    prop.value = BitConverter.GetBytes((UInt32)currentStruct.GetType().GetProperty(propInfo.Name).GetValue(currentStruct));
                //}
                //else if (propType == typeof(UInt64))
                //{
                //    prop.value = BitConverter.GetBytes((UInt64)currentStruct.GetType().GetProperty(propInfo.Name).GetValue(currentStruct));
                //}
                //else if (propType == typeof(sbyte))
                //{
                //    prop.value = new byte[] { (byte)propInfo.GetValue(currentStruct) };
                //    prop.sigFlag = 128;
                //}
                //else if (propType == typeof(sbyte[]))
                //{
                //    prop.value = (byte[])currentStruct.GetType().GetProperty(propInfo.Name).GetValue(currentStruct);
                //    prop.sigFlag = 128;
                //}
                //else if (propType == typeof(Int16))
                //{
                //    prop.value = BitConverter.GetBytes((Int16)currentStruct.GetType().GetProperty(propInfo.Name).GetValue(currentStruct));
                //    prop.sigFlag = 128;
                //}
                //else if (propType == typeof(Int32))
                //{
                //    prop.value = BitConverter.GetBytes((Int32)currentStruct.GetType().GetProperty(propInfo.Name).GetValue(currentStruct));
                //    prop.sigFlag = 128;
                //}
                //else if (propType == typeof(Int64))
                //{
                //    prop.value = BitConverter.GetBytes((Int64)currentStruct.GetType().GetProperty(propInfo.Name).GetValue(currentStruct));
                //    prop.sigFlag = 128;                 
                //}
                ////Come Back
                //else if (propType.ToString().Contains(".structs."))
                //{
                //    //    foreach (PropertyInfo innerPropInfo in propType.GetProperties())
                //    //    {
                //    //        propArr.AddRange(getPropertyValues(innerPropInfo));
                //    //    }
                //}
                //prop.typeFlag = (byte)(Enums.DataTypes)Enum.Parse(typeof(Enums.DataTypes), propType.Name);
                //props.Add(prop);
            }
            return props;
        }

        /// <summary>
        /// This function is used for test purposes and generates a user readable strings of binary data
        /// </summary>
        /// <param name="props"></param>
        /// <returns>A list of all user readable strings of bytes</returns>
        public List<string> generateByteStrings(List<Property> props)
        {
            List<string> byteValueStrings = new List<string>();
            foreach(Property prop in props)
            {
                string byteValueString = "";
                //props.value = byte[] and the highest index value is the first byte from left to right which results in reversed order loop.
                for (int i = prop.value.Length - 1; i >= 0; i--)
                {
                    byteValueString += fillByte(Convert.ToString(prop.value[i], 2));
                }
                byteValueStrings.Add(byteValueString);
            }
            return byteValueStrings;
        }

        //Converts byte array to a string of the bytes themselves. Only used for tool test purposes.
        //Also puts each property string into a bucket of like types 
        //possible use latter on
        //public List<string>[] generateByteStrings(List<Property> props)
        //{
        //    //initialize array of lists
        //    List<string>[] strListArr = new List<string>[Enum.GetNames(typeof(Enums.DataTypes)).Length];
        //    for (int i = 0; i < strListArr.Length; i++)
        //    {
        //        strListArr[i] = new List<string>();
        //    }
        //    foreach (Property prop in props)
        //    {
        //        string byteStr = "";
        //        for (int i = prop.value.Length - 1; i >= 0; i--)
        //        {
        //            byteStr += Convert.ToString(prop.value[i], 2);
        //        }
        //        strListArr[prop.typeFlag].Add(byteStr);
        //    }
        //    return strListArr;
        //}

        public string fillDisplayByte(List<string>[] strListArr)
        {
            string displayByte = "";
            // i is a repesentation of the Data Type Enum because 1 list is made for each type in the order they are in inside the eum 
            for (int i = 0; i < strListArr.Length; i++)
            {
                if (strListArr[i].Count > 0)
                {
                    string typeByte = "";
                    string repByte = "";
                    string valueByte = "";

                    //defaulting to 0 to save time
                    typeByte += Convert.ToString(0, 2);
                    if (strListArr[i].Count == 1)
                    {
                        //is repeated byte
                        typeByte += "0";
                        valueByte += fillByte(strListArr[i][0]);
                    }
                    else if (strListArr[i].Count > 1)
                    {
                        //visual rep (not used in prod)
                        repByte = fillByte(Convert.ToString((byte)strListArr[i].Count, 2));
                        foreach (string s in strListArr[i])
                        {
                            valueByte += fillByte(s);
                        }
                        typeByte += "1";
                    }
                    else
                    {
                        typeByte += "0";
                        valueByte += fillByte(valueByte);
                    }

                    //type byte - visual rep (not used in prod)
                    typeByte += fillByte(Convert.ToString(i, 2), 6);

                    displayByte += " type : " + typeByte;
                    if (repByte != "")
                    {
                        displayByte += " reps : " + repByte;
                    }
                    displayByte += " vals : " + valueByte;               
                }
            }
            return displayByte;
        }

        public List<byte[]> generateByteDoc(PropertyInfo propInfo = null)
        {
            PropertyInfo[] propInfoArr;
            Type structType;
            if(propInfo != null)
            {
                structType = propInfo.PropertyType.GetElementType();
                propInfoArr = new PropertyInfo[] { propInfo };
            }
            else
            {
                structType = this.currentStruct.GetType();
                propInfoArr = structType.GetProperties();
            }
            byte structFlag = (byte)(Enums.StructTypes)Enum.Parse(typeof(Enums.StructTypes), structType.Name);
            writeToBinary(structFlag);

            return findPropTypeInfo(propInfoArr);
        }

        public List<byte[]> findPropTypeInfo(PropertyInfo[] propInfoArr)
        {
            List<byte[]> byteVals = new List<byte[]>();
            int repCounter = 0;

            for (int i = 0; i < propInfoArr.Length; i++)
            {
                Property prop = new Property();
                prop.propInfo = propInfoArr[i];
                if(repCounter > 0)
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
                            }
                            else
                            {
                                break;
                            }
                        }                      
                    }
                    if(repCounter > 0)
                    {
                        prop.repFlag = 64;
                    }
                    prop.sigFlag = (byte)getSigFlag(prop.propInfo.PropertyType);                   
                    prop.arrFlag = (byte)getArrayFlag(prop.propInfo.PropertyType);
                    prop.dataFlag = (byte)(Enums.DataTypes)Enum.Parse(typeof(Enums.DataTypes), prop.propInfo.PropertyType.Name);
                    prop.typeFlag = (byte)((int)prop.sigFlag + (int)prop.repFlag + (int)prop.arrFlag + (int)prop.dataFlag);
                    writeToBinary(prop.typeFlag);
                }

                byteVals.AddRange(findPropertyValue(prop));
                
                
            }
            return byteVals;
        }

        public List<byte[]> findPropertyValue(Property prop)
        {
            List<byte[]> byteVals = new List<byte[]>();
            if (prop.arrFlag > 0)
            {
                var innerPropArr = (Array)prop.propInfo.GetValue(this.currentStruct);
                writeToBinary((byte)innerPropArr.Length);

                Enums.StructTypes innerStructType;
                bool ans = Enum.TryParse<Enums.StructTypes>(prop.propInfo.PropertyType.GetElementType().Name, out innerStructType);
                if (ans)
                {
                    byteVals.AddRange(generateByteDoc(prop.propInfo));
                }
                else
                {
                    foreach(var item in innerPropArr)
                    {
                        // iterate through list somehow and add this to the 'if' above
                    }
                }
            }
            else
            {
                prop.typeFlag += (byte)(Enums.DataTypes)Enum.Parse(typeof(Enums.DataTypes), propInfoArr[i].PropertyType.Name);
            }
            return byteVals;
        }

        /// <summary>
        /// This function determines if the data type of the propertyinfo sent is signed or unsigned.
        /// THis function is also dependent on the ordering of the DataType enum. Possibly revisit to find a less dependent way.
        /// </summary>
        /// <param name="prop"></param>
        /// <returns>a value added to the typeByte to show if the data is signed or not</returns>
        public int getSigFlag(Type propType)
        {
            int typeVal = (int)(Enums.DataTypes)Enum.Parse(typeof(Enums.DataTypes), propType.Name);
            if (propType.IsPrimitive)
            {
                if (typeVal % 2 != 0)
                {
                    return 128;
                }
            }           
            return 0;
        }

        public int getArrayFlag(Type propType)
        {
            Logic l = new Logic();
            if (l.IsPropertyACollection(propType))
            {
                return 32;
            }
            return 0;
        }
    } 
}



// ALL USED FOR REFERENCE

//failed attempt 1
//BinaryFormatter bf = new BinaryFormatter();
//using (var ms = new MemoryStream())
//{
//    MessageBox.Show(currentStruct.GetType().GetProperty(prop.Name).GetValue(currentStruct, null).ToString());
//    bf.Serialize(ms, currentStruct.GetType().GetProperty(prop.Name).GetValue(currentStruct, null));
//    test = ms.ToArray();
//}
//var t =;
//MessageBox.Show(t.GetType().ToString());


//failed attempt 2
//(byte[])typeof(BitConverter)
//    .GetMethod("GetBytes", new Type[] { currentStruct.GetType().GetProperty(prop.Name).PropertyType.GetType() })
//    .Invoke(null, new object[] { currentStruct.GetType().GetProperty(prop.Name).GetValue(currentStruct, null) });


//failed attempt 3 .... and done ... resorting to many if else statments instead of dynamic type into byte array
//test = BitConverter.GetBytes(
//    Convert.ChangeType(currentStruct.GetType()
//                            .GetProperty(prop.Name)
//                            .GetValue(currentStruct, null),
//                        currentStruct.GetType()
//                        .GetProperty(prop.Name)
//                        .PropertyType));

//MessageBox.Show(currentStruct.GetType().GetProperty(prop.Name).GetValue(currentStruct, null).ToString()); //reference
