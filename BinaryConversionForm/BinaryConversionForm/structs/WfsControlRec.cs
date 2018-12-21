using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm.structs
{
    class WfsControlRec
    {
        public ulong config { get; set; }
        public ImdPtrU[] unused1 = new ImdPtrU[2];
        public ImdPtrU c2 { get; set; }
        public ImdPtrU init_vrms_adj { get; set; }
        public ImdPtrU init_irms_adj { get; set; }
        public ImdPtrU[] unused2 = new ImdPtrU[10];

        public WfsControlRec()
        {
        }

        public WfsControlRec(ulong config, ImdPtrU[] unused1, ImdPtrU c2, ImdPtrU init_vrms_adj, ImdPtrU init_irms_adj, ImdPtrU[] unused2)
        {
            this.config = config;
            this.unused1 = unused1;
            this.c2 = c2;
            this.init_vrms_adj = init_vrms_adj;
            this.init_irms_adj = init_irms_adj;
            this.unused2 = unused2;
        }
    }
}
