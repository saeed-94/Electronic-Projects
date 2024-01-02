namespace p4
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
            DevComponents.Instrumentation.GradientFillColor gradientFillColor7 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor8 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GaugeText gaugeText7 = new DevComponents.Instrumentation.GaugeText();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevComponents.Instrumentation.GaugeText gaugeText8 = new DevComponents.Instrumentation.GaugeText();
            DevComponents.Instrumentation.GaugeLinearScale gaugeLinearScale7 = new DevComponents.Instrumentation.GaugeLinearScale();
            DevComponents.Instrumentation.GaugePointer gaugePointer4 = new DevComponents.Instrumentation.GaugePointer();
            DevComponents.Instrumentation.GaugeSection gaugeSection4 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeLinearScale gaugeLinearScale8 = new DevComponents.Instrumentation.GaugeLinearScale();
            this.gaugeControl1 = new DevComponents.Instrumentation.GaugeControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gaugeControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gaugeControl1
            // 
            gradientFillColor7.Color1 = System.Drawing.Color.Gainsboro;
            gradientFillColor7.Color2 = System.Drawing.Color.DarkGray;
            this.gaugeControl1.Frame.BackColor = gradientFillColor7;
            gradientFillColor8.BorderColor = System.Drawing.Color.Gainsboro;
            gradientFillColor8.BorderWidth = 1;
            gradientFillColor8.Color1 = System.Drawing.Color.White;
            gradientFillColor8.Color2 = System.Drawing.Color.DimGray;
            this.gaugeControl1.Frame.FrameColor = gradientFillColor8;
            this.gaugeControl1.Frame.InnerBevel = 0.031F;
            this.gaugeControl1.Frame.OuterBevel = 0.021F;
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
            gaugeLinearScale7.Labels.FormatString = "0°";
            gaugeLinearScale7.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeLinearScale7.Location")));
            gaugeLinearScale7.MajorTickMarks.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Near;
            gaugeLinearScale7.MajorTickMarks.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Rectangle;
            gaugeLinearScale7.MajorTickMarks.Layout.Width = 0.008F;
            gaugeLinearScale7.MaxPin.Name = "MaxPin";
            gaugeLinearScale7.MaxPin.Visible = false;
            gaugeLinearScale7.MaxValue = 150D;
            gaugeLinearScale7.MinorTickMarks.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Near;
            gaugeLinearScale7.MinorTickMarks.Layout.Width = 0.016F;
            gaugeLinearScale7.MinPin.Name = "MinPin";
            gaugeLinearScale7.MinPin.Visible = false;
            gaugeLinearScale7.Name = "Scale1";
            gaugeLinearScale7.Orientation = System.Windows.Forms.Orientation.Vertical;
            gaugePointer4.BulbOffset = 0.026F;
            gaugePointer4.BulbSize = 0.132F;
            gaugePointer4.CapFillColor.BorderColor = System.Drawing.Color.DimGray;
            gaugePointer4.CapFillColor.BorderWidth = 1;
            gaugePointer4.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke;
            gaugePointer4.CapFillColor.Color2 = System.Drawing.Color.DimGray;
            gaugePointer4.FillColor.BorderColor = System.Drawing.Color.Black;
            gaugePointer4.FillColor.BorderWidth = 1;
            gaugePointer4.FillColor.Color1 = System.Drawing.Color.Red;
            gaugePointer4.Name = "Pointer1";
            gaugePointer4.Style = DevComponents.Instrumentation.PointerStyle.Thermometer;
            gaugePointer4.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            gaugePointer4.Value = 12D;
            gaugePointer4.Width = 0.1F;
            gaugeLinearScale7.Pointers.AddRange(new DevComponents.Instrumentation.GaugePointer[] {
            gaugePointer4});
            gaugeSection4.FillColor.Color1 = System.Drawing.Color.SteelBlue;
            gaugeSection4.FillColor.Color2 = System.Drawing.Color.LightCyan;
            gaugeSection4.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.VerticalCenter;
            gaugeSection4.Name = "Section1";
            gaugeLinearScale7.Sections.AddRange(new DevComponents.Instrumentation.GaugeSection[] {
            gaugeSection4});
            gaugeLinearScale7.Size = new System.Drawing.SizeF(0.75F, 0.75F);
            gaugeLinearScale7.Width = 0.1F;
            gaugeLinearScale8.Labels.FormatString = "0°";
            gaugeLinearScale8.Labels.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far;
            gaugeLinearScale8.Labels.ShowMaxLabel = false;
            gaugeLinearScale8.Labels.ShowMinLabel = false;
            gaugeLinearScale8.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeLinearScale8.Location")));
            gaugeLinearScale8.MajorTickMarks.Interval = 20D;
            gaugeLinearScale8.MajorTickMarks.IntervalOffset = 2D;
            gaugeLinearScale8.MajorTickMarks.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far;
            gaugeLinearScale8.MajorTickMarks.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Rectangle;
            gaugeLinearScale8.MajorTickMarks.Layout.Width = 0.008F;
            gaugeLinearScale8.MaxPin.Name = "MaxPin";
            gaugeLinearScale8.MaxPin.Visible = false;
            gaugeLinearScale8.MaxValue = 104D;
            gaugeLinearScale8.MinorTickMarks.Interval = 4D;
            gaugeLinearScale8.MinorTickMarks.IntervalOffset = 2D;
            gaugeLinearScale8.MinorTickMarks.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far;
            gaugeLinearScale8.MinorTickMarks.Layout.Width = 0.016F;
            gaugeLinearScale8.MinPin.Name = "MinPin";
            gaugeLinearScale8.MinPin.Visible = false;
            gaugeLinearScale8.MinValue = -22D;
            gaugeLinearScale8.Name = "Scale2";
            gaugeLinearScale8.Orientation = System.Windows.Forms.Orientation.Vertical;
            gaugeLinearScale8.Size = new System.Drawing.SizeF(0.75F, 0.75F);
            gaugeLinearScale8.Width = 0.1F;
            this.gaugeControl1.LinearScales.AddRange(new DevComponents.Instrumentation.GaugeLinearScale[] {
            gaugeLinearScale7,
            gaugeLinearScale8});
            this.gaugeControl1.Location = new System.Drawing.Point(12, 12);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(164, 456);
            this.gaugeControl1.TabIndex = 0;
            this.gaugeControl1.Text = "gaugeControl1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::p4.Properties.Resources.lm35;
            this.pictureBox1.Location = new System.Drawing.Point(182, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 371);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Titr", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(184, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "دما:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.Location = new System.Drawing.Point(237, 423);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 50);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(485, 485);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gaugeControl1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "LM35 Real Time";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gaugeControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.Instrumentation.GaugeControl gaugeControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

