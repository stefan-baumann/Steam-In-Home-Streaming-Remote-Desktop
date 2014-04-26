using System;
using System.Drawing;
using System.Windows.Forms;

namespace Steam_In_Home_Streaming_Desktop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Startup = false;
            this.Invalidate();
            Application.DoEvents();
            this.WindowState = FormWindowState.Minimized;
            this.Icon = SteamInHomeStreamingRemoteDesktop.Properties.Resources.SIHS_End_Remote_Desktop_Logo;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            var CenterFormat = new StringFormat();
            CenterFormat.Alignment = StringAlignment.Center;
            CenterFormat.LineAlignment = StringAlignment.Center;
            var FontSize = 96 * (Screen.PrimaryScreen.Bounds.Width / 1080);
            if (Startup)
                e.Graphics.DrawString("Click to Start Desktop Stream", new Font("Segoe UI", 96), SystemBrushes.ControlText, this.ClientRectangle, CenterFormat);
            else
                e.Graphics.DrawString("End Desktop Stream", new Font("Segoe UI", 96), SystemBrushes.ControlText, this.ClientRectangle, CenterFormat);
        }

        bool Startup = true;
        private void Form1_Activated(object sender, EventArgs e)
        {
            if (!Startup)
                Application.Exit();
        }
    }
}
