namespace Steam_Remote_Desktop
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.accessDesktopBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Not yet?";
            this.label1.Visible = false;
            // 
            // accessDesktopBtn
            // 
            this.accessDesktopBtn.BackColor = System.Drawing.Color.DarkGray;
            this.accessDesktopBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.accessDesktopBtn.FlatAppearance.BorderSize = 0;
            this.accessDesktopBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.accessDesktopBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.accessDesktopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accessDesktopBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessDesktopBtn.Location = new System.Drawing.Point(17, 38);
            this.accessDesktopBtn.Name = "accessDesktopBtn";
            this.accessDesktopBtn.Size = new System.Drawing.Size(253, 29);
            this.accessDesktopBtn.TabIndex = 2;
            this.accessDesktopBtn.Text = "Click here to access your desktop again";
            this.accessDesktopBtn.UseVisualStyleBackColor = false;
            this.accessDesktopBtn.Visible = false;
            this.accessDesktopBtn.Click += new System.EventHandler(this.accessDesktopBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(581, 354);
            this.Controls.Add(this.accessDesktopBtn);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Steam In Home Streaming Remote Desktop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.Form1_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button accessDesktopBtn;
    }
}

