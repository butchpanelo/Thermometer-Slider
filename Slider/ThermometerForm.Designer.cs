namespace Slider
{
    partial class ThermometerForm
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
            trackBarThermometer = new TrackBar();
            spinCelsius = new NumericUpDown();
            spinFahrenheit = new NumericUpDown();
            labelCelsius = new Label();
            labelFahrenheit = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBarThermometer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spinCelsius).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spinFahrenheit).BeginInit();
            SuspendLayout();
            // 
            // trackBarThermometer
            // 
            trackBarThermometer.Location = new Point(367, 28);
            trackBarThermometer.Maximum = 200;
            trackBarThermometer.Minimum = -30;
            trackBarThermometer.Name = "trackBarThermometer";
            trackBarThermometer.Orientation = Orientation.Vertical;
            trackBarThermometer.Size = new Size(56, 368);
            trackBarThermometer.TabIndex = 0;
            trackBarThermometer.Scroll += TrackBarThermometer_Scroll;
            trackBarThermometer.ValueChanged += TrackBarThermometer_ValueChanged;
            // 
            // spinCelsius
            // 
            spinCelsius.Location = new Point(172, 285);
            spinCelsius.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            spinCelsius.Minimum = new decimal(new int[] { 30, 0, 0, int.MinValue });
            spinCelsius.Name = "spinCelsius";
            spinCelsius.Size = new Size(150, 27);
            spinCelsius.TabIndex = 3;
            spinCelsius.ValueChanged += SpinCelsius_ValueChanged;
            // 
            // spinFahrenheit
            // 
            spinFahrenheit.Location = new Point(463, 285);
            spinFahrenheit.Maximum = new decimal(new int[] { 392, 0, 0, 0 });
            spinFahrenheit.Minimum = new decimal(new int[] { 22, 0, 0, int.MinValue });
            spinFahrenheit.Name = "spinFahrenheit";
            spinFahrenheit.Size = new Size(150, 27);
            spinFahrenheit.TabIndex = 4;
            spinFahrenheit.ValueChanged += SpinFahrenehit_ValueChanged;
            // 
            // labelCelsius
            // 
            labelCelsius.AutoSize = true;
            labelCelsius.Location = new Point(170, 265);
            labelCelsius.Name = "labelCelsius";
            labelCelsius.Size = new Size(54, 20);
            labelCelsius.TabIndex = 5;
            labelCelsius.Text = "Celsius";
            // 
            // labelFahrenheit
            // 
            labelFahrenheit.AutoSize = true;
            labelFahrenheit.Location = new Point(463, 265);
            labelFahrenheit.Name = "labelFahrenheit";
            labelFahrenheit.Size = new Size(77, 20);
            labelFahrenheit.TabIndex = 6;
            labelFahrenheit.Text = "Fahrenheit";
            // 
            // ThermometerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelFahrenheit);
            Controls.Add(labelCelsius);
            Controls.Add(spinFahrenheit);
            Controls.Add(spinCelsius);
            Controls.Add(trackBarThermometer);
            Name = "ThermometerForm";
            Text = "Thermometer Slider";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)trackBarThermometer).EndInit();
            ((System.ComponentModel.ISupportInitialize)spinCelsius).EndInit();
            ((System.ComponentModel.ISupportInitialize)spinFahrenheit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBarThermometer;
        private NumericUpDown spinCelsius;
        private NumericUpDown spinFahrenheit;
        private Label labelCelsius;
        private Label labelFahrenheit;
    }
}