using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jhjo.DB;
using Jhjo.Common;

namespace SystemInfo_Advantech
{
    public class CDB : ADB
    {
        #region SIGNLE TON
        protected static CDB Src_It = null;
        public static CDB It
        {
            get
            {
                CDB OResult = null;

                try
                {
                    if (CDB.Src_It == null)
                    {
                        CDB.Src_It = new CDB();
                    }

                    OResult = CDB.Src_It;
                }
                catch (Exception ex)
                {
                    CError.Throw(ex);
                }

                return OResult;
            }
        }
        #endregion


        #region CONST
        public const string TABLE_REPORT = "REPORT";
        public const string Datetime = "DATETIME";
        public const string F64CPUCoreTemp_1 = "CPUCoreTemp_1";
        public const string F64CPUCoreTemp_1_min = "CPUCoreTemp_1_min";
        public const string F64CPUCoreTemp_1_max = "CPUCoreTemp_1_max";
        public const string F64CPUCoreTemp_2 = "CPUCoreTemp_2";
        public const string F64CPUCoreTemp_2_min = "CPUCoreTemp_2_min";
        public const string F64CPUCoreTemp_2_max = "CPUCoreTemp_2_max";
        public const string F64CPUCoreTemp_3 = "CPUCoreTemp_3";
        public const string F64CPUCoreTemp_3_min = "CPUCoreTemp_3_min";
        public const string F64CPUCoreTemp_3_max = "CPUCoreTemp_3_max";
        public const string F64CPUCoreTemp_4 = "CPUCoreTemp_4";
        public const string F64CPUCoreTemp_4_min = "CPUCoreTemp_4_min";
        public const string F64CPUCoreTemp_4_max = "CPUCoreTemp_4_max";
        public const string F64CPUCoreTemp_Package = "CPUCoreTemp_Package";
        public const string F64CPUCoreTemp_Package_min = "CPUCoreTemp_Package_min";
        public const string F64CPUCoreTemp_Package_max = "CPUCoreTemp_Package_max";
        public const string F64CPUPackagePower = "CPUPackagePower";
        public const string F64CPUPackagePower_min = "CPUPackagePower_min";
        public const string F64CPUPackagePower_max = "CPUPackagePower_max";
        public const string F64CPUCorePower = "CPUCorePower";
        public const string F64CPUCorePower_min = "CPUCorePower_min";
        public const string F64CPUCorePower_max = "CPUCorePower_max";
        public const string F64CPUCoreClock_1 = "CPUCoreClock_1";
        public const string F64CPUCoreClock_1_min = "CPUCoreClock_1_min";
        public const string F64CPUCoreClock_1_max = "CPUCoreClock_1_max";
        public const string F64CPUCoreClock_2 = "CPUCoreClock_2";
        public const string F64CPUCoreClock_2_min = "CPUCoreClock_2_min";
        public const string F64CPUCoreClock_2_max = "CPUCoreClock_2_max";
        public const string F64CPUCoreClock_3 = "CPUCoreClock_3";
        public const string F64CPUCoreClock_3_min = "CPUCoreClock_3_min";
        public const string F64CPUCoreClock_3_max = "CPUCoreClock_3_max";
        public const string F64CPUCoreClock_4 = "CPUCoreClock_4";
        public const string F64CPUCoreClock_4_min = "CPUCoreClock_4_min";
        public const string F64CPUCoreClock_4_max = "CPUCoreClock_4_max";
        #endregion
       

        #region FUNCTION
        protected override void InitDB() { }
        #endregion
    }
}
