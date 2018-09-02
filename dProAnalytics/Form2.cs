using System;
using System.Management;
using System.Windows.Forms;

namespace dProAnalytics {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        public void Form2_Load(object sender, EventArgs e) {
            timer1.Start();
            ManagementScope connectionScope = new ManagementScope();
            SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_SerialPort");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery);

            foreach (ManagementObject item in searcher.Get()){
                string desc = item["Description"].ToString();
                string deviceId = item["DeviceID"].ToString();

                if (desc.Contains("Arduino")){
                    serPort.PortName = deviceId;
                    try { serPort.Open(); }
                    catch {
                        output.Text = "Fehler beim Öffnen des Ports!";
                        break;
                    }
                    output.Text = "´Das gerät ist am Port ''" + deviceId + "'' verbunden";
                }
                else output.Text = "Kein Gerät verbunden...";
            }
        }

        public void ComTest_Click(object sender, EventArgs e) {
            string recieve = "";
            output.Clear();

            try {
                serPort.Write("C");
                System.Threading.Thread.Sleep(2500);
                recieve = serPort.ReadExisting();
            }
            catch (Exception _e) { MessageBox.Show(_e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            output.Text = recieve.ToLower() == "ok" ? "Das Gerät ist ordnungsgemäß angeschlossen!" : "Irgendetwas ist schiefgelaufen..";
        }

        private void ReadRom_Click(object sender, EventArgs e) {
            string recieve = "";
            output.Clear();

            try {
                serPort.Write("D");
                System.Threading.Thread.Sleep(2500);
                recieve = serPort.ReadExisting();
            }
            catch (Exception _e) { MessageBox.Show(_e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            output.Text = recieve;
        }


        private void ClearRom_Click(object sender, EventArgs e) {
            string recieve = "";
            output.Clear();

            if (MessageBox.Show("Sind Sie sicher dass Sie ALLE gespeicherten Daten löschen wollen? Diese können nicht wiederhergestellt werden", "Löschbestätigung", MessageBoxButtons.YesNo) == DialogResult.Yes) {

                try {
                    serPort.Write("D");
                    System.Threading.Thread.Sleep(2500);
                    recieve = serPort.ReadExisting();
                }
                catch (Exception _e) { MessageBox.Show(_e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                output.Text = recieve.ToLower() == "d" ? output.Text = "Das gespeicherte protokoll wurde erfolgreich gelöscht!" : "Irgendetwas ist schiefgelaufen";
            }
            else output.Text = "Löschvorgang erflogreich abgebrochen!";
        }

        private void close_Click(object sender, EventArgs e) {
            serPort.Close(); 
            this.Close();
        }
    }
}