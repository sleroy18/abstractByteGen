using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm.structs
{
    class PwfCategoryString
    {
        //char[3]
        public byte[] langCode { get; set; }
        //char[17]
        public byte[] name { get; set; }

        public PwfCategoryString()
        {
        }

        public PwfCategoryString(byte[] langCode, byte[] name)
        {
            this.langCode = langCode;
            this.name = name;
        }
    }
}
