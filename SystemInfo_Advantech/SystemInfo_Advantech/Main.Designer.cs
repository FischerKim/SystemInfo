namespace SystemInfo_Advantech
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ChkGraphVisible = new System.Windows.Forms.CheckBox();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NudRefreshtime = new System.Windows.Forms.NumericUpDown();
            this.BtnTest = new System.Windows.Forms.Button();
            this.PnlBody = new Jhjo.Component.CPanel();
            this.Clock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Power = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Temperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnClear = new System.Windows.Forms.Button();
            this.LblTime = new Jhjo.Component.CLabel();
            this.Timer1000 = new System.Windows.Forms.Timer(this.components);
            this.ChkSave = new System.Windows.Forms.CheckBox();
            this.cPanel1 = new Jhjo.Component.CPanel();
            this.cLabel2 = new Jhjo.Component.CLabel();
            this.cLabel3 = new Jhjo.Component.CLabel();
            this.LblCPU4C_max = new Jhjo.Component.CLabel();
            this.LblCPU3C_max = new Jhjo.Component.CLabel();
            this.LblCPU4C_min = new Jhjo.Component.CLabel();
            this.LblCPU3C_min = new Jhjo.Component.CLabel();
            this.LblCPU4C = new Jhjo.Component.CLabel();
            this.LblCPU3C = new Jhjo.Component.CLabel();
            this.cLabel10 = new Jhjo.Component.CLabel();
            this.cLabel11 = new Jhjo.Component.CLabel();
            this.cLabel1 = new Jhjo.Component.CLabel();
            this.LblTitleUnit = new Jhjo.Component.CLabel();
            this.cLabel23 = new Jhjo.Component.CLabel();
            this.cLabel24 = new Jhjo.Component.CLabel();
            this.cLabel25 = new Jhjo.Component.CLabel();
            this.cLabel26 = new Jhjo.Component.CLabel();
            this.cLabel27 = new Jhjo.Component.CLabel();
            this.cLabel28 = new Jhjo.Component.CLabel();
            this.cLabel29 = new Jhjo.Component.CLabel();
            this.cLabel30 = new Jhjo.Component.CLabel();
            this.cLabel31 = new Jhjo.Component.CLabel();
            this.LblTitleMax = new Jhjo.Component.CLabel();
            this.LblCPU2C_max = new Jhjo.Component.CLabel();
            this.LblCPU1C_max = new Jhjo.Component.CLabel();
            this.LblCPUP_max = new Jhjo.Component.CLabel();
            this.LblPackP_max = new Jhjo.Component.CLabel();
            this.LblCPUPackT_max = new Jhjo.Component.CLabel();
            this.LblCPU4T_max = new Jhjo.Component.CLabel();
            this.LblCPU3T_max = new Jhjo.Component.CLabel();
            this.LblCPU2T_max = new Jhjo.Component.CLabel();
            this.LblCPU1T_max = new Jhjo.Component.CLabel();
            this.LblTitleMin = new Jhjo.Component.CLabel();
            this.LblCPU2C_min = new Jhjo.Component.CLabel();
            this.LblCPU1C_min = new Jhjo.Component.CLabel();
            this.LblCPUP_min = new Jhjo.Component.CLabel();
            this.LblPackP_min = new Jhjo.Component.CLabel();
            this.LblCPUPackT_min = new Jhjo.Component.CLabel();
            this.LblCPU4T_min = new Jhjo.Component.CLabel();
            this.LblCPU3T_min = new Jhjo.Component.CLabel();
            this.LblCPU2T_min = new Jhjo.Component.CLabel();
            this.LblCPU1T_min = new Jhjo.Component.CLabel();
            this.LblTitleItem = new Jhjo.Component.CLabel();
            this.LblTitleVal = new Jhjo.Component.CLabel();
            this.LblCPU2C = new Jhjo.Component.CLabel();
            this.LblCPU1C = new Jhjo.Component.CLabel();
            this.LblCPUP = new Jhjo.Component.CLabel();
            this.LblPackP = new Jhjo.Component.CLabel();
            this.LblCPUPackT = new Jhjo.Component.CLabel();
            this.LblCPU4T = new Jhjo.Component.CLabel();
            this.LblCPU3T = new Jhjo.Component.CLabel();
            this.LblCPU2T = new Jhjo.Component.CLabel();
            this.LblCPU1T = new Jhjo.Component.CLabel();
            this.LblTitleCPUCoreTemp_Package = new Jhjo.Component.CLabel();
            this.LblTitleCPUCoreTemp_Pack = new Jhjo.Component.CLabel();
            this.LblCPUCoreTemp_4 = new Jhjo.Component.CLabel();
            this.LblCPUCoreTemp_3 = new Jhjo.Component.CLabel();
            this.LblCPUCoreTemp_2 = new Jhjo.Component.CLabel();
            this.LblTitleYLength = new Jhjo.Component.CLabel();
            this.LblTitleXLength = new Jhjo.Component.CLabel();
            this.LblTitleSubStance = new Jhjo.Component.CLabel();
            this.LblCPUCoreTemp_1 = new Jhjo.Component.CLabel();
            ((System.ComponentModel.ISupportInitialize)(this.NudRefreshtime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Power)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Temperature)).BeginInit();
            this.cPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChkGraphVisible
            // 
            this.ChkGraphVisible.AutoSize = true;
            this.ChkGraphVisible.Checked = true;
            this.ChkGraphVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkGraphVisible.Location = new System.Drawing.Point(449, 9);
            this.ChkGraphVisible.Name = "ChkGraphVisible";
            this.ChkGraphVisible.Size = new System.Drawing.Size(100, 16);
            this.ChkGraphVisible.TabIndex = 37;
            this.ChkGraphVisible.Text = "Graph Visible";
            this.ChkGraphVisible.UseVisualStyleBackColor = true;
            this.ChkGraphVisible.CheckedChanged += new System.EventHandler(this.ChkGraphVisible_CheckedChanged);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Location = new System.Drawing.Point(338, 6);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(75, 23);
            this.BtnConfirm.TabIndex = 36;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 12);
            this.label1.TabIndex = 35;
            this.label1.Text = "Refresh time (ms)";
            // 
            // NudRefreshtime
            // 
            this.NudRefreshtime.Location = new System.Drawing.Point(212, 7);
            this.NudRefreshtime.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NudRefreshtime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudRefreshtime.Name = "NudRefreshtime";
            this.NudRefreshtime.Size = new System.Drawing.Size(120, 21);
            this.NudRefreshtime.TabIndex = 34;
            this.NudRefreshtime.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // BtnTest
            // 
            this.BtnTest.Location = new System.Drawing.Point(638, 6);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(75, 23);
            this.BtnTest.TabIndex = 32;
            this.BtnTest.Text = "Test";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Visible = false;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // PnlBody
            // 
            this.PnlBody.BDrawBorderBottom = true;
            this.PnlBody.BDrawBorderLeft = true;
            this.PnlBody.BDrawBorderRight = true;
            this.PnlBody.BDrawBorderTop = true;
            this.PnlBody.Location = new System.Drawing.Point(638, 34);
            this.PnlBody.Name = "PnlBody";
            this.PnlBody.Size = new System.Drawing.Size(554, 816);
            this.PnlBody.TabIndex = 38;
            // 
            // Clock
            // 
            this.Clock.BackColor = System.Drawing.Color.RosyBrown;
            this.Clock.BorderlineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.Name = "ChartArea1";
            this.Clock.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Clock.Legends.Add(legend1);
            this.Clock.Location = new System.Drawing.Point(8, 681);
            this.Clock.Name = "Clock";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Navy;
            series1.Legend = "Legend1";
            series1.Name = "CPU Core #1";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.DarkRed;
            series2.Legend = "Legend1";
            series2.Name = "CPU Core #2";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "CPU Core #3";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "CPU Core #4";
            this.Clock.Series.Add(series1);
            this.Clock.Series.Add(series2);
            this.Clock.Series.Add(series3);
            this.Clock.Series.Add(series4);
            this.Clock.Size = new System.Drawing.Size(624, 149);
            this.Clock.TabIndex = 41;
            this.Clock.Text = "Clock";
            title1.Name = "Clock";
            title1.Text = "Current Clock";
            this.Clock.Titles.Add(title1);
            // 
            // Power
            // 
            this.Power.BackColor = System.Drawing.Color.RosyBrown;
            this.Power.BorderlineColor = System.Drawing.Color.Gray;
            chartArea2.AxisX.IsStartedFromZero = false;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.Name = "ChartArea1";
            this.Power.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Power.Legends.Add(legend2);
            this.Power.Location = new System.Drawing.Point(8, 526);
            this.Power.Name = "Power";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Navy;
            series5.Legend = "Legend1";
            series5.Name = "CPU Package";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.DarkRed;
            series6.Legend = "Legend1";
            series6.Name = "CPU Cores";
            this.Power.Series.Add(series5);
            this.Power.Series.Add(series6);
            this.Power.Size = new System.Drawing.Size(624, 149);
            this.Power.TabIndex = 40;
            this.Power.Text = "Power";
            title2.Name = "Power";
            title2.Text = "Current Power";
            this.Power.Titles.Add(title2);
            // 
            // Temperature
            // 
            this.Temperature.BackColor = System.Drawing.Color.RosyBrown;
            this.Temperature.BorderlineColor = System.Drawing.Color.Gray;
            chartArea3.AxisX.IsStartedFromZero = false;
            chartArea3.AxisY.IsStartedFromZero = false;
            chartArea3.Name = "ChartArea1";
            this.Temperature.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Temperature.Legends.Add(legend3);
            this.Temperature.Location = new System.Drawing.Point(8, 371);
            this.Temperature.Name = "Temperature";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "CPU Core #1";
            series7.YValuesPerPoint = 6;
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "CPU Core #2";
            series9.BorderWidth = 2;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "CPU Core #3";
            series10.BorderWidth = 2;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "CPU Core #4";
            series11.BorderWidth = 2;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.Name = "CPU Package";
            this.Temperature.Series.Add(series7);
            this.Temperature.Series.Add(series8);
            this.Temperature.Series.Add(series9);
            this.Temperature.Series.Add(series10);
            this.Temperature.Series.Add(series11);
            this.Temperature.Size = new System.Drawing.Size(624, 149);
            this.Temperature.TabIndex = 39;
            this.Temperature.Text = "Temperature °C";
            title3.Name = "Temperature";
            title3.Text = "Current Temperature";
            this.Temperature.Titles.Add(title3);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(896, 6);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 44;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // LblTime
            // 
            this.LblTime.BackColor = System.Drawing.Color.Honeydew;
            this.LblTime.BDrawBorderBottom = false;
            this.LblTime.BDrawBorderLeft = false;
            this.LblTime.BDrawBorderRight = true;
            this.LblTime.BDrawBorderTop = false;
            this.LblTime.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.LblTime.ForeColor = System.Drawing.Color.Black;
            this.LblTime.Location = new System.Drawing.Point(992, 5);
            this.LblTime.Name = "LblTime";
            this.LblTime.OBorderColor = System.Drawing.Color.Black;
            this.LblTime.Size = new System.Drawing.Size(200, 24);
            this.LblTime.TabIndex = 43;
            this.LblTime.Text = "1111-11-11 00:00:00";
            this.LblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer1000
            // 
            this.Timer1000.Tick += new System.EventHandler(this.Timer1000_Tick);
            // 
            // ChkSave
            // 
            this.ChkSave.AutoSize = true;
            this.ChkSave.Checked = true;
            this.ChkSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkSave.Location = new System.Drawing.Point(13, 9);
            this.ChkSave.Name = "ChkSave";
            this.ChkSave.Size = new System.Drawing.Size(52, 16);
            this.ChkSave.TabIndex = 33;
            this.ChkSave.Text = "Save";
            this.ChkSave.UseVisualStyleBackColor = true;
            // 
            // cPanel1
            // 
            this.cPanel1.BDrawBorderBottom = false;
            this.cPanel1.BDrawBorderLeft = false;
            this.cPanel1.BDrawBorderRight = false;
            this.cPanel1.BDrawBorderTop = false;
            this.cPanel1.Controls.Add(this.cLabel2);
            this.cPanel1.Controls.Add(this.cLabel3);
            this.cPanel1.Controls.Add(this.LblCPU4C_max);
            this.cPanel1.Controls.Add(this.LblCPU3C_max);
            this.cPanel1.Controls.Add(this.LblCPU4C_min);
            this.cPanel1.Controls.Add(this.LblCPU3C_min);
            this.cPanel1.Controls.Add(this.LblCPU4C);
            this.cPanel1.Controls.Add(this.LblCPU3C);
            this.cPanel1.Controls.Add(this.cLabel10);
            this.cPanel1.Controls.Add(this.cLabel11);
            this.cPanel1.Controls.Add(this.cLabel1);
            this.cPanel1.Controls.Add(this.LblTitleUnit);
            this.cPanel1.Controls.Add(this.cLabel23);
            this.cPanel1.Controls.Add(this.cLabel24);
            this.cPanel1.Controls.Add(this.cLabel25);
            this.cPanel1.Controls.Add(this.cLabel26);
            this.cPanel1.Controls.Add(this.cLabel27);
            this.cPanel1.Controls.Add(this.cLabel28);
            this.cPanel1.Controls.Add(this.cLabel29);
            this.cPanel1.Controls.Add(this.cLabel30);
            this.cPanel1.Controls.Add(this.cLabel31);
            this.cPanel1.Controls.Add(this.LblTitleMax);
            this.cPanel1.Controls.Add(this.LblCPU2C_max);
            this.cPanel1.Controls.Add(this.LblCPU1C_max);
            this.cPanel1.Controls.Add(this.LblCPUP_max);
            this.cPanel1.Controls.Add(this.LblPackP_max);
            this.cPanel1.Controls.Add(this.LblCPUPackT_max);
            this.cPanel1.Controls.Add(this.LblCPU4T_max);
            this.cPanel1.Controls.Add(this.LblCPU3T_max);
            this.cPanel1.Controls.Add(this.LblCPU2T_max);
            this.cPanel1.Controls.Add(this.LblCPU1T_max);
            this.cPanel1.Controls.Add(this.LblTitleMin);
            this.cPanel1.Controls.Add(this.LblCPU2C_min);
            this.cPanel1.Controls.Add(this.LblCPU1C_min);
            this.cPanel1.Controls.Add(this.LblCPUP_min);
            this.cPanel1.Controls.Add(this.LblPackP_min);
            this.cPanel1.Controls.Add(this.LblCPUPackT_min);
            this.cPanel1.Controls.Add(this.LblCPU4T_min);
            this.cPanel1.Controls.Add(this.LblCPU3T_min);
            this.cPanel1.Controls.Add(this.LblCPU2T_min);
            this.cPanel1.Controls.Add(this.LblCPU1T_min);
            this.cPanel1.Controls.Add(this.LblTitleItem);
            this.cPanel1.Controls.Add(this.LblTitleVal);
            this.cPanel1.Controls.Add(this.LblCPU2C);
            this.cPanel1.Controls.Add(this.LblCPU1C);
            this.cPanel1.Controls.Add(this.LblCPUP);
            this.cPanel1.Controls.Add(this.LblPackP);
            this.cPanel1.Controls.Add(this.LblCPUPackT);
            this.cPanel1.Controls.Add(this.LblCPU4T);
            this.cPanel1.Controls.Add(this.LblCPU3T);
            this.cPanel1.Controls.Add(this.LblCPU2T);
            this.cPanel1.Controls.Add(this.LblCPU1T);
            this.cPanel1.Controls.Add(this.LblTitleCPUCoreTemp_Package);
            this.cPanel1.Controls.Add(this.LblTitleCPUCoreTemp_Pack);
            this.cPanel1.Controls.Add(this.LblCPUCoreTemp_4);
            this.cPanel1.Controls.Add(this.LblCPUCoreTemp_3);
            this.cPanel1.Controls.Add(this.LblCPUCoreTemp_2);
            this.cPanel1.Controls.Add(this.LblTitleYLength);
            this.cPanel1.Controls.Add(this.LblTitleXLength);
            this.cPanel1.Controls.Add(this.LblTitleSubStance);
            this.cPanel1.Controls.Add(this.LblCPUCoreTemp_1);
            this.cPanel1.Location = new System.Drawing.Point(12, 34);
            this.cPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cPanel1.Name = "cPanel1";
            this.cPanel1.Size = new System.Drawing.Size(431, 290);
            this.cPanel1.TabIndex = 45;
            // 
            // cLabel2
            // 
            this.cLabel2.BackColor = System.Drawing.Color.Gainsboro;
            this.cLabel2.BDrawBorderBottom = true;
            this.cLabel2.BDrawBorderLeft = false;
            this.cLabel2.BDrawBorderRight = true;
            this.cLabel2.BDrawBorderTop = true;
            this.cLabel2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.cLabel2.ForeColor = System.Drawing.Color.Black;
            this.cLabel2.Location = new System.Drawing.Point(378, 264);
            this.cLabel2.Name = "cLabel2";
            this.cLabel2.OBorderColor = System.Drawing.Color.Black;
            this.cLabel2.Size = new System.Drawing.Size(51, 22);
            this.cLabel2.TabIndex = 60;
            this.cLabel2.Text = "MHz";
            this.cLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cLabel3
            // 
            this.cLabel3.BackColor = System.Drawing.Color.Gainsboro;
            this.cLabel3.BDrawBorderBottom = false;
            this.cLabel3.BDrawBorderLeft = false;
            this.cLabel3.BDrawBorderRight = true;
            this.cLabel3.BDrawBorderTop = true;
            this.cLabel3.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.cLabel3.ForeColor = System.Drawing.Color.Black;
            this.cLabel3.Location = new System.Drawing.Point(378, 242);
            this.cLabel3.Name = "cLabel3";
            this.cLabel3.OBorderColor = System.Drawing.Color.Black;
            this.cLabel3.Size = new System.Drawing.Size(51, 22);
            this.cLabel3.TabIndex = 61;
            this.cLabel3.Text = "MHz";
            this.cLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCPU4C_max
            // 
            this.LblCPU4C_max.BackColor = System.Drawing.Color.White;
            this.LblCPU4C_max.BDrawBorderBottom = true;
            this.LblCPU4C_max.BDrawBorderLeft = false;
            this.LblCPU4C_max.BDrawBorderRight = true;
            this.LblCPU4C_max.BDrawBorderTop = true;
            this.LblCPU4C_max.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblCPU4C_max.ForeColor = System.Drawing.Color.Black;
            this.LblCPU4C_max.Location = new System.Drawing.Point(297, 264);
            this.LblCPU4C_max.Name = "LblCPU4C_max";
            this.LblCPU4C_max.OBorderColor = System.Drawing.Color.Black;
            this.LblCPU4C_max.Size = new System.Drawing.Size(81, 22);
            this.LblCPU4C_max.TabIndex = 58;
            this.LblCPU4C_max.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCPU3C_max
            // 
            this.LblCPU3C_max.BackColor = System.Drawing.Color.White;
            this.LblCPU3C_max.BDrawBorderBottom = false;
            this.LblCPU3C_max.BDrawBorderLeft = false;
            this.LblCPU3C_max.BDrawBorderRight = true;
            this.LblCPU3C_max.BDrawBorderTop = true;
            this.LblCPU3C_max.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblCPU3C_max.ForeColor = System.Drawing.Color.Black;
            this.LblCPU3C_max.Location = new System.Drawing.Point(297, 242);
            this.LblCPU3C_max.Name = "LblCPU3C_max";
            this.LblCPU3C_max.OBorderColor = System.Drawing.Color.Black;
            this.LblCPU3C_max.Size = new System.Drawing.Size(81, 22);
            this.LblCPU3C_max.TabIndex = 59;
            this.LblCPU3C_max.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCPU4C_min
            // 
            this.LblCPU4C_min.BackColor = System.Drawing.Color.White;
            this.LblCPU4C_min.BDrawBorderBottom = true;
            this.LblCPU4C_min.BDrawBorderLeft = false;
            this.LblCPU4C_min.BDrawBorderRight = true;
            this.LblCPU4C_min.BDrawBorderTop = true;
            this.LblCPU4C_min.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblCPU4C_min.ForeColor = System.Drawing.Color.Black;
            this.LblCPU4C_min.Location = new System.Drawing.Point(216, 264);
            this.LblCPU4C_min.Name = "LblCPU4C_min";
            this.LblCPU4C_min.OBorderColor = System.Drawing.Color.Black;
            this.LblCPU4C_min.Size = new System.Drawing.Size(81, 22);
            this.LblCPU4C_min.TabIndex = 56;
            this.LblCPU4C_min.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCPU3C_min
            // 
            this.LblCPU3C_min.BackColor = System.Drawing.Color.White;
            this.LblCPU3C_min.BDrawBorderBottom = false;
            this.LblCPU3C_min.BDrawBorderLeft = false;
            this.LblCPU3C_min.BDrawBorderRight = true;
            this.LblCPU3C_min.BDrawBorderTop = true;
            this.LblCPU3C_min.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblCPU3C_min.ForeColor = System.Drawing.Color.Black;
            this.LblCPU3C_min.Location = new System.Drawing.Point(216, 242);
            this.LblCPU3C_min.Name = "LblCPU3C_min";
            this.LblCPU3C_min.OBorderColor = System.Drawing.Color.Black;
            this.LblCPU3C_min.Size = new System.Drawing.Size(81, 22);
            this.LblCPU3C_min.TabIndex = 57;
            this.LblCPU3C_min.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCPU4C
            // 
            this.LblCPU4C.BackColor = System.Drawing.Color.White;
            this.LblCPU4C.BDrawBorderBottom = true;
            this.LblCPU4C.BDrawBorderLeft = false;
            this.LblCPU4C.BDrawBorderRight = true;
            this.LblCPU4C.BDrawBorderTop = true;
            this.LblCPU4C.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblCPU4C.ForeColor = System.Drawing.Color.Black;
            this.LblCPU4C.Location = new System.Drawing.Point(135, 264);
            this.LblCPU4C.Name = "LblCPU4C";
            this.LblCPU4C.OBorderColor = System.Drawing.Color.Black;
            this.LblCPU4C.Size = new System.Drawing.Size(81, 22);
            this.LblCPU4C.TabIndex = 54;
            this.LblCPU4C.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCPU3C
            // 
            this.LblCPU3C.BackColor = System.Drawing.Color.White;
            this.LblCPU3C.BDrawBorderBottom = false;
            this.LblCPU3C.BDrawBorderLeft = false;
            this.LblCPU3C.BDrawBorderRight = true;
            this.LblCPU3C.BDrawBorderTop = true;
            this.LblCPU3C.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblCPU3C.ForeColor = System.Drawing.Color.Black;
            this.LblCPU3C.Location = new System.Drawing.Point(135, 242);
            this.LblCPU3C.Name = "LblCPU3C";
            this.LblCPU3C.OBorderColor = System.Drawing.Color.Black;
            this.LblCPU3C.Size = new System.Drawing.Size(81, 22);
            this.LblCPU3C.TabIndex = 55;
            this.LblCPU3C.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cLabel10
            // 
            this.cLabel10.BackColor = System.Drawing.Color.DimGray;
            this.cLabel10.BDrawBorderBottom = true;
            this.cLabel10.BDrawBorderLeft = false;
            this.cLabel10.BDrawBorderRight = true;
            this.cLabel10.BDrawBorderTop = true;
            this.cLabel10.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.cLabel10.ForeColor = System.Drawing.Color.White;
            this.cLabel10.Location = new System.Drawing.Point(0, 264);
            this.cLabel10.Name = "cLabel10";
            this.cLabel10.OBorderColor = System.Drawing.Color.Black;
            this.cLabel10.Size = new System.Drawing.Size(135, 22);
            this.cLabel10.TabIndex = 52;
            this.cLabel10.Text = "CPU Core 4 Clock";
            this.cLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cLabel11
            // 
            this.cLabel11.BackColor = System.Drawing.Color.DimGray;
            this.cLabel11.BDrawBorderBottom = false;
            this.cLabel11.BDrawBorderLeft = false;
            this.cLabel11.BDrawBorderRight = true;
            this.cLabel11.BDrawBorderTop = true;
            this.cLabel11.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.cLabel11.ForeColor = System.Drawing.Color.White;
            this.cLabel11.Location = new System.Drawing.Point(0, 242);
            this.cLabel11.Name = "cLabel11";
            this.cLabel11.OBorderColor = System.Drawing.Color.Black;
            this.cLabel11.Size = new System.Drawing.Size(135, 22);
            this.cLabel11.TabIndex = 53;
            this.cLabel11.Text = "CPU Core 3 Clock";
            this.cLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cLabel1
            // 
            this.cLabel1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cLabel1.BDrawBorderBottom = false;
            this.cLabel1.BDrawBorderLeft = true;
            this.cLabel1.BDrawBorderRight = true;
            this.cLabel1.BDrawBorderTop = true;
            this.cLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cLabel1.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.cLabel1.ForeColor = System.Drawing.Color.White;
            this.cLabel1.Location = new System.Drawing.Point(0, 0);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.OBorderColor = System.Drawing.Color.Black;
            this.cLabel1.Size = new System.Drawing.Size(431, 22);
            this.cLabel1.TabIndex = 51;
            this.cLabel1.Text = "Current Status";
            this.cLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTitleUnit
            // 
            this.LblTitleUnit.BackColor = System.Drawing.Color.Tan;
            this.LblTitleUnit.BDrawBorderBottom = false;
            this.LblTitleUnit.BDrawBorderLeft = false;
            this.LblTitleUnit.BDrawBorderRight = true;
            this.LblTitleUnit.BDrawBorderTop = true;
            this.LblTitleUnit.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.LblTitleUnit.ForeColor = System.Drawing.Color.White;
            this.LblTitleUnit.Location = new System.Drawing.Point(378, 22);
            this.LblTitleUnit.Name = "LblTitleUnit";
            this.LblTitleUnit.OBorderColor = System.Drawing.Color.Black;
            this.LblTitleUnit.Size = new System.Drawing.Size(51, 22);
            this.LblTitleUnit.TabIndex = 41;
            this.LblTitleUnit.Text = "Unit";
            this.LblTitleUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cLabel23
            // 
            this.cLabel23.BackColor = System.Drawing.Color.Gainsboro;
            this.cLabel23.BDrawBorderBottom = false;
            this.cLabel23.BDrawBorderLeft = false;
            this.cLabel23.BDrawBorderRight = true;
            this.cLabel23.BDrawBorderTop = true;
            this.cLabel23.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.cLabel23.ForeColor = System.Drawing.Color.Black;
            this.cLabel23.Location = new System.Drawing.Point(378, 220);
            this.cLabel23.Name = "cLabel23";
            this.cLabel23.OBorderColor = System.Drawing.Color.Black;
            this.cLabel23.Size = new System.Drawing.Size(51, 22);
            this.cLabel23.TabIndex = 42;
            this.cLabel23.Text = "MHz";
            this.cLabel23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cLabel24
            // 
            this.cLabel24.BackColor = System.Drawing.Color.Gainsboro;
            this.cLabel24.BDrawBorderBottom = false;
            this.cLabel24.BDrawBorderLeft = false;
            this.cLabel24.BDrawBorderRight = true;
            this.cLabel24.BDrawBorderTop = true;
            this.cLabel24.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.cLabel24.ForeColor = System.Drawing.Color.Black;
            this.cLabel24.Location = new System.Drawing.Point(378, 198);
            this.cLabel24.Name = "cLabel24";
            this.cLabel24.OBorderColor = System.Drawing.Color.Black;
            this.cLabel24.Size = new System.Drawing.Size(51, 22);
            this.cLabel24.TabIndex = 43;
            this.cLabel24.Text = "MHz";
            this.cLabel24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cLabel25
            // 
            this.cLabel25.BackColor = System.Drawing.Color.Gainsboro;
            this.cLabel25.BDrawBorderBottom = false;
            this.cLabel25.BDrawBorderLeft = false;
            this.cLabel25.BDrawBorderRight = true;
            this.cLabel25.BDrawBorderTop = false;
            this.cLabel25.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.cLabel25.ForeColor = System.Drawing.Color.Black;
            this.cLabel25.Location = new System.Drawing.Point(378, 176);
            this.cLabel25.Name = "cLabel25";
            this.cLabel25.OBorderColor = System.Drawing.Color.Black;
            this.cLabel25.Size = new System.Drawing.Size(51, 22);
            this.cLabel25.TabIndex = 44;
            this.cLabel25.Text = "W";
            this.cLabel25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cLabel26
            // 
            this.cLabel26.BackColor = System.Drawing.Color.Gainsboro;
            this.cLabel26.BDrawBorderBottom = true;
            this.cLabel26.BDrawBorderLeft = false;
            this.cLabel26.BDrawBorderRight = true;
            this.cLabel26.BDrawBorderTop = true;
            this.cLabel26.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.cLabel26.ForeColor = System.Drawing.Color.Black;
            this.cLabel26.Location = new System.Drawing.Point(378, 154);
            this.cLabel26.Name = "cLabel26";
            this.cLabel26.OBorderColor = System.Drawing.Color.Black;
            this.cLabel26.Size = new System.Drawing.Size(51, 22);
            this.cLabel26.TabIndex = 45;
            this.cLabel26.Text = "W";
            this.cLabel26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cLabel27
            // 
            this.cLabel27.BackColor = System.Drawing.Color.Gainsboro;
            this.cLabel27.BDrawBorderBottom = false;
            this.cLabel27.BDrawBorderLeft = false;
            this.cLabel27.BDrawBorderRight = true;
            this.cLabel27.BDrawBorderTop = true;
            this.cLabel27.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.cLabel27.ForeColor = System.Drawing.Color.Black;
            this.cLabel27.Location = new System.Drawing.Point(378, 132);
            this.cLabel27.Name = "cLabel27";
            this.cLabel27.OBorderColor = System.Drawing.Color.Black;
            this.cLabel27.Size = new System.Drawing.Size(51, 22);
            this.cLabel27.TabIndex = 46;
            this.cLabel27.Text = "°C";
            this.cLabel27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cLabel28
            // 
            this.cLabel28.BackColor = System.Drawing.Color.Gainsboro;
            this.cLabel28.BDrawBorderBottom = false;
            this.cLabel28.BDrawBorderLeft = false;
            this.cLabel28.BDrawBorderRight = true;
            this.cLabel28.BDrawBorderTop = true;
            this.cLabel28.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.cLabel28.ForeColor = System.Drawing.Color.Black;
            this.cLabel28.Location = new System.Drawing.Point(378, 110);
            this.cLabel28.Name = "cLabel28";
            this.cLabel28.OBorderColor = System.Drawing.Color.Black;
            this.cLabel28.Size = new System.Drawing.Size(51, 22);
            this.cLabel28.TabIndex = 47;
            this.cLabel28.Text = "°C";
            this.cLabel28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cLabel29
            // 
            this.cLabel29.BackColor = System.Drawing.Color.Gainsboro;
            this.cLabel29.BDrawBorderBottom = false;
            this.cLabel29.BDrawBorderLeft = false;
            this.cLabel29.BDrawBorderRight = true;
            this.cLabel29.BDrawBorderTop = true;
            this.cLabel29.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.cLabel29.ForeColor = System.Drawing.Color.Black;
            this.cLabel29.Location = new System.Drawing.Point(378, 88);
            this.cLabel29.Name = "cLabel29";
            this.cLabel29.OBorderColor = System.Drawing.Color.Black;
            this.cLabel29.Size = new System.Drawing.Size(51, 22);
            this.cLabel29.TabIndex = 48;
            this.cLabel29.Text = "°C";
            this.cLabel29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cLabel30
            // 
            this.cLabel30.BackColor = System.Drawing.Color.Gainsboro;
            this.cLabel30.BDrawBorderBottom = false;
            this.cLabel30.BDrawBorderLeft = false;
            this.cLabel30.BDrawBorderRight = true;
            this.cLabel30.BDrawBorderTop = true;
            this.cLabel30.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.cLabel30.ForeColor = System.Drawing.Color.Black;
            this.cLabel30.Location = new System.Drawing.Point(378, 66);
            this.cLabel30.Name = "cLabel30";
            this.cLabel30.OBorderColor = System.Drawing.Color.Black;
            this.cLabel30.Size = new System.Drawing.Size(51, 22);
            this.cLabel30.TabIndex = 49;
            this.cLabel30.Text = "°C";
            this.cLabel30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cLabel31
            // 
            this.cLabel31.BackColor = System.Drawing.Color.Gainsboro;
            this.cLabel31.BDrawBorderBottom = false;
            this.cLabel31.BDrawBorderLeft = false;
            this.cLabel31.BDrawBorderRight = true;
            this.cLabel31.BDrawBorderTop = false;
            this.cLabel31.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.cLabel31.ForeColor = System.Drawing.Color.Black;
            this.cLabel31.Location = new System.Drawing.Point(378, 44);
            this.cLabel31.Name = "cLabel31";
            this.cLabel31.OBorderColor = System.Drawing.Color.Black;
            this.cLabel31.Size = new System.Drawing.Size(51, 22);
            this.cLabel31.TabIndex = 50;
            this.cLabel31.Text = "°C";
            this.cLabel31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblTitleMax
            // 
            this.LblTitleMax.BackColor = System.Drawing.Color.Tan;
            this.LblTitleMax.BDrawBorderBottom = false;
            this.LblTitleMax.BDrawBorderLeft = false;
            this.LblTitleMax.BDrawBorderRight = true;
            this.LblTitleMax.BDrawBorderTop = true;
            this.LblTitleMax.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.LblTitleMax.ForeColor = System.Drawing.Color.White;
            this.LblTitleMax.Location = new System.Drawing.Point(297, 22);
            this.LblTitleMax.Name = "LblTitleMax";
            this.LblTitleMax.OBorderColor = System.Drawing.Color.Black;
            this.LblTitleMax.Size = new System.Drawing.Size(81, 22);
            this.LblTitleMax.TabIndex = 31;
            this.LblTitleMax.Text = "Max";
            this.LblTitleMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblCPU2C_max
            // 
            this.LblCPU2C_max.BackColor = System.Drawing.Color.White;
            this.LblCPU2C_max.BDrawBorderBottom = false;
            this.LblCPU2C_max.BDrawBorderLeft = false;
            this.LblCPU2C_max.BDrawBorderRight = true;
            this.LblCPU2C_max.BDrawBorderTop = true;
            this.LblCPU2C_max.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblCPU2C_max.ForeColor = System.Drawing.Color.Black;
            this.LblCPU2C_max.Location = new System.Drawing.Point(297, 220);
            this.LblCPU2C_max.Name = "LblCPU2C_max";
            this.LblCPU2C_max.OBorderColor = System.Drawing.Color.Black;
            this.LblCPU2C_max.Size = new System.Drawing.Size(81, 22);
            this.LblCPU2C_max.TabIndex = 32;
            this.LblCPU2C_max.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCPU1C_max
            // 
            this.LblCPU1C_max.BackColor = System.Drawing.Color.White;
            this.LblCPU1C_max.BDrawBorderBottom = false;
            this.LblCPU1C_max.BDrawBorderLeft = false;
            this.LblCPU1C_max.BDrawBorderRight = true;
            this.LblCPU1C_max.BDrawBorderTop = true;
            this.LblCPU1C_max.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblCPU1C_max.ForeColor = System.Drawing.Color.Black;
            this.LblCPU1C_max.Location = new System.Drawing.Point(297, 198);
            this.LblCPU1C_max.Name = "LblCPU1C_max";
            this.LblCPU1C_max.OBorderColor = System.Drawing.Color.Black;
            this.LblCPU1C_max.Size = new System.Drawing.Size(81, 22);
            this.LblCPU1C_max.TabIndex = 33;
            this.LblCPU1C_max.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCPUP_max
            // 
            this.LblCPUP_max.BackColor = System.Drawing.Color.White;
            this.LblCPUP_max.BDrawBorderBottom = false;
            this.LblCPUP_max.BDrawBorderLeft = false;
            this.LblCPUP_max.BDrawBorderRight = true;
            this.LblCPUP_max.BDrawBorderTop = false;
            this.LblCPUP_max.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblCPUP_max.ForeColor = System.Drawing.Color.Black;
            this.LblCPUP_max.Location = new System.Drawing.Point(297, 176);
            this.LblCPUP_max.Name = "LblCPUP_max";
            this.LblCPUP_max.OBorderColor = System.Drawing.Color.Black;
            this.LblCPUP_max.Size = new System.Drawing.Size(81, 22);
            this.LblCPUP_max.TabIndex = 34;
            this.LblCPUP_max.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblPackP_max
            // 
            this.LblPackP_max.BackColor = System.Drawing.Color.White;
            this.LblPackP_max.BDrawBorderBottom = true;
            this.LblPackP_max.BDrawBorderLeft = false;
            this.LblPackP_max.BDrawBorderRight = true;
            this.LblPackP_max.BDrawBorderTop = true;
            this.LblPackP_max.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblPackP_max.ForeColor = System.Drawing.Color.Black;
            this.LblPackP_max.Location = new System.Drawing.Point(297, 154);
            this.LblPackP_max.Name = "LblPackP_max";
            this.LblPackP_max.OBorderColor = System.Drawing.Color.Black;
            this.LblPackP_max.Size = new System.Drawing.Size(81, 22);
            this.LblPackP_max.TabIndex = 35;
            this.LblPackP_max.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCPUPackT_max
            // 
            this.LblCPUPackT_max.BackColor = System.Drawing.Color.White;
            this.LblCPUPackT_max.BDrawBorderBottom = false;
            this.LblCPUPackT_max.BDrawBorderLeft = false;
            this.LblCPUPackT_max.BDrawBorderRight = true;
            this.LblCPUPackT_max.BDrawBorderTop = true;
            this.LblCPUPackT_max.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblCPUPackT_max.ForeColor = System.Drawing.Color.Black;
            this.LblCPUPackT_max.Location = new System.Drawing.Point(297, 132);
            this.LblCPUPackT_max.Name = "LblCPUPackT_max";
            this.LblCPUPackT_max.OBorderColor = System.Drawing.Color.Black;
            this.LblCPUPackT_max.Size = new System.Drawing.Size(81, 22);
            this.LblCPUPackT_max.TabIndex = 36;
            this.LblCPUPackT_max.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCPU4T_max
            // 
            this.LblCPU4T_max.BackColor = System.Drawing.Color.White;
            this.LblCPU4T_max.BDrawBorderBottom = false;
            this.LblCPU4T_max.BDrawBorderLeft = false;
            this.LblCPU4T_max.BDrawBorderRight = true;
            this.LblCPU4T_max.BDrawBorderTop = true;
            this.LblCPU4T_max.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblCPU4T_max.ForeColor = System.Drawing.Color.Black;
            this.LblCPU4T_max.Location = new System.Drawing.Point(297, 110);
            this.LblCPU4T_max.Name = "LblCPU4T_max";
            this.LblCPU4T_max.OBorderColor = System.Drawing.Color.Black;
            this.LblCPU4T_max.Size = new System.Drawing.Size(81, 22);
            this.LblCPU4T_max.TabIndex = 37;
            this.LblCPU4T_max.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCPU3T_max
            // 
            this.LblCPU3T_max.BackColor = System.Drawing.Color.White;
            this.LblCPU3T_max.BDrawBorderBottom = false;
            this.LblCPU3T_max.BDrawBorderLeft = false;
            this.LblCPU3T_max.BDrawBorderRight = true;
            this.LblCPU3T_max.BDrawBorderTop = true;
            this.LblCPU3T_max.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblCPU3T_max.ForeColor = System.Drawing.Color.Black;
            this.LblCPU3T_max.Location = new System.Drawing.Point(297, 88);
            this.LblCPU3T_max.Name = "LblCPU3T_max";
            this.LblCPU3T_max.OBorderColor = System.Drawing.Color.Black;
            this.LblCPU3T_max.Size = new System.Drawing.Size(81, 22);
            this.LblCPU3T_max.TabIndex = 38;
            this.LblCPU3T_max.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCPU2T_max
            // 
            this.LblCPU2T_max.BackColor = System.Drawing.Color.White;
            this.LblCPU2T_max.BDrawBorderBottom = false;
            this.LblCPU2T_max.BDrawBorderLeft = false;
            this.LblCPU2T_max.BDrawBorderRight = true;
            this.LblCPU2T_max.BDrawBorderTop = true;
            this.LblCPU2T_max.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblCPU2T_max.ForeColor = System.Drawing.Color.Black;
            this.LblCPU2T_max.Location = new System.Drawing.Point(297, 66);
            this.LblCPU2T_max.Name = "LblCPU2T_max";
            this.LblCPU2T_max.OBorderColor = System.Drawing.Color.Black;
            this.LblCPU2T_max.Size = new System.Drawing.Size(81, 22);
            this.LblCPU2T_max.TabIndex = 39;
            this.LblCPU2T_max.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCPU1T_max
            // 
            this.LblCPU1T_max.BackColor = System.Drawing.Color.White;
            this.LblCPU1T_max.BDrawBorderBottom = false;
            this.LblCPU1T_max.BDrawBorderLeft = false;
            this.LblCPU1T_max.BDrawBorderRight = true;
            this.LblCPU1T_max.BDrawBorderTop = false;
            this.LblCPU1T_max.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblCPU1T_max.ForeColor = System.Drawing.Color.Black;
            this.LblCPU1T_max.Location = new System.Drawing.Point(297, 44);
            this.LblCPU1T_max.Name = "LblCPU1T_max";
            this.LblCPU1T_max.OBorderColor = System.Drawing.Color.Black;
            this.LblCPU1T_max.Size = new System.Drawing.Size(81, 22);
            this.LblCPU1T_max.TabIndex = 40;
            this.LblCPU1T_max.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblTitleMin
            // 
            this.LblTitleMin.BackColor = System.Drawing.Color.Tan;
            this.LblTitleMin.BDrawBorderBottom = false;
            this.LblTitleMin.BDrawBorderLeft = false;
            this.LblTitleMin.BDrawBorderRight = true;
            this.LblTitleMin.BDrawBorderTop = true;
            this.LblTitleMin.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.LblTitleMin.ForeColor = System.Drawing.Color.White;
            this.LblTitleMin.Location = new System.Drawing.Point(216, 22);
            this.LblTitleMin.Name = "LblTitleMin";
            this.LblTitleMin.OBorderColor = System.Drawing.Color.Black;
            this.LblTitleMin.Size = new System.Drawing.Size(81, 22);
            this.LblTitleMin.TabIndex = 21;
            this.LblTitleMin.Text = "Min";
            this.LblTitleMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblCPU2C_min
            // 
            this.LblCPU2C_min.BackColor = System.Drawing.Color.White;
            this.LblCPU2C_min.BDrawBorderBottom = false;
            this.LblCPU2C_min.BDrawBorderLeft = false;
            this.LblCPU2C_min.BDrawBorderRight = true;
            this.LblCPU2C_min.BDrawBorderTop = true;
            this.LblCPU2C_min.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblCPU2C_min.ForeColor = System.Drawing.Color.Black;
            this.LblCPU2C_min.Location = new System.Drawing.Point(216, 220);
            this.LblCPU2C_min.Name = "LblCPU2C_min";
            this.LblCPU2C_min.OBorderColor = System.Drawing.Color.Black;
            this.LblCPU2C_min.Size = new System.Drawing.Size(81, 22);
            this.LblCPU2C_min.TabIndex = 22;
            this.LblCPU2C_min.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCPU1C_min
            // 
            this.LblCPU1C_min.BackColor = System.Drawing.Color.White;
            this.LblCPU1C_min.BDrawBorderBottom = false;
            this.LblCPU1C_min.BDrawBorderLeft = false;
            this.LblCPU1C_min.BDrawBorderRight = true;
            this.LblCPU1C_min.BDrawBorderTop = true;
            this.LblCPU1C_min.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblCPU1C_min.ForeColor = System.Drawing.Color.Black;
            this.LblCPU1C_min.Location = new System.Drawing.Point(216, 198);
            this.LblCPU1C_min.Name = "LblCPU1C_min";
            this.LblCPU1C_min.OBorderColor = System.Drawing.Color.Black;
            this.LblCPU1C_min.Size = new System.Drawing.Size(81, 22);
            this.LblCPU1C_min.TabIndex = 23;
            this.LblCPU1C_min.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCPUP_min
            // 
            this.LblCPUP_min.BackColor = System.Drawing.Color.White;
            this.LblCPUP_min.BDrawBorderBottom = false;
            this.LblCPUP_min.BDrawBorderLeft = false;
            this.LblCPUP_min.BDrawBorderRight = true;
            this.LblCPUP_min.BDrawBorderTop = false;
            this.LblCPUP_min.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblCPUP_min.ForeColor = System.Drawing.Color.Black;
            this.LblCPUP_min.Location = new System.Drawing.Point(216, 176);
            this.LblCPUP_min.Name = "LblCPUP_min";
            this.LblCPUP_min.OBorderColor = System.Drawing.Color.Black;
            this.LblCPUP_min.Size = new System.Drawing.Size(81, 22);
            this.LblCPUP_min.TabIndex = 24;
            this.LblCPUP_min.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblPackP_min
            // 
            this.LblPackP_min.BackColor = System.Drawing.Color.White;
            this.LblPackP_min.BDrawBorderBottom = true;
            this.LblPackP_min.BDrawBorderLeft = false;
            this.LblPackP_min.BDrawBorderRight = true;
            this.LblPackP_min.BDrawBorderTop = true;
            this.LblPackP_min.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblPackP_min.ForeColor = System.Drawing.Color.Black;
            this.LblPackP_min.Location = new System.Drawing.Point(216, 154);
            this.LblPackP_min.Name = "LblPackP_min";
            this.LblPackP_min.OBorderColor = System.Drawing.Color.Black;
            this.LblPackP_min.Size = new System.Drawing.Size(81, 22);
            this.LblPackP_min.TabIndex = 25;
            this.LblPackP_min.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCPUPackT_min
            // 
            this.LblCPUPackT_min.BackColor = System.Drawing.Color.White;
            this.LblCPUPackT_min.BDrawBorderBottom = false;
            this.LblCPUPackT_min.BDrawBorderLeft = false;
            this.LblCPUPackT_min.BDrawBorderRight = true;
            this.LblCPUPackT_min.BDrawBorderTop = true;
            this.LblCPUPackT_min.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblCPUPackT_min.ForeColor = System.Drawing.Color.Black;
            this.LblCPUPackT_min.Location = new System.Drawing.Point(216, 132);
            this.LblCPUPackT_min.Name = "LblCPUPackT_min";
            this.LblCPUPackT_min.OBorderColor = System.Drawing.Color.Black;
            this.LblCPUPackT_min.Size = new System.Drawing.Size(81, 22);
            this.LblCPUPackT_min.TabIndex = 26;
            this.LblCPUPackT_min.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCPU4T_min
            // 
            this.LblCPU4T_min.BackColor = System.Drawing.Color.White;
            this.LblCPU4T_min.BDrawBorderBottom = false;
            this.LblCPU4T_min.BDrawBorderLeft = false;
            this.LblCPU4T_min.BDrawBorderRight = true;
            this.LblCPU4T_min.BDrawBorderTop = true;
            this.LblCPU4T_min.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblCPU4T_min.ForeColor = System.Drawing.Color.Black;
            this.LblCPU4T_min.Location = new System.Drawing.Point(216, 110);
            this.LblCPU4T_min.Name = "LblCPU4T_min";
            this.LblCPU4T_min.OBorderColor = System.Drawing.Color.Black;
            this.LblCPU4T_min.Size = new System.Drawing.Size(81, 22);
            this.LblCPU4T_min.TabIndex = 27;
            this.LblCPU4T_min.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCPU3T_min
            // 
            this.LblCPU3T_min.BackColor = System.Drawing.Color.White;
            this.LblCPU3T_min.BDrawBorderBottom = false;
            this.LblCPU3T_min.BDrawBorderLeft = false;
            this.LblCPU3T_min.BDrawBorderRight = true;
            this.LblCPU3T_min.BDrawBorderTop = true;
            this.LblCPU3T_min.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblCPU3T_min.ForeColor = System.Drawing.Color.Black;
            this.LblCPU3T_min.Location = new System.Drawing.Point(216, 88);
            this.LblCPU3T_min.Name = "LblCPU3T_min";
            this.LblCPU3T_min.OBorderColor = System.Drawing.Color.Black;
            this.LblCPU3T_min.Size = new System.Drawing.Size(81, 22);
            this.LblCPU3T_min.TabIndex = 28;
            this.LblCPU3T_min.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCPU2T_min
            // 
            this.LblCPU2T_min.BackColor = System.Drawing.Color.White;
            this.LblCPU2T_min.BDrawBorderBottom = false;
            this.LblCPU2T_min.BDrawBorderLeft = false;
            this.LblCPU2T_min.BDrawBorderRight = true;
            this.LblCPU2T_min.BDrawBorderTop = true;
            this.LblCPU2T_min.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblCPU2T_min.ForeColor = System.Drawing.Color.Black;
            this.LblCPU2T_min.Location = new System.Drawing.Point(216, 66);
            this.LblCPU2T_min.Name = "LblCPU2T_min";
            this.LblCPU2T_min.OBorderColor = System.Drawing.Color.Black;
            this.LblCPU2T_min.Size = new System.Drawing.Size(81, 22);
            this.LblCPU2T_min.TabIndex = 29;
            this.LblCPU2T_min.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCPU1T_min
            // 
            this.LblCPU1T_min.BackColor = System.Drawing.Color.White;
            this.LblCPU1T_min.BDrawBorderBottom = false;
            this.LblCPU1T_min.BDrawBorderLeft = false;
            this.LblCPU1T_min.BDrawBorderRight = true;
            this.LblCPU1T_min.BDrawBorderTop = false;
            this.LblCPU1T_min.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblCPU1T_min.ForeColor = System.Drawing.Color.Black;
            this.LblCPU1T_min.Location = new System.Drawing.Point(216, 44);
            this.LblCPU1T_min.Name = "LblCPU1T_min";
            this.LblCPU1T_min.OBorderColor = System.Drawing.Color.Black;
            this.LblCPU1T_min.Size = new System.Drawing.Size(81, 22);
            this.LblCPU1T_min.TabIndex = 30;
            this.LblCPU1T_min.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblTitleItem
            // 
            this.LblTitleItem.BackColor = System.Drawing.Color.Tan;
            this.LblTitleItem.BDrawBorderBottom = false;
            this.LblTitleItem.BDrawBorderLeft = false;
            this.LblTitleItem.BDrawBorderRight = true;
            this.LblTitleItem.BDrawBorderTop = true;
            this.LblTitleItem.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.LblTitleItem.ForeColor = System.Drawing.Color.White;
            this.LblTitleItem.Location = new System.Drawing.Point(0, 22);
            this.LblTitleItem.Name = "LblTitleItem";
            this.LblTitleItem.OBorderColor = System.Drawing.Color.Black;
            this.LblTitleItem.Size = new System.Drawing.Size(135, 22);
            this.LblTitleItem.TabIndex = 20;
            this.LblTitleItem.Text = "Items";
            this.LblTitleItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTitleVal
            // 
            this.LblTitleVal.BackColor = System.Drawing.Color.Tan;
            this.LblTitleVal.BDrawBorderBottom = false;
            this.LblTitleVal.BDrawBorderLeft = false;
            this.LblTitleVal.BDrawBorderRight = true;
            this.LblTitleVal.BDrawBorderTop = true;
            this.LblTitleVal.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.LblTitleVal.ForeColor = System.Drawing.Color.White;
            this.LblTitleVal.Location = new System.Drawing.Point(135, 22);
            this.LblTitleVal.Name = "LblTitleVal";
            this.LblTitleVal.OBorderColor = System.Drawing.Color.Black;
            this.LblTitleVal.Size = new System.Drawing.Size(81, 22);
            this.LblTitleVal.TabIndex = 8;
            this.LblTitleVal.Text = "Value";
            this.LblTitleVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblCPU2C
            // 
            this.LblCPU2C.BackColor = System.Drawing.Color.White;
            this.LblCPU2C.BDrawBorderBottom = false;
            this.LblCPU2C.BDrawBorderLeft = false;
            this.LblCPU2C.BDrawBorderRight = true;
            this.LblCPU2C.BDrawBorderTop = true;
            this.LblCPU2C.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblCPU2C.ForeColor = System.Drawing.Color.Black;
            this.LblCPU2C.Location = new System.Drawing.Point(135, 220);
            this.LblCPU2C.Name = "LblCPU2C";
            this.LblCPU2C.OBorderColor = System.Drawing.Color.Black;
            this.LblCPU2C.Size = new System.Drawing.Size(81, 22);
            this.LblCPU2C.TabIndex = 19;
            this.LblCPU2C.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCPU1C
            // 
            this.LblCPU1C.BackColor = System.Drawing.Color.White;
            this.LblCPU1C.BDrawBorderBottom = false;
            this.LblCPU1C.BDrawBorderLeft = false;
            this.LblCPU1C.BDrawBorderRight = true;
            this.LblCPU1C.BDrawBorderTop = true;
            this.LblCPU1C.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblCPU1C.ForeColor = System.Drawing.Color.Black;
            this.LblCPU1C.Location = new System.Drawing.Point(135, 198);
            this.LblCPU1C.Name = "LblCPU1C";
            this.LblCPU1C.OBorderColor = System.Drawing.Color.Black;
            this.LblCPU1C.Size = new System.Drawing.Size(81, 22);
            this.LblCPU1C.TabIndex = 19;
            this.LblCPU1C.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCPUP
            // 
            this.LblCPUP.BackColor = System.Drawing.Color.White;
            this.LblCPUP.BDrawBorderBottom = false;
            this.LblCPUP.BDrawBorderLeft = false;
            this.LblCPUP.BDrawBorderRight = true;
            this.LblCPUP.BDrawBorderTop = false;
            this.LblCPUP.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblCPUP.ForeColor = System.Drawing.Color.Black;
            this.LblCPUP.Location = new System.Drawing.Point(135, 176);
            this.LblCPUP.Name = "LblCPUP";
            this.LblCPUP.OBorderColor = System.Drawing.Color.Black;
            this.LblCPUP.Size = new System.Drawing.Size(81, 22);
            this.LblCPUP.TabIndex = 19;
            this.LblCPUP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblPackP
            // 
            this.LblPackP.BackColor = System.Drawing.Color.White;
            this.LblPackP.BDrawBorderBottom = true;
            this.LblPackP.BDrawBorderLeft = false;
            this.LblPackP.BDrawBorderRight = true;
            this.LblPackP.BDrawBorderTop = true;
            this.LblPackP.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblPackP.ForeColor = System.Drawing.Color.Black;
            this.LblPackP.Location = new System.Drawing.Point(135, 154);
            this.LblPackP.Name = "LblPackP";
            this.LblPackP.OBorderColor = System.Drawing.Color.Black;
            this.LblPackP.Size = new System.Drawing.Size(81, 22);
            this.LblPackP.TabIndex = 19;
            this.LblPackP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCPUPackT
            // 
            this.LblCPUPackT.BackColor = System.Drawing.Color.White;
            this.LblCPUPackT.BDrawBorderBottom = false;
            this.LblCPUPackT.BDrawBorderLeft = false;
            this.LblCPUPackT.BDrawBorderRight = true;
            this.LblCPUPackT.BDrawBorderTop = true;
            this.LblCPUPackT.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblCPUPackT.ForeColor = System.Drawing.Color.Black;
            this.LblCPUPackT.Location = new System.Drawing.Point(135, 132);
            this.LblCPUPackT.Name = "LblCPUPackT";
            this.LblCPUPackT.OBorderColor = System.Drawing.Color.Black;
            this.LblCPUPackT.Size = new System.Drawing.Size(81, 22);
            this.LblCPUPackT.TabIndex = 19;
            this.LblCPUPackT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCPU4T
            // 
            this.LblCPU4T.BackColor = System.Drawing.Color.White;
            this.LblCPU4T.BDrawBorderBottom = false;
            this.LblCPU4T.BDrawBorderLeft = false;
            this.LblCPU4T.BDrawBorderRight = true;
            this.LblCPU4T.BDrawBorderTop = true;
            this.LblCPU4T.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblCPU4T.ForeColor = System.Drawing.Color.Black;
            this.LblCPU4T.Location = new System.Drawing.Point(135, 110);
            this.LblCPU4T.Name = "LblCPU4T";
            this.LblCPU4T.OBorderColor = System.Drawing.Color.Black;
            this.LblCPU4T.Size = new System.Drawing.Size(81, 22);
            this.LblCPU4T.TabIndex = 19;
            this.LblCPU4T.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCPU3T
            // 
            this.LblCPU3T.BackColor = System.Drawing.Color.White;
            this.LblCPU3T.BDrawBorderBottom = false;
            this.LblCPU3T.BDrawBorderLeft = false;
            this.LblCPU3T.BDrawBorderRight = true;
            this.LblCPU3T.BDrawBorderTop = true;
            this.LblCPU3T.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblCPU3T.ForeColor = System.Drawing.Color.Black;
            this.LblCPU3T.Location = new System.Drawing.Point(135, 88);
            this.LblCPU3T.Name = "LblCPU3T";
            this.LblCPU3T.OBorderColor = System.Drawing.Color.Black;
            this.LblCPU3T.Size = new System.Drawing.Size(81, 22);
            this.LblCPU3T.TabIndex = 19;
            this.LblCPU3T.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCPU2T
            // 
            this.LblCPU2T.BackColor = System.Drawing.Color.White;
            this.LblCPU2T.BDrawBorderBottom = false;
            this.LblCPU2T.BDrawBorderLeft = false;
            this.LblCPU2T.BDrawBorderRight = true;
            this.LblCPU2T.BDrawBorderTop = true;
            this.LblCPU2T.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblCPU2T.ForeColor = System.Drawing.Color.Black;
            this.LblCPU2T.Location = new System.Drawing.Point(135, 66);
            this.LblCPU2T.Name = "LblCPU2T";
            this.LblCPU2T.OBorderColor = System.Drawing.Color.Black;
            this.LblCPU2T.Size = new System.Drawing.Size(81, 22);
            this.LblCPU2T.TabIndex = 19;
            this.LblCPU2T.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCPU1T
            // 
            this.LblCPU1T.BackColor = System.Drawing.Color.White;
            this.LblCPU1T.BDrawBorderBottom = false;
            this.LblCPU1T.BDrawBorderLeft = false;
            this.LblCPU1T.BDrawBorderRight = true;
            this.LblCPU1T.BDrawBorderTop = false;
            this.LblCPU1T.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.LblCPU1T.ForeColor = System.Drawing.Color.Black;
            this.LblCPU1T.Location = new System.Drawing.Point(135, 44);
            this.LblCPU1T.Name = "LblCPU1T";
            this.LblCPU1T.OBorderColor = System.Drawing.Color.Black;
            this.LblCPU1T.Size = new System.Drawing.Size(81, 22);
            this.LblCPU1T.TabIndex = 19;
            this.LblCPU1T.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblTitleCPUCoreTemp_Package
            // 
            this.LblTitleCPUCoreTemp_Package.BackColor = System.Drawing.Color.DimGray;
            this.LblTitleCPUCoreTemp_Package.BDrawBorderBottom = true;
            this.LblTitleCPUCoreTemp_Package.BDrawBorderLeft = false;
            this.LblTitleCPUCoreTemp_Package.BDrawBorderRight = true;
            this.LblTitleCPUCoreTemp_Package.BDrawBorderTop = true;
            this.LblTitleCPUCoreTemp_Package.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.LblTitleCPUCoreTemp_Package.ForeColor = System.Drawing.Color.White;
            this.LblTitleCPUCoreTemp_Package.Location = new System.Drawing.Point(0, 154);
            this.LblTitleCPUCoreTemp_Package.Name = "LblTitleCPUCoreTemp_Package";
            this.LblTitleCPUCoreTemp_Package.OBorderColor = System.Drawing.Color.Black;
            this.LblTitleCPUCoreTemp_Package.Size = new System.Drawing.Size(135, 22);
            this.LblTitleCPUCoreTemp_Package.TabIndex = 10;
            this.LblTitleCPUCoreTemp_Package.Text = "CPU Pack. Power";
            this.LblTitleCPUCoreTemp_Package.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblTitleCPUCoreTemp_Pack
            // 
            this.LblTitleCPUCoreTemp_Pack.BackColor = System.Drawing.Color.DimGray;
            this.LblTitleCPUCoreTemp_Pack.BDrawBorderBottom = false;
            this.LblTitleCPUCoreTemp_Pack.BDrawBorderLeft = false;
            this.LblTitleCPUCoreTemp_Pack.BDrawBorderRight = true;
            this.LblTitleCPUCoreTemp_Pack.BDrawBorderTop = true;
            this.LblTitleCPUCoreTemp_Pack.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.LblTitleCPUCoreTemp_Pack.ForeColor = System.Drawing.Color.White;
            this.LblTitleCPUCoreTemp_Pack.Location = new System.Drawing.Point(0, 132);
            this.LblTitleCPUCoreTemp_Pack.Name = "LblTitleCPUCoreTemp_Pack";
            this.LblTitleCPUCoreTemp_Pack.OBorderColor = System.Drawing.Color.Black;
            this.LblTitleCPUCoreTemp_Pack.Size = new System.Drawing.Size(135, 22);
            this.LblTitleCPUCoreTemp_Pack.TabIndex = 10;
            this.LblTitleCPUCoreTemp_Pack.Text = "CPU Pack. Temp.";
            this.LblTitleCPUCoreTemp_Pack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblCPUCoreTemp_4
            // 
            this.LblCPUCoreTemp_4.BackColor = System.Drawing.Color.DimGray;
            this.LblCPUCoreTemp_4.BDrawBorderBottom = false;
            this.LblCPUCoreTemp_4.BDrawBorderLeft = false;
            this.LblCPUCoreTemp_4.BDrawBorderRight = true;
            this.LblCPUCoreTemp_4.BDrawBorderTop = true;
            this.LblCPUCoreTemp_4.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.LblCPUCoreTemp_4.ForeColor = System.Drawing.Color.White;
            this.LblCPUCoreTemp_4.Location = new System.Drawing.Point(0, 110);
            this.LblCPUCoreTemp_4.Name = "LblCPUCoreTemp_4";
            this.LblCPUCoreTemp_4.OBorderColor = System.Drawing.Color.Black;
            this.LblCPUCoreTemp_4.Size = new System.Drawing.Size(135, 22);
            this.LblCPUCoreTemp_4.TabIndex = 10;
            this.LblCPUCoreTemp_4.Text = "CPU Core 4 Temp.";
            this.LblCPUCoreTemp_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblCPUCoreTemp_3
            // 
            this.LblCPUCoreTemp_3.BackColor = System.Drawing.Color.DimGray;
            this.LblCPUCoreTemp_3.BDrawBorderBottom = false;
            this.LblCPUCoreTemp_3.BDrawBorderLeft = false;
            this.LblCPUCoreTemp_3.BDrawBorderRight = true;
            this.LblCPUCoreTemp_3.BDrawBorderTop = true;
            this.LblCPUCoreTemp_3.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.LblCPUCoreTemp_3.ForeColor = System.Drawing.Color.White;
            this.LblCPUCoreTemp_3.Location = new System.Drawing.Point(0, 88);
            this.LblCPUCoreTemp_3.Name = "LblCPUCoreTemp_3";
            this.LblCPUCoreTemp_3.OBorderColor = System.Drawing.Color.Black;
            this.LblCPUCoreTemp_3.Size = new System.Drawing.Size(135, 22);
            this.LblCPUCoreTemp_3.TabIndex = 10;
            this.LblCPUCoreTemp_3.Text = "CPU Core 3 Temp.";
            this.LblCPUCoreTemp_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblCPUCoreTemp_2
            // 
            this.LblCPUCoreTemp_2.BackColor = System.Drawing.Color.DimGray;
            this.LblCPUCoreTemp_2.BDrawBorderBottom = false;
            this.LblCPUCoreTemp_2.BDrawBorderLeft = false;
            this.LblCPUCoreTemp_2.BDrawBorderRight = true;
            this.LblCPUCoreTemp_2.BDrawBorderTop = true;
            this.LblCPUCoreTemp_2.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.LblCPUCoreTemp_2.ForeColor = System.Drawing.Color.White;
            this.LblCPUCoreTemp_2.Location = new System.Drawing.Point(0, 66);
            this.LblCPUCoreTemp_2.Name = "LblCPUCoreTemp_2";
            this.LblCPUCoreTemp_2.OBorderColor = System.Drawing.Color.Black;
            this.LblCPUCoreTemp_2.Size = new System.Drawing.Size(135, 22);
            this.LblCPUCoreTemp_2.TabIndex = 10;
            this.LblCPUCoreTemp_2.Text = "CPU Core 2 Temp.";
            this.LblCPUCoreTemp_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblTitleYLength
            // 
            this.LblTitleYLength.BackColor = System.Drawing.Color.DimGray;
            this.LblTitleYLength.BDrawBorderBottom = false;
            this.LblTitleYLength.BDrawBorderLeft = false;
            this.LblTitleYLength.BDrawBorderRight = true;
            this.LblTitleYLength.BDrawBorderTop = true;
            this.LblTitleYLength.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.LblTitleYLength.ForeColor = System.Drawing.Color.White;
            this.LblTitleYLength.Location = new System.Drawing.Point(0, 220);
            this.LblTitleYLength.Name = "LblTitleYLength";
            this.LblTitleYLength.OBorderColor = System.Drawing.Color.Black;
            this.LblTitleYLength.Size = new System.Drawing.Size(135, 22);
            this.LblTitleYLength.TabIndex = 10;
            this.LblTitleYLength.Text = "CPU Core 2 Clock";
            this.LblTitleYLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblTitleXLength
            // 
            this.LblTitleXLength.BackColor = System.Drawing.Color.DimGray;
            this.LblTitleXLength.BDrawBorderBottom = false;
            this.LblTitleXLength.BDrawBorderLeft = false;
            this.LblTitleXLength.BDrawBorderRight = true;
            this.LblTitleXLength.BDrawBorderTop = true;
            this.LblTitleXLength.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.LblTitleXLength.ForeColor = System.Drawing.Color.White;
            this.LblTitleXLength.Location = new System.Drawing.Point(0, 198);
            this.LblTitleXLength.Name = "LblTitleXLength";
            this.LblTitleXLength.OBorderColor = System.Drawing.Color.Black;
            this.LblTitleXLength.Size = new System.Drawing.Size(135, 22);
            this.LblTitleXLength.TabIndex = 10;
            this.LblTitleXLength.Text = "CPU Core 1 Clock";
            this.LblTitleXLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblTitleSubStance
            // 
            this.LblTitleSubStance.BackColor = System.Drawing.Color.DimGray;
            this.LblTitleSubStance.BDrawBorderBottom = false;
            this.LblTitleSubStance.BDrawBorderLeft = false;
            this.LblTitleSubStance.BDrawBorderRight = true;
            this.LblTitleSubStance.BDrawBorderTop = false;
            this.LblTitleSubStance.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.LblTitleSubStance.ForeColor = System.Drawing.Color.White;
            this.LblTitleSubStance.Location = new System.Drawing.Point(0, 176);
            this.LblTitleSubStance.Name = "LblTitleSubStance";
            this.LblTitleSubStance.OBorderColor = System.Drawing.Color.Black;
            this.LblTitleSubStance.Size = new System.Drawing.Size(135, 22);
            this.LblTitleSubStance.TabIndex = 10;
            this.LblTitleSubStance.Text = "CPU Core Power";
            this.LblTitleSubStance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblCPUCoreTemp_1
            // 
            this.LblCPUCoreTemp_1.BackColor = System.Drawing.Color.DimGray;
            this.LblCPUCoreTemp_1.BDrawBorderBottom = false;
            this.LblCPUCoreTemp_1.BDrawBorderLeft = false;
            this.LblCPUCoreTemp_1.BDrawBorderRight = true;
            this.LblCPUCoreTemp_1.BDrawBorderTop = false;
            this.LblCPUCoreTemp_1.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.LblCPUCoreTemp_1.ForeColor = System.Drawing.Color.White;
            this.LblCPUCoreTemp_1.Location = new System.Drawing.Point(0, 44);
            this.LblCPUCoreTemp_1.Name = "LblCPUCoreTemp_1";
            this.LblCPUCoreTemp_1.OBorderColor = System.Drawing.Color.Black;
            this.LblCPUCoreTemp_1.Size = new System.Drawing.Size(135, 22);
            this.LblCPUCoreTemp_1.TabIndex = 10;
            this.LblCPUCoreTemp_1.Text = "CPU Core 1 Temp.";
            this.LblCPUCoreTemp_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 854);
            this.Controls.Add(this.cPanel1);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.Clock);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.Temperature);
            this.Controls.Add(this.PnlBody);
            this.Controls.Add(this.ChkGraphVisible);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NudRefreshtime);
            this.Controls.Add(this.ChkSave);
            this.Controls.Add(this.BtnTest);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "SystemInfo";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudRefreshtime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Power)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Temperature)).EndInit();
            this.cPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChkGraphVisible;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NudRefreshtime;
        private System.Windows.Forms.Button BtnTest;
        private Jhjo.Component.CPanel PnlBody;
        private System.Windows.Forms.DataVisualization.Charting.Chart Clock;
        private System.Windows.Forms.DataVisualization.Charting.Chart Power;
        private System.Windows.Forms.DataVisualization.Charting.Chart Temperature;
        private System.Windows.Forms.Button BtnClear;
        private Jhjo.Component.CLabel LblTime;
        private System.Windows.Forms.Timer Timer1000;
        private System.Windows.Forms.CheckBox ChkSave;
        private Jhjo.Component.CPanel cPanel1;
        private Jhjo.Component.CLabel cLabel1;
        private Jhjo.Component.CLabel LblTitleUnit;
        private Jhjo.Component.CLabel cLabel23;
        private Jhjo.Component.CLabel cLabel24;
        private Jhjo.Component.CLabel cLabel25;
        private Jhjo.Component.CLabel cLabel26;
        private Jhjo.Component.CLabel cLabel27;
        private Jhjo.Component.CLabel cLabel28;
        private Jhjo.Component.CLabel cLabel29;
        private Jhjo.Component.CLabel cLabel30;
        private Jhjo.Component.CLabel cLabel31;
        private Jhjo.Component.CLabel LblTitleMax;
        private Jhjo.Component.CLabel LblCPU2C_max;
        private Jhjo.Component.CLabel LblCPU1C_max;
        private Jhjo.Component.CLabel LblCPUP_max;
        private Jhjo.Component.CLabel LblPackP_max;
        private Jhjo.Component.CLabel LblCPUPackT_max;
        private Jhjo.Component.CLabel LblCPU4T_max;
        private Jhjo.Component.CLabel LblCPU3T_max;
        private Jhjo.Component.CLabel LblCPU2T_max;
        private Jhjo.Component.CLabel LblCPU1T_max;
        private Jhjo.Component.CLabel LblTitleMin;
        private Jhjo.Component.CLabel LblCPU2C_min;
        private Jhjo.Component.CLabel LblCPU1C_min;
        private Jhjo.Component.CLabel LblCPUP_min;
        private Jhjo.Component.CLabel LblPackP_min;
        private Jhjo.Component.CLabel LblCPUPackT_min;
        private Jhjo.Component.CLabel LblCPU4T_min;
        private Jhjo.Component.CLabel LblCPU3T_min;
        private Jhjo.Component.CLabel LblCPU2T_min;
        private Jhjo.Component.CLabel LblCPU1T_min;
        private Jhjo.Component.CLabel LblTitleItem;
        private Jhjo.Component.CLabel LblTitleVal;
        private Jhjo.Component.CLabel LblCPU2C;
        private Jhjo.Component.CLabel LblCPU1C;
        private Jhjo.Component.CLabel LblCPUP;
        private Jhjo.Component.CLabel LblPackP;
        private Jhjo.Component.CLabel LblCPUPackT;
        private Jhjo.Component.CLabel LblCPU4T;
        private Jhjo.Component.CLabel LblCPU3T;
        private Jhjo.Component.CLabel LblCPU2T;
        private Jhjo.Component.CLabel LblCPU1T;
        private Jhjo.Component.CLabel LblTitleCPUCoreTemp_Package;
        private Jhjo.Component.CLabel LblTitleCPUCoreTemp_Pack;
        private Jhjo.Component.CLabel LblCPUCoreTemp_4;
        private Jhjo.Component.CLabel LblCPUCoreTemp_3;
        private Jhjo.Component.CLabel LblCPUCoreTemp_2;
        private Jhjo.Component.CLabel LblTitleYLength;
        private Jhjo.Component.CLabel LblTitleXLength;
        private Jhjo.Component.CLabel LblTitleSubStance;
        private Jhjo.Component.CLabel LblCPUCoreTemp_1;
        private Jhjo.Component.CLabel cLabel2;
        private Jhjo.Component.CLabel cLabel3;
        private Jhjo.Component.CLabel LblCPU4C_max;
        private Jhjo.Component.CLabel LblCPU3C_max;
        private Jhjo.Component.CLabel LblCPU4C_min;
        private Jhjo.Component.CLabel LblCPU3C_min;
        private Jhjo.Component.CLabel LblCPU4C;
        private Jhjo.Component.CLabel LblCPU3C;
        private Jhjo.Component.CLabel cLabel10;
        private Jhjo.Component.CLabel cLabel11;
    }
}

