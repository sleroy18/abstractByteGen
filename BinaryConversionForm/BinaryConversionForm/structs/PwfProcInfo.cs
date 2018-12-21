using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm.structs
{
    class PwfProcInfo
    {
        //char
        public byte sc_pt { get; set; }
        //char
        public byte sc_wt { get; set; }
        //char
        public byte sc_ws { get; set; }
        //char
        public byte sc_gas { get; set; }
        //char[17]
        public sbyte[] process_name { get; set; }
        //char[17]
        public sbyte[] procedure_desc { get; set; }
        //char[17]
        public sbyte[] gas_desc { get; set; }
        //char[20]
        public sbyte[] featureName { get; set; }
        //char[12]
        public sbyte[] kNumber { get; set; }
        //char
        public byte[] wcDCOffset { get; set; }
        public ushort freqMin { get; set; }
        public ushort freqNom { get; set; }
        public ushort freqMax { get; set; }
        public ushort balMin { get; set; }
        public ushort balNom { get; set; }
        public ushort balMax { get; set; }
        public ulong specifiersAddr { get; set; }
        public ulong keysAddr { get; set; }
        public ushort numSpecifiers { get; set; }
        public ushort numKeys { get; set; }

        public PwfProcInfo()
        {
        }

        public PwfProcInfo(byte sc_pt, byte sc_wt, byte sc_ws, byte sc_gas, sbyte[] process_name, sbyte[] procedure_desc, sbyte[] gas_desc, sbyte[] featureName, sbyte[] kNumber, byte[] wcDCOffset, ushort freqMin, ushort freqNom, ushort freqMax, ushort balMin, ushort balNom, ushort balMax, ulong specifiersAddr, ulong keysAddr, ushort numSpecifiers, ushort numKeys)
        {
            this.sc_pt = sc_pt;
            this.sc_wt = sc_wt;
            this.sc_ws = sc_ws;
            this.sc_gas = sc_gas;
            this.process_name = process_name;
            this.procedure_desc = procedure_desc;
            this.gas_desc = gas_desc;
            this.featureName = featureName;
            this.kNumber = kNumber;
            this.wcDCOffset = wcDCOffset;
            this.freqMin = freqMin;
            this.freqNom = freqNom;
            this.freqMax = freqMax;
            this.balMin = balMin;
            this.balNom = balNom;
            this.balMax = balMax;
            this.specifiersAddr = specifiersAddr;
            this.keysAddr = keysAddr;
            this.numSpecifiers = numSpecifiers;
            this.numKeys = numKeys;
        }
    }
}
