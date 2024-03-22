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
    public partial class Rectangle : Form, Shape
    {
        private Double Length { get; set; }
        private Double Width { get; set; }
        public Rectangle()
        {
            InitializeComponent();
        }

        private void calc_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Length = Convert.ToDouble(textBox1.Text.Trim());
                Width = Convert.ToDouble(textBox2.Text.Trim());
                string text = String.Format($"Perimeter of Rectangle with the length of {Length} and width {Width}:");
                Result r = new Result(text, CalculatePerimeter());
                r.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public double CalculatePerimeter() => 2 * (Length + Width);
    }
}
