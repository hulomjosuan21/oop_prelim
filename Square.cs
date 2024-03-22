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
    public partial class Square : Form, Shape
    {
        private double Length { get; set; }
        public Square()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void calc_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Length = Convert.ToDouble(textBox1.Text.Trim());
                string text = String.Format($"Perimeter of Square with the Side length of {Length}:");
                Result r = new Result(text, CalculatePerimeter());
                r.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public double CalculatePerimeter() => 4 * Length;
    }
}
