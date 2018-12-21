using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm.structs
{
    class PWZCompressed
    {
        public ulong platform { get; set; }
        public ulong mcuOffset { get; set; }
        public ulong mcuCompSize { get; set; }
        public ulong mcuUncompSize { get; set; }
        public ulong mcuChecksum { get; set; }
        public ulong fgenOffset { get; set; }
        public ulong fgenCompSize { get; set; }
        public ulong fgenUncompSize { get; set; }
        public ulong fgenChecksum { get; set; }
        public ulong pcOffset { get; set; }
        public ulong pcCompSize { get; set; }
        public ulong pcUncompSize { get; set; }
        public ulong pcChecksum { get; set; }
        public ulong wdOffset { get; set; }
        public ulong wdCompSize { get; set; }
        public ulong wdUncompSize { get; set; }
        public ulong wdChecksum { get; set; }

        public PWZCompressed()
        {

        }

        public PWZCompressed(ulong platform, ulong mcuOffset, ulong mcuCompSize, ulong mcuUncompSize, ulong mcuChecksum, ulong fgenOffset, ulong fgenCompSize, ulong fgenUncompSize, ulong fgenChecksum, ulong pcOffset, ulong pcCompSize, ulong pcUncompSize, ulong pcChecksum, ulong wdOffset, ulong wdCompSize, ulong wdUncompSize, ulong wdChecksum)
        {
            this.platform = platform;
            this.mcuOffset = mcuOffset;
            this.mcuCompSize = mcuCompSize;
            this.mcuUncompSize = mcuUncompSize;
            this.mcuChecksum = mcuChecksum;
            this.fgenOffset = fgenOffset;
            this.fgenCompSize = fgenCompSize;
            this.fgenUncompSize = fgenUncompSize;
            this.fgenChecksum = fgenChecksum;
            this.pcOffset = pcOffset;
            this.pcCompSize = pcCompSize;
            this.pcUncompSize = pcUncompSize;
            this.pcChecksum = pcChecksum;
            this.wdOffset = wdOffset;
            this.wdCompSize = wdCompSize;
            this.wdUncompSize = wdUncompSize;
            this.wdChecksum = wdChecksum;
        }
    }
}
