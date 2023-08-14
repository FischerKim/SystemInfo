using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Jhjo.Common;
using OpenHardwareMonitor.Hardware;

namespace SystemInfo_Advantech
{
    public class CListener : IDisposable
    {
        #region SINGLE TON
        private static CListener Src_It = null;


        public static CListener It
        {
            get
            {
                CListener OResult = null;

                try
                {
                    if (CListener.Src_It == null)
                    {
                        CListener.Src_It = new CListener();
                    }

                    OResult = CListener.Src_It;
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
        private const int SECOND_TICK = 600000000;
        #endregion


        #region VARIABLE
        private object m_OInterrupt = null;

        private Thread m_OWorker = null;
        private bool m_BDoWork = false;


        private int m_DRefreshtime = 1000;

        private Computer OMyPC;
        bool disposed = false;// Flag: Has Dispose already been called?
        #endregion


        #region DELEGATE & EVENT
        public delegate void RetrievedHandler(CResult OResult);
        public RetrievedHandler Retrieved = null;
        #endregion


        #region PROPERTIES
        public decimal DRefreshtime
        {
            //get { return m_DRefreshtime; }
            set
            {
                this.m_DRefreshtime = Convert.ToInt32(value);
            }
        }
        #endregion


        #region CONSTRUCTOR & DESTRUCTOR
        public CListener()
        {
            try
            {
                this.OMyPC = new Computer();
                this.OMyPC.MainboardEnabled = true;
                this.OMyPC.FanControllerEnabled = true; //This doesn't seem to do anything
                this.OMyPC.CPUEnabled = true;
                this.OMyPC.GPUEnabled = true;
                this.OMyPC.RAMEnabled = true;
                this.OMyPC.HDDEnabled = true;
                this.OMyPC.Open();

                this.m_OInterrupt = new object();

                this.BeginWork();
            }
            catch (Exception ex)
            {
                CError.Throw(ex);
            }
        }


        ~CListener()
        {
            try
            {
            }
            catch (Exception ex)
            {
                CError.Ignore(ex);
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
#if TrapUSB
                watcher.Stop();
#endif
                // Free any other managed objects here.
                //
            }

            // Free any unmanaged objects here.
            //
            OMyPC.Close();

            disposed = true;
        }
        
        #endregion


        #region EVENT
        private void OExporter_Exported()
        {
            try
            {
                Monitor.Enter(this.m_OInterrupt);

            }
            catch (Exception ex)
            {
                CError.Throw(ex);
            }
            finally
            {
                Monitor.Exit(this.m_OInterrupt);
            }
        }
        #endregion


        #region FUNCTION
        private void BeginWork()
        {
            try
            {
                if (this.m_OWorker == null)
                {
                    this.m_BDoWork = true;

                    this.m_OWorker = new Thread(this.Work);
                    this.m_OWorker.IsBackground = true;
                    this.m_OWorker.Start();
                }
            }
            catch (Exception ex)
            {
                CError.Throw(ex);
            }
        }


        private void Work()
        {
            try
            {
                while (this.m_BDoWork == true)
                {
                    try
                    {
                        RefreshItems();
                    }
                    catch (Exception ex)
                    {
                        CError.Ignore(ex);
                    }

                    Thread.Sleep(this.m_DRefreshtime);
                }
            }
            catch (Exception ex)
            {
                CError.Throw(ex);
            }
        }


        private void EndWork()
        {
            try
            {
                if (this.m_OWorker != null)
                {
                    this.m_BDoWork = false;

                    this.m_OWorker.Join();
                    this.m_OWorker = null;
                }
            }
            catch (Exception ex)
            {
                CError.Throw(ex);
            }
        }

        private void RefreshItems()
        {
            UInt32 Status;
            UInt32 temp_U32 = 0;

            Monitor.Enter(this.m_OInterrupt);
            CResult OResult = new CResult();
            OResult.OTime = DateTime.Now;

            IHardware[] hardWare = this.OMyPC.Hardware;

            for (int i = 0; i < hardWare.Count(); i++)
            {
                string StrHardwareName = hardWare[i].Name;
                try
                {
                    hardWare[i].Update();
                }
                catch
                {
                    //throw away any exception
                }

                HardwareType StrType = hardWare[i].HardwareType;
                if (hardWare[i].Sensors.Count() > 0)
                {
                    for (int j = 0; j < hardWare[i].Sensors.Count(); j++)
                    {
                        string StrSensorName = hardWare[i].Sensors[j].Name;
                      //  Console.WriteLine(StrSensorName + " /" + hardWare[i].Sensors[j].Value + " /" + hardWare[i].Sensors[j].SensorType);
                      //Temperature
                        if (hardWare[i].Sensors[j].Name == "CPU Core #1" && hardWare[i].Sensors[j].SensorType.ToString() == "Temperature")
                        {
                            OResult.F64CPUCoreTemp_1 = Convert.ToDouble(hardWare[i].Sensors[j].Value);
                        }
                        if (hardWare[i].Sensors[j].Name == "CPU Core #2" && hardWare[i].Sensors[j].SensorType.ToString() == "Temperature")
                        {
                            OResult.F64CPUCoreTemp_2 = Convert.ToDouble(hardWare[i].Sensors[j].Value);
                        }
                        if (hardWare[i].Sensors[j].Name == "CPU Core #3" && hardWare[i].Sensors[j].SensorType.ToString() == "Temperature")
                        {
                            OResult.F64CPUCoreTemp_3 = Convert.ToDouble(hardWare[i].Sensors[j].Value);
                        }
                        if (hardWare[i].Sensors[j].Name == "CPU Core #4" && hardWare[i].Sensors[j].SensorType.ToString() == "Temperature")
                        {
                            OResult.F64CPUCoreTemp_4 = Convert.ToDouble(hardWare[i].Sensors[j].Value);
                        }
                        if (hardWare[i].Sensors[j].Name == "CPU Package" && hardWare[i].Sensors[j].SensorType.ToString() == "Temperature")
                        {
                            OResult.F64CPUCoreTemp_Package = Convert.ToDouble(hardWare[i].Sensors[j].Value);
                        }
                        //Power
                        if (hardWare[i].Sensors[j].Name == "CPU Package" && hardWare[i].Sensors[j].SensorType.ToString() == "Power")
                        {
                            OResult.F64CPUPackagePower = Math.Round(Convert.ToDouble(hardWare[i].Sensors[j].Value),3);
                        }
                        if (hardWare[i].Sensors[j].Name == "CPU Cores" && hardWare[i].Sensors[j].SensorType.ToString() == "Power")
                        {
                            OResult.F64CPUCorePower = Math.Round(Convert.ToDouble(hardWare[i].Sensors[j].Value),3);
                        }
                        //Clock
                        if (hardWare[i].Sensors[j].Name == "CPU Core #1" && hardWare[i].Sensors[j].SensorType.ToString() == "Clock")
                        {
                            OResult.F64CPUCoreClock_1 = Math.Round(Convert.ToDouble(hardWare[i].Sensors[j].Value),3);
                        }
                        if (hardWare[i].Sensors[j].Name == "CPU Core #2" && hardWare[i].Sensors[j].SensorType.ToString() == "Clock")
                        {
                            OResult.F64CPUCoreClock_2 = Math.Round(Convert.ToDouble(hardWare[i].Sensors[j].Value),3);
                        }
                        if (hardWare[i].Sensors[j].Name == "CPU Core #3" && hardWare[i].Sensors[j].SensorType.ToString() == "Clock")
                        {
                            OResult.F64CPUCoreClock_3 = Math.Round(Convert.ToDouble(hardWare[i].Sensors[j].Value),3);
                        }
                        if (hardWare[i].Sensors[j].Name == "CPU Core #4" && hardWare[i].Sensors[j].SensorType.ToString() == "Clock")
                        {
                            OResult.F64CPUCoreClock_4 = Math.Round(Convert.ToDouble(hardWare[i].Sensors[j].Value),3);
                        }

                    }
                }
            }

            
            if (this.Retrieved != null)
            {
                this.Retrieved(OResult);
            }

            Monitor.Exit(this.m_OInterrupt);
        }
        #endregion
    }
}
