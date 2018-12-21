using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm.structs
{
    class PwfEDSRec
    {
        //char
        public byte attr_flags { get; set; }
        //char
        public byte mod_flags { get; set; }
        //char
        public byte units_code { get; set; }
        //char
        public byte dec { get; set; } //original name: decimal (cannot use as name)
        public short center { get; set; }
        public short value { get; set; }
        public short min { get; set; }
        public short max { get; set; }
        public short wave_factor { get; set; }
        public short scale_factor { get; set; }
        //char[16]
        public byte[] name { get; set; }

        public PwfEDSRec()
        {
        }

        public PwfEDSRec(byte attr_flags, byte mod_flags, byte units_code, byte dec, short center, short value, short min, short max, short wave_factor, short scale_factor, byte[] name)
        {
            this.attr_flags = attr_flags;
            this.mod_flags = mod_flags;
            this.units_code = units_code;
            this.dec = dec;
            this.center = center;
            this.value = value;
            this.min = min;
            this.max = max;
            this.wave_factor = wave_factor;
            this.scale_factor = scale_factor;
            this.name = name;
        }
    }
}
