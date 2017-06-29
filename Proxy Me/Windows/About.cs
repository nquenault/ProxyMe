using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace ProxyMe
{
    public partial class About : Form
    {
        private System.Version CurrentVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version;
            }
        }

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

        private void About_Load(object sender, System.EventArgs e)
        {
            string version = CurrentVersion.Major.ToString() + "." + CurrentVersion.Minor.ToString();

            if (CurrentVersion.Build != 0)
                version += "." + CurrentVersion.Build.ToString();

            if (CurrentVersion.Revision != 0)
                version += "." + CurrentVersion.Revision.ToString();

            label2.Text = "version " + version + "\r\nby Nicolas Quenault";
        }
    }
}
