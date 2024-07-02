using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void tm_splah_Tick(object sender, EventArgs e)
        {
            if (pgb_splah.Value < 100)
            {
                pgb_splah.Value += 2;
            }
            else
            {
                tm_splah.Stop();
                frm_login login = new frm_login();
                login.Show();
                this.Visible = false;
            }
        }

        private void pct_image_Click(object sender, EventArgs e)
        {

        }

        private void pgb_splah_Click(object sender, EventArgs e)
        {

        }
    }
}
