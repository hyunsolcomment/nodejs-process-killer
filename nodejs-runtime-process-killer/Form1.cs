using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace nodejs_runtime_process_killer {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            int count = 0;
            foreach(var process in Process.GetProcessesByName("node")) {
                process.Kill();
                count++;
            }

            label1.Text = $"총 {count.ToString()}개의 프로세스를 종료헀어요.";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            this.TopMost = checkBox1.Checked;
        }
    }
}
