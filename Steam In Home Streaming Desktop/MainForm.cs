using System;
using System.Drawing;
using System.Windows.Forms;

namespace Steam_In_Home_Streaming_Desktop
{
    public partial class MainForm : Form
    {
        private NotifyIcon notifyIcon1;
        private ContextMenu contextMenu1;
        private MenuItem menuItem1;
        
        private bool Startup = true;

        public MainForm()
        {
            InitializeComponent();

            contextMenu1 = new ContextMenu();
            menuItem1 = new MenuItem();
            contextMenu1.MenuItems.AddRange(new MenuItem[] {menuItem1});
            menuItem1.Index = 0;
            menuItem1.Text = "Q&uit";
            menuItem1.Click += new EventHandler(menuItem1_Click);

            notifyIcon1 = new NotifyIcon();
            notifyIcon1.Icon = this.Icon;
            notifyIcon1.ContextMenu = contextMenu1;
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

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                this.Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void menuItem1_Click(object Sender, EventArgs e)
        {
            notifyIcon1.Dispose();
            // Close the form, which closes the application. 
            this.Close();
        }
    }
}
