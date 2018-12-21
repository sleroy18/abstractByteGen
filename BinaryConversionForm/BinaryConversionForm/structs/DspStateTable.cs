using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm.structs
{
    class DspStateTable
    {
        public ulong cpfState { get; set; }
        public ulong endState { get; set; }
        public ulong doneState { get; set; }
        public ulong exitStartState { get; set; }
        public ulong exitDoneState { get; set; }
        public ulong ncb { get; set; }
        //DspControl Vcontrols { get; set; }
        public ulong nStates { get; set; }
        //DspState vStates { get; set; }
        public ulong nwp { get; set; }
        public ushort wpp { get; set; } //original type : WORD
        public ulong numExposedCols { get; set; }
        public ulong exposedColsP { get; set; }
        public ulong numExposedConsts { get; set; }
        public ulong exposedConstP { get; set; }
        public ulong numSpecifiers { get; set; }
        public ushort specifiersP { get; set; } //originalS type : UWORD
        public ulong timer1Res { get; set; }
        public ulong timer2Res { get; set; }
        public ulong timer3Res { get; set; }
        public ulong timer4Res { get; set; }
        public ulong wtGainSelect { get; set; }
        //char[16]
        public byte[] exp_md5 = new byte[16];
        public byte extensions { get; set; }

        public DspStateTable()
        {
        }
    }
}
