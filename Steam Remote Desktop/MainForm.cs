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
        private NotifyIcon notifyIcon1;
        private ContextMenu contextMenu1;
        private MenuItem menuItem1;
        private MenuItem menuItem2;
        public MainForm()
        {
            InitializeComponent();

            contextMenu1 = new ContextMenu();
            menuItem1 = new MenuItem();
            menuItem2 = new MenuItem();
            contextMenu1.MenuItems.AddRange(new MenuItem[] { menuItem1, menuItem2 });
            menuItem1.Index = 0;
            menuItem1.Text = "Q&uit";
            menuItem1.Click += new EventHandler(menuItem1_Click);
            menuItem2.Index = 0;
            menuItem2.Text = "Steam Remote Desktop";
            menuItem2.Enabled = false;
            notifyIcon1 = new NotifyIcon();
            notifyIcon1.Icon = this.Icon;
            notifyIcon1.ContextMenu = contextMenu1;

            foreach (var process in Process.GetProcessesByName("steam_monitor"))
            {
                timer1.Start();
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (Startup)
            {
                focusOnDesktop();
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

        private void menuItem1_Click(object Sender, EventArgs e)
        {
            notifyIcon1.Dispose();
            // Close the form, which closes the application. 
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            focusOnDesktop();
            timer1.Stop();
        }

        private void focusOnDesktop()
        {
            Startup = false;
            this.Invalidate();
            Application.DoEvents();
            this.WindowState = FormWindowState.Minimized;
            notifyIcon1.Visible = true;
        }
    }
}
