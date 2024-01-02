namespace p3
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
            DevComponents.Instrumentation.GradientFillColor gradientFillColor1 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor2 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GaugeText gaugeText1 = new DevComponents.Instrumentation.GaugeText();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevComponents.Instrumentation.GaugeText gaugeText2 = new DevComponents.Instrumentation.GaugeText();
            DevComponents.Instrumentation.GaugeLinearScale gaugeLinearScale1 = new DevComponents.Instrumentation.GaugeLinearScale();
            DevComponents.Instrumentation.GaugePointer gaugePointer1 = new DevComponents.Instrumentation.GaugePointer();
            DevComponents.Instrumentation.GaugeSection gaugeSection1 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeLinearScale gaugeLinearScale2 = new DevComponents.Instrumentation.GaugeLinearScale();
            this.gaugeControl1 = new DevComponents.Instrumentation.GaugeControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gaugeControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gradientFillColor1.Color1 = System.Drawing.Color.Gainsboro;
            gradientFillColor1.Color2 = System.Drawing.Color.DarkGray;
            this.gaugeControl1.Frame.BackColor = gradientFillColor1;
            gradientFillColor2.BorderColor = System.Drawing.Color.Gainsboro;
            gradientFillColor2.BorderWidth = 1;
            gradientFillColor2.Color1 = System.Drawing.Color.White;
            gradientFillColor2.Color2 = System.Drawing.Color.DimGray;
            this.gaugeControl1.Frame.FrameColor = gradientFillColor2;
            this.gaugeControl1.Frame.InnerBevel = 0.043F;
            this.gaugeControl1.Frame.OuterBevel = 0.036F;
            this.gaugeControl1.Frame.RoundRectangleArc = 0.5F;
            this.gaugeControl1.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.RoundedRectangular;
            gaugeText1.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText1.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeText1.Location")));
            gaugeText1.Name = "Text1";
            gaugeText1.Text = "C°";
            gaugeText2.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText2.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeText2.Location")));
            gaugeText2.Name = "Text2";
            gaugeText2.Text = "F°";
            this.gaugeControl1.GaugeItems.AddRange(new DevComponents.Instrumentation.GaugeItem[] {
            gaugeText1,
            gaugeText2});
            gaugeLinearScale1.Labels.FormatString = "0°";
            gaugeLinearScale1.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeLinearScale1.Location")));
            gaugeLinearScale1.MajorTickMarks.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Near;
            gaugeLinearScale1.MajorTickMarks.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Rectangle;
            gaugeLinearScale1.MajorTickMarks.Layout.Width = 0.008F;
            gaugeLinearScale1.MaxPin.Name = "MaxPin";
            gaugeLinearScale1.MaxPin.Visible = false;
            gaugeLinearScale1.MaxValue = 150D;
            gaugeLinearScale1.MinorTickMarks.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Near;
            gaugeLinearScale1.MinorTickMarks.Layout.Width = 0.016F;
            gaugeLinearScale1.MinPin.Name = "MinPin";
            gaugeLinearScale1.MinPin.Visible = false;
            gaugeLinearScale1.Name = "Scale1";
            gaugeLinearScale1.Orientation = System.Windows.Forms.Orientation.Vertical;
            gaugePointer1.BulbOffset = 0.026F;
            gaugePointer1.BulbSize = 0.132F;
            gaugePointer1.CapFillColor.BorderColor = System.Drawing.Color.DimGray;
            gaugePointer1.CapFillColor.BorderWidth = 1;
            gaugePointer1.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke;
            gaugePointer1.CapFillColor.Color2 = System.Drawing.Color.DimGray;
            gaugePointer1.FillColor.BorderColor = System.Drawing.Color.Black;
            gaugePointer1.FillColor.BorderWidth = 1;
            gaugePointer1.FillColor.Color1 = System.Drawing.Color.Red;
            gaugePointer1.Name = "Pointer1";
            gaugePointer1.Style = DevComponents.Instrumentation.PointerStyle.Thermometer;
            gaugePointer1.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            gaugePointer1.Value = 12D;
            gaugePointer1.Width = 0.1F;
            gaugeLinearScale1.Pointers.AddRange(new DevComponents.Instrumentation.GaugePointer[] {
            gaugePointer1});
            gaugeSection1.FillColor.Color1 = System.Drawing.Color.SteelBlue;
            gaugeSection1.FillColor.Color2 = System.Drawing.Color.LightCyan;
            gaugeSection1.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.VerticalCenter;
            gaugeSection1.Name = "Section1";
            gaugeLinearScale1.Sections.AddRange(new DevComponents.Instrumentation.GaugeSection[] {
            gaugeSection1});
            gaugeLinearScale1.Size = new System.Drawing.SizeF(0.75F, 0.75F);
            gaugeLinearScale1.Width = 0.1F;
            gaugeLinearScale2.Labels.FormatString = "0°";
            gaugeLinearScale2.Labels.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far;
            gaugeLinearScale2.Labels.ShowMaxLabel = false;
            gaugeLinearScale2.Labels.ShowMinLabel = false;
            gaugeLinearScale2.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeLinearScale2.Location")));
            gaugeLinearScale2.MajorTickMarks.Interval = 20D;
            gaugeLinearScale2.MajorTickMarks.IntervalOffset = 2D;
            gaugeLinearScale2.MajorTickMarks.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far;
            gaugeLinearScale2.MajorTickMarks.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Rectangle;
            gaugeLinearScale2.MajorTickMarks.Layout.Width = 0.008F;
            gaugeLinearScale2.MaxPin.Name = "MaxPin";
            gaugeLinearScale2.MaxPin.Visible = false;
            gaugeLinearScale2.MaxValue = 104D;
            gaugeLinearScale2.MinorTickMarks.Interval = 4D;
            gaugeLinearScale2.MinorTickMarks.IntervalOffset = 2D;
            gaugeLinearScale2.MinorTickMarks.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far;
            gaugeLinearScale2.MinorTickMarks.Layout.Width = 0.016F;
            gaugeLinearScale2.MinPin.Name = "MinPin";
            gaugeLinearScale2.MinPin.Visible = false;
            gaugeLinearScale2.MinValue = -22D;
            gaugeLinearScale2.Name = "Scale2";
            gaugeLinearScale2.Orientation = System.Windows.Forms.Orientation.Vertical;
            gaugeLinearScale2.Size = new System.Drawing.SizeF(0.75F, 0.75F);
            gaugeLinearScale2.Width = 0.1F;
            this.gaugeControl1.LinearScales.AddRange(new DevComponents.Instrumentation.GaugeLinearScale[] {
            gaugeLinearScale1,
            gaugeLinearScale2});
            this.gaugeControl1.Location = new System.Drawing.Point(12, 12);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(112, 356);
            this.gaugeControl1.TabIndex = 0;
            this.gaugeControl1.Text = "gaugeControl1";
            this.gaugeControl1.Click += new System.EventHandler(this.gaugeControl1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(130, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 299);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tempereture(˚C):";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 368);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 30);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(422, 404);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gaugeControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LM35 ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gaugeControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.Instrumentation.GaugeControl gaugeControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
    }
}

