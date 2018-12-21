using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm.structs
{
    class ModeDirectory
    {
        //char[9]
        public byte[] wmd_name { get; set; }
        //char[7]
        public byte[] wmd_version { get; set; }
        //char[16]
        public byte[] wmd_sernum { get; set; }
        //long[max modes?]
        public long[] vFatAddr { get; set; } 

        public ModeDirectory()
        {
        }

        public ModeDirectory(byte[] wmd_name, byte[] wmd_version, byte[] wmd_sernum, long[] vFatAddr)
        {
            this.wmd_name = wmd_name;
            this.wmd_version = wmd_version;
            this.wmd_sernum = wmd_sernum;
            this.vFatAddr = vFatAddr;
        }
    }
}
