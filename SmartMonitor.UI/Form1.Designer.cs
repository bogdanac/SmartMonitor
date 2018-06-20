using System.Windows.Forms;

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
            this.vmTab = new MetroFramework.Controls.MetroTabPage();
            this.solidGauge2 = new LiveCharts.WinForms.SolidGauge();
            this.activityLogTab = new MetroFramework.Controls.MetroTabPage();
            this.tabHolder = new MetroFramework.Controls.MetroTabControl();
            this.webTab = new MetroFramework.Controls.MetroTabPage();
            this.metricsListWebTab = new MetroFramework.Controls.MetroListView();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.websiteChooser = new MetroFramework.Controls.MetroComboBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.websiteChart = new LiveCharts.WinForms.CartesianChart();
            this.ehTab = new MetroFramework.Controls.MetroTabPage();
            this.operationsTab = new MetroFramework.Controls.MetroTabPage();
            this.operationsList = new MetroFramework.Controls.MetroListView();
            this.vmTab.SuspendLayout();
            this.tabHolder.SuspendLayout();
            this.webTab.SuspendLayout();
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
            this.saTab.Location = new System.Drawing.Point(254, 4);
            this.saTab.Name = "saTab";
            this.saTab.Size = new System.Drawing.Size(926, 645);
            this.saTab.TabIndex = 2;
            this.saTab.Text = "Storage Accounts";
            this.saTab.VerticalScrollbarBarColor = true;
            this.saTab.VerticalScrollbarHighlightOnWheel = false;
            this.saTab.VerticalScrollbarSize = 10;
            // 
            // vmTab
            // 
            this.vmTab.Controls.Add(this.solidGauge2);
            this.vmTab.HorizontalScrollbarBarColor = true;
            this.vmTab.HorizontalScrollbarHighlightOnWheel = false;
            this.vmTab.HorizontalScrollbarSize = 10;
            this.vmTab.Location = new System.Drawing.Point(254, 4);
            this.vmTab.Name = "vmTab";
            this.vmTab.Size = new System.Drawing.Size(926, 645);
            this.vmTab.TabIndex = 4;
            this.vmTab.Text = "Virtual Machines";
            this.vmTab.VerticalScrollbarBarColor = true;
            this.vmTab.VerticalScrollbarHighlightOnWheel = false;
            this.vmTab.VerticalScrollbarSize = 10;
            // 
            // solidGauge2
            // 
            this.solidGauge2.Location = new System.Drawing.Point(583, 44);
            this.solidGauge2.Name = "solidGauge2";
            this.solidGauge2.Size = new System.Drawing.Size(200, 100);
            this.solidGauge2.TabIndex = 2;
            this.solidGauge2.Text = "solidGauge2";
            // 
            // activityLogTab
            // 
            this.activityLogTab.HorizontalScrollbarBarColor = true;
            this.activityLogTab.HorizontalScrollbarHighlightOnWheel = false;
            this.activityLogTab.HorizontalScrollbarSize = 10;
            this.activityLogTab.Location = new System.Drawing.Point(254, 4);
            this.activityLogTab.Name = "activityLogTab";
            this.activityLogTab.Size = new System.Drawing.Size(926, 645);
            this.activityLogTab.TabIndex = 0;
            this.activityLogTab.Text = "Activity Log";
            this.activityLogTab.UseStyleColors = true;
            this.activityLogTab.VerticalScrollbarBarColor = true;
            this.activityLogTab.VerticalScrollbarHighlightOnWheel = false;
            this.activityLogTab.VerticalScrollbarSize = 10;
            // 
            // tabHolder
            // 
            this.tabHolder.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabHolder.Controls.Add(this.activityLogTab);
            this.tabHolder.Controls.Add(this.webTab);
            this.tabHolder.Controls.Add(this.ehTab);
            this.tabHolder.Controls.Add(this.operationsTab);
            this.tabHolder.Controls.Add(this.saTab);
            this.tabHolder.Controls.Add(this.vmTab);
            this.tabHolder.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.tabHolder.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.tabHolder.ItemSize = new System.Drawing.Size(90, 250);
            this.tabHolder.Location = new System.Drawing.Point(10, 63);
            this.tabHolder.Multiline = true;
            this.tabHolder.Name = "tabHolder";
            this.tabHolder.RightToLeftLayout = true;
            this.tabHolder.SelectedIndex = 3;
            this.tabHolder.Size = new System.Drawing.Size(1184, 653);
            this.tabHolder.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabHolder.Style = MetroFramework.MetroColorStyle.Blue;
            this.tabHolder.TabIndex = 2;
            this.tabHolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tabHolder.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabHolder.UseCustomBackColor = true;
            this.tabHolder.UseSelectable = true;
            this.tabHolder.UseStyleColors = true;
            // 
            // webTab
            // 
            this.webTab.Controls.Add(this.metricsListWebTab);
            this.webTab.Controls.Add(this.metroLabel2);
            this.webTab.Controls.Add(this.websiteChooser);
            this.webTab.Controls.Add(this.metroButton2);
            this.webTab.Controls.Add(this.metroLabel1);
            this.webTab.Controls.Add(this.websiteChart);
            this.webTab.HorizontalScrollbarBarColor = true;
            this.webTab.HorizontalScrollbarHighlightOnWheel = false;
            this.webTab.HorizontalScrollbarSize = 10;
            this.webTab.Location = new System.Drawing.Point(254, 4);
            this.webTab.Name = "webTab";
            this.webTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.webTab.Size = new System.Drawing.Size(926, 645);
            this.webTab.TabIndex = 1;
            this.webTab.Text = "Websites";
            this.webTab.UseStyleColors = true;
            this.webTab.VerticalScrollbarBarColor = true;
            this.webTab.VerticalScrollbarHighlightOnWheel = false;
            this.webTab.VerticalScrollbarSize = 10;
            // 
            // metricsListWebTab
            // 
            this.metricsListWebTab.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metricsListWebTab.FullRowSelect = true;
            this.metricsListWebTab.Location = new System.Drawing.Point(30, 156);
            this.metricsListWebTab.Name = "metricsListWebTab";
            this.metricsListWebTab.OwnerDraw = true;
            this.metricsListWebTab.Size = new System.Drawing.Size(229, 319);
            this.metricsListWebTab.Style = MetroFramework.MetroColorStyle.Blue;
            this.metricsListWebTab.TabIndex = 9;
            this.metricsListWebTab.UseCompatibleStateImageBehavior = false;
            this.metricsListWebTab.UseSelectable = true;
            this.metricsListWebTab.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(26, 12);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(139, 25);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Choose website";
            // 
            // websiteChooser
            // 
            this.websiteChooser.FormattingEnabled = true;
            this.websiteChooser.ItemHeight = 24;
            this.websiteChooser.Location = new System.Drawing.Point(30, 49);
            this.websiteChooser.Name = "websiteChooser";
            this.websiteChooser.Size = new System.Drawing.Size(229, 30);
            this.websiteChooser.TabIndex = 7;
            this.websiteChooser.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButton2.DisplayFocus = true;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(30, 543);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(206, 60);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroButton2.TabIndex = 6;
            this.metroButton2.Text = "Create Alert";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(30, 105);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(135, 25);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Select a metric";
            // 
            // websiteChart
            // 
            this.websiteChart.Location = new System.Drawing.Point(290, 12);
            this.websiteChart.Name = "websiteChart";
            this.websiteChart.Size = new System.Drawing.Size(627, 617);
            this.websiteChart.TabIndex = 3;
            // 
            // ehTab
            // 
            this.ehTab.HorizontalScrollbarBarColor = true;
            this.ehTab.HorizontalScrollbarHighlightOnWheel = false;
            this.ehTab.HorizontalScrollbarSize = 10;
            this.ehTab.Location = new System.Drawing.Point(254, 4);
            this.ehTab.Name = "ehTab";
            this.ehTab.Size = new System.Drawing.Size(926, 645);
            this.ehTab.TabIndex = 3;
            this.ehTab.Text = "Event Hubs";
            this.ehTab.VerticalScrollbarBarColor = true;
            this.ehTab.VerticalScrollbarHighlightOnWheel = false;
            this.ehTab.VerticalScrollbarSize = 10;
            // 
            // operationsTab
            // 
            this.operationsTab.Controls.Add(this.operationsList);
            this.operationsTab.HorizontalScrollbarBarColor = true;
            this.operationsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.operationsTab.HorizontalScrollbarSize = 10;
            this.operationsTab.Location = new System.Drawing.Point(254, 4);
            this.operationsTab.Name = "operationsTab";
            this.operationsTab.Size = new System.Drawing.Size(926, 645);
            this.operationsTab.TabIndex = 5;
            this.operationsTab.Text = "Operations";
            this.operationsTab.VerticalScrollbarBarColor = true;
            this.operationsTab.VerticalScrollbarHighlightOnWheel = false;
            this.operationsTab.VerticalScrollbarSize = 10;
            // 
            // operationsList
            // 
            this.operationsList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.operationsList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.operationsList.FullRowSelect = true;
            this.operationsList.Location = new System.Drawing.Point(3, 3);
            this.operationsList.Name = "operationsList";
            this.operationsList.OwnerDraw = true;
            this.operationsList.Size = new System.Drawing.Size(897, 639);
            this.operationsList.Style = MetroFramework.MetroColorStyle.Green;
            this.operationsList.TabIndex = 5;
            this.operationsList.Theme = MetroFramework.MetroThemeStyle.Light;
            this.operationsList.UseCompatibleStateImageBehavior = false;
            this.operationsList.UseSelectable = true;
            this.operationsList.UseStyleColors = true;
            // 
            // Form1
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1204, 768);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.tabHolder);
            this.Name = "Form1";
            this.Text = "SmartMonitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.vmTab.ResumeLayout(false);
            this.tabHolder.ResumeLayout(false);
            this.webTab.ResumeLayout(false);
            this.webTab.PerformLayout();
            this.operationsTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTabPage saTab;
        private MetroFramework.Controls.MetroTabPage vmTab;
        private MetroFramework.Controls.MetroTabPage activityLogTab;
        private MetroFramework.Controls.MetroTabControl tabHolder;
        private MetroFramework.Controls.MetroTabPage operationsTab;
        private MetroFramework.Controls.MetroListView operationsList;
        private MetroFramework.Controls.MetroTabPage webTab;
        private LiveCharts.WinForms.CartesianChart websiteChart;
        private MetroFramework.Controls.MetroTabPage ehTab;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private LiveCharts.WinForms.SolidGauge solidGauge2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox websiteChooser;
        private MetroFramework.Controls.MetroListView metricsListWebTab;
    }
}

