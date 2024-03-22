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
    public partial class Triangle : Form, Shape
    {
        private double SideA { get; set; }
        private double SideB { get; set; }
        private double SideC { get; set; }
        public Triangle()
        {
            InitializeComponent();
        }

        public double CalculatePerimeter() => SideA + SideB + SideC;

        private void calc_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SideA = Convert.ToDouble(textBox1.Text.Trim());
                SideB = Convert.ToDouble(textBox2.Text.Trim());
                SideC = Convert.ToDouble(textBox3.Text.Trim());
                string text = String.Format($"Perimeter of Triangle with the Side A of {SideA},  Side B of {SideB} and Side C of {SideC}:");
                Result r = new Result(text, CalculatePerimeter());
                r.ShowDialog();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
