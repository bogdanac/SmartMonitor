namespace SmartMonitor.UI
{
    partial class Alert
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
            this.cpuTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.emailAddress = new MetroFramework.Controls.MetroTextBox();
            this.createAlert = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // cpuTrackBar
            // 
            this.cpuTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.cpuTrackBar.Location = new System.Drawing.Point(223, 63);
            this.cpuTrackBar.Name = "cpuTrackBar";
            this.cpuTrackBar.Size = new System.Drawing.Size(271, 53);
            this.cpuTrackBar.TabIndex = 0;
            this.cpuTrackBar.Text = "metroTrackBar1";
            this.cpuTrackBar.Value = 80;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(55, 90);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(106, 20);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Select max CPU";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(55, 162);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "E-mail address";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "metroTextBox1"};
            this.metroTextBox1.Location = new System.Drawing.Point(-19, -19);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(75, 23);
            this.metroTextBox1.TabIndex = 3;
            this.metroTextBox1.Text = "metroTextBox1";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // emailAddress
            // 
            // 
            // 
            // 
            this.emailAddress.CustomButton.Image = null;
            this.emailAddress.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.emailAddress.CustomButton.Name = "";
            this.emailAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.emailAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailAddress.CustomButton.TabIndex = 1;
            this.emailAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailAddress.CustomButton.UseSelectable = true;
            this.emailAddress.CustomButton.Visible = false;
            this.emailAddress.Lines = new string[] {
        "Write e-mail here"};
            this.emailAddress.Location = new System.Drawing.Point(223, 162);
            this.emailAddress.MaxLength = 32767;
            this.emailAddress.Name = "emailAddress";
            this.emailAddress.PasswordChar = '\0';
            this.emailAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailAddress.SelectedText = "";
            this.emailAddress.SelectionLength = 0;
            this.emailAddress.SelectionStart = 0;
            this.emailAddress.ShortcutsEnabled = true;
            this.emailAddress.Size = new System.Drawing.Size(271, 23);
            this.emailAddress.TabIndex = 4;
            this.emailAddress.Text = "Write e-mail here";
            this.emailAddress.UseSelectable = true;
            this.emailAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emailAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // createAlert
            // 
            this.createAlert.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.createAlert.Location = new System.Drawing.Point(393, 260);
            this.createAlert.Name = "createAlert";
            this.createAlert.Size = new System.Drawing.Size(101, 52);
            this.createAlert.Style = MetroFramework.MetroColorStyle.Green;
            this.createAlert.TabIndex = 5;
            this.createAlert.Text = "Create";
            this.createAlert.UseCustomBackColor = true;
            this.createAlert.UseSelectable = true;
            this.createAlert.UseStyleColors = true;
            this.createAlert.Click += new System.EventHandler(this.createAlert_Click);
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 355);
            this.Controls.Add(this.createAlert);
            this.Controls.Add(this.emailAddress);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cpuTrackBar);
            this.Name = "Alert";
            this.Text = "Alert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTrackBar cpuTrackBar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox emailAddress;
        private MetroFramework.Controls.MetroButton createAlert;
    }
}