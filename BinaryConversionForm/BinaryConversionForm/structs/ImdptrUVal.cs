using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm.structs
{
    public class ImdptrUVal
    {
        public UInt16 v { get; set; }
        public UInt16 p { get; set; }

        public ImdptrUVal()
        {
        }

        public ImdptrUVal(UInt16 val, UInt16 pad)
        {
            v = val;
            p = pad;
        }
    }
}
