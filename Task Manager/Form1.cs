using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace Task_Manager
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        PerformanceCounter perfCPUCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        PerformanceCounter perfRAMCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");
        private Thread cputThread;
        const int arraySize = 30;
        private double[] cpuArray = new double[arraySize];
        private double[] ramArray = new double[arraySize];
        private Process[] process;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
            GetProcesses();
            cputThread = new Thread(new ThreadStart(this.getPerformanceCounters));
            cputThread.IsBackground = true;
            cputThread.Start();

            Tabs.SelectedTab = cpuTab;
        }

        private void GetProcesses()
        {
            processListbox.Items.Clear();
            process = Process.GetProcesses();
            for(int i=0;i<process.Length; i++)
            {
                processListbox.Items.Add(process[i].ProcessName);
            }
            processListbox.Sorted = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            double cpuValue = perfCPUCounter.NextValue();
            double ramValue = perfRAMCounter.NextValue();
            lblCPU_.Text = String.Format("{0:0}%", cpuValue);
            lblRAM.Text = String.Format("{0:0}%", ramValue);
            metroProgressBarCPU.Value = (int)cpuValue;
            metroProgressBarRAM.Value = (int)ramValue;
        }

        private void UpdateCpuChart()
        {
            cpuChart.Series["CPU"].Points.Clear();
            ramChart.Series["RAM"].Points.Clear();
            for (int i = 0; i < cpuArray.Length - 1; i++)
            {
                cpuChart.Series["CPU"].Points.AddY(cpuArray[i]);
                ramChart.Series["RAM"].Points.AddY(ramArray[i]);
            }
        }

        private void getPerformanceCounters()
        {
            while (true)
            {
                cpuArray[cpuArray.Length - 1] = Math.Round(perfCPUCounter.NextValue());
                ramArray[ramArray.Length - 1] = Math.Round(perfRAMCounter.NextValue());

                Array.Copy(cpuArray, 1, cpuArray, 0, cpuArray.Length - 1);
                Array.Copy(ramArray, 1, ramArray, 0, ramArray.Length - 1);

                if (cpuChart.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate {
                        UpdateCpuChart();
                    });
                }
                Thread.Sleep(1000);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string processName = userProcessName.Text;
            Process process = new Process();
            process.StartInfo.FileName = processName;

            try
            { process.Start(); }
            catch
            { MessageBox.Show("Invalid entry");}

            GetProcesses();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            foreach (Process p in Process.GetProcessesByName(processListbox.Text))
            {
                p.Kill();
            }
            GetProcesses();
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            GetProcesses();
        }
    }
}
