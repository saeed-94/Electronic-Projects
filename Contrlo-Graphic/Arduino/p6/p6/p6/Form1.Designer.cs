namespace p6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor22 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor23 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GaugeText gaugeText7 = new DevComponents.Instrumentation.GaugeText();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevComponents.Instrumentation.GaugeText gaugeText8 = new DevComponents.Instrumentation.GaugeText();
            DevComponents.Instrumentation.GaugeLinearScale gaugeLinearScale4 = new DevComponents.Instrumentation.GaugeLinearScale();
            DevComponents.Instrumentation.GaugePointer gaugePointer10 = new DevComponents.Instrumentation.GaugePointer();
            DevComponents.Instrumentation.GaugeSection gaugeSection7 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeCircularScale gaugeCircularScale7 = new DevComponents.Instrumentation.GaugeCircularScale();
            DevComponents.Instrumentation.GaugePointer gaugePointer11 = new DevComponents.Instrumentation.GaugePointer();
            DevComponents.Instrumentation.GaugeRange gaugeRange7 = new DevComponents.Instrumentation.GaugeRange();
            DevComponents.Instrumentation.GaugeSection gaugeSection8 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor24 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor25 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GaugeCircularScale gaugeCircularScale8 = new DevComponents.Instrumentation.GaugeCircularScale();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor26 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GaugePointer gaugePointer12 = new DevComponents.Instrumentation.GaugePointer();
            DevComponents.Instrumentation.GaugeRange gaugeRange8 = new DevComponents.Instrumentation.GaugeRange();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor27 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor28 = new DevComponents.Instrumentation.GradientFillColor();
            this.gaugeControl1 = new DevComponents.Instrumentation.GaugeControl();
            this.gaugeControl2 = new DevComponents.Instrumentation.GaugeControl();
            this.gaugeControl3 = new DevComponents.Instrumentation.GaugeControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gaugeControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaugeControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaugeControl3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gaugeControl1
            // 
            gradientFillColor22.Color1 = System.Drawing.Color.Gainsboro;
            gradientFillColor22.Color2 = System.Drawing.Color.DarkGray;
            this.gaugeControl1.Frame.BackColor = gradientFillColor22;
            gradientFillColor23.BorderColor = System.Drawing.Color.Gainsboro;
            gradientFillColor23.BorderWidth = 1;
            gradientFillColor23.Color1 = System.Drawing.Color.White;
            gradientFillColor23.Color2 = System.Drawing.Color.DimGray;
            this.gaugeControl1.Frame.FrameColor = gradientFillColor23;
            this.gaugeControl1.Frame.InnerBevel = 0.026F;
            this.gaugeControl1.Frame.OuterBevel = 0.031F;
            this.gaugeControl1.Frame.RoundRectangleArc = 0.5F;
            this.gaugeControl1.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.RoundedRectangular;
            gaugeText7.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText7.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeText7.Location")));
            gaugeText7.Name = "Text1";
            gaugeText7.Text = "C°";
            gaugeText8.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText8.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeText8.Location")));
            gaugeText8.Name = "Text2";
            gaugeText8.Text = "F°";
            this.gaugeControl1.GaugeItems.AddRange(new DevComponents.Instrumentation.GaugeItem[] {
            gaugeText7,
            gaugeText8});
            gaugeLinearScale4.Labels.FormatString = "0°";
            gaugeLinearScale4.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeLinearScale4.Location")));
            gaugeLinearScale4.MajorTickMarks.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Near;
            gaugeLinearScale4.MajorTickMarks.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Rectangle;
            gaugeLinearScale4.MajorTickMarks.Layout.Width = 0.008F;
            gaugeLinearScale4.MaxPin.Name = "MaxPin";
            gaugeLinearScale4.MaxPin.Visible = false;
            gaugeLinearScale4.MaxValue = 50D;
            gaugeLinearScale4.MinorTickMarks.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Near;
            gaugeLinearScale4.MinorTickMarks.Layout.Width = 0.016F;
            gaugeLinearScale4.MinPin.Name = "MinPin";
            gaugeLinearScale4.MinPin.Visible = false;
            gaugeLinearScale4.Name = "Scale1";
            gaugeLinearScale4.Orientation = System.Windows.Forms.Orientation.Vertical;
            gaugePointer10.BulbOffset = 0.026F;
            gaugePointer10.BulbSize = 0.132F;
            gaugePointer10.CapFillColor.BorderColor = System.Drawing.Color.DimGray;
            gaugePointer10.CapFillColor.BorderWidth = 1;
            gaugePointer10.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke;
            gaugePointer10.CapFillColor.Color2 = System.Drawing.Color.DimGray;
            gaugePointer10.FillColor.BorderColor = System.Drawing.Color.Black;
            gaugePointer10.FillColor.BorderWidth = 1;
            gaugePointer10.FillColor.Color1 = System.Drawing.Color.Red;
            gaugePointer10.Name = "Pointer1";
            gaugePointer10.Style = DevComponents.Instrumentation.PointerStyle.Thermometer;
            gaugePointer10.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            gaugePointer10.Value = 12D;
            gaugePointer10.Width = 0.1F;
            gaugeLinearScale4.Pointers.AddRange(new DevComponents.Instrumentation.GaugePointer[] {
            gaugePointer10});
            gaugeSection7.FillColor.Color1 = System.Drawing.Color.SteelBlue;
            gaugeSection7.FillColor.Color2 = System.Drawing.Color.LightCyan;
            gaugeSection7.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.VerticalCenter;
            gaugeSection7.Name = "Section1";
            gaugeLinearScale4.Sections.AddRange(new DevComponents.Instrumentation.GaugeSection[] {
            gaugeSection7});
            gaugeLinearScale4.Size = new System.Drawing.SizeF(0.75F, 0.75F);
            gaugeLinearScale4.Width = 0.1F;
            this.gaugeControl1.LinearScales.AddRange(new DevComponents.Instrumentation.GaugeLinearScale[] {
            gaugeLinearScale4});
            this.gaugeControl1.Location = new System.Drawing.Point(6, 38);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(148, 383);
            this.gaugeControl1.TabIndex = 0;
            this.gaugeControl1.Text = "gaugeControl1";
            // 
            // gaugeControl2
            // 
            gaugeCircularScale7.MaxPin.Name = "MaxPin";
            gaugeCircularScale7.MaxValue = 90D;
            gaugeCircularScale7.MinPin.Name = "MinPin";
            gaugeCircularScale7.MinValue = 20D;
            gaugeCircularScale7.Name = "Scale1";
            gaugePointer11.CapFillColor.BorderColor = System.Drawing.Color.DimGray;
            gaugePointer11.CapFillColor.BorderWidth = 1;
            gaugePointer11.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke;
            gaugePointer11.CapFillColor.Color2 = System.Drawing.Color.DimGray;
            gaugePointer11.FillColor.BorderColor = System.Drawing.Color.DimGray;
            gaugePointer11.FillColor.BorderWidth = 1;
            gaugePointer11.FillColor.Color1 = System.Drawing.Color.WhiteSmoke;
            gaugePointer11.FillColor.Color2 = System.Drawing.Color.Red;
            gaugePointer11.Length = 0.358F;
            gaugePointer11.Name = "Pointer1";
            gaugePointer11.Style = DevComponents.Instrumentation.PointerStyle.Needle;
            gaugeCircularScale7.Pointers.AddRange(new DevComponents.Instrumentation.GaugePointer[] {
            gaugePointer11});
            gaugeRange7.FillColor.BorderColor = System.Drawing.Color.DimGray;
            gaugeRange7.FillColor.BorderWidth = 1;
            gaugeRange7.FillColor.Color1 = System.Drawing.Color.Lime;
            gaugeRange7.FillColor.Color2 = System.Drawing.Color.Red;
            gaugeRange7.Name = "Range1";
            gaugeRange7.ScaleOffset = 0.28F;
            gaugeRange7.StartValue = 70D;
            gaugeCircularScale7.Ranges.AddRange(new DevComponents.Instrumentation.GaugeRange[] {
            gaugeRange7});
            gaugeSection8.FillColor.Color1 = System.Drawing.Color.CornflowerBlue;
            gaugeSection8.FillColor.Color2 = System.Drawing.Color.Purple;
            gaugeSection8.Name = "Section1";
            gaugeCircularScale7.Sections.AddRange(new DevComponents.Instrumentation.GaugeSection[] {
            gaugeSection8});
            this.gaugeControl2.CircularScales.AddRange(new DevComponents.Instrumentation.GaugeCircularScale[] {
            gaugeCircularScale7});
            gradientFillColor24.Color1 = System.Drawing.Color.Gainsboro;
            gradientFillColor24.Color2 = System.Drawing.Color.DarkGray;
            this.gaugeControl2.Frame.BackColor = gradientFillColor24;
            gradientFillColor25.BorderColor = System.Drawing.Color.Gainsboro;
            gradientFillColor25.BorderWidth = 1;
            gradientFillColor25.Color1 = System.Drawing.Color.White;
            gradientFillColor25.Color2 = System.Drawing.Color.DimGray;
            this.gaugeControl2.Frame.FrameColor = gradientFillColor25;
            this.gaugeControl2.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Circular;
            this.gaugeControl2.Location = new System.Drawing.Point(160, 185);
            this.gaugeControl2.Name = "gaugeControl2";
            this.gaugeControl2.Size = new System.Drawing.Size(357, 239);
            this.gaugeControl2.TabIndex = 1;
            this.gaugeControl2.Text = "gaugeControl2";
            this.gaugeControl2.Click += new System.EventHandler(this.gaugeControl2_Click);
            // 
            // gaugeControl3
            // 
            gaugeCircularScale8.Labels.Layout.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F);
            gaugeCircularScale8.Labels.Layout.ScaleOffset = 0.075F;
            gaugeCircularScale8.MajorTickMarks.Interval = 50D;
            gaugeCircularScale8.MajorTickMarks.Layout.Length = 0.063F;
            gaugeCircularScale8.MajorTickMarks.Layout.Width = 0.033F;
            gaugeCircularScale8.MaxPin.EndOffset = 0.01F;
            gaugeCircularScale8.MaxPin.Length = 0.026F;
            gaugeCircularScale8.MaxPin.Name = "MaxPin";
            gaugeCircularScale8.MaxPin.ScaleOffset = -0.06F;
            gaugeCircularScale8.MaxPin.Width = 0.026F;
            gaugeCircularScale8.MaxValue = 180D;
            gaugeCircularScale8.MinorTickMarks.Interval = 10D;
            gradientFillColor26.BorderColor = System.Drawing.Color.DimGray;
            gradientFillColor26.BorderWidth = 1;
            gradientFillColor26.Color1 = System.Drawing.Color.LightYellow;
            gaugeCircularScale8.MinorTickMarks.Layout.FillColor = gradientFillColor26;
            gaugeCircularScale8.MinorTickMarks.Layout.Length = 0.042F;
            gaugeCircularScale8.MinorTickMarks.Layout.Width = 0.013F;
            gaugeCircularScale8.MinPin.EndOffset = 0.01F;
            gaugeCircularScale8.MinPin.Length = 0.026F;
            gaugeCircularScale8.MinPin.Name = "MinPin";
            gaugeCircularScale8.MinPin.ScaleOffset = -0.06F;
            gaugeCircularScale8.MinPin.Width = 0.026F;
            gaugeCircularScale8.MinValue = -5D;
            gaugeCircularScale8.Name = "Scale1";
            gaugeCircularScale8.PivotPoint = ((System.Drawing.PointF)(resources.GetObject("gaugeCircularScale8.PivotPoint")));
            gaugePointer12.CapFillColor.BorderColor = System.Drawing.Color.DimGray;
            gaugePointer12.CapFillColor.BorderWidth = 1;
            gaugePointer12.CapFillColor.Color1 = System.Drawing.Color.Gainsboro;
            gaugePointer12.CapFillColor.Color2 = System.Drawing.Color.Silver;
            gaugePointer12.FillColor.BorderColor = System.Drawing.Color.DimGray;
            gaugePointer12.FillColor.BorderWidth = 1;
            gaugePointer12.FillColor.Color1 = System.Drawing.Color.Black;
            gaugePointer12.Name = "Pointer1";
            gaugePointer12.ScaleOffset = -0.057F;
            gaugePointer12.Style = DevComponents.Instrumentation.PointerStyle.Needle;
            gaugePointer12.Width = 0.032F;
            gaugeCircularScale8.Pointers.AddRange(new DevComponents.Instrumentation.GaugePointer[] {
            gaugePointer12});
            gaugeCircularScale8.Radius = 2.5F;
            gaugeRange8.EndValue = 100D;
            gaugeRange8.EndWidth = 0.07F;
            gaugeRange8.FillColor.BorderColor = System.Drawing.Color.Gray;
            gaugeRange8.FillColor.BorderWidth = 1;
            gaugeRange8.FillColor.Color1 = System.Drawing.Color.Yellow;
            gaugeRange8.FillColor.Color2 = System.Drawing.Color.Lime;
            gaugeRange8.Name = "Range1";
            gaugeRange8.ScaleOffset = 0.033F;
            gaugeRange8.StartValue = 0D;
            gaugeRange8.StartWidth = 0.07F;
            gaugeCircularScale8.Ranges.AddRange(new DevComponents.Instrumentation.GaugeRange[] {
            gaugeRange8});
            gaugeCircularScale8.StartAngle = 240F;
            gaugeCircularScale8.SweepAngle = 60F;
            gaugeCircularScale8.Width = 0.011F;
            this.gaugeControl3.CircularScales.AddRange(new DevComponents.Instrumentation.GaugeCircularScale[] {
            gaugeCircularScale8});
            gradientFillColor27.Color1 = System.Drawing.Color.Gainsboro;
            gradientFillColor27.Color2 = System.Drawing.Color.DarkGray;
            this.gaugeControl3.Frame.BackColor = gradientFillColor27;
            gradientFillColor28.BorderColor = System.Drawing.Color.Gainsboro;
            gradientFillColor28.BorderWidth = 1;
            gradientFillColor28.Color1 = System.Drawing.Color.White;
            gradientFillColor28.Color2 = System.Drawing.Color.DimGray;
            this.gaugeControl3.Frame.FrameColor = gradientFillColor28;
            this.gaugeControl3.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Rectangular;
            this.gaugeControl3.Location = new System.Drawing.Point(160, 43);
            this.gaugeControl3.Name = "gaugeControl3";
            this.gaugeControl3.Size = new System.Drawing.Size(358, 95);
            this.gaugeControl3.TabIndex = 2;
            this.gaugeControl3.Text = "gaugeControl3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.gaugeControl3);
            this.groupBox1.Controls.Add(this.gaugeControl1);
            this.groupBox1.Controls.Add(this.gaugeControl2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 509);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System Monitornig";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(336, 426);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 39);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(303, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 39);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 427);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 39);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "HeatIndex:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Humidity:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Temp:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::p6.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(541, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(547, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 224);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Command";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(33, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect Temp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(33, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "Connect Hmidity";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(33, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "Connect HeatIndex";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Magenta;
            this.ClientSize = new System.Drawing.Size(820, 566);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DHT";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gaugeControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaugeControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaugeControl3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.Instrumentation.GaugeControl gaugeControl1;
        private DevComponents.Instrumentation.GaugeControl gaugeControl2;
        private DevComponents.Instrumentation.GaugeControl gaugeControl3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

