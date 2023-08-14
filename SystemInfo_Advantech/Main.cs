using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using Jhjo.Common;
using Jhjo.DB;
using System.Data;
using System.Text;

namespace SystemInfo_Advantech
{
    public partial class Main : Form
    {
        #region STATIC VARIABLE
        public static object OScreenInterrupt = null;
        #endregion


        #region VARIABLE
        private UcScreen m_OScreen = null;
        private UcReport m_OReport = null;

        int I32Xcount = 0;

        bool BIgnoreFirst = false;
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
        public Main()
        {
            InitializeComponent();

            try
            {
                Main.OScreenInterrupt = new object();
            }
            catch (Exception ex)
            {
                CError.Throw(ex);
            }
        }


        private void Main_Load(object sender, EventArgs e)
        {
            CDB.It.Load();
            this.m_OReport = new UcReport();
            this.m_OScreen = new UcScreen();
            this.SetScreen(this.m_OReport, ESUBSCREEN.NONE);

            CListener.It.Retrieved = this.OListener_Retrieved;
            this.Timer1000.Start();
        }

        private void Loadtest()
        {
            try
            {
                do
                {
                    try
                    {
                        //this.LoadTestTable("TABLE_DEFINDER", Environment.CurrentDirectory + @"\DB\TableDefinder.csv");

                        CTable OTableDefinder = new CTable("TABLE_DEFINDER", Environment.CurrentDirectory + @"\DB\TableDefinder.csv");

                        DataTable OTableInfo = OTableDefinder.Select();
                        string StrName = string.Empty;
                        string StrKind = string.Empty;
                        string StrPath = string.Empty;
                        string StrRoot = string.Empty;

                        foreach (DataRow _Item in OTableInfo.Rows)
                        {
                            StrName = (string)_Item["NAME"];
                            StrKind = (string)_Item["TYPE"];
                            StrPath = (string)_Item["PATH"];
                            StrRoot = (string)_Item["ROOT"];
                            CDailyTable test = new CDailyTable(StrName, StrPath, StrRoot);
                            break;

                        }

                        OTableDefinder.Dispose();
                        OTableDefinder = null;

                        //    BResult = true;
                        break;
                    }
                    catch (Exception ex)
                    {
                    }
                }
                while (true);
            }
            catch (Exception ex)
            {
                CError.Throw(ex);
            }
            finally
            {
            }

        }
        #endregion


        #region EVENTS

        private void BtnTest_Click(object sender, EventArgs e)
        {

            try
            {
                IDynamicTable OTable = CDB.It.GetDynamicTable(CDB.TABLE_REPORT);

                try
                {
                    OTable.BeginSyncData();
                    Random random = new Random();


                    int I32RowIndex = OTable.InsertRow();
                    OTable.Update(I32RowIndex, CDB.Datetime, DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss.ffff"));
               
                    
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreTemp_1, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreTemp_1_min, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreTemp_1_max, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreTemp_2, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreTemp_2_min, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreTemp_2_max, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreTemp_3, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreTemp_3_min, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreTemp_3_max, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreTemp_4, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreTemp_4_min, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreTemp_4_max, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreTemp_Package, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreTemp_Package_min, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreTemp_Package_max, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUPackagePower, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUPackagePower_min, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUPackagePower_max, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUCorePower, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUCorePower_min, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUCorePower_max, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreClock_1, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreClock_1_min, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreClock_1_max, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreClock_2, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreClock_2_min, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreClock_2_max, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreClock_3, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreClock_3_min, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreClock_3_max, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreClock_4, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreClock_4_min, random.NextDouble() * 10);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreClock_4_max, random.NextDouble() * 10);



                }
                catch (Exception ex)
                {
                    CError.Throw(ex);
                }
                finally
                {
                    OTable.EndSyncData();
                }
            }
            catch (Exception ex)
            {
                CError.Throw(ex);
            }
        }


