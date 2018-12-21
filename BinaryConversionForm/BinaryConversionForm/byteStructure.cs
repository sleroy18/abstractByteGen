using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm
{
    public class ByteStructure
    {
        public bool IsSigned { get; set; }
        public int NumReps { get; set; }
        public string DataType { get; set; }
        public string Length { get; set; }
        public List<string> Values { get; set; }

        public ByteStructure()
        {
            this.Values = new List<string>();
        }

        public ByteStructure(bool IsSigned, int NumReps, string DataType, string Length, List<string> Values)
        {
            this.IsSigned = IsSigned;
            this.NumReps = NumReps;
            this.DataType = DataType;
            this.Length = Length;
            this.Values = Values;
        }
    }
}
