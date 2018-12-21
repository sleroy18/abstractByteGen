using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm.structs
{
    class PwfEDSHeader
    {
        //char
        public byte n_edsrecs { get; set; }
        //char
        public byte n_synrecs { get; set; }
        public ushort nbytes { get; set; }
        public ulong mode_descriptor { get; set; }
        public ulong seq_attr_relevance { get; set; }
        public ushort func_out_relevance { get; set; }
        public ushort wpt_offset { get; set; }
        public ushort trim_offset { get; set; }
        public ushort wc1_offset { get; set; }
        public ushort wc2_offset { get; set; }
        public ushort wc3_offset { get; set; }
        public ushort wc4_offset { get; set; }
        public ushort fo1_offset { get; set; }
        public ushort fo2_offset { get; set; }
        public ushort fo3_offset { get; set; }
        public ushort fo4_offset { get; set; }
        public ushort ctwd1_offset { get; set; }
        public ushort ctwd2_offset { get; set; }
        public ushort ctwd3_offset { get; set; }
        public ushort ctwd4_offset { get; set; }
        public ushort amps1_offset { get; set; }
        public ushort amps2_offset { get; set; }
        public ushort amps3_offset { get; set; }
        public ushort amps4_offset { get; set; }
        public ushort amps_tbl_offset { get; set; }
        public ushort olc2_vrv_offset { get; set; }
        public ushort olc2_trange_offset { get; set; }
        public ushort olc2_slope_offset { get; set; }
        public ushort swfs_offset { get; set; }
        public ushort iblk_offset { get; set; }
        public ushort slave_mode_number { get; set; }
        public ushort numAutoRecs { get; set; }
        public ushort auto_recs_offset { get; set; }

        public PwfEDSHeader()
        {
        }

        public PwfEDSHeader(byte n_edsrecs, byte n_synrecs, ushort nbytes, ulong mode_descriptor, ulong seq_attr_relevance, ushort func_out_relevance, ushort wpt_offset, ushort trim_offset, ushort wc1_offset, ushort wc2_offset, ushort wc3_offset, ushort wc4_offset, ushort fo1_offset, ushort fo2_offset, ushort fo3_offset, ushort fo4_offset, ushort ctwd1_offset, ushort ctwd2_offset, ushort ctwd3_offset, ushort ctwd4_offset, ushort amps1_offset, ushort amps2_offset, ushort amps3_offset, ushort amps4_offset, ushort amps_tbl_offset, ushort olc2_vrv_offset, ushort olc2_trange_offset, ushort olc2_slope_offset, ushort swfs_offset, ushort iblk_offset, ushort slave_mode_number, ushort numAutoRecs, ushort auto_recs_offset)
        {
            this.n_edsrecs = n_edsrecs;
            this.n_synrecs = n_synrecs;
            this.nbytes = nbytes;
            this.mode_descriptor = mode_descriptor;
            this.seq_attr_relevance = seq_attr_relevance;
            this.func_out_relevance = func_out_relevance;
            this.wpt_offset = wpt_offset;
            this.trim_offset = trim_offset;
            this.wc1_offset = wc1_offset;
            this.wc2_offset = wc2_offset;
            this.wc3_offset = wc3_offset;
            this.wc4_offset = wc4_offset;
            this.fo1_offset = fo1_offset;
            this.fo2_offset = fo2_offset;
            this.fo3_offset = fo3_offset;
            this.fo4_offset = fo4_offset;
            this.ctwd1_offset = ctwd1_offset;
            this.ctwd2_offset = ctwd2_offset;
            this.ctwd3_offset = ctwd3_offset;
            this.ctwd4_offset = ctwd4_offset;
            this.amps1_offset = amps1_offset;
            this.amps2_offset = amps2_offset;
            this.amps3_offset = amps3_offset;
            this.amps4_offset = amps4_offset;
            this.amps_tbl_offset = amps_tbl_offset;
            this.olc2_vrv_offset = olc2_vrv_offset;
            this.olc2_trange_offset = olc2_trange_offset;
            this.olc2_slope_offset = olc2_slope_offset;
            this.swfs_offset = swfs_offset;
            this.iblk_offset = iblk_offset;
            this.slave_mode_number = slave_mode_number;
            this.numAutoRecs = numAutoRecs;
            this.auto_recs_offset = auto_recs_offset;
        }
    }
}
