using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm.structs
{
    class SfRec
    {
        public ulong logic { get; set; }
        public ImdPtrU value { get; set; }

        public SfRec()
        {
        }

        public SfRec(ulong logic, ImdPtrU value)
        {
            this.logic = logic;
            this.value = value;
        }
    }
}
