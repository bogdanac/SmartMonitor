namespace SmartMonitor.UI
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
            this.tabHolder = new MetroFramework.Controls.MetroTabControl();
            this.activityLogTab = new MetroFramework.Controls.MetroTabPage();
            this.webTab = new MetroFramework.Controls.MetroTabPage();
            this.vmTab = new MetroFramework.Controls.MetroTabPage();
            this.ehTab = new MetroFramework.Controls.MetroTabPage();
            this.saTab = new MetroFramework.Controls.MetroTabPage();
            this.tabHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabHolder
            // 
            this.tabHolder.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabHolder.Controls.Add(this.activityLogTab);
            this.tabHolder.Controls.Add(this.webTab);
            this.tabHolder.Controls.Add(this.vmTab);
            this.tabHolder.Controls.Add(this.ehTab);
            this.tabHolder.Controls.Add(this.saTab);
            this.tabHolder.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.tabHolder.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.tabHolder.Location = new System.Drawing.Point(23, 78);
            this.tabHolder.Name = "tabHolder";
            this.tabHolder.SelectedIndex = 0;
            this.tabHolder.Size = new System.Drawing.Size(961, 593);
            this.tabHolder.Style = MetroFramework.MetroColorStyle.Yellow;
            this.tabHolder.TabIndex = 0;
            this.tabHolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tabHolder.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabHolder.UseCustomBackColor = true;
            this.tabHolder.UseSelectable = true;
            // 
            // activityLogTab
            // 
            this.activityLogTab.HorizontalScrollbarBarColor = true;
            this.activityLogTab.HorizontalScrollbarHighlightOnWheel = false;
            this.activityLogTab.HorizontalScrollbarSize = 10;
            this.activityLogTab.Location = new System.Drawing.Point(4, 47);
            this.activityLogTab.Name = "activityLogTab";
            this.activityLogTab.Size = new System.Drawing.Size(953, 542);
            this.activityLogTab.Style = MetroFramework.MetroColorStyle.Yellow;
            this.activityLogTab.TabIndex = 0;
            this.activityLogTab.Text = "Activity Log";
            this.activityLogTab.VerticalScrollbarBarColor = true;
            this.activityLogTab.VerticalScrollbarHighlightOnWheel = false;
            this.activityLogTab.VerticalScrollbarSize = 10;
            // 
            // webTab
            // 
            this.webTab.HorizontalScrollbarBarColor = true;
            this.webTab.HorizontalScrollbarHighlightOnWheel = false;
            this.webTab.HorizontalScrollbarSize = 10;
            this.webTab.Location = new System.Drawing.Point(4, 47);
            this.webTab.Name = "webTab";
            this.webTab.Size = new System.Drawing.Size(813, 510);
            this.webTab.TabIndex = 1;
            this.webTab.Text = "Websites";
            this.webTab.VerticalScrollbarBarColor = true;
            this.webTab.VerticalScrollbarHighlightOnWheel = false;
            this.webTab.VerticalScrollbarSize = 10;
            // 
            // vmTab
            // 
            this.vmTab.HorizontalScrollbarBarColor = true;
            this.vmTab.HorizontalScrollbarHighlightOnWheel = false;
            this.vmTab.HorizontalScrollbarSize = 10;
            this.vmTab.Location = new System.Drawing.Point(4, 47);
            this.vmTab.Name = "vmTab";
            this.vmTab.Size = new System.Drawing.Size(813, 510);
            this.vmTab.TabIndex = 2;
            this.vmTab.Text = "Virtual Machines";
            this.vmTab.VerticalScrollbarBarColor = true;
            this.vmTab.VerticalScrollbarHighlightOnWheel = false;
            this.vmTab.VerticalScrollbarSize = 10;
            // 
            // ehTab
            // 
            this.ehTab.HorizontalScrollbarBarColor = true;
            this.ehTab.HorizontalScrollbarHighlightOnWheel = false;
            this.ehTab.HorizontalScrollbarSize = 10;
            this.ehTab.Location = new System.Drawing.Point(4, 47);
            this.ehTab.Name = "ehTab";
            this.ehTab.Size = new System.Drawing.Size(813, 510);
            this.ehTab.TabIndex = 3;
            this.ehTab.Text = "Storage Accounts";
            this.ehTab.VerticalScrollbarBarColor = true;
            this.ehTab.VerticalScrollbarHighlightOnWheel = false;
            this.ehTab.VerticalScrollbarSize = 10;
            // 
            // saTab
            // 
            this.saTab.HorizontalScrollbarBarColor = true;
            this.saTab.HorizontalScrollbarHighlightOnWheel = false;
            this.saTab.HorizontalScrollbarSize = 10;
            this.saTab.Location = new System.Drawing.Point(4, 47);
            this.saTab.Name = "saTab";
            this.saTab.Size = new System.Drawing.Size(813, 510);
            this.saTab.TabIndex = 4;
            this.saTab.Text = "Event Hubs";
            this.saTab.VerticalScrollbarBarColor = true;
            this.saTab.VerticalScrollbarHighlightOnWheel = false;
            this.saTab.VerticalScrollbarSize = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 734);
            this.Controls.Add(this.tabHolder);
            this.Name = "Form1";
            this.Text = "SmartMonitor";
            this.tabHolder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabHolder;
        private MetroFramework.Controls.MetroTabPage activityLogTab;
        private MetroFramework.Controls.MetroTabPage webTab;
        private MetroFramework.Controls.MetroTabPage vmTab;
        private MetroFramework.Controls.MetroTabPage ehTab;
        private MetroFramework.Controls.MetroTabPage saTab;
    }
}

