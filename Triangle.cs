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
    public partial class Triangle : Form
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle()
        {
            InitializeComponent();
        }

        private void calc_btn_Click(object sender, EventArgs e)
        {
            SideA = Convert.ToDouble(textBox1.Text.Trim());
            SideB = Convert.ToDouble(textBox2.Text.Trim());
            SideC = Convert.ToDouble(textBox3.Text.Trim());

            string text = String.Format($"{SideA} + {SideB} + {SideC}:");

            Result r = new Result(text, SideA + SideB + SideC);
                r.ShowDialog();
        }
    }
}
