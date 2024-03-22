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
    public partial class Result : Form
    {
        public Result(string text, double res)
        {
            InitializeComponent();
            label1.Text = text;
            label2.Text = String.Format($"Result: {res} units");
        }

        private void Result_Load(object sender, EventArgs e)
        {

        }
    }
}
