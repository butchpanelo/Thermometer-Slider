using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slider
{
    public partial class ThermometerForm : Form
    {
        public ThermometerForm()
        {
            InitializeComponent();
        }

        private void TrackBarThermometer_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = (TrackBar)sender;
            spinCelsius.Value = trackBar.Value;

            MoveLabelAndSpinBoxControls(trackBar.Value);
        }

        private void MoveLabelAndSpinBoxControls(int trackBarValue)
        {
            int trackBarHeight = trackBarThermometer.Size.Height;
            int trackBarTopLocation = trackBarThermometer.Location.Y;

            decimal bottomOffset = ((decimal)trackBarValue - trackBarThermometer.Minimum) / (trackBarThermometer.Maximum - trackBarThermometer.Minimum);
            decimal heightOffset = bottomOffset * trackBarHeight;
            decimal newLocationY = trackBarTopLocation + (trackBarHeight - heightOffset);

            spinCelsius.Location = new Point(spinCelsius.Location.X, (int)newLocationY);
            spinFahrenheit.Location = new Point(spinFahrenheit.Location.X, (int)newLocationY);
            labelCelsius.Location = new Point(labelCelsius.Location.X, (int)newLocationY - 20);
            labelFahrenheit.Location = new Point(labelFahrenheit.Location.X, (int)newLocationY - 20);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            decimal initialCelsius = -30;
            trackBarThermometer.Value = Convert.ToInt32(initialCelsius);
            spinCelsius.Value = initialCelsius;
            spinFahrenheit.Value = TemperatureConverter.ConvertFromCelsiusToFahrenheit(initialCelsius);

            MoveLabelAndSpinBoxControls(trackBarThermometer.Value);
        }

        private void SpinFahrenehit_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown control = (NumericUpDown)sender;
            decimal fahrenheit = control.Value;
            spinCelsius.Value = TemperatureConverter.ConvertFromFahrenheitToCelsius(fahrenheit);
        }

        private void SpinCelsius_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown control = (NumericUpDown)sender;
            decimal celsius = control.Value;
            trackBarThermometer.Value = Convert.ToInt32(celsius);
            spinFahrenheit.Value = TemperatureConverter.ConvertFromCelsiusToFahrenheit(celsius);
        }

        private void TrackBarThermometer_ValueChanged(object sender, EventArgs e)
        {
            MoveLabelAndSpinBoxControls(trackBarThermometer.Value);
        }
    }
}
