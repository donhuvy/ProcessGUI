using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ProcessGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void GetProcesses()
        {
            Process[] processArr = Process.GetProcesses();
            foreach (Process item in processArr)
            {
                txtbLog.Text = item.ProcessName + Environment.NewLine + txtbLog.Text;
            }

            //var item = Process.GetCurrentProcess();
            //txtbLog.Text = item.ProcessName;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            GetProcesses();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // string link = @"http://github.com";
            // Process.Start(link);

            // Process.Start("notepad.exe");

            // Process.Start("regedit");

            // Khởi động được bất kỳ chương trình nào nếu có full_path.
            // Process.Start(Application.StartupPath + "\\ProcessGUI.exe");

            Process.Start("https://github.com/donhuvy");
        }

        private void btnHiden_Click(object sender, EventArgs e)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = Application.StartupPath + "\\ProcessGUI.exe";
            // proc.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            // proc.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;

            // Chạy ngầm, có process, nhưng không hiển thị.
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            proc.Start();
        }
    }

}
