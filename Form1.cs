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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Triangle_Click(object sender, EventArgs e)
        {
            Triangle t = new Triangle();
            t.ShowDialog();
        }

        private void btn_Rectangle_Click(object sender, EventArgs e)
        {
            Rectangle r = new Rectangle();
            r.ShowDialog();
        }

        private void btn_square_Click(object sender, EventArgs e)
        {
            Square s = new Square();
            s.ShowDialog();
        }

        private void btn_circle_Click(object sender, EventArgs e)
        {
            Circle c = new Circle();
            c.ShowDialog();
        }
    }
}
