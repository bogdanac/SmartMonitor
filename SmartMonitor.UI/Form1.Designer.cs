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
            this.saTab = new MetroFramework.Controls.MetroTabPage();
            this.vmTab = new MetroFramework.Controls.MetroTabPage();
            this.vmChart = new LiveCharts.WinForms.CartesianChart();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.endVMTime = new MetroFramework.Controls.MetroDateTime();
            this.startVMTime = new MetroFramework.Controls.MetroDateTime();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.percentageCPUchart = new LiveCharts.WinForms.AngularGauge();
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
            this.operationsTab = new MetroFramework.Controls.MetroTabPage();
            this.operationsList = new MetroFramework.Controls.MetroListView();
            this.storageMetricsList = new MetroFramework.Controls.MetroListView();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.storageAccountChooser = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.storageChart = new LiveCharts.WinForms.CartesianChart();
            this.saTab.SuspendLayout();
            this.vmTab.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.tabHolder.SuspendLayout();
            this.webTab.SuspendLayout();
            this.operationsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // saTab
            // 
            this.saTab.Controls.Add(this.storageMetricsList);
            this.saTab.Controls.Add(this.metroLabel9);
            this.saTab.Controls.Add(this.storageAccountChooser);
            this.saTab.Controls.Add(this.metroLabel10);
            this.saTab.Controls.Add(this.storageChart);
            this.saTab.HorizontalScrollbarBarColor = true;
            this.saTab.HorizontalScrollbarHighlightOnWheel = false;
            this.saTab.HorizontalScrollbarSize = 10;
            this.saTab.Location = new System.Drawing.Point(254, 4);
            this.saTab.Name = "saTab";
            this.saTab.Size = new System.Drawing.Size(1076, 645);
            this.saTab.TabIndex = 2;
            this.saTab.Text = "Storage Accounts";
            this.saTab.VerticalScrollbarBarColor = true;
            this.saTab.VerticalScrollbarHighlightOnWheel = false;
            this.saTab.VerticalScrollbarSize = 10;
            // 
            // vmTab
            // 
            this.vmTab.Controls.Add(this.vmChart);
            this.vmTab.Controls.Add(this.metroLabel7);
            this.vmTab.Controls.Add(this.metroLabel6);
            this.vmTab.Controls.Add(this.endVMTime);
            this.vmTab.Controls.Add(this.startVMTime);
            this.vmTab.Controls.Add(this.metroPanel1);
            this.vmTab.Controls.Add(this.vmMetricsList);
            this.vmTab.Controls.Add(this.metroLabel4);
            this.vmTab.HorizontalScrollbarBarColor = true;
            this.vmTab.HorizontalScrollbarHighlightOnWheel = false;
            this.vmTab.HorizontalScrollbarSize = 10;
            this.vmTab.Location = new System.Drawing.Point(254, 4);
            this.vmTab.Name = "vmTab";
            this.vmTab.Size = new System.Drawing.Size(1076, 645);
            this.vmTab.TabIndex = 4;
            this.vmTab.Text = "Virtual Machines";
            this.vmTab.VerticalScrollbarBarColor = true;
            this.vmTab.VerticalScrollbarHighlightOnWheel = false;
            this.vmTab.VerticalScrollbarSize = 10;
            // 
            // vmChart
            // 
            this.vmChart.Location = new System.Drawing.Point(398, 222);
            this.vmChart.Name = "vmChart";
            this.vmChart.Size = new System.Drawing.Size(659, 398);
            this.vmChart.TabIndex = 23;
            this.vmChart.Text = "vmChart";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(540, 144);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(64, 20);
            this.metroLabel7.TabIndex = 22;
            this.metroLabel7.Text = "End date";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(540, 69);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(68, 20);
            this.metroLabel6.TabIndex = 21;
            this.metroLabel6.Text = "Start date";
            // 
            // endVMTime
            // 
            this.endVMTime.Location = new System.Drawing.Point(534, 170);
            this.endVMTime.MinimumSize = new System.Drawing.Size(0, 30);
            this.endVMTime.Name = "endVMTime";
            this.endVMTime.Size = new System.Drawing.Size(218, 30);
            this.endVMTime.TabIndex = 19;
            this.endVMTime.ValueChanged += new System.EventHandler(this.endVMTime_ValueChanged);
            // 
            // startVMTime
            // 
            this.startVMTime.Location = new System.Drawing.Point(534, 97);
            this.startVMTime.MinimumSize = new System.Drawing.Size(0, 30);
            this.startVMTime.Name = "startVMTime";
            this.startVMTime.Size = new System.Drawing.Size(218, 30);
            this.startVMTime.TabIndex = 18;
            this.startVMTime.ValueChanged += new System.EventHandler(this.startVMTime_ValueChanged);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.percentageCPUchart);
            this.metroPanel1.Controls.Add(this.metroButton3);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.vmChooser);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(15, 30);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(352, 590);
            this.metroPanel1.TabIndex = 17;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(33, 470);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(245, 20);
            this.metroLabel8.TabIndex = 17;
            this.metroLabel8.Text = "Create here to create an alert for CPU";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(91, 133);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(140, 25);
            this.metroLabel5.TabIndex = 15;
            this.metroLabel5.Text = "Percentage CPU";
            // 
            // percentageCPUchart
            // 
            this.percentageCPUchart.Location = new System.Drawing.Point(3, 183);
            this.percentageCPUchart.Name = "percentageCPUchart";
            this.percentageCPUchart.Size = new System.Drawing.Size(331, 213);
            this.percentageCPUchart.TabIndex = 16;
            this.percentageCPUchart.Text = "angularGauge1";
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButton3.DisplayFocus = true;
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton3.Highlight = true;
            this.metroButton3.Location = new System.Drawing.Point(61, 505);
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
            this.metroLabel3.Location = new System.Drawing.Point(27, 22);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(240, 25);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Choose your virtual machine";
            // 
            // vmChooser
            // 
            this.vmChooser.FormattingEnabled = true;
            this.vmChooser.ItemHeight = 24;
            this.vmChooser.Location = new System.Drawing.Point(49, 63);
            this.vmChooser.Name = "vmChooser";
            this.vmChooser.Size = new System.Drawing.Size(229, 30);
            this.vmChooser.TabIndex = 12;
            this.vmChooser.UseSelectable = true;
            this.vmChooser.SelectedIndexChanged += new System.EventHandler(this.vmChooser_SelectedIndexChanged);
            // 
            // vmMetricsList
            // 
            this.vmMetricsList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.vmMetricsList.FullRowSelect = true;
            this.vmMetricsList.Location = new System.Drawing.Point(771, 30);
            this.vmMetricsList.Name = "vmMetricsList";
            this.vmMetricsList.OwnerDraw = true;
            this.vmMetricsList.Size = new System.Drawing.Size(286, 170);
            this.vmMetricsList.Style = MetroFramework.MetroColorStyle.Blue;
            this.vmMetricsList.TabIndex = 14;
            this.vmMetricsList.UseCompatibleStateImageBehavior = false;
            this.vmMetricsList.UseSelectable = true;
            this.vmMetricsList.UseStyleColors = true;
            this.vmMetricsList.SelectedIndexChanged += new System.EventHandler(this.vmMetricsList_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(593, 30);
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
            this.activityLogTab.Size = new System.Drawing.Size(1076, 645);
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
            this.tabHolder.Controls.Add(this.saTab);
            this.tabHolder.Controls.Add(this.vmTab);
            this.tabHolder.Controls.Add(this.operationsTab);
            this.tabHolder.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.tabHolder.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.tabHolder.ItemSize = new System.Drawing.Size(90, 250);
            this.tabHolder.Location = new System.Drawing.Point(8, 81);
            this.tabHolder.Multiline = true;
            this.tabHolder.Name = "tabHolder";
            this.tabHolder.RightToLeftLayout = true;
            this.tabHolder.SelectedIndex = 0;
            this.tabHolder.Size = new System.Drawing.Size(1334, 653);
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
            this.webTab.Size = new System.Drawing.Size(1076, 645);
            this.webTab.TabIndex = 1;
            this.webTab.Text = "Websites";
            this.webTab.UseStyleColors = true;
            this.webTab.VerticalScrollbarBarColor = true;
            this.webTab.VerticalScrollbarHighlightOnWheel = false;
            this.webTab.VerticalScrollbarSize = 10;
            // 
            // webMetricsList
            // 
            this.webMetricsList.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.webMetricsList.FullRowSelect = true;
            this.webMetricsList.Location = new System.Drawing.Point(30, 74);
            this.webMetricsList.Name = "webMetricsList";
            this.webMetricsList.OwnerDraw = true;
            this.webMetricsList.Size = new System.Drawing.Size(229, 401);
            this.webMetricsList.Style = MetroFramework.MetroColorStyle.Blue;
            this.webMetricsList.TabIndex = 9;
            this.webMetricsList.UseCompatibleStateImageBehavior = false;
            this.webMetricsList.UseSelectable = true;
            this.webMetricsList.UseStyleColors = true;
            this.webMetricsList.SelectedIndexChanged += new System.EventHandler(this.webMetricsList_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(653, 11);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(139, 25);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Choose website";
            // 
            // websiteChooser
            // 
            this.websiteChooser.FormattingEnabled = true;
            this.websiteChooser.ItemHeight = 24;
            this.websiteChooser.Location = new System.Drawing.Point(830, 11);
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
            this.metroLabel1.Location = new System.Drawing.Point(30, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(135, 25);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Select a metric";
            // 
            // websiteChart
            // 
            this.websiteChart.Location = new System.Drawing.Point(290, 74);
            this.websiteChart.Name = "websiteChart";
            this.websiteChart.Size = new System.Drawing.Size(783, 529);
            this.websiteChart.TabIndex = 3;
            // 
            // operationsTab
            // 
            this.operationsTab.Controls.Add(this.operationsList);
            this.operationsTab.HorizontalScrollbarBarColor = true;
            this.operationsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.operationsTab.HorizontalScrollbarSize = 10;
            this.operationsTab.Location = new System.Drawing.Point(254, 4);
            this.operationsTab.Name = "operationsTab";
            this.operationsTab.Size = new System.Drawing.Size(1076, 645);
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
            // storageMetricsList
            // 
            this.storageMetricsList.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.storageMetricsList.FullRowSelect = true;
            this.storageMetricsList.Location = new System.Drawing.Point(17, 207);
            this.storageMetricsList.Name = "storageMetricsList";
            this.storageMetricsList.OwnerDraw = true;
            this.storageMetricsList.Size = new System.Drawing.Size(229, 401);
            this.storageMetricsList.Style = MetroFramework.MetroColorStyle.Blue;
            this.storageMetricsList.TabIndex = 15;
            this.storageMetricsList.UseCompatibleStateImageBehavior = false;
            this.storageMetricsList.UseSelectable = true;
            this.storageMetricsList.UseStyleColors = true;
            this.storageMetricsList.SelectedIndexChanged += new System.EventHandler(this.storageMetricsList_SelectedIndexChanged);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.Location = new System.Drawing.Point(17, 13);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(205, 25);
            this.metroLabel9.TabIndex = 14;
            this.metroLabel9.Text = "Choose storage account";
            // 
            // storageAccountChooser
            // 
            this.storageAccountChooser.FormattingEnabled = true;
            this.storageAccountChooser.ItemHeight = 24;
            this.storageAccountChooser.Location = new System.Drawing.Point(17, 67);
            this.storageAccountChooser.Name = "storageAccountChooser";
            this.storageAccountChooser.Size = new System.Drawing.Size(229, 30);
            this.storageAccountChooser.TabIndex = 13;
            this.storageAccountChooser.UseSelectable = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(17, 151);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(135, 25);
            this.metroLabel10.TabIndex = 11;
            this.metroLabel10.Text = "Select a metric";
            // 
            // storageChart
            // 
            this.storageChart.Location = new System.Drawing.Point(269, 13);
            this.storageChart.Name = "storageChart";
            this.storageChart.Size = new System.Drawing.Size(791, 605);
            this.storageChart.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1365, 759);
            this.Controls.Add(this.tabHolder);
            this.Name = "Form1";
            this.Text = "SmartMonitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.saTab.ResumeLayout(false);
            this.saTab.PerformLayout();
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
        private MetroFramework.Controls.MetroTabPage saTab;
        private MetroFramework.Controls.MetroTabPage vmTab;
        private MetroFramework.Controls.MetroTabPage activityLogTab;
        private MetroFramework.Controls.MetroTabControl tabHolder;
        private MetroFramework.Controls.MetroTabPage operationsTab;
        private MetroFramework.Controls.MetroListView operationsList;
        private MetroFramework.Controls.MetroTabPage webTab;
        private LiveCharts.WinForms.CartesianChart websiteChart;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox websiteChooser;
        private MetroFramework.Controls.MetroListView webMetricsList;
        private MetroFramework.Controls.MetroDateTime endVMTime;
        private MetroFramework.Controls.MetroDateTime startVMTime;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private LiveCharts.WinForms.AngularGauge percentageCPUchart;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox vmChooser;
        private MetroFramework.Controls.MetroListView vmMetricsList;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private LiveCharts.WinForms.CartesianChart vmChart;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroListView storageMetricsList;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroComboBox storageAccountChooser;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private LiveCharts.WinForms.CartesianChart storageChart;
    }
}

