using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm.structs
{
    class AutoRecord
    {
        //char
        public byte autoGroup { get; set; }
        //char
        public byte wsState { get; set; }
        public ushort objAttr { get; set; }
        public ushort objClass { get; set; }
        //char
        public byte varDataIndex { get; set; }
        //char
        public byte flags { get; set; }

        public AutoRecord()
        {
        }

        public AutoRecord(byte autoGroup, byte wsState, ushort objAttr, ushort objClass, byte varDataIndex, byte flags)
        {
            this.autoGroup = autoGroup;
            this.wsState = wsState;
            this.objAttr = objAttr;
            this.objClass = objClass;
            this.varDataIndex = varDataIndex;
            this.flags = flags;
        }
    }
}
