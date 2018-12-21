using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm.structs
{
    class CheckRec
    {
        public ulong decode { get; set; }
        public ulong logic { get; set; }
        public ulong condition { get; set; }
        public ulong scaling { get; set; }
        public ulong action { get; set; }
        public ImdPtrU value { get; set; }

        public CheckRec()
        {
        }

        public CheckRec(ulong decode, ulong logic, ulong condition, ulong scaling, ulong action, ImdPtrU value)
        {
            this.decode = decode;
            this.logic = logic;
            this.condition = condition;
            this.scaling = scaling;
            this.action = action;
            this.value = value;
        }
    }
}
