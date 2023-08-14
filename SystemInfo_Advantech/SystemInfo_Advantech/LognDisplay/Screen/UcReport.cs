using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Jhjo.Common;
using Jhjo.DB;
using System.Threading;
using System.Linq;

namespace SystemInfo_Advantech
{
    public partial class UcReport : UcScreen//UserControl//
    {
        #region VARIABLE
        private DataTable m_ODataSource = null;

        private double F64CPUCoreTemp_1_Min = double.MaxValue;
        private double F64CPUCoreTemp_2_Min = double.MaxValue;
        private double F64CPUCoreTemp_3_Min = double.MaxValue;
        private double F64CPUCoreTemp_4_Min = double.MaxValue;
        private double F64CPUCoreTemp_Package_Min = double.MaxValue;
        private double F64CPUPackagePower_Min = double.MaxValue;
        private double F64CPUCorePower_Min = double.MaxValue;
        private double F64CPUCoreClock_1_Min = double.MaxValue;
        private double F64CPUCoreClock_2_Min = double.MaxValue;
        private double F64CPUCoreClock_3_Min = double.MaxValue;
        private double F64CPUCoreClock_4_Min = double.MaxValue;

        private double F64CPUCoreTemp_1_Max = double.MinValue;
        private double F64CPUCoreTemp_2_Max = double.MinValue;
        private double F64CPUCoreTemp_3_Max = double.MinValue;
        private double F64CPUCoreTemp_4_Max = double.MinValue;
        private double F64CPUCoreTemp_Package_Max = double.MinValue;
        private double F64CPUPackagePower_Max = double.MinValue;
        private double F64CPUCorePower_Max = double.MinValue;
        private double F64CPUCoreClock_1_Max = double.MinValue;
        private double F64CPUCoreClock_2_Max = double.MinValue;
        private double F64CPUCoreClock_3_Max = double.MinValue;
        private double F64CPUCoreClock_4_Max = double.MinValue;
        #endregion


        #region CONSTRUCTOR & DESTRUCTOR
        public UcReport()
        {
            InitializeComponent();

            try
            {
                this.DgvReport.AutoGenerateColumns = false;
            }
            catch (Exception ex)
            {
                CError.Throw(ex);
            }
        }
        #endregion


        #region EVENT
        #region BUTTON EVENT
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                IDynamicTable OTable = CDB.It.GetDynamicTable(CDB.TABLE_REPORT);

                //this.DgvReport.DataSource = Selecttest(this.DtpDate.Value, true).Copy();

                DataTable OData = OTable.Select(this.DtpDate.Value, true).Copy();
                this.DgvReport.DataSource = OData;
                
