using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BinaryConversionForm
{
    public partial class CompiledData : Form
    {
        private List<ByteStructure> byteStructs = new List<ByteStructure>();
        Dictionary<string, int> DataTypes = new Dictionary<string, int>
        {
            {"Char", 0 },
            {"Short", 1 },
            {"Long", 2 },
            {"String", 3 },
            {"Double", 4 }
        };
        public CompiledData(List<ByteStructure> byteStructs)
        {
            InitializeComponent();
            this.byteStructs = byteStructs;

        }

        private void compiledData_Load(object sender, EventArgs e)
        {
            foreach(ByteStructure bS in byteStructs)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView.Rows[0].Clone();
                int type = 0;
                row.Cells[0].Value = Convert.ToString(Convert.ToInt32(bS.IsSigned), 2);
                if (bS.IsSigned)
                {
                    type += 128;
                }              
                if(bS.NumReps > 0)
                {
                    type += 64;
                }

                type += DataTypes[bS.DataType];

                if(type >= 128)
                {
                    row.Cells[0].Value = Convert.ToString(type, 2)[0];
                    row.Cells[1].Value = Convert.ToString(type, 2)[1];
                    row.Cells[2].Value = Convert.ToString(type, 2).Substring(2, 6);
                }
                else if(type >= 64 )
                {
                    row.Cells[0].Value = 0;
                    row.Cells[1].Value = Convert.ToString(type, 2)[0];
                    row.Cells[2].Value = Convert.ToString(type, 2).Substring(1, 6);
                }
                else
                {
                    row.Cells[0].Value = 0;
                    row.Cells[1].Value = 0;
                    row.Cells[2].Value = Convert.ToString(type, 2);
                }

                string length = "";
                string values = "";
                if (bS.DataType == "String")
                {
                    for (int i = 0; i < bS.Values.Count; i++)
                    {
                        length += Convert.ToString(bS.Values[0].Length, 2);
                        if (i != bS.Values.Count - 1)
                        {
                            length = length + "-";
                        }
                        byte[] arr = Encoding.ASCII.GetBytes(bS.Values[i]);
                        for (int j = 0; j < arr.Length; j++)
                        {
                            values += Convert.ToString(arr[j],2);
                            if(j < arr.Length - 1)
                            {
                                values += "-";
                            }
                        }
                        if (i < bS.Values.Count - 1)
                        {
                            values += "|";
                        }
                    } 
                }
                else
                {
                    for(int i = 0; i< bS.Values.Count; i++)
                    {
                        byte[] arr = Encoding.ASCII.GetBytes(bS.Values[i]);
                        for(int j = 0; j < arr.Length; j++)
                        {
                            values += Convert.ToString(arr[j], 2);
                            if (j != bS.Values.Count - 1)
                            {
                                values += "-";
                            }
                        }
                        if (i < bS.Values.Count - 1)
                        {
                            values += "|";
                        }
                    }
                }  
                row.Cells[3].Value = length;
                row.Cells[4].Value = values;
                dataGridView.Rows.Add(row);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
