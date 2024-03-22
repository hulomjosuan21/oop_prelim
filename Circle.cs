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
    public partial class Circle : Form
    {
        public double Radius { get; set; }

        public Circle()
        {
            InitializeComponent();
        }

        private void calc_btn_Click(object sender, EventArgs e)
        {
            Radius = Convert.ToDouble(textBox1.Text.Trim());

            string text = String.Format($"Perimeter of Cicle with the Radius of {Radius}:");

            Result r = new Result(text, 2 * Math.PI * Radius);
            r.ShowDialog();
        }
    }
}
