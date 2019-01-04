using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm.structs
{
    class testClass
    {
        public int[] testIntArr { get; set; }
        public innerTestClass[] innerTestArr { get; set; }
        public int[][] nestedArrs { get; set; }
        public int testInt { get; set; }
        public int testInt2 { get; set; }
        public string testString1 { get; set; }
        public byte testByte1 { get; set; }
        public byte testByte2 { get; set; }
        public sbyte testSByte1 { get; set; }

        public testClass()
        {
        }

        public testClass(int[] testIntArr, innerTestClass[] innerTestArr, int[][] nestedArrs, int testInt, int testInt2, string testString1, byte testByte1, byte testByte2, sbyte testSByte1)
        {
            this.testIntArr = testIntArr;
            this.innerTestArr = innerTestArr;
            this.nestedArrs = nestedArrs;
            this.testInt = testInt;
            this.testInt2 = testInt2;
            this.testString1 = testString1;
            this.testByte1 = testByte1;
            this.testByte2 = testByte2;
            this.testSByte1 = testSByte1;
        }
    }


}
