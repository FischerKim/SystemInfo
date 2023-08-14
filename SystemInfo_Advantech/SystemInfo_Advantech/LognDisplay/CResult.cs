using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemInfo_Advantech
{
    public class CResult
    {
        #region VARIABLE
        private DateTime m_OTime = DateTime.MinValue;

        //Temperature
        private double m_F64CPUCoreTemp_1 = 0;
        //private double m_F64CPUCoreTemp_1_min = Double.MaxValue;
        //private double m_F64CPUCoreTemp_1_max = Double.MinValue;
        private double m_F64CPUCoreTemp_2 = 0;
        //private double m_F64CPUCoreTemp_2_min = Double.MaxValue;
        //private double m_F64CPUCoreTemp_2_max = Double.MinValue;
        private double m_F64CPUCoreTemp_3 = 0;
        //private double m_F64CPUCoreTemp_3_min = Double.MaxValue;
        //private double m_F64CPUCoreTemp_3_max = Double.MinValue;
        private double m_F64CPUCoreTemp_4 = 0;
        //private double m_F64CPUCoreTemp_4_min = Double.MaxValue;
        //private double m_F64CPUCoreTemp_4_max = Double.MinValue;
        private double m_F64CPUCoreTemp_Package = 0;
        //private double m_F64CPUCoreTemp_Package_min = Double.MaxValue;
        //private double m_F64CPUCoreTemp_Package_max = Double.MinValue;

        //Power
        private double m_F64CPUPackagePower = 0;
        //private double m_F64CPUPackagePower_min = Double.MaxValue;
        //private double m_F64CPUPackagePower_max = Double.MinValue;
        private double m_F64CPUCorePower = 0;
        //private double m_F64CPUCorePower_min = Double.MaxValue;
        //private double m_F64CPUCorePower_max = Double.MinValue;

        //Clock
        private double m_F64CPUCoreClock_1 = 0;
        //private double m_F64CPUCoreClock_1_min = Double.MaxValue;
        //private double m_F64CPUCoreClock_1_max = Double.MinValue;
        private double m_F64CPUCoreClock_2 = 0;
        //private double m_F64CPUCoreClock_2_min = Double.MaxValue;
        //private double m_F64CPUCoreClock_2_max = Double.MinValue;
        private double m_F64CPUCoreClock_3 = 0;
        //private double m_F64CPUCoreClock_3_min = Double.MaxValue;
        //private double m_F64CPUCoreClock_3_max = Double.MinValue;
        private double m_F64CPUCoreClock_4 = 0;
        //private double m_F64CPUCoreClock_4_min = Double.MaxValue;
        //private double m_F64CPUCoreClock_4_max = Double.MinValue;
        #endregion


        #region PROPERTIES
        public DateTime OTime
        {
            get { return this.m_OTime; }
            set { this.m_OTime = value; }
        }


        public double F64CPUCoreTemp_1
        {
            get { return this.m_F64CPUCoreTemp_1; }
            set { this.m_F64CPUCoreTemp_1 = value; }
        }

        //public double F64CPUCoreTemp_1_min
        //{
        //    get { return this.m_F64CPUCoreTemp_1_min; }
        //    set { this.m_F64CPUCoreTemp_1_min = value; }
        //}

        //public double F64CPUCoreTemp_1_max
        //{
        //    get { return this.m_F64CPUCoreTemp_1_max; }
        //    set { this.m_F64CPUCoreTemp_1_max = value; }
        //}

        public double F64CPUCoreTemp_2
        {
            get { return this.m_F64CPUCoreTemp_2; }
            set { this.m_F64CPUCoreTemp_2 = value; }
        }

        //public double F64CPUCoreTemp_2_min
        //{
        //    get { return this.m_F64CPUCoreTemp_2_min; }
        //    set { this.m_F64CPUCoreTemp_2_min = value; }
        //}

        //public double F64CPUCoreTemp_2_max
        //{
        //    get { return this.m_F64CPUCoreTemp_2_max; }
        //    set { this.m_F64CPUCoreTemp_2_max = value; }
        //}

        public double F64CPUCoreTemp_3
        {
            get { return this.m_F64CPUCoreTemp_3; }
            set { this.m_F64CPUCoreTemp_3 = value; }
        }

        //public double F64CPUCoreTemp_3_min
        //{
        //    get { return this.m_F64CPUCoreTemp_3_min; }
        //    set { this.m_F64CPUCoreTemp_3_min = value; }
        //}

        //public double F64CPUCoreTemp_3_max
        //{
        //    get { return this.m_F64CPUCoreTemp_3_max; }
        //    set { this.m_F64CPUCoreTemp_3_max = value; }
        //}

        public double F64CPUCoreTemp_4
        {
            get { return this.m_F64CPUCoreTemp_4; }
            set { this.m_F64CPUCoreTemp_4 = value; }
        }

        //public double F64CPUCoreTemp_4_min
        //{
        //    get { return this.m_F64CPUCoreTemp_4_min; }
        //    set { this.m_F64CPUCoreTemp_4_min = value; }
        //}

        //public double F64CPUCoreTemp_4_max
        //{
        //    get { return this.m_F64CPUCoreTemp_4_max; }
        //    set { this.m_F64CPUCoreTemp_4_max = value; }
        //}

        public double F64CPUCoreTemp_Package
        {
            get { return this.m_F64CPUCoreTemp_Package; }
            set { this.m_F64CPUCoreTemp_Package = value; }
        }

        //public double F64CPUCoreTemp_Package_min
        //{
        //    get { return this.m_F64CPUCoreTemp_Package_min; }
        //    set { this.m_F64CPUCoreTemp_Package_min = value; }
        //}

        //public double F64CPUCoreTemp_Package_max
        //{
        //    get { return this.m_F64CPUCoreTemp_Package_max; }
        //    set { this.m_F64CPUCoreTemp_Package_max = value; }
        //}

        public double F64CPUPackagePower
        {
            get { return this.m_F64CPUPackagePower; }
            set { this.m_F64CPUPackagePower = value; }
        }

        //public double F64CPUPackagePower_min
        //{
        //    get { return this.m_F64CPUPackagePower_min; }
        //    set { this.m_F64CPUPackagePower_min = value; }
        //}

        //public double F64CPUPackagePower_max
        //{
        //    get { return this.m_F64CPUPackagePower_max; }
        //    set { this.m_F64CPUPackagePower_max = value; }
        //}

        public double F64CPUCorePower
        {
            get { return this.m_F64CPUCorePower; }
            set { this.m_F64CPUCorePower = value; }
        }

        //public double F64CPUCorePower_min
        //{
        //    get { return this.m_F64CPUCorePower_min; }
        //    set { this.m_F64CPUCorePower_min = value; }
        //}

        //public double F64CPUCorePower_max
        //{
        //    get { return this.m_F64CPUCorePower_max; }
        //    set { this.m_F64CPUCorePower_max = value; }
        //}

        public double F64CPUCoreClock_1
        {
            get { return this.m_F64CPUCoreClock_1; }
            set { this.m_F64CPUCoreClock_1 = value; }
        }

        //public double F64CPUCoreClock_1_min
        //{
        //    get { return this.m_F64CPUCoreClock_1_min; }
        //    set { this.m_F64CPUCoreClock_1_min = value; }
        //}

        //public double F64CPUCoreClock_1_max
        //{
        //    get { return this.m_F64CPUCoreClock_1_max; }
        //    set { this.m_F64CPUCoreClock_1_max = value; }
        //}

        public double F64CPUCoreClock_2
        {
            get { return this.m_F64CPUCoreClock_2; }
            set { this.m_F64CPUCoreClock_2 = value; }
        }

        //public double F64CPUCoreClock_2_min
        //{
        //    get { return this.m_F64CPUCoreClock_2_min; }
        //    set { this.m_F64CPUCoreClock_2_min = value; }
        //}

        //public double F64CPUCoreClock_2_max
        //{
        //    get { return this.m_F64CPUCoreClock_2_max; }
        //    set { this.m_F64CPUCoreClock_2_max = value; }
        //}

        public double F64CPUCoreClock_3
        {
            get { return this.m_F64CPUCoreClock_3; }
            set { this.m_F64CPUCoreClock_3 = value; }
        }

        //public double F64CPUCoreClock_3_min
        //{
        //    get { return this.m_F64CPUCoreClock_3_min; }
        //    set { this.m_F64CPUCoreClock_3_min = value; }
        //}

        //public double F64CPUCoreClock_3_max
        //{
        //    get { return this.m_F64CPUCoreClock_3_max; }
        //    set { this.m_F64CPUCoreClock_3_max = value; }
        //}
        public double F64CPUCoreClock_4
        {
            get { return this.m_F64CPUCoreClock_4; }
            set { this.m_F64CPUCoreClock_4 = value; }
        }

        //public double F64CPUCoreClock_4_min
        //{
        //    get { return this.m_F64CPUCoreClock_4_min; }
        //    set { this.m_F64CPUCoreClock_4_min = value; }
        //}

        //public double F64CPUCoreClock_4_max
        //{
        //    get { return this.m_F64CPUCoreClock_4_max; }
        //    set { this.m_F64CPUCoreClock_4_max = value; }
        //}
        #endregion
    }
}
