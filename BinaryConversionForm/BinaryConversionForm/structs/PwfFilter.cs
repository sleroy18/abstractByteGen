using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm.structs
{
    class PwfFilter
    {
        public long b0 { get; set; }
        public long b1 { get; set; }
        public long b2 { get; set; }
        public long a1 { get; set; }
        public long a2 { get; set; }
        //assuming BYTE data type in C is unsigned by nature
        public byte b0_scale { get; set; }
        public byte b1_scale { get; set; }
        public byte b2_scale { get; set; }
        public byte a1_scale { get; set; }
        public byte a2_scale { get; set; }
        public byte input_shift { get; set; }
        //actual byte[2] (not char)
        public byte[] reserved = new byte[2];

        public PwfFilter()
        {
        }

        public PwfFilter(long b0, long b1, long b2, long a1, long a2, byte b0_scale, byte b1_scale, byte b2_scale, byte a1_scale, byte a2_scale, byte input_shift, byte[] reserved)
        {
            this.b0 = b0;
            this.b1 = b1;
            this.b2 = b2;
            this.a1 = a1;
            this.a2 = a2;
            this.b0_scale = b0_scale;
            this.b1_scale = b1_scale;
            this.b2_scale = b2_scale;
            this.a1_scale = a1_scale;
            this.a2_scale = a2_scale;
            this.input_shift = input_shift;
            this.reserved = reserved;
        }
    }
}
