using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace BinaryConversionForm
{
    public partial class FillStructForm : Form
    {
        private const int verticalBuffer = 10;
        private const int horizontalBuffer = 8;
        private const int labelHeight = 20;
        private const int labelWidth = 100;
        private const int tbHeight = 20;
        private const int tbWidth = 120;
        private const int headerWidth = 300;
        private static int nextX = horizontalBuffer;
        private static int nextY = 40;
        private static Type type;
        private TypeSelectionForm tsf;
        Logic l = new Logic();
        public FillStructForm(TypeSelectionForm tsf, string structType)
        {
            this.tsf = tsf;
            InitializeComponent();
            //creates instance of the selected struct type
            type = Type.GetType("BinaryConversionForm.structs." + structType);           
            generateControls(Activator.CreateInstance(type));           
        }

        private void structSubmitBtn_Click(object sender, EventArgs e)
        {
            object currentStruct = Activator.CreateInstance(type);
            Type innerType = currentStruct.GetType();
            foreach (PropertyInfo propInfo in currentStruct.GetType().GetProperties())
            {
                Enums.StructTypes structDataType;
                if (l.IsPropertyACollection(propInfo.PropertyType))
                {
                    //this would be functionality to implement getting an array of info
                    //ie) find value based on .PropertyType.GetElementType() then = data or data.toList()
                    innerType = propInfo.PropertyType.GetElementType();
                }
                PropertyInfo propertyInfo = currentStruct.GetType().GetProperty(propInfo.Name);
                //specify between byte and byte[] to determine if propertyinfo is set to single byte
                if (propInfo.PropertyType == typeof(byte))
                {
                    propertyInfo.SetValue(currentStruct, (byte)(Controls.Find(propInfo.Name, true).FirstOrDefault().Text)[0], null);
                }
                else if (propInfo.PropertyType == typeof(sbyte))
                {
                    propertyInfo.SetValue(currentStruct, (sbyte)(Controls.Find(propInfo.Name, true).FirstOrDefault().Text)[0], null);
                }
                else if (propInfo.PropertyType == typeof(byte[]) || propInfo.PropertyType == typeof(sbyte[]))
                {
                    propertyInfo.SetValue(currentStruct, Encoding.ASCII.GetBytes(Controls.Find(propInfo.Name, true).FirstOrDefault().Text), null);
                }
                else if (Enum.TryParse(propInfo.PropertyType.Name, out structDataType))
                {
                    if (l.IsPropertyACollection(propInfo.PropertyType))
                    {
                        //come back to this
                        //Issue: 
                        //propertyInfo does not know if it is an array or not so we have to treat it like a variable and use 
                        //SetValue. In doing so we have to give SetValue and array. The array we give it is an object array filled with 
                        //the same content type as the "PropertyInfo" array will need but because the array's type that we are pushing into
                        //propertyInfo is object it will not accept trying to convert object[] to whateverThisTypeEndsUpBeing[]
                        //possible fix:
                        //Just how it was done in the TypeSelectionForm where the cast had to be explicit in the writeUnknownType() function
                        //this can be done. Ask if the type is a collection what type of collection it is. It may not be able to be dynamic 
                        //but without this piece it prevents any struct with an array other than a byte[] to pass.

                        //object[] arr = new object[1];
                        //object[][] fieldArrs = new object[1][];
                        //for(int i = 0; i < arr.Length; i++)
                        //{
                        //    arr[i] = assignInnerValues(prop);
                        //    fieldArrs[i] = arr[i].GetType().GetProperties().Select(p =>
                        //    {
                        //        object value = p.GetValue(arr[i], null);
                        //        return value == null ? null : value;
                        //    })
                        //    .ToArray();
                        //}
                        //Type t = prop.PropertyType.GetElementType();
                        //var objs = arr.Select(x => Activator.CreateInstance(t, fieldArrs[0])).ToArray();

                        //propertyInfo.SetValue(currentStruct, objs, null);
                    }
                    else
                    {
                        propertyInfo.SetValue(currentStruct, assignInnerValues(propInfo), null);
                    }
                }
                else
                {
                    propertyInfo.SetValue(currentStruct, Convert.ChangeType(Controls.Find(propInfo.Name, true).FirstOrDefault().Text, propInfo.PropertyType), null);
                }
            }
            tsf.generateByteDoc(currentStruct);
            this.Close();
        }

        private void FillStructForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainContainer.Controls.Clear();
            nextX = 12;
            nextY = 30;
        }

        public void createLabel(string name, string text)
        {
            Label label = new Label()
            {
                Name = name + "Label",
                Text = text,
                Location = new Point(nextX, nextY),
                Width = labelWidth,
                Height = labelHeight,
                BorderStyle = BorderStyle.FixedSingle
        };
            mainContainer.HorizontalScroll.Value = 0;
            mainContainer.Controls.Add(label);
        }

        public void createTB(string name, string text = "")
        {
            TextBox tb = new TextBox()
            {
                Name = name,
                Text = text,
                Location = new Point(nextX, nextY),
                Height = tbHeight,
                Width = tbWidth
            };
            mainContainer.Controls.Add(tb);
        }

        //Similar to getInnerControls but uses GetType to get class variables
        public void generateControls(object str)
        {
            foreach (PropertyInfo prop in str.GetType().GetProperties())
            {
                string propType = prop.PropertyType.ToString().Split('.')[prop.PropertyType.ToString().Split('.').Length - 1];

                if (prop.PropertyType.ToString().Contains(".structs."))
                {
                    createLabel(prop.PropertyType.ToString(), propType);
                    nextY += labelHeight + verticalBuffer;

                    generateInnerControls(prop);
                }
                else
                {
                    generateControlVisuals(prop);
                }              
            }
        }

        //Similar to getControls but uses PropertyType to get class variables
        public void generateInnerControls(PropertyInfo propInfo)
        {
            PropertyInfo[] piArr = propInfo.PropertyType.GetProperties();
            if (l.IsPropertyACollection(propInfo.PropertyType))
            {
                piArr = propInfo.PropertyType.GetElementType().GetProperties();
            }
            foreach (PropertyInfo prop in piArr)
            {
                string propType = prop.PropertyType.ToString().Split('.')[prop.PropertyType.ToString().Split('.').Length - 1];

                if (prop.PropertyType.ToString().Contains(".structs."))
                {                  
                    createLabel(prop.PropertyType.ToString(), propType);
                    nextY += labelHeight + verticalBuffer;
                    generateInnerControls(prop);
                }
                else
                {
                    generateControlVisuals(prop);
                }   
            }           
        }

        public void generateControlVisuals(PropertyInfo prop)
        {
            string propType = prop.PropertyType.ToString().Split('.')[prop.PropertyType.ToString().Split('.').Length - 1];

            createLabel(prop.Name, prop.Name);
            nextX += labelWidth + horizontalBuffer;
            if (prop.PropertyType == typeof(byte[]))
            {
                createLabel(prop.Name, "Char");
            }
            else
            {
                createLabel(prop.Name, propType);
            }
            nextX += labelWidth + horizontalBuffer;
            createTB(prop.Name);
            nextX = nextX - ((labelWidth * 2) + (2 * horizontalBuffer));
            nextY += labelHeight + verticalBuffer;
        }

        public object assignInnerValues(PropertyInfo propInfo)
        {
            Type type = propInfo.PropertyType;
            PropertyInfo[] piArr = propInfo.PropertyType.GetProperties();           

            if (l.IsPropertyACollection(propInfo.PropertyType))
            {
                type = propInfo.PropertyType.GetElementType();
                piArr = propInfo.PropertyType.GetElementType().GetProperties();
            }

            object innerStruct = Activator.CreateInstance(type);
            foreach (PropertyInfo pi in piArr)
            {
                string propType = pi.PropertyType.ToString().Split('.')[pi.PropertyType.ToString().Split('.').Length - 1];

                if (pi.PropertyType.ToString().Contains(".structs."))
                {
                    pi.SetValue(innerStruct, assignInnerValues(pi), null);
                }
                else
                {
                    pi.SetValue(innerStruct, Convert.ChangeType(Controls.Find(pi.Name, true).FirstOrDefault().Text, pi.PropertyType), null);
                }
            }
            return innerStruct;
        }
    }
}
