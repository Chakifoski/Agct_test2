namespace Agct_test2
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ucThermometer1 = new HZH_Controls.Controls.UCThermometer();
            this.ucThermometer2 = new HZH_Controls.Controls.UCThermometer();
            this.ucMeter1 = new HZH_Controls.Controls.UCMeter();
            this.ucThermometer3 = new HZH_Controls.Controls.UCThermometer();
            this.ucMeter2 = new HZH_Controls.Controls.UCMeter();
            this.ucMeter3 = new HZH_Controls.Controls.UCMeter();
            this.ucWave1 = new HZH_Controls.Controls.UCWave();
            this.ucProcessWave1 = new HZH_Controls.Controls.UCProcessWave();
            this.ucRollText1 = new HZH_Controls.Controls.UCRollText();
            this.ucledDataTime1 = new HZH_Controls.Controls.UCLEDDataTime();
            this.ucProcessEllipse1 = new HZH_Controls.Controls.UCProcessEllipse();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("千图厚黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(803, 505);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 94);
            this.button1.TabIndex = 0;
            this.button1.Text = "历史数据";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonViewData_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("千图厚黑体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(803, 284);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 100);
            this.button2.TabIndex = 1;
            this.button2.Text = "数据刷新";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // ucThermometer1
            // 
            this.ucThermometer1.GlassTubeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.ucThermometer1.LeftTemperatureUnit = HZH_Controls.Controls.TemperatureUnit.C;
            this.ucThermometer1.Location = new System.Drawing.Point(51, 244);
            this.ucThermometer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucThermometer1.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ucThermometer1.MercuryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucThermometer1.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucThermometer1.Name = "ucThermometer1";
            this.ucThermometer1.RightTemperatureUnit = HZH_Controls.Controls.TemperatureUnit.C;
            this.ucThermometer1.Size = new System.Drawing.Size(77, 406);
            this.ucThermometer1.SplitCount = 1;
            this.ucThermometer1.TabIndex = 2;
            this.ucThermometer1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // ucThermometer2
            // 
            this.ucThermometer2.GlassTubeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.ucThermometer2.LeftTemperatureUnit = HZH_Controls.Controls.TemperatureUnit.C;
            this.ucThermometer2.Location = new System.Drawing.Point(203, 244);
            this.ucThermometer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucThermometer2.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ucThermometer2.MercuryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucThermometer2.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucThermometer2.Name = "ucThermometer2";
            this.ucThermometer2.RightTemperatureUnit = HZH_Controls.Controls.TemperatureUnit.C;
            this.ucThermometer2.Size = new System.Drawing.Size(77, 406);
            this.ucThermometer2.SplitCount = 1;
            this.ucThermometer2.TabIndex = 3;
            this.ucThermometer2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ucMeter1
            // 
            this.ucMeter1.BoundaryLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucMeter1.ExternalRoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucMeter1.FixedText = null;
            this.ucMeter1.InsideRoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucMeter1.Location = new System.Drawing.Point(12, 32);
            this.ucMeter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucMeter1.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ucMeter1.MeterDegrees = 150;
            this.ucMeter1.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucMeter1.Name = "ucMeter1";
            this.ucMeter1.PointerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucMeter1.ScaleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucMeter1.ScaleValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucMeter1.Size = new System.Drawing.Size(268, 168);
            this.ucMeter1.SplitCount = 10;
            this.ucMeter1.TabIndex = 4;
            this.ucMeter1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucMeter1.TextFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucMeter1.TextLocation = HZH_Controls.Controls.MeterTextLocation.None;
            this.ucMeter1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // ucThermometer3
            // 
            this.ucThermometer3.GlassTubeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.ucThermometer3.LeftTemperatureUnit = HZH_Controls.Controls.TemperatureUnit.C;
            this.ucThermometer3.Location = new System.Drawing.Point(367, 244);
            this.ucThermometer3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucThermometer3.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ucThermometer3.MercuryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucThermometer3.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucThermometer3.Name = "ucThermometer3";
            this.ucThermometer3.RightTemperatureUnit = HZH_Controls.Controls.TemperatureUnit.C;
            this.ucThermometer3.Size = new System.Drawing.Size(77, 406);
            this.ucThermometer3.SplitCount = 1;
            this.ucThermometer3.TabIndex = 5;
            this.ucThermometer3.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ucMeter2
            // 
            this.ucMeter2.BoundaryLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucMeter2.ExternalRoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucMeter2.FixedText = null;
            this.ucMeter2.InsideRoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucMeter2.Location = new System.Drawing.Point(367, 32);
            this.ucMeter2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucMeter2.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ucMeter2.MeterDegrees = 150;
            this.ucMeter2.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucMeter2.Name = "ucMeter2";
            this.ucMeter2.PointerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucMeter2.ScaleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucMeter2.ScaleValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucMeter2.Size = new System.Drawing.Size(268, 168);
            this.ucMeter2.SplitCount = 10;
            this.ucMeter2.TabIndex = 6;
            this.ucMeter2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucMeter2.TextFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucMeter2.TextLocation = HZH_Controls.Controls.MeterTextLocation.None;
            this.ucMeter2.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // ucMeter3
            // 
            this.ucMeter3.BoundaryLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucMeter3.ExternalRoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucMeter3.FixedText = null;
            this.ucMeter3.InsideRoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucMeter3.Location = new System.Drawing.Point(712, 32);
            this.ucMeter3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucMeter3.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ucMeter3.MeterDegrees = 150;
            this.ucMeter3.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucMeter3.Name = "ucMeter3";
            this.ucMeter3.PointerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucMeter3.ScaleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucMeter3.ScaleValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucMeter3.Size = new System.Drawing.Size(268, 168);
            this.ucMeter3.SplitCount = 10;
            this.ucMeter3.TabIndex = 7;
            this.ucMeter3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucMeter3.TextFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucMeter3.TextLocation = HZH_Controls.Controls.MeterTextLocation.None;
            this.ucMeter3.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // ucWave1
            // 
            this.ucWave1.Location = new System.Drawing.Point(-5, 732);
            this.ucWave1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucWave1.Name = "ucWave1";
            this.ucWave1.Size = new System.Drawing.Size(1093, 51);
            this.ucWave1.TabIndex = 8;
            this.ucWave1.Text = "ucWave1";
            this.ucWave1.WaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucWave1.WaveHeight = 30;
            this.ucWave1.WaveSleep = 50;
            this.ucWave1.WaveWidth = 200;
            // 
            // ucProcessWave1
            // 
            this.ucProcessWave1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucProcessWave1.ConerRadius = 0;
            this.ucProcessWave1.FillColor = System.Drawing.Color.Empty;
            this.ucProcessWave1.Font = new System.Drawing.Font("字体传奇雪家黑-粉丝免费", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucProcessWave1.ForeColor = System.Drawing.Color.White;
            this.ucProcessWave1.IsRadius = false;
            this.ucProcessWave1.IsRectangle = false;
            this.ucProcessWave1.IsShowRect = false;
            this.ucProcessWave1.Location = new System.Drawing.Point(603, 265);
            this.ucProcessWave1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucProcessWave1.MaxValue = 100;
            this.ucProcessWave1.Name = "ucProcessWave1";
            this.ucProcessWave1.RectColor = System.Drawing.Color.White;
            this.ucProcessWave1.RectWidth = 4;
            this.ucProcessWave1.Size = new System.Drawing.Size(140, 140);
            this.ucProcessWave1.TabIndex = 9;
            this.ucProcessWave1.Value = 0;
            this.ucProcessWave1.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            // 
            // ucRollText1
            // 
            this.ucRollText1.Font = new System.Drawing.Font("字体传奇雪家黑-粉丝免费", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucRollText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucRollText1.Location = new System.Drawing.Point(-5, 0);
            this.ucRollText1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucRollText1.MoveSleepTime = 100;
            this.ucRollText1.Name = "ucRollText1";
            this.ucRollText1.RollStyle = HZH_Controls.Controls.RollStyle.LeftToRight;
            this.ucRollText1.Size = new System.Drawing.Size(1093, 38);
            this.ucRollText1.TabIndex = 10;
            this.ucRollText1.Text = "物联网智能农业 ";
            // 
            // ucledDataTime1
            // 
            this.ucledDataTime1.LineWidth = 2;
            this.ucledDataTime1.Location = new System.Drawing.Point(480, 684);
            this.ucledDataTime1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucledDataTime1.Name = "ucledDataTime1";
            this.ucledDataTime1.Size = new System.Drawing.Size(587, 42);
            this.ucledDataTime1.TabIndex = 11;
            this.ucledDataTime1.Value = new System.DateTime(2023, 2, 17, 20, 23, 3, 0);
            // 
            // ucProcessEllipse1
            // 
            this.ucProcessEllipse1.BackEllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucProcessEllipse1.CoreEllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucProcessEllipse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ucProcessEllipse1.ForeColor = System.Drawing.Color.Black;
            this.ucProcessEllipse1.IsShowCoreEllipseBorder = true;
            this.ucProcessEllipse1.Location = new System.Drawing.Point(592, 474);
            this.ucProcessEllipse1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucProcessEllipse1.MaxValue = 100;
            this.ucProcessEllipse1.Name = "ucProcessEllipse1";
            this.ucProcessEllipse1.ShowType = HZH_Controls.Controls.ShowType.Ring;
            this.ucProcessEllipse1.Size = new System.Drawing.Size(169, 159);
            this.ucProcessEllipse1.TabIndex = 12;
            this.ucProcessEllipse1.Value = 0;
            this.ucProcessEllipse1.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucProcessEllipse1.ValueMargin = 5;
            this.ucProcessEllipse1.ValueType = HZH_Controls.Controls.ValueType.Percent;
            this.ucProcessEllipse1.ValueWidth = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("荆南麦圆体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(45, 672);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "温度计1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("荆南麦圆体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(197, 672);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "温度计2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("荆南麦圆体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(361, 672);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "温度计3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("荆南麦圆体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(100, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "湿度计1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("荆南麦圆体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(457, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "湿度计2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("荆南麦圆体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(804, 194);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "湿度计3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("荆南麦圆体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(456, 326);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "CO²浓度";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("荆南麦圆体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(457, 544);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "光照强度";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1083, 781);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucProcessEllipse1);
            this.Controls.Add(this.ucledDataTime1);
            this.Controls.Add(this.ucRollText1);
            this.Controls.Add(this.ucProcessWave1);
            this.Controls.Add(this.ucWave1);
            this.Controls.Add(this.ucMeter3);
            this.Controls.Add(this.ucMeter2);
            this.Controls.Add(this.ucThermometer3);
            this.Controls.Add(this.ucMeter1);
            this.Controls.Add(this.ucThermometer2);
            this.Controls.Add(this.ucThermometer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.Text = "物联网智能农业";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private HZH_Controls.Controls.UCThermometer ucThermometer1;
        private HZH_Controls.Controls.UCThermometer ucThermometer2;
        private HZH_Controls.Controls.UCMeter ucMeter1;
        private HZH_Controls.Controls.UCThermometer ucThermometer3;
        private HZH_Controls.Controls.UCMeter ucMeter2;
        private HZH_Controls.Controls.UCMeter ucMeter3;
        private HZH_Controls.Controls.UCWave ucWave1;
        private HZH_Controls.Controls.UCProcessWave ucProcessWave1;
        private HZH_Controls.Controls.UCRollText ucRollText1;
        private HZH_Controls.Controls.UCLEDDataTime ucledDataTime1;
        private HZH_Controls.Controls.UCProcessEllipse ucProcessEllipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

