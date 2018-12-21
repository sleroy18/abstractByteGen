using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm.structs
{
    class PwfAmpsTable
    {
        public ushort numCols { get; set; }
        public PwfAmpsEntry[] columns { get; set; }

        public PwfAmpsTable()
        {
        }

        public PwfAmpsTable(ushort num_cols, PwfAmpsEntry[] columns)
        {
            this.numCols = num_cols;
            this.columns = columns;
        }
    }
}
