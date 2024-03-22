using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hulom_prelim
{
    public partial class Circle : Form, Shape
    {
        public double Radius { get; set; }
        public Circle()
        {
            InitializeComponent();
        }

        public double CalculatePerimeter() => 2 * Math.PI * Radius;

        private void calc_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Radius = Convert.ToDouble(textBox1.Text.Trim());
                string text = String.Format($"Perimeter of Cicle with the Radius of {Radius}:");
                Result r = new Result(text, CalculatePerimeter());
                r.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
