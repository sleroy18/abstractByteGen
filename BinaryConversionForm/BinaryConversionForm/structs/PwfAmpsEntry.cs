using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm.structs
{
    class PwfAmpsEntry
    {
        public ushort ctwd { get; set; }
        public short amps { get; set; }

        public PwfAmpsEntry()
        {
        }

        public PwfAmpsEntry(ushort ctwd, short amps)
        {
            this.ctwd = ctwd;
            this.amps = amps;
        }
    }
}
