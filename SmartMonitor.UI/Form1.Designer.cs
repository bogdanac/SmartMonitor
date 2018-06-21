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
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.angularGauge1 = new LiveCharts.WinForms.AngularGauge();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.vmChooser = new MetroFramework.Controls.MetroComboBox();
            this.vmMetricsList = new MetroFramework.Controls.MetroListView();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.activityLogTab = new MetroFramework.Controls.MetroTabPage();
            this.tabHolder = new MetroFramework.Controls.MetroTabControl();
            this.webTab = new MetroFramework.Controls.MetroTabPage();
            this.webMetricsList = new MetroFramework.Controls.MetroListView();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.websiteChooser = new MetroFramework.Controls.MetroComboBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.websiteChart = new LiveCharts.WinForms.CartesianChart();
            this.ehTab = new MetroFramework.Controls.MetroTabPage();
            this.operationsTab = new MetroFramework.Controls.MetroTabPage();
            this.operationsList = new MetroFramework.Controls.MetroListView();
            this.vmTab.SuspendLayout();
            this.metroPanel1.SuspendLayout();
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
            this.vmTab.Controls.Add(this.metroLabel7);
            this.vmTab.Controls.Add(this.metroLabel6);
            this.vmTab.Controls.Add(this.metroDateTime2);
            this.vmTab.Controls.Add(this.metroDateTime1);
            this.vmTab.Controls.Add(this.metroPanel1);
            this.vmTab.Controls.Add(this.vmMetricsList);
            this.vmTab.Controls.Add(this.metroLabel4);
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
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(681, 29);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(64, 20);
            this.metroLabel7.TabIndex = 22;
            this.metroLabel7.Text = "End date";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(455, 29);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(68, 20);
            this.metroLabel6.TabIndex = 21;
            this.metroLabel6.Text = "Start date";
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.Location = new System.Drawing.Point(681, 55);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(200, 30);
            this.metroDateTime2.TabIndex = 19;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(455, 55);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 30);
            this.metroDateTime1.TabIndex = 18;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.angularGauge1);
            this.metroPanel1.Controls.Add(this.metroButton3);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.vmChooser);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(22, 97);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(337, 477);
            this.metroPanel1.TabIndex = 17;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(82, 135);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(140, 25);
            this.metroLabel5.TabIndex = 15;
            this.metroLabel5.Text = "Percentage CPU";
            // 
            // angularGauge1
            // 
            this.angularGauge1.Location = new System.Drawing.Point(36, 172);
            this.angularGauge1.Name = "angularGauge1";
            this.angularGauge1.Size = new System.Drawing.Size(242, 161);
            this.angularGauge1.TabIndex = 16;
            this.angularGauge1.Text = "angularGauge1";
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButton3.DisplayFocus = true;
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton3.Highlight = true;
            this.metroButton3.Location = new System.Drawing.Point(53, 378);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(206, 60);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroButton3.TabIndex = 11;
            this.metroButton3.Text = "Create Alert";
            this.metroButton3.UseCustomBackColor = true;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(36, 25);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(240, 25);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Choose your virtual machine";
            // 
            // vmChooser
            // 
            this.vmChooser.FormattingEnabled = true;
            this.vmChooser.ItemHeight = 24;
            this.vmChooser.Location = new System.Drawing.Point(40, 62);
            this.vmChooser.Name = "vmChooser";
            this.vmChooser.Size = new System.Drawing.Size(229, 30);
            this.vmChooser.TabIndex = 12;
            this.vmChooser.UseSelectable = true;
            // 
            // vmMetricsList
            // 
            this.vmMetricsList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.vmMetricsList.FullRowSelect = true;
            this.vmMetricsList.Location = new System.Drawing.Point(611, 109);
            this.vmMetricsList.Name = "vmMetricsList";
            this.vmMetricsList.OwnerDraw = true;
            this.vmMetricsList.Size = new System.Drawing.Size(249, 119);
            this.vmMetricsList.Style = MetroFramework.MetroColorStyle.Blue;
            this.vmMetricsList.TabIndex = 14;
            this.vmMetricsList.UseCompatibleStateImageBehavior = false;
            this.vmMetricsList.UseSelectable = true;
            this.vmMetricsList.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(455, 145);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(135, 25);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Select a metric";
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
            this.tabHolder.Controls.Add(this.saTab);
            this.tabHolder.Controls.Add(this.vmTab);
            this.tabHolder.Controls.Add(this.operationsTab);
            this.tabHolder.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.tabHolder.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.tabHolder.ItemSize = new System.Drawing.Size(90, 250);
            this.tabHolder.Location = new System.Drawing.Point(10, 63);
            this.tabHolder.Multiline = true;
            this.tabHolder.Name = "tabHolder";
            this.tabHolder.RightToLeftLayout = true;
            this.tabHolder.SelectedIndex = 2;
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
            this.webTab.Controls.Add(this.webMetricsList);
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
            // webMetricsList
            // 
            this.webMetricsList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.webMetricsList.FullRowSelect = true;
            this.webMetricsList.Location = new System.Drawing.Point(30, 156);
            this.webMetricsList.Name = "webMetricsList";
            this.webMetricsList.OwnerDraw = true;
            this.webMetricsList.Size = new System.Drawing.Size(229, 319);
            this.webMetricsList.Style = MetroFramework.MetroColorStyle.Blue;
            this.webMetricsList.TabIndex = 9;
            this.webMetricsList.UseCompatibleStateImageBehavior = false;
            this.webMetricsList.UseSelectable = true;
            this.webMetricsList.UseStyleColors = true;
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
            this.ClientSize = new System.Drawing.Size(1215, 757);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.tabHolder);
            this.Name = "Form1";
            this.Text = "SmartMonitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.vmTab.ResumeLayout(false);
            this.vmTab.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
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
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox websiteChooser;
        private MetroFramework.Controls.MetroListView webMetricsList;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private LiveCharts.WinForms.AngularGauge angularGauge1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox vmChooser;
        private MetroFramework.Controls.MetroListView vmMetricsList;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}

