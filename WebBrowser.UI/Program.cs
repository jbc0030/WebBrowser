using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class WebBrowserUI : Form
    {
        public WebBrowserUI()
        {
            InitializeComponent();
        }

        private void WebBrowserUI_Load(object sender, EventArgs e)
        {
            this.Focus();
            this.BringToFront();
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.Activate();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Browser in Beta Mode developed by X");
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string url = textBox1.Text;

                if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
                {
                    tabPage1.Text = url;
                    webBrowser1.Navigate(url);
                }
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text;

            if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                tabPage1.Text = url;
                webBrowser1.Navigate(url);
            }
        }

        private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
