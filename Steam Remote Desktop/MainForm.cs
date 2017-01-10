using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Steam_Remote_Desktop
{
    public partial class MainForm : Form
    {
        public static Process process = new Process();
        private bool Startup = true;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (Startup)
            {
                Startup = false;
                this.Invalidate();
                Application.DoEvents();
                this.WindowState = FormWindowState.Minimized;
                this.Icon = SteamRemoteDesktop.Properties.Resources.computerscross;
            }
            else
            {
                //exit application
                Application.Exit();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            var CenterFormat = new StringFormat();
            CenterFormat.Alignment = StringAlignment.Center;
            CenterFormat.LineAlignment = StringAlignment.Center;
            var FontSize = 90 * (Screen.PrimaryScreen.Bounds.Width / 1080);
            if (Startup)
                e.Graphics.DrawString("Click to Start Desktop Stream", new Font("Segoe UI", 90), SystemBrushes.ControlText, this.ClientRectangle, CenterFormat);
            else
            {
                e.Graphics.DrawString("End Desktop Stream", new Font("Segoe UI", 90), SystemBrushes.ControlText, this.ClientRectangle, CenterFormat);
                label1.Visible = true;
                accessDesktopBtn.Visible = true;
            }
        }

        private void accessDesktopBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
