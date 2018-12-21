using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm.structs
{
    class PwfSynergicWFSRec
    {
        //char
        public byte syn_flags { get; set; }
        //char
        public byte mod_flags { get; set; }
        public ushort value { get; set; }
        public ushort seq_state_mask { get; set; }
        public short wave_factor { get; set; }
        public short scale_factor { get; set; }
        public ushort update_rate { get; set; }
        public ushort target_class { get; set; }
        public ushort target_attr { get; set; }
        public ushort target_instance { get; set; }
        public ushort reserved { get; set; }

        public PwfSynergicWFSRec()
        {
        }

        public PwfSynergicWFSRec(byte syn_flags, byte mod_flags, ushort value, ushort seq_state_mask, short wave_factor, short scale_factor, ushort update_rate, ushort target_class, ushort target_attr, ushort target_instance, ushort reserved)
        {
            this.syn_flags = syn_flags;
            this.mod_flags = mod_flags;
            this.value = value;
            this.seq_state_mask = seq_state_mask;
            this.wave_factor = wave_factor;
            this.scale_factor = scale_factor;
            this.update_rate = update_rate;
            this.target_class = target_class;
            this.target_attr = target_attr;
            this.target_instance = target_instance;
            this.reserved = reserved;
        }
    }
}
