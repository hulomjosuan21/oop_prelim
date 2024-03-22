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
    public partial class Square : Form
    {
        public double Length { get; set; }

        public Square()
        {
            InitializeComponent();
        }

        private void calc_btn_Click(object sender, EventArgs e)
        {
            Length = Convert.ToDouble(textBox1.Text.Trim());

            string text = String.Format($"Perimeter of Square with the Side length of {Length}:");

            Result r = new Result(text, (4 * Length));
            r.ShowDialog();
        }
    }
}
