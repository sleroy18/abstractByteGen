using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace BinaryConversionForm.structs
{
    public unsafe class ImdPtrU
    {
        public void* Address { get; private set; }
        public ImdptrUVal value { get; private set; }

        public ImdPtrU()
        {
        }

        public ImdPtrU(void* Address, ImdptrUVal value)
        {
            this.Address = Address;
            this.value = value;
        }

        public struct Layout_1
        {
            public ImdptrUVal val;
        }

        public struct Layout_2
        {
            public ushort vp;
        }
    }
}
