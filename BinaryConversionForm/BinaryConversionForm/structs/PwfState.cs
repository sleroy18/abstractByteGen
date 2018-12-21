using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm.structs
{
    class PwfState
    {
        public ulong misc_out { get; set; }
        public ulong wc_timers { get; set; }
        public ushort wf1_p { get; set; } //was datatype: WORD
        public ushort wf3_p { get; set; } //was datatype: WORD
        public ushort wf2_p { get; set; } //was datatype: WORD
        public ushort wf4_p { get; set; } //was datatype: WORD
        public ushort wf1_n { get; set; } //was datatype: WORD
        public ushort wf3_n { get; set; } //was datatype: WORD
        public ushort wf2_n { get; set; } //was datatype: WORD
        public ushort wf4_n { get; set; } //was datatype: WORD
        public CheckRec[] chk = new CheckRec[6];
        public RegRec[] rt = new RegRec[2];
        public SfRec[] sf = new SfRec[2];
        public SfRec[] sfNeg = new SfRec[2];

        public PwfState()
        {
        }

        public PwfState(ulong misc_out, ulong wc_timers, ushort wf1_p, ushort wf3_p, ushort wf2_p, ushort wf4_p, ushort wf1_n, ushort wf3_n, ushort wf2_n, ushort wf4_n, CheckRec[] chk, RegRec[] rt, SfRec[] sf, SfRec[] sfNeg)
        {
            this.misc_out = misc_out;
            this.wc_timers = wc_timers;
            this.wf1_p = wf1_p;
            this.wf3_p = wf3_p;
            this.wf2_p = wf2_p;
            this.wf4_p = wf4_p;
            this.wf1_n = wf1_n;
            this.wf3_n = wf3_n;
            this.wf2_n = wf2_n;
            this.wf4_n = wf4_n;
            this.chk = chk;
            this.rt = rt;
            this.sf = sf;
            this.sfNeg = sfNeg;
        }
    }
}
