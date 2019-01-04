using System;
using System.Reflection;

namespace BinaryConversionForm
{
    public class Property
    {
        public PropertyInfo propInfo { get; set; }
        public Type type { get; set; }
        public byte sigFlag { get; set; }
        public byte repFlag { get; set; }
        public byte arrFlag { get; set; }
        public byte dataFlag { get; set; }
        public Property()
        {
            
        }

        public byte constructTypeByte()
        {
            return (byte)(sigFlag + repFlag + arrFlag + dataFlag);
        }
    }
}
