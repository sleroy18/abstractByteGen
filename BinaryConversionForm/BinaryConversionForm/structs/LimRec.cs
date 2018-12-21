using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm.structs
{
    class LimRec
    {
        public ulong config { get; set; }
        public ImdPtrU OCVmodek { get; set; }
        public ImdPtrU OCVmodeIMax { get; set; }
        public ImdPtrU Vmodek { get; set; }
        public ImdPtrU VmodeIMin { get; set; }
        public ImdPtrU VmodeIMax { get; set; }
        public ImdPtrU Imodek { get; set; }
        public ImdPtrU ImodeVMin { get; set; }
        public ImdPtrU ImodeVMax { get; set; }
        public ImdPtrU PmodeIMin { get; set; }
        public ImdPtrU PmodeVMin { get; set; }
        public ImdPtrU PmodeIMax { get; set; }
        public ImdPtrU PmodeVMax { get; set; }
        public ImdPtrU OCVmodeVMin { get; set; }
        public ImdPtrU VmodeVMin { get; set; }
        public ImdPtrU ImodeIMin { get; set; }

        public LimRec()
        {
        }

        public LimRec(ulong config, ImdPtrU oCVmodek, ImdPtrU oCVmodeIMax, ImdPtrU vmodek, ImdPtrU vmodeIMin, ImdPtrU vmodeIMax, ImdPtrU imodek, ImdPtrU imodeVMin, ImdPtrU imodeVMax, ImdPtrU pmodeIMin, ImdPtrU pmodeVMin, ImdPtrU pmodeIMax, ImdPtrU pmodeVMax, ImdPtrU oCVmodeVMin, ImdPtrU vmodeVMin, ImdPtrU imodeIMin)
        {
            this.config = config;
            OCVmodek = oCVmodek;
            OCVmodeIMax = oCVmodeIMax;
            Vmodek = vmodek;
            VmodeIMin = vmodeIMin;
            VmodeIMax = vmodeIMax;
            Imodek = imodek;
            ImodeVMin = imodeVMin;
            ImodeVMax = imodeVMax;
            PmodeIMin = pmodeIMin;
            PmodeVMin = pmodeVMin;
            PmodeIMax = pmodeIMax;
            PmodeVMax = pmodeVMax;
            OCVmodeVMin = oCVmodeVMin;
            VmodeVMin = vmodeVMin;
            ImodeIMin = imodeIMin;
        }
    }
}
