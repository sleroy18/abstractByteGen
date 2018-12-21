using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm.structs
{
    class PWZHeader
    {
        //char[32]
        public sbyte[] version { get; set; }
        public ulong baseAddressMCU { get; set; }
        public ulong baseAddressFGen { get; set; }
        public ushort maxWeldModes { get; set; }
        //char
        public byte[] numSysTypes { get; set; }
        //char
        public byte[] pwzVer { get; set; }
        public ushort numCategories { get; set; }
        public ushort numCategoryLangs { get; set; }
        public ulong reserved { get; set; }
        public ulong pwf_chksum { get; set; }
        public ulong cs_bytes { get; set; }
        public ulong chksum { get; set; }

        public PWZHeader()
        {

        }

        public PWZHeader(sbyte[] version, ulong baseAddressMCU, ulong baseAddressFGen, ushort maxWeldModes, byte[] numSysTypes, byte[] pwzVer, ushort numCategories, ushort numCategoryLangs, ulong reserved, ulong pwf_chksum, ulong cs_bytes, ulong chksum)
        {
            this.version = version;
            this.baseAddressMCU = baseAddressMCU;
            this.baseAddressFGen = baseAddressFGen;
            this.maxWeldModes = maxWeldModes;
            this.numSysTypes = numSysTypes;
            this.pwzVer = pwzVer;
            this.numCategories = numCategories;
            this.numCategoryLangs = numCategoryLangs;
            this.reserved = reserved;
            this.pwf_chksum = pwf_chksum;
            this.cs_bytes = cs_bytes;
            this.chksum = chksum;
        }
    }
}
