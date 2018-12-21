using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm.structs
{
    class FgenDataVerifyStruct
    {
        public int workpointUnits;
        public int numExposedColumns;
        public int numExposedConstants;
        public int origNumWorkpoints;
        public int[] columnUnits = new int[16];
        public int[] constantUnits = new int[16];
        public double[] origWorkpoints = new double[16];

        public FgenDataVerifyStruct()
        {
        }

        public FgenDataVerifyStruct(int workpointUnits, int numExposedColumns, int numExposedConstants, int origNumWorkpoints, int[] columnUnits, int[] constantUnits, double[] origWorkpoints)
        {
            this.workpointUnits = workpointUnits;
            this.numExposedColumns = numExposedColumns;
            this.numExposedConstants = numExposedConstants;
            this.origNumWorkpoints = origNumWorkpoints;
            this.columnUnits = columnUnits;
            this.constantUnits = constantUnits;
            this.origWorkpoints = origWorkpoints;
        }
    }
}
