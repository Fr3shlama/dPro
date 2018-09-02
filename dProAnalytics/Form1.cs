using System;
using System.IO;
using System.Management;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace dProAnalytics {
    public partial class Form1 : Form {
        public Form1(){
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){
            string port = "";
            ManagementScope connectionScope = new ManagementScope();
            SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_SerialPort");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery);

            foreach (ManagementObject item in searcher.Get()){
                string desc = item["Description"].ToString();
                string deviceId = item["DeviceID"].ToString(); 
                if (desc.Contains("Arduino")) port = deviceId;
            }
        }                                                                                                       

        private void GetData_Click(object sender, EventArgs e){                                       
            ReadFile.Filter = "Trinkprotokoll (*.dp)|*.dp";
            DialogResult result = ReadFile.ShowDialog();
            string file = ReadFile.FileName; 

            try {
                var cur = DateTime.Now;

                chart1.Series[0].XValueType = ChartValueType.DateTime;

                var daten = File.ReadLines(file).Where(
                    zeile => !string.IsNullOrWhiteSpace(zeile)
                ).Select(zeile => 
                    zeile.Split(':')
                ).Select(obj => new {
                    x = (cur).AddMinutes(int.Parse(obj[0]) * 15), y = int.Parse(obj[1])
                }).ToArray();

                chart1.Series[0].XValueMember  = "x";
                chart1.Series[0].YValueMembers = "y";

                /**
                 * ChartAreas[0] => "ChartArea1"
                 */

                chart1.ChartAreas[0].CursorX.IsUserEnabled = false;
                chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = false;

                chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = false;
                chart1.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm";
                chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Minutes;
                chart1.ChartAreas[0].AxisX.Interval = 15;
                chart1.ChartAreas[0].AxisX.Minimum = 0;
                chart1.ChartAreas[0].AxisX.Maximum = daten.Length;
                chart1.ChartAreas[0].AxisX.ScaleView.Zoom(0, 15);
                chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = true;

                chart1.Update();

                chart1.DataSource = daten;
                chart1.DataBind();
            }
            catch { errorbox.Text = "1"; }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e){
            Application.Exit();
        } 

        private void updategraph_Click(object sender, EventArgs e){ 
            chart1.DataBind();
            return;
        }  

        private void bunifuFlatButton1_Click(object sender, EventArgs e){
            var tools = new Form2();
            serPort.Close();
            tools.ShowDialog();         
        }

        private void pictureBox1_Click_1(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://www.dpro.at");
        }
    }
}
