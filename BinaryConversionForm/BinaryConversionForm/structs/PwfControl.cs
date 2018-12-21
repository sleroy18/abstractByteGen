using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm.structs
{
    class PwfControl
    {
        public ulong config { get; set; }
        public ImdPtrU regTerm { get; set; }
        public ImdPtrU slope { get; set; }
        public ImdPtrU kp { get; set; }
        public ImdPtrU ki { get; set; }
        public ImdPtrU kd { get; set; }
        public byte kpScale { get; set; }
        public byte kiScale { get; set; }
        public byte kdScale { get; set; }
        public byte reserved { get; set; }
        public ImdPtrU wpsf { get; set; }
        public ImdPtrU trimRange { get; set; }
        public ulong frequency { get; set; }
        public long forcedGSF { get; set; }
        //public ControlParamsU Params { get; set; } // original name: parmas

        public PwfControl()
        {
        }
    }
}