        private void BtnClear_Click(object sender, EventArgs e)
        {
            try
            {
                this.I32Xcount = 0;
                this.Temperature.Series["CPU Core #1"].Points.Clear();
                this.Temperature.Series["CPU Core #2"].Points.Clear();
                this.Temperature.Series["CPU Core #3"].Points.Clear();
                this.Temperature.Series["CPU Core #4"].Points.Clear();
                this.Temperature.Series["CPU Package"].Points.Clear();

                this.Power.Series["CPU Package"].Points.Clear();
                this.Power.Series["CPU Cores"].Points.Clear();

                this.Clock.Series["CPU Core #1"].Points.Clear();
                this.Clock.Series["CPU Core #2"].Points.Clear();
                this.Clock.Series["CPU Core #3"].Points.Clear();
                this.Clock.Series["CPU Core #4"].Points.Clear();
            }
            catch (Exception ex)
            {
                CError.Throw(ex);
            }
        }


        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            CListener.It.DRefreshtime = NudRefreshtime.Value;
        }


        private void Timer1000_Tick(object sender, EventArgs e)
        {
            try
            {

                this.LblTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                Monitor.Enter(Main.OScreenInterrupt);

                if (this.m_OScreen != null)
                {
                    this.m_OScreen.OnTimer1000();
                }
            }
            catch (Exception ex)
            {
                CError.Show(ex);
            }
            finally
            {
                Monitor.Exit(Main.OScreenInterrupt);
            }
        }

        #endregion


        #region FUNCTION
        private void SetScreen(UcScreen OScreen, ESUBSCREEN ESubScreen)
        {
            try
            {
                Monitor.Enter(Main.OScreenInterrupt);

                if (this.m_OScreen.GetType() != OScreen.GetType())
                {
                    this.m_OScreen.Remove();
                    OScreen.Add();
                    OScreen.OpenSubScreen(ESubScreen);

                    this.PnlBody.Controls.Add(OScreen);
                    OScreen.BringToFront();
                    this.PnlBody.Controls.Remove(this.m_OScreen);

                    this.m_OScreen = OScreen;
                }
                else this.m_OScreen.OpenSubScreen(ESubScreen);
            }
            catch (Exception ex)
            {
                CError.Throw(ex);
            }
            finally
            {
                Monitor.Exit(Main.OScreenInterrupt);
            }
        }


        private void OListener_Retrieved(CResult OResult)
        {
            if (this.InvokeRequired == true)
            {
                this.BeginInvoke(new CListener.RetrievedHandler(this.OListener_Retrieved), OResult);
                return;
            }
            if (BIgnoreFirst == false)
            {
                BIgnoreFirst = true;
                return;
            }
            WriteToDB(OResult);
            Display(OResult);
        }


        private void WriteToDB(CResult OResult)
        {
            try
            {
                if (OResult.OTime == DateTime.MinValue) return;
                if (ChkSave.Checked == false) return;
                IDynamicTable OTable = CDB.It.GetDynamicTable(CDB.TABLE_REPORT);

                try
                {
                    OTable.BeginSyncData();

                    int I32RowIndex = OTable.InsertRow();
                    OTable.Update(I32RowIndex, CDB.Datetime, OResult.OTime.ToString("yyyy.MM.dd HH:mm:ss fff"));
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreTemp_1, OResult.F64CPUCoreTemp_1);
                    //OTable.Update(I32RowIndex, CDB.F64CPUCoreTemp_1_min, OResult.F64CPUCoreTemp_1_min);
                    //OTable.Update(I32RowIndex, CDB.F64CPUCoreTemp_1_max, OResult.F64CPUCoreTemp_1_max);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreTemp_2, OResult.F64CPUCoreTemp_2);
                    //OTable.Update(I32RowIndex, CDB.F64CPUCoreTemp_2_min, OResult.F64CPUCoreTemp_2_min);
                    //OTable.Update(I32RowIndex, CDB.F64CPUCoreTemp_2_max, OResult.F64CPUCoreTemp_2_max);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreTemp_3, OResult.F64CPUCoreTemp_3);
                    //OTable.Update(I32RowIndex, CDB.F64CPUCoreTemp_3_min, OResult.F64CPUCoreTemp_3_min);
                    //OTable.Update(I32RowIndex, CDB.F64CPUCoreTemp_3_max, OResult.F64CPUCoreTemp_3_max);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreTemp_4, OResult.F64CPUCoreTemp_4);
                    //OTable.Update(I32RowIndex, CDB.F64CPUCoreTemp_4_min, OResult.F64CPUCoreTemp_4_min);
                    //OTable.Update(I32RowIndex, CDB.F64CPUCoreTemp_4_max, OResult.F64CPUCoreTemp_4_max);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreTemp_Package, OResult.F64CPUCoreTemp_Package);
                    //OTable.Update(I32RowIndex, CDB.F64CPUCoreTemp_Package_min, OResult.F64CPUCoreTemp_Package_min);
                    //OTable.Update(I32RowIndex, CDB.F64CPUCoreTemp_Package_max, OResult.F64CPUCoreTemp_Package_max);
                    OTable.Update(I32RowIndex, CDB.F64CPUPackagePower, OResult.F64CPUPackagePower);
                    //OTable.Update(I32RowIndex, CDB.F64CPUPackagePower_min, OResult.F64CPUPackagePower_min);
                    //OTable.Update(I32RowIndex, CDB.F64CPUPackagePower_max, OResult.F64CPUPackagePower_max);
                    OTable.Update(I32RowIndex, CDB.F64CPUCorePower, OResult.F64CPUCorePower);
                    //OTable.Update(I32RowIndex, CDB.F64CPUCorePower_min, OResult.F64CPUCorePower_min);
                    //OTable.Update(I32RowIndex, CDB.F64CPUCorePower_max, OResult.F64CPUCorePower_max);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreClock_1, OResult.F64CPUCoreClock_1);
                    //OTable.Update(I32RowIndex, CDB.F64CPUCoreClock_1_min, OResult.F64CPUCoreClock_1_min);
                    //OTable.Update(I32RowIndex, CDB.F64CPUCoreClock_1_max, OResult.F64CPUCoreClock_1_max);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreClock_2, OResult.F64CPUCoreClock_2);
                    //OTable.Update(I32RowIndex, CDB.F64CPUCoreClock_2_min, OResult.F64CPUCoreClock_2_min);
                    //OTable.Update(I32RowIndex, CDB.F64CPUCoreClock_2_max, OResult.F64CPUCoreClock_2_max);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreClock_3, OResult.F64CPUCoreClock_3);
                    //OTable.Update(I32RowIndex, CDB.F64CPUCoreClock_3_min, OResult.F64CPUCoreClock_3_min);
                    //OTable.Update(I32RowIndex, CDB.F64CPUCoreClock_3_max, OResult.F64CPUCoreClock_3_max);
                    OTable.Update(I32RowIndex, CDB.F64CPUCoreClock_4, OResult.F64CPUCoreClock_4);
                    //OTable.Update(I32RowIndex, CDB.F64CPUCoreClock_4_min, OResult.F64CPUCoreClock_4_min);
                    //OTable.Update(I32RowIndex, CDB.F64CPUCoreClock_4_max, OResult.F64CPUCoreClock_4_max);

                }
                catch (Exception ex)
                {
                    CError.Throw(ex);
                }
                finally
                {
                    OTable.EndSyncData();
                }
            }
            catch (Exception ex)
            {
                CError.Throw(ex);
            }
        }


        private void Display(CResult OResult)
        {
            try
            {
                
                if (this.Temperature.Series["CPU Core #1"].Points.Count > 100)
                {
                    this.Temperature.Series["CPU Core #1"].Points.RemoveAt(0);
                    this.Temperature.Series["CPU Core #2"].Points.RemoveAt(0);
                    this.Temperature.Series["CPU Core #3"].Points.RemoveAt(0);
                    this.Temperature.Series["CPU Core #4"].Points.RemoveAt(0);
                    this.Temperature.Series["CPU Package"].Points.RemoveAt(0);
                    this.Temperature.Update();

                    this.Power.Series["CPU Package"].Points.RemoveAt(0);
                    this.Power.Series["CPU Cores"].Points.RemoveAt(0);
                    this.Power.Update();

                    this.Clock.Series["CPU Core #1"].Points.RemoveAt(0);
                    this.Clock.Series["CPU Core #2"].Points.RemoveAt(0);
                    this.Clock.Series["CPU Core #3"].Points.RemoveAt(0);
                    this.Clock.Series["CPU Core #4"].Points.RemoveAt(0);
                    this.Clock.Update();
                }

                this.I32Xcount++;
                object x = I32Xcount;
                this.Temperature.Series["CPU Core #1"].Points.AddXY(x, OResult.F64CPUCoreTemp_1);
                this.Temperature.Series["CPU Core #2"].Points.AddXY(x, OResult.F64CPUCoreTemp_2);
                this.Temperature.Series["CPU Core #3"].Points.AddXY(x, OResult.F64CPUCoreTemp_3);
                this.Temperature.Series["CPU Core #4"].Points.AddXY(x, OResult.F64CPUCoreTemp_4);
                this.Temperature.Series["CPU Package"].Points.AddXY(x, OResult.F64CPUCoreTemp_Package);

                this.Power.Series["CPU Package"].Points.AddXY(x, OResult.F64CPUPackagePower);
                this.Power.Series["CPU Cores"].Points.AddXY(x, OResult.F64CPUCorePower);

                this.Clock.Series["CPU Core #1"].Points.AddXY(x, OResult.F64CPUCoreClock_1);
                this.Clock.Series["CPU Core #2"].Points.AddXY(x, OResult.F64CPUCoreClock_2);
                this.Clock.Series["CPU Core #3"].Points.AddXY(x, OResult.F64CPUCoreClock_3);
                this.Clock.Series["CPU Core #4"].Points.AddXY(x, OResult.F64CPUCoreClock_4);
                
                if (OResult.F64CPUCoreTemp_1 < this.F64CPUCoreTemp_1_Min) this.F64CPUCoreTemp_1_Min = OResult.F64CPUCoreTemp_1;
                if (OResult.F64CPUCoreTemp_2 < this.F64CPUCoreTemp_2_Min) this.F64CPUCoreTemp_2_Min = OResult.F64CPUCoreTemp_2;
                if (OResult.F64CPUCoreTemp_3 < this.F64CPUCoreTemp_3_Min) this.F64CPUCoreTemp_3_Min = OResult.F64CPUCoreTemp_3;
                if (OResult.F64CPUCoreTemp_4 < this.F64CPUCoreTemp_4_Min) this.F64CPUCoreTemp_4_Min = OResult.F64CPUCoreTemp_4;
                if (OResult.F64CPUCoreTemp_Package < this.F64CPUCoreTemp_Package_Min) this.F64CPUCoreTemp_Package_Min = OResult.F64CPUCoreTemp_Package;
                if (OResult.F64CPUPackagePower < this.F64CPUPackagePower_Min) this.F64CPUPackagePower_Min = OResult.F64CPUPackagePower;
                if (OResult.F64CPUCorePower < this.F64CPUCorePower_Min) this.F64CPUCorePower_Min = OResult.F64CPUCorePower;
                if (OResult.F64CPUCoreClock_1 < this.F64CPUCoreClock_1_Min) this.F64CPUCoreClock_1_Min = OResult.F64CPUCoreClock_1;
                if (OResult.F64CPUCoreClock_2 < this.F64CPUCoreClock_2_Min) this.F64CPUCoreClock_2_Min = OResult.F64CPUCoreClock_2;
                if (OResult.F64CPUCoreClock_3 < this.F64CPUCoreClock_3_Min) this.F64CPUCoreClock_3_Min = OResult.F64CPUCoreClock_3;
                if (OResult.F64CPUCoreClock_4 < this.F64CPUCoreClock_4_Min) this.F64CPUCoreClock_4_Min = OResult.F64CPUCoreClock_4;
                
                if (OResult.F64CPUCoreTemp_1 > this.F64CPUCoreTemp_1_Max) this.F64CPUCoreTemp_1_Max = OResult.F64CPUCoreTemp_1;
                if (OResult.F64CPUCoreTemp_2 > this.F64CPUCoreTemp_2_Max) this.F64CPUCoreTemp_2_Max = OResult.F64CPUCoreTemp_2;
                if (OResult.F64CPUCoreTemp_3 > this.F64CPUCoreTemp_3_Max) this.F64CPUCoreTemp_3_Max = OResult.F64CPUCoreTemp_3;
                if (OResult.F64CPUCoreTemp_4 > this.F64CPUCoreTemp_4_Max) this.F64CPUCoreTemp_4_Max = OResult.F64CPUCoreTemp_4;
                if (OResult.F64CPUCoreTemp_Package > this.F64CPUCoreTemp_Package_Max) this.F64CPUCoreTemp_Package_Max = OResult.F64CPUCoreTemp_Package;
                if (OResult.F64CPUPackagePower > this.F64CPUPackagePower_Max) this.F64CPUPackagePower_Max = OResult.F64CPUPackagePower;
                if (OResult.F64CPUCorePower > this.F64CPUCorePower_Max) this.F64CPUCorePower_Max = OResult.F64CPUCorePower;
                if (OResult.F64CPUCoreClock_1 > this.F64CPUCoreClock_1_Max) this.F64CPUCoreClock_1_Max = OResult.F64CPUCoreClock_1;
                if (OResult.F64CPUCoreClock_2 > this.F64CPUCoreClock_2_Max) this.F64CPUCoreClock_2_Max = OResult.F64CPUCoreClock_2;
                if (OResult.F64CPUCoreClock_3 > this.F64CPUCoreClock_3_Max) this.F64CPUCoreClock_3_Max = OResult.F64CPUCoreClock_3;
                if (OResult.F64CPUCoreClock_4 > this.F64CPUCoreClock_4_Max) this.F64CPUCoreClock_4_Max = OResult.F64CPUCoreClock_4;

                //String.Format("{0:0.00}", 123.4567);      // "123.46"
                //
                this.LblCPU1T.Text = String.Format("{0:0.0}", OResult.F64CPUCoreTemp_1);
                this.LblCPU1T_min.Text = String.Format("{0:0.0}", this.F64CPUCoreTemp_1_Min);
                this.LblCPU1T_max.Text = String.Format("{0:0.0}", this.F64CPUCoreTemp_1_Max);
                this.LblCPU2T.Text = String.Format("{0:0.0}", OResult.F64CPUCoreTemp_2);
                this.LblCPU2T_min.Text = String.Format("{0:0.0}", this.F64CPUCoreTemp_2_Min);
                this.LblCPU2T_max.Text = String.Format("{0:0.0}", this.F64CPUCoreTemp_2_Max);
                this.LblCPU3T.Text = String.Format("{0:0.0}", OResult.F64CPUCoreTemp_3);
                this.LblCPU3T_min.Text = String.Format("{0:0.0}", this.F64CPUCoreTemp_3_Min);
                this.LblCPU3T_max.Text = String.Format("{0:0.0}", this.F64CPUCoreTemp_3_Max);
                this.LblCPU4T.Text = String.Format("{0:0.0}", OResult.F64CPUCoreTemp_4);
                this.LblCPU4T_min.Text = String.Format("{0:0.0}", this.F64CPUCoreTemp_4_Min);
                this.LblCPU4T_max.Text = String.Format("{0:0.0}", this.F64CPUCoreTemp_4_Max);
                this.LblCPUPackT.Text = String.Format("{0:0.0}", OResult.F64CPUCoreTemp_Package); 
                this.LblCPUPackT_min.Text = String.Format("{0:0.0}", this.F64CPUCoreTemp_Package_Min);
                this.LblCPUPackT_max.Text = String.Format("{0:0.0}", this.F64CPUCoreTemp_Package_Max);

                this.LblPackP.Text = OResult.F64CPUPackagePower.ToString();
                this.LblPackP_min.Text = this.F64CPUPackagePower_Min.ToString();
                this.LblPackP_max.Text = this.F64CPUPackagePower_Max.ToString();
                this.LblCPUP.Text = OResult.F64CPUCorePower.ToString();
                this.LblCPUP_min.Text = this.F64CPUCorePower_Min.ToString();
                this.LblCPUP_max.Text = this.F64CPUCorePower_Max.ToString();

                this.LblCPU1C.Text = OResult.F64CPUCoreClock_1.ToString();
                this.LblCPU1C_min.Text = this.F64CPUCoreClock_1_Min.ToString();
                this.LblCPU1C_max.Text = this.F64CPUCoreClock_1_Max.ToString();
                this.LblCPU2C.Text = OResult.F64CPUCoreClock_2.ToString();
                this.LblCPU2C_min.Text = this.F64CPUCoreClock_2_Min.ToString();
                this.LblCPU2C_max.Text = this.F64CPUCoreClock_2_Max.ToString();
                this.LblCPU3C.Text = OResult.F64CPUCoreClock_3.ToString();
                this.LblCPU3C_min.Text = this.F64CPUCoreClock_3_Min.ToString();
                this.LblCPU3C_max.Text = this.F64CPUCoreClock_3_Max.ToString();
                this.LblCPU4C.Text = OResult.F64CPUCoreClock_4.ToString();
                this.LblCPU4C_min.Text = this.F64CPUCoreClock_4_Min.ToString();
                this.LblCPU4C_max.Text = this.F64CPUCoreClock_4_Max.ToString();

            }
            catch (Exception ex)
            {
                CError.Throw(ex);
            }
        }
        #endregion

        private void ChkGraphVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkGraphVisible.Checked == true)
            {
                System.Drawing.Size OSize = new System.Drawing.Size(1209, 893);
                this.Size = OSize;
            }
            else
            {
                System.Drawing.Size OSize = new System.Drawing.Size(1209, 400);
                this.Size = OSize;
            }
            this.Temperature.Visible = ChkGraphVisible.Checked;
            this.Power.Visible = ChkGraphVisible.Checked;
            this.Clock.Visible = ChkGraphVisible.Checked;

            this.m_OReport.ChangeVisibleProp(this.ChkGraphVisible.Checked);
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            CListener.It.Dispose();
        }
    }
}
