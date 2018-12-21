using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm.structs
{
    class PwfCategory
    {
        //char[MAX_MODES / 8]??
        public byte[] members { get; set; } 
        public PwfCategoryString[] names { get; set; }

        public PwfCategory()
        {
        }

        public PwfCategory(byte[] members, PwfCategoryString[] names)
        {
            this.members = members;
            this.names = names;
        }
    }
}
