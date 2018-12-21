using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm.structs
{
    class PwfSystemType
    {
        public ulong id { get; set; }
        //char[32]
        public sbyte[] name { get; set; }
        //char[MAX_MODES/8]???
        public byte[] members { get; set; }

        public PwfSystemType()
        {
        }

        public PwfSystemType(ulong id, sbyte[] name, byte[] members)
        {
            this.id = id;
            this.name = name;
            this.members = members;
        }
    }
}
