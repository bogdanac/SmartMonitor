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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.saTab = new MetroFramework.Controls.MetroTabPage();
            this.ehTab = new MetroFramework.Controls.MetroTabPage();
            this.vmTab = new MetroFramework.Controls.MetroTabPage();
            this.webTab = new MetroFramework.Controls.MetroTabPage();
            this.activityLogTab = new MetroFramework.Controls.MetroTabPage();
            this.tabHolder = new MetroFramework.Controls.MetroTabControl();
            this.operationsTab = new MetroFramework.Controls.MetroTabPage();
            this.activityLogList = new MetroFramework.Controls.MetroListView();
            this.tabHolder.SuspendLayout();
            this.operationsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(908, 28);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // saTab
            // 
            this.saTab.HorizontalScrollbarBarColor = true;
            this.saTab.HorizontalScrollbarHighlightOnWheel = false;
            this.saTab.HorizontalScrollbarSize = 10;
            this.saTab.Location = new System.Drawing.Point(4, 47);
            this.saTab.Name = "saTab";
            this.saTab.Size = new System.Drawing.Size(1025, 585);
            this.saTab.TabIndex = 4;
            this.saTab.Text = "Event Hubs";
            this.saTab.VerticalScrollbarBarColor = true;
            this.saTab.VerticalScrollbarHighlightOnWheel = false;
            this.saTab.VerticalScrollbarSize = 10;
            // 
            // ehTab
            // 
            this.ehTab.HorizontalScrollbarBarColor = true;
            this.ehTab.HorizontalScrollbarHighlightOnWheel = false;
            this.ehTab.HorizontalScrollbarSize = 10;
            this.ehTab.Location = new System.Drawing.Point(4, 47);
            this.ehTab.Name = "ehTab";
            this.ehTab.Size = new System.Drawing.Size(1025, 585);
            this.ehTab.TabIndex = 3;
            this.ehTab.Text = "Storage Accounts";
            this.ehTab.VerticalScrollbarBarColor = true;
            this.ehTab.VerticalScrollbarHighlightOnWheel = false;
            this.ehTab.VerticalScrollbarSize = 10;
            // 
            // vmTab
            // 
            this.vmTab.HorizontalScrollbarBarColor = true;
            this.vmTab.HorizontalScrollbarHighlightOnWheel = false;
            this.vmTab.HorizontalScrollbarSize = 10;
            this.vmTab.Location = new System.Drawing.Point(4, 47);
            this.vmTab.Name = "vmTab";
            this.vmTab.Size = new System.Drawing.Size(1025, 585);
            this.vmTab.TabIndex = 2;
            this.vmTab.Text = "Virtual Machines";
            this.vmTab.VerticalScrollbarBarColor = true;
            this.vmTab.VerticalScrollbarHighlightOnWheel = false;
            this.vmTab.VerticalScrollbarSize = 10;
            // 
            // webTab
            // 
            this.webTab.HorizontalScrollbarBarColor = true;
            this.webTab.HorizontalScrollbarHighlightOnWheel = false;
            this.webTab.HorizontalScrollbarSize = 10;
            this.webTab.Location = new System.Drawing.Point(4, 47);
            this.webTab.Name = "webTab";
            this.webTab.Size = new System.Drawing.Size(1025, 585);
            this.webTab.TabIndex = 1;
            this.webTab.Text = "Websites";
            this.webTab.VerticalScrollbarBarColor = true;
            this.webTab.VerticalScrollbarHighlightOnWheel = false;
            this.webTab.VerticalScrollbarSize = 10;
            // 
            // activityLogTab
            // 
            this.activityLogTab.HorizontalScrollbarBarColor = true;
            this.activityLogTab.HorizontalScrollbarHighlightOnWheel = false;
            this.activityLogTab.HorizontalScrollbarSize = 10;
            this.activityLogTab.Location = new System.Drawing.Point(4, 47);
            this.activityLogTab.Name = "activityLogTab";
            this.activityLogTab.Size = new System.Drawing.Size(1025, 585);
            this.activityLogTab.Style = MetroFramework.MetroColorStyle.Yellow;
            this.activityLogTab.TabIndex = 0;
            this.activityLogTab.Text = "Activity Log";
            this.activityLogTab.VerticalScrollbarBarColor = true;
            this.activityLogTab.VerticalScrollbarHighlightOnWheel = false;
            this.activityLogTab.VerticalScrollbarSize = 10;
            // 
            // tabHolder
            // 
            this.tabHolder.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabHolder.Controls.Add(this.activityLogTab);
            this.tabHolder.Controls.Add(this.saTab);
            this.tabHolder.Controls.Add(this.webTab);
            this.tabHolder.Controls.Add(this.vmTab);
            this.tabHolder.Controls.Add(this.ehTab);
            this.tabHolder.Controls.Add(this.operationsTab);
            this.tabHolder.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.tabHolder.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.tabHolder.Location = new System.Drawing.Point(23, 78);
            this.tabHolder.Name = "tabHolder";
            this.tabHolder.SelectedIndex = 5;
            this.tabHolder.Size = new System.Drawing.Size(1284, 636);
            this.tabHolder.Style = MetroFramework.MetroColorStyle.Blue;
            this.tabHolder.TabIndex = 0;
            this.tabHolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tabHolder.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabHolder.UseCustomBackColor = true;
            this.tabHolder.UseSelectable = true;
            // 
            // operationsTab
            // 
            this.operationsTab.Controls.Add(this.activityLogList);
            this.operationsTab.HorizontalScrollbarBarColor = true;
            this.operationsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.operationsTab.HorizontalScrollbarSize = 10;
            this.operationsTab.Location = new System.Drawing.Point(4, 47);
            this.operationsTab.Name = "operationsTab";
            this.operationsTab.Size = new System.Drawing.Size(1276, 585);
            this.operationsTab.TabIndex = 5;
            this.operationsTab.Text = "Operations";
            this.operationsTab.VerticalScrollbarBarColor = true;
            this.operationsTab.VerticalScrollbarHighlightOnWheel = false;
            this.operationsTab.VerticalScrollbarSize = 10;
            // 
            // activityLogList
            // 
            this.activityLogList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.activityLogList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.activityLogList.FullRowSelect = true;
            this.activityLogList.Location = new System.Drawing.Point(3, 0);
            this.activityLogList.Name = "activityLogList";
            this.activityLogList.OwnerDraw = true;
            this.activityLogList.Size = new System.Drawing.Size(1270, 585);
            this.activityLogList.Style = MetroFramework.MetroColorStyle.Green;
            this.activityLogList.TabIndex = 4;
            this.activityLogList.Theme = MetroFramework.MetroThemeStyle.Light;
            this.activityLogList.UseCompatibleStateImageBehavior = false;
            this.activityLogList.UseSelectable = true;
            this.activityLogList.UseStyleColors = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 833);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.tabHolder);
            this.Name = "Form1";
            this.Text = "SmartMonitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabHolder.ResumeLayout(false);
            this.operationsTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTabPage saTab;
        private MetroFramework.Controls.MetroTabPage ehTab;
        private MetroFramework.Controls.MetroTabPage vmTab;
        private MetroFramework.Controls.MetroTabPage webTab;
        private MetroFramework.Controls.MetroTabPage activityLogTab;
        private MetroFramework.Controls.MetroTabControl tabHolder;
        private MetroFramework.Controls.MetroTabPage operationsTab;
        private MetroFramework.Controls.MetroListView activityLogList;
    }
}

