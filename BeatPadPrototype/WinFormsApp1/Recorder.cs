using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Recorder : Form
    {
        private AudioRecorder recorder;
        private Array listOfDevices;

        public Recorder()
        {
            InitializeComponent();
            this.recorder = new AudioRecorder();
            this.listOfDevices = this.recorder.LoadDevices();
            devices.Items.AddRange((object[]) this.listOfDevices);
            devices.SelectedIndex = 0
        }

        private void recordButton_Click(object sender, EventArgs e)
        {

        }
    }
}
