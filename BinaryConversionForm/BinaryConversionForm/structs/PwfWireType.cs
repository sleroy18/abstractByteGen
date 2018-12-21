using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm.structs
{
    class PwfWireType
    {
        //char
        public byte[] wt_id { get; set; }
        //char[11]
        public sbyte[] wire_type_desc { get; set; }

        public PwfWireType()
        {
        }

        public PwfWireType(byte[] wt_id, sbyte[] wire_type_desc)
        {
            this.wt_id = wt_id;
            this.wire_type_desc = wire_type_desc;
        }
    }
}
