# ProcessGUI
Process GUI


https://youtu.be/epec4etkaW4

File `Form1.Designer.cs`

```csharp

namespace ProcessGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProcess = new System.Windows.Forms.Button();
            this.txtbLog = new System.Windows.Forms.TextBox();
            this.btnHiden = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(352, 22);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 0;
            this.btnProcess.Text = "Get Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // txtbLog
            // 
            this.txtbLog.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbLog.Location = new System.Drawing.Point(12, 12);
            this.txtbLog.Multiline = true;
            this.txtbLog.Name = "txtbLog";
            this.txtbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbLog.Size = new System.Drawing.Size(307, 426);
            this.txtbLog.TabIndex = 1;
            // 
            // btnHiden
            // 
            this.btnHiden.Location = new System.Drawing.Point(352, 160);
            this.btnHiden.Name = "btnHiden";
            this.btnHiden.Size = new System.Drawing.Size(75, 23);
            this.btnHiden.TabIndex = 3;
            this.btnHiden.Text = "Hidden";
            this.btnHiden.UseVisualStyleBackColor = true;
            this.btnHiden.Click += new System.EventHandler(this.btnHiden_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(352, 85);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnHiden);
            this.Controls.Add(this.txtbLog);
            this.Controls.Add(this.btnProcess);
            this.Name = "Form1";
            this.Text = "Get processes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txtbLog;
        private System.Windows.Forms.Button btnHiden;
        private System.Windows.Forms.Button btnStart;
    }
}
```


File `Form1.cs`

```csharp
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
```
