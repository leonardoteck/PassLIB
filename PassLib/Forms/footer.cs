using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassLib
{
    public partial class footer : UserControl
    {
        string hora = DateTime.Now.ToShortTimeString();

        public footer()
        {
            InitializeComponent();
        }

        private void footer_Load(object sender, EventArgs e)
        {
            DiaHora.Text = DateTime.Now.ToShortDateString() + " - "
                + DateTime.Now.ToShortTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hora != DateTime.Now.ToShortTimeString())
            {
                DiaHora.Text = DateTime.Now.ToShortDateString() + " - "
                    + hora;
                hora = DateTime.Now.ToShortTimeString();
            }
        }
    }
}
