using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class frmhowareyou : Form
    {
        public frmhowareyou()
        {
            InitializeComponent();
        }

        private void rdbGreat_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "Hello";
        }

        private void rdbGood_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "Sweet, you probably had a cookie";
        }

        private void rdbMad_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "Would u like a cookie?";
        }

        private void rdbSad_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "Did someone take your cookie";
        }

        private void rdbHitting_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "The Cookie Monster is a good punching bag";
        }

        private void rdbDud_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "Wonderful, Im gonna guess you had a couple cookies";
        }
    }
}
