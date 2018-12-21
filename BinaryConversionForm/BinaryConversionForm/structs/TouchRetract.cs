using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm.structs
{
    class TouchRetract
    {
        public ushort mode { get; set; }
        public ushort preheatTime { get; set; }
        public short preheatCurr { get; set; }
        public short approachSpeed { get; set; }
        public ushort retractTimeOut { get; set; }
        public short retractCurr { get; set; }
        public short retractSpeed { get; set; }
        public ushort touchTimeOut { get; set; }
        public ushort heatTime { get; set; }
        public short heatCurr { get; set; }
        public short heatSpeed { get; set; }
        public ushort wpMask { get; set; }

        public TouchRetract()
        {
        }

        public TouchRetract(ushort mode, ushort preheatTime, short preheatCurr, short approachSpeed, short uretractTimeOut, short retractCurr, short retractSpeed, short utouchTimeOut, ushort heatTime, short heatCurr, short heatSpeed, ushort wpMask)
        {
            this.mode = mode;
            this.preheatTime = preheatTime;
            this.preheatCurr = preheatCurr;
            this.approachSpeed = approachSpeed;
            this.retractTimeOut = retractTimeOut;
            this.retractCurr = retractCurr;
            this.retractSpeed = retractSpeed;
            this.touchTimeOut = touchTimeOut;
            this.heatTime = heatTime;
            this.heatCurr = heatCurr;
            this.heatSpeed = heatSpeed;
            this.wpMask = wpMask;
        }
    }
}
