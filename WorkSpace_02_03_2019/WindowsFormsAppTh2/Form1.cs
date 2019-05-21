using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTh2
{
    public partial class Form1 : Form
    {
        Thread thR; //правий поток
        Thread thL; //левий поток

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            thR = new Thread(() => { while (true) { if (trackBar1.Value < trackBar1.Maximum) trackBar1.Value++; Thread.Sleep(10); } });
            thL = new Thread(() => { while (true) { if (trackBar1.Value > trackBar1.Minimum) trackBar1.Value--; Thread.Sleep(10); } });
            thR.IsBackground = true;
            thL.IsBackground = true;
            thR.Start();
            thL.Start();
            textBoxR.Text = thR.Priority.ToString();
            textBoxL.Text = thL.Priority.ToString();
        }

        private void buttonLM_Click(object sender, EventArgs e)
        {
            thL.Priority--;
            textBoxL.Text = thL.Priority.ToString();
        }

        private void buttonLP_Click(object sender, EventArgs e)
        {
            thL.Priority++;
            textBoxL.Text = thL.Priority.ToString();
        }

        private void buttonRM_Click(object sender, EventArgs e)
        {
            thR.Priority--;
            textBoxR.Text = thR.Priority.ToString();
        }

        private void buttonRP_Click(object sender, EventArgs e)
        {
            thR.Priority++;
            textBoxR.Text = thR.Priority.ToString();
        }
    }
}
