using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm
{
    public class Property
    {
        public byte[] value { get; set; }
        public PropertyInfo propInfo { get; set; }
        public byte sigFlag { get; set; }
        public byte repFlag { get; set; }
        public byte arrFlag { get; set; }
        public byte dataFlag { get; set; }
        public byte typeFlag { get; set; }

        public Property()
        {
            
        }

        
    }
}
