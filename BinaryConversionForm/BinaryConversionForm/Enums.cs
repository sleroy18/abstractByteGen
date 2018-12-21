using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversionForm
{
    class Enums
    {

        public enum Signature
        {
            Unsigned,
            Signed
        }

        public enum DataTypes : UInt16
        {
            Byte,
            SByte,
            UInt16,
            Int16,
            UInt32,
            Int32,
            UInt64,
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