                for (int i = 0; i < OData.Rows.Count; i++)
                {
                    object x = OData.Rows[i][0];
                    //Temperature
                    object y1_T = OData.Rows[i][1]; //CPU Core #1
                    object y2_T = OData.Rows[i][2]; //CPU Core #2
                    object y3_T = OData.Rows[i][3]; //CPU Core #3
                    object y4_T = OData.Rows[i][4]; //CPU Core #4
                    object y5_T = OData.Rows[i][5]; //CPU Package
                    //Power
                    object y1_P = OData.Rows[i][6]; //Package
                    object y2_P = OData.Rows[i][7]; //Cores
                    //Clock
                    object y1_C = OData.Rows[i][8]; //1
                    object y2_C = OData.Rows[i][9]; //2
                    object y3_C = OData.Rows[i][10]; //3
                    object y4_C = OData.Rows[i][11]; //4

                

                    this.Temperature.Series["CPU Core #1"].Points.AddXY(x, y1_T);
                    this.Temperature.Series["CPU Core #2"].Points.AddXY(x, y2_T);
                    this.Temperature.Series["CPU Core #3"].Points.AddXY(x, y3_T);
                    this.Temperature.Series["CPU Core #4"].Points.AddXY(x, y4_T);
                    this.Temperature.Series["CPU Package"].Points.AddXY(x, y5_T);

                    this.Power.Series["CPU Package"].Points.AddXY(x, y1_P);
                    this.Power.Series["CPU Cores"].Points.AddXY(x, y2_P);

                    this.Clock.Series["CPU Core #1"].Points.AddXY(x, y1_C);
                    this.Clock.Series["CPU Core #2"].Points.AddXY(x, y2_C);
                    this.Clock.Series["CPU Core #3"].Points.AddXY(x, y3_C);
                    this.Clock.Series["CPU Core #4"].Points.AddXY(x, y4_C);

                    double F64CPUCoreTemp_1 = Convert.ToDouble(y1_T);
                    double F64CPUCoreTemp_2 = Convert.ToDouble(y2_T);
                    double F64CPUCoreTemp_3 = Convert.ToDouble(y3_T);
                    double F64CPUCoreTemp_4 = Convert.ToDouble(y4_T);
                    double F64CPUCoreTemp_Package = Convert.ToDouble(y5_T);
                    double F64CPUPackagePower = Convert.ToDouble(y1_P);
                    double F64CPUCorePower = Convert.ToDouble(y2_P);
                    double F64CPUCoreClock_1 = Convert.ToDouble(y1_C);
                    double F64CPUCoreClock_2 = Convert.ToDouble(y2_C);
                    double F64CPUCoreClock_3 = Convert.ToDouble(y3_C);
                    double F64CPUCoreClock_4 = Convert.ToDouble(y4_C);

                    if (F64CPUCoreTemp_1 < this.F64CPUCoreTemp_1_Min) this.F64CPUCoreTemp_1_Min = F64CPUCoreTemp_1;
                    if (F64CPUCoreTemp_2 < this.F64CPUCoreTemp_2_Min) this.F64CPUCoreTemp_2_Min = F64CPUCoreTemp_2;
                    if (F64CPUCoreTemp_3 < this.F64CPUCoreTemp_3_Min) this.F64CPUCoreTemp_3_Min = F64CPUCoreTemp_3;
                    if (F64CPUCoreTemp_4 < this.F64CPUCoreTemp_4_Min) this.F64CPUCoreTemp_4_Min = F64CPUCoreTemp_4;
                    if (F64CPUCoreTemp_Package < this.F64CPUCoreTemp_Package_Min) this.F64CPUCoreTemp_Package_Min = F64CPUCoreTemp_Package;
                    if (F64CPUPackagePower < this.F64CPUPackagePower_Min) this.F64CPUPackagePower_Min = F64CPUPackagePower;
                    if (F64CPUCorePower < this.F64CPUCorePower_Min) this.F64CPUCorePower_Min = F64CPUCorePower;
                    if (F64CPUCoreClock_1 < this.F64CPUCoreClock_1_Min) this.F64CPUCoreClock_1_Min = F64CPUCoreClock_1;
                    if (F64CPUCoreClock_2 < this.F64CPUCoreClock_2_Min) this.F64CPUCoreClock_2_Min = F64CPUCoreClock_2;
                    if (F64CPUCoreClock_3 < this.F64CPUCoreClock_3_Min) this.F64CPUCoreClock_3_Min = F64CPUCoreClock_3;
                    if (F64CPUCoreClock_4 < this.F64CPUCoreClock_4_Min) this.F64CPUCoreClock_4_Min = F64CPUCoreClock_4;

                    if (F64CPUCoreTemp_1 > this.F64CPUCoreTemp_1_Max) this.F64CPUCoreTemp_1_Max = F64CPUCoreTemp_1;
                    if (F64CPUCoreTemp_2 > this.F64CPUCoreTemp_2_Max) this.F64CPUCoreTemp_2_Max = F64CPUCoreTemp_2;
                    if (F64CPUCoreTemp_3 > this.F64CPUCoreTemp_3_Max) this.F64CPUCoreTemp_3_Max = F64CPUCoreTemp_3;
                    if (F64CPUCoreTemp_4 > this.F64CPUCoreTemp_4_Max) this.F64CPUCoreTemp_4_Max = F64CPUCoreTemp_4;
                    if (F64CPUCoreTemp_Package > this.F64CPUCoreTemp_Package_Max) this.F64CPUCoreTemp_Package_Max = F64CPUCoreTemp_Package;
                    if (F64CPUPackagePower > this.F64CPUPackagePower_Max) this.F64CPUPackagePower_Max = F64CPUPackagePower;
                    if (F64CPUCorePower > this.F64CPUCorePower_Max) this.F64CPUCorePower_Max = F64CPUCorePower;
                    if (F64CPUCoreClock_1 > this.F64CPUCoreClock_1_Max) this.F64CPUCoreClock_1_Max = F64CPUCoreClock_1;
                    if (F64CPUCoreClock_2 > this.F64CPUCoreClock_2_Max) this.F64CPUCoreClock_2_Max = F64CPUCoreClock_2;
                    if (F64CPUCoreClock_3 > this.F64CPUCoreClock_3_Max) this.F64CPUCoreClock_3_Max = F64CPUCoreClock_3;
                    if (F64CPUCoreClock_4 > this.F64CPUCoreClock_4_Max) this.F64CPUCoreClock_4_Max = F64CPUCoreClock_4;

                }


