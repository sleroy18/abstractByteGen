using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm
{
    class Enums
    {
        public enum DataTypes : UInt16
        {
            Byte,
            Int16,
            Int32,
            Int64,
            String,
            Collection,
            User_Defined_Type
        };

        public enum StructTypes
        {
            AutoRecord,
            CheckRec,
            DspStateTable,
            FgenDataVerifyStruct,
            ImdPtrU,
            LEALFileHeader,
            LimRec,
            ModeDirectory,
            PwfAmpsEntry,
            PwfAmpsTable,
            PwfCategory,
            PwfCategoryString,
            PwfControl,
            PwfEDSHeader,
            PwfEDSRec,
            PwfExposed,
            PwfFat,
            PwfFilter,
            PwfKey,
            PwfProcInfo,
            PwfState,
            PwfSynergicWFSRec,
            PwfSystemType,
            PwfWireType,
            PWZCompressed,
            PWZHeader,
            RegRec,
            SfRec,
            TouchRetract,
            WfsControlRec,
            testClass,
            innerTestClass
        }
    }
}
