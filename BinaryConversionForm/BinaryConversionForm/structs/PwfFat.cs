using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm.structs
{
    class PwfFat
    {
        public ulong stbl_vardata_addr { get; set; }
        public ulong fgen_base_addr { get; set; }
        public ulong stbl_addr { get; set; }
        public ulong proc_info_addr { get; set; }
        public ulong eds_addr { get; set; }
        public ulong exposed_addr { get; set; }
        //char[8]
        public sbyte[] filename { get; set; }
        //char[3]
        public sbyte[] extension { get; set; }
        //char
        public byte attrib { get; set; }
        public ulong checksum { get; set; }
        public ushort size { get; set; }
        public ushort flash_id { get; set; }
        public ushort file_rev { get; set; }
        public sbyte nstates { get; set; }
        public sbyte ncb { get; set; }
        public ushort stbl_id { get; set; }
        public ulong featureID { get; set; }
        public ushort eds_size { get; set; }
        public ushort pcdata_size { get; set; }
        //char
        public sbyte pcdataFormat { get; set; }
        //char
        public sbyte embeddedFormat { get; set; }
        public ulong numBytesDSP { get; set; }
        public ulong ptrDSP { get; set; }
        public ulong numBytesWD { get; set; }
        public ulong ptrWD { get; set; }
        public ulong fgenDataID { get; set; }
        public ulong extensions_addr { get; set; }

        public PwfFat()
        {
        }

        public PwfFat(ulong stbl_vardata_addr, ulong fgen_base_addr, ulong stbl_addr, ulong proc_info_addr, ulong eds_addr, ulong exposed_addr, sbyte[] filename, sbyte[] extension, byte attrib, ulong checksum, ushort size, ushort flash_id, ushort file_rev, sbyte nstates, sbyte ncb, ushort stbl_id, ulong featureID, ushort eds_size, ushort pcdata_size, sbyte pcdataFormat, sbyte embeddedFormat, ulong numBytesDSP, ulong ptrDSP, ulong numBytesWD, ulong ptrWD, ulong fgenDataID, ulong extensions_addr)
        {
            this.stbl_vardata_addr = stbl_vardata_addr;
            this.fgen_base_addr = fgen_base_addr;
            this.stbl_addr = stbl_addr;
            this.proc_info_addr = proc_info_addr;
            this.eds_addr = eds_addr;
            this.exposed_addr = exposed_addr;
            this.filename = filename;
            this.extension = extension;
            this.attrib = attrib;
            this.checksum = checksum;
            this.size = size;
            this.flash_id = flash_id;
            this.file_rev = file_rev;
            this.nstates = nstates;
            this.ncb = ncb;
            this.stbl_id = stbl_id;
            this.featureID = featureID;
            this.eds_size = eds_size;
            this.pcdata_size = pcdata_size;
            this.pcdataFormat = pcdataFormat;
            this.embeddedFormat = embeddedFormat;
            this.numBytesDSP = numBytesDSP;
            this.ptrDSP = ptrDSP;
            this.numBytesWD = numBytesWD;
            this.ptrWD = ptrWD;
            this.fgenDataID = fgenDataID;
            this.extensions_addr = extensions_addr;
        }
    }
}
