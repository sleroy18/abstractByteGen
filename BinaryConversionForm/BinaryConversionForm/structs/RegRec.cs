using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm.structs
{
    class RegRec
    {
        public ulong func_num { get; set; }
        public ulong scaling { get; set; }
        public ImdPtrU value { get; set; }

        public RegRec()
        {
        }

        public RegRec(ulong func_num, ulong scaling, ImdPtrU value)
        {
            this.func_num = func_num;
            this.scaling = scaling;
            this.value = value;
        }
    }
}