                if (this.m_ODataSource != null)
                {
                    this.m_ODataSource.Dispose();
                    this.m_ODataSource = null;
                }
                this.m_ODataSource = (DataTable)this.DgvReport.DataSource;
            }
            catch (Exception ex)
            {
                CMsgBox.Warning("데이터 자리수 에러");
            }
        }
        #endregion


        #region ETC EVENT
        private void DgvReport_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.DgvReport.CurrentRow == null) return;

                DataRow ORow = ((DataRowView)(this.DgvReport.CurrentRow.DataBoundItem)).Row;

                //this.LblTime.Text = ORow[CDB.Datetime].ToString();
                this.LblCPU1T.Text = ORow[CDB.F64CPUCoreTemp_1].ToString();
                this.LblCPU1T_min.Text = this.F64CPUCoreTemp_1_Min.ToString();
                this.LblCPU1T_max.Text = this.F64CPUCoreTemp_1_Max.ToString();
                this.LblCPU2T.Text = ORow[CDB.F64CPUCoreTemp_2].ToString();
                this.LblCPU2T_min.Text = this.F64CPUCoreTemp_2_Min.ToString();
                this.LblCPU2T_max.Text = this.F64CPUCoreTemp_2_Max.ToString();
                this.LblCPU3T.Text = ORow[CDB.F64CPUCoreTemp_3].ToString();
                this.LblCPU3T_min.Text = this.F64CPUCoreTemp_3_Min.ToString();
                this.LblCPU3T_max.Text = this.F64CPUCoreTemp_3_Max.ToString();
                this.LblCPU4T.Text = ORow[CDB.F64CPUCoreTemp_4].ToString();
                this.LblCPU4T_min.Text = this.F64CPUCoreTemp_4_Min.ToString();
                this.LblCPU4T_max.Text = this.F64CPUCoreTemp_4_Max.ToString();
                this.LblCPUPackT.Text = ORow[CDB.F64CPUCoreTemp_Package].ToString();
                this.LblCPUPackT_min.Text = this.F64CPUCoreTemp_Package_Min.ToString();
                this.LblCPUPackT_max.Text = this.F64CPUCoreTemp_Package_Max.ToString();

                this.LblPackP.Text = ORow[CDB.F64CPUPackagePower].ToString();
                this.LblPackP_min.Text = this.F64CPUPackagePower_Min.ToString();
                this.LblPackP_max.Text = this.F64CPUPackagePower_Max.ToString();
                this.LblCPUP.Text = ORow[CDB.F64CPUCorePower].ToString();
                this.LblCPUP_min.Text = this.F64CPUCorePower_Min.ToString();
                this.LblCPUP_max.Text = this.F64CPUCorePower_Max.ToString();

                this.LblCPU1C.Text = ORow[CDB.F64CPUCoreClock_1].ToString();
                this.LblCPU1C_min.Text = this.F64CPUCoreClock_1_Min.ToString();
                this.LblCPU1C_max.Text = this.F64CPUCoreClock_1_Max.ToString();
                this.LblCPU2C.Text = ORow[CDB.F64CPUCoreClock_2].ToString();
                this.LblCPU2C_min.Text = this.F64CPUCoreClock_2_Min.ToString();
                this.LblCPU2C_max.Text = this.F64CPUCoreClock_2_Max.ToString();
                this.LblCPU3C.Text = ORow[CDB.F64CPUCoreClock_3].ToString();
                this.LblCPU3C_min.Text = this.F64CPUCoreClock_3_Min.ToString();
                this.LblCPU3C_max.Text = this.F64CPUCoreClock_3_Max.ToString();
                this.LblCPU4C.Text = ORow[CDB.F64CPUCoreClock_4].ToString();
                this.LblCPU4C_min.Text = this.F64CPUCoreClock_4_Min.ToString();
                this.LblCPU4C_max.Text = this.F64CPUCoreClock_4_Max.ToString();
            }
            catch (Exception ex)
            {
                CError.Show(ex);
            }
        }
        #endregion
        #endregion


        #region FUNCTION
        public override void Remove()
        {
            try
            {
                this.DgvReport.DataSource = null;
                if (this.m_ODataSource != null)
                {
                    this.m_ODataSource.Dispose();
                    this.m_ODataSource = null;
                }

            }
            catch (Exception ex)
            {
                CError.Throw(ex);
            }
        }

        public void ChangeVisibleProp(bool BVisible)
        {
            this.Temperature.Visible = BVisible;
            this.Power.Visible = BVisible;
            this.Clock.Visible = BVisible;
        }

        #endregion
        
    }
}
