namespace Task_Manager
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBarRAM = new MetroFramework.Controls.MetroProgressBar();
            this.lblRAM = new MetroFramework.Controls.MetroLabel();
            this.cpuChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Tabs = new MetroFramework.Controls.MetroTabControl();
            this.cpuTab = new MetroFramework.Controls.MetroTabPage();
            this.lblCPU_ = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBarCPU = new MetroFramework.Controls.MetroProgressBar();
            this.ramTab = new MetroFramework.Controls.MetroTabPage();
            this.ramChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.processesTab = new MetroFramework.Controls.MetroTabPage();
            this.processListbox = new System.Windows.Forms.ListBox();
            this.reloadButton = new MetroFramework.Controls.MetroButton();
            this.stopButton = new MetroFramework.Controls.MetroButton();
            this.startProcessButton = new MetroFramework.Controls.MetroButton();
            this.userProcessName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).BeginInit();
            this.Tabs.SuspendLayout();
            this.cpuTab.SuspendLayout();
            this.ramTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ramChart)).BeginInit();
            this.processesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(-4, 3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "RAM: ";
            // 
            // metroProgressBarRAM
            // 
            this.metroProgressBarRAM.Location = new System.Drawing.Point(47, 3);
            this.metroProgressBarRAM.Name = "metroProgressBarRAM";
            this.metroProgressBarRAM.Size = new System.Drawing.Size(75, 20);
            this.metroProgressBarRAM.TabIndex = 3;
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Location = new System.Drawing.Point(128, 4);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(27, 19);
            this.lblRAM.TabIndex = 5;
            this.lblRAM.Text = "0%";
            // 
            // cpuChart
            // 
            chartArea1.Name = "ChartArea1";
            this.cpuChart.ChartAreas.Add(chartArea1);
            this.cpuChart.Location = new System.Drawing.Point(-4, 25);
            this.cpuChart.Name = "cpuChart";
            this.cpuChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series1.YValuesPerPoint = 10;
            this.cpuChart.Series.Add(series1);
            this.cpuChart.Size = new System.Drawing.Size(411, 209);
            this.cpuChart.TabIndex = 6;
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.cpuTab);
            this.Tabs.Controls.Add(this.ramTab);
            this.Tabs.Controls.Add(this.processesTab);
            this.Tabs.Location = new System.Drawing.Point(23, 48);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 2;
            this.Tabs.Size = new System.Drawing.Size(423, 263);
            this.Tabs.TabIndex = 7;
            this.Tabs.UseSelectable = true;
            // 
            // cpuTab
            // 
            this.cpuTab.Controls.Add(this.cpuChart);
            this.cpuTab.Controls.Add(this.lblCPU_);
            this.cpuTab.Controls.Add(this.metroLabel3);
            this.cpuTab.Controls.Add(this.metroProgressBarCPU);
            this.cpuTab.HorizontalScrollbarBarColor = true;
            this.cpuTab.HorizontalScrollbarHighlightOnWheel = false;
            this.cpuTab.HorizontalScrollbarSize = 10;
            this.cpuTab.Location = new System.Drawing.Point(4, 38);
            this.cpuTab.Name = "cpuTab";
            this.cpuTab.Size = new System.Drawing.Size(415, 221);
            this.cpuTab.TabIndex = 0;
            this.cpuTab.Text = "CPU";
            this.cpuTab.VerticalScrollbarBarColor = true;
            this.cpuTab.VerticalScrollbarHighlightOnWheel = false;
            this.cpuTab.VerticalScrollbarSize = 10;
            // 
            // lblCPU_
            // 
            this.lblCPU_.AutoSize = true;
            this.lblCPU_.Location = new System.Drawing.Point(127, 3);
            this.lblCPU_.Name = "lblCPU_";
            this.lblCPU_.Size = new System.Drawing.Size(27, 19);
            this.lblCPU_.TabIndex = 9;
            this.lblCPU_.Text = "0%";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(-4, 3);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(42, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "CPU: ";
            // 
            // metroProgressBarCPU
            // 
            this.metroProgressBarCPU.Location = new System.Drawing.Point(44, 3);
            this.metroProgressBarCPU.Name = "metroProgressBarCPU";
            this.metroProgressBarCPU.Size = new System.Drawing.Size(75, 20);
            this.metroProgressBarCPU.TabIndex = 1;
            // 
            // ramTab
            // 
            this.ramTab.Controls.Add(this.ramChart);
            this.ramTab.Controls.Add(this.lblRAM);
            this.ramTab.Controls.Add(this.metroProgressBarRAM);
            this.ramTab.Controls.Add(this.metroLabel2);
            this.ramTab.HorizontalScrollbarBarColor = true;
            this.ramTab.HorizontalScrollbarHighlightOnWheel = false;
            this.ramTab.HorizontalScrollbarSize = 10;
            this.ramTab.Location = new System.Drawing.Point(4, 38);
            this.ramTab.Name = "ramTab";
            this.ramTab.Size = new System.Drawing.Size(415, 221);
            this.ramTab.TabIndex = 1;
            this.ramTab.Text = "RAM";
            this.ramTab.VerticalScrollbarBarColor = true;
            this.ramTab.VerticalScrollbarHighlightOnWheel = false;
            this.ramTab.VerticalScrollbarSize = 10;
            // 
            // ramChart
            // 
            chartArea2.Name = "ChartArea1";
            this.ramChart.ChartAreas.Add(chartArea2);
            this.ramChart.Location = new System.Drawing.Point(0, 26);
            this.ramChart.Name = "ramChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            this.ramChart.Series.Add(series2);
            this.ramChart.Size = new System.Drawing.Size(419, 199);
            this.ramChart.TabIndex = 6;
            this.ramChart.Text = "chart2";
            // 
            // processesTab
            // 
            this.processesTab.Controls.Add(this.processListbox);
            this.processesTab.Controls.Add(this.reloadButton);
            this.processesTab.Controls.Add(this.stopButton);
            this.processesTab.Controls.Add(this.startProcessButton);
            this.processesTab.Controls.Add(this.userProcessName);
            this.processesTab.Controls.Add(this.metroLabel1);
            this.processesTab.HorizontalScrollbarBarColor = true;
            this.processesTab.HorizontalScrollbarHighlightOnWheel = false;
            this.processesTab.HorizontalScrollbarSize = 10;
            this.processesTab.Location = new System.Drawing.Point(4, 38);
            this.processesTab.Name = "processesTab";
            this.processesTab.Size = new System.Drawing.Size(415, 221);
            this.processesTab.TabIndex = 2;
            this.processesTab.Text = "Processes";
            this.processesTab.VerticalScrollbarBarColor = true;
            this.processesTab.VerticalScrollbarHighlightOnWheel = false;
            this.processesTab.VerticalScrollbarSize = 10;
            // 
            // processListbox
            // 
            this.processListbox.FormattingEnabled = true;
            this.processListbox.Location = new System.Drawing.Point(0, 26);
            this.processListbox.Name = "processListbox";
            this.processListbox.Size = new System.Drawing.Size(419, 160);
            this.processListbox.TabIndex = 8;
            // 
            // reloadButton
            // 
            this.reloadButton.Location = new System.Drawing.Point(237, 4);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(75, 20);
            this.reloadButton.TabIndex = 7;
            this.reloadButton.Text = "Reload";
            this.reloadButton.UseSelectable = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(318, 4);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 20);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "Stop";
            this.stopButton.UseSelectable = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startProcessButton
            // 
            this.startProcessButton.Location = new System.Drawing.Point(156, 4);
            this.startProcessButton.Name = "startProcessButton";
            this.startProcessButton.Size = new System.Drawing.Size(75, 20);
            this.startProcessButton.TabIndex = 4;
            this.startProcessButton.Text = "Start";
            this.startProcessButton.UseSelectable = true;
            this.startProcessButton.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // userProcessName
            // 
            // 
            // 
            // 
            this.userProcessName.CustomButton.Image = null;
            this.userProcessName.CustomButton.Location = new System.Drawing.Point(69, 2);
            this.userProcessName.CustomButton.Name = "";
            this.userProcessName.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.userProcessName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userProcessName.CustomButton.TabIndex = 1;
            this.userProcessName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userProcessName.CustomButton.UseSelectable = true;
            this.userProcessName.CustomButton.Visible = false;
            this.userProcessName.Lines = new string[0];
            this.userProcessName.Location = new System.Drawing.Point(63, 4);
            this.userProcessName.MaxLength = 32767;
            this.userProcessName.Name = "userProcessName";
            this.userProcessName.PasswordChar = '\0';
            this.userProcessName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userProcessName.SelectedText = "";
            this.userProcessName.SelectionLength = 0;
            this.userProcessName.SelectionStart = 0;
            this.userProcessName.ShortcutsEnabled = true;
            this.userProcessName.Size = new System.Drawing.Size(87, 20);
            this.userProcessName.TabIndex = 3;
            this.userProcessName.UseSelectable = true;
            this.userProcessName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userProcessName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 4);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Launch:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 315);
            this.Controls.Add(this.Tabs);
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).EndInit();
            this.Tabs.ResumeLayout(false);
            this.cpuTab.ResumeLayout(false);
            this.cpuTab.PerformLayout();
            this.ramTab.ResumeLayout(false);
            this.ramTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ramChart)).EndInit();
            this.processesTab.ResumeLayout(false);
            this.processesTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarRAM;
        private MetroFramework.Controls.MetroLabel lblRAM;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuChart;
        private MetroFramework.Controls.MetroTabControl Tabs;
        private MetroFramework.Controls.MetroLabel lblCPU;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarCPU;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblCPU_;
        private MetroFramework.Controls.MetroTabPage cpuTab;
        private MetroFramework.Controls.MetroTabPage ramTab;
        private System.Windows.Forms.DataVisualization.Charting.Chart ramChart;
        private MetroFramework.Controls.MetroTabPage processesTab;
        private MetroFramework.Controls.MetroTextBox userProcessName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton startProcessButton;
        private MetroFramework.Controls.MetroButton stopButton;
        private MetroFramework.Controls.MetroButton reloadButton;
        private System.Windows.Forms.ListBox processListbox;
    }
}

