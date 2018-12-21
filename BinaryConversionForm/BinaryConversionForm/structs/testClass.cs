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
        public testClass()
        {
        }

        public testClass(int[] testIntArr, innerTestClass[] innerTestArr)
        {
            this.testIntArr = testIntArr;
            this.innerTestArr = innerTestArr;
        }
    }


}
