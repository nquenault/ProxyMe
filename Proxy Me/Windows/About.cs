using System.Diagnostics;
using System.Windows.Forms;

namespace ProxyMe
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel1.Text);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
