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
    public partial class Rectangle : Form
    {
        public Double Length { get; set; }
        public Double Width { get; set; }

        public Rectangle()
        {
            InitializeComponent();
        }

        private void calc_btn_Click(object sender, EventArgs e)
        {
            
            Length = Convert.ToDouble(textBox1.Text.Trim());
            Width = Convert.ToDouble(textBox2.Text.Trim());

            string text = String.Format($"Perimeter of Rectangle with the length of {Length} and width {Width}:");

            Result r = new Result(text, 2 * (Length + Width));
            r.ShowDialog();
        }
    }
}
