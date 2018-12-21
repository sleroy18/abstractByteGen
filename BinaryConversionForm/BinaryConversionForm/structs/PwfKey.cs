using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm.structs
{
    class PwfKey
    {
        public ushort keyInfo { get; set; }
        public ushort keyAttrID { get; set; }
        public ulong keyValue { get; set; }

        public PwfKey()
        {
        }

        public PwfKey(ushort keyInfo, ushort keyAttrID, ulong keyValue)
        {
            this.keyInfo = keyInfo;
            this.keyAttrID = keyAttrID;
            this.keyValue = keyValue;
        }
    }
}
