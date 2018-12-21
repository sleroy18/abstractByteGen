using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm.structs
{
    class LEALFileHeader
    {
        //char[2]
        public byte[] magic { get; set; }
        public short headerVersion { get; set; }
        public long fileSize { get; set; }
        public long checksum { get; set; }
        public long fileType { get; set; }
        //char[16]
        public byte[] codeVersion { get; set; }
        //char[16]
        public byte[] date { get; set; }
        //char[16]
        public byte[] time { get; set; }

        public LEALFileHeader()
        {
        }

        public LEALFileHeader(byte[] magic, short headerVersion, long fileSize, long checksum, long fileType, byte[] codeVersion, byte[] date, byte[] time)
        {
            this.magic = magic;
            this.headerVersion = headerVersion;
            this.fileSize = fileSize;
            this.checksum = checksum;
            this.fileType = fileType;
            this.codeVersion = codeVersion;
            this.date = date;
            this.time = time;
        }
    }


}
