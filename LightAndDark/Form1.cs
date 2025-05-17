using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightAndDark
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            getInit();
        }

        private void getInit()
        {
            Settings get = new Settings();
            get.readIni();

            if (get.theme == "dark")
            {
                SwithDarkWhite.Checked = true;
                ltheme.Text = "DARK";
                this.BackColor = Color.FromArgb(32, 33, 36);
                this.ForeColor = Color.White;
            }
            else
            {
                SwithDarkWhite.Checked = false;
                ltheme.Text = "LIGHT";
                this.BackColor = Color.White;
                this.ForeColor = Color.FromArgb(32, 33, 36);
            }
        }

        private void SwithDarkWhite_CheckedChanged(object sender, EventArgs e)
        {
            Settings set = new Settings();
            if (SwithDarkWhite.Checked == true)
            {
                set.writeIni("SECTION", "key", "dark");
                this.BackColor = Color.FromArgb(32, 33, 36);
                this.ForeColor = Color.White;
                ltheme.Text = "DARK";
            }
            else
            {
                set.writeIni("SECTION", "key", "light");
                this.BackColor = Color.White;
                this.ForeColor = Color.FromArgb(32, 33, 36);
                ltheme.Text = "LIGHT";
            }
        }
    }
}
