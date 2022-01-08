using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arduino
{
    public partial class Arduino : Form
    {
        public string port;

        public Arduino()
        {
            InitializeComponent();
            COM.Text = "Nie wybrano portu";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = port;
            serialPort1.Open();
            Info.Text = "Opened";
        }

        private void Info_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cOM1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            port = "COM1";
            COM.Text = port;
        }

        private void cOM2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            port = "COM2";
            COM.Text = port;
        }

        private void cOM3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            port = "COM3";
            COM.Text = port;
        }

        private void cOM4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            port = "COM4";
            COM.Text = port;
        }

        private void cOM5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            port = "COM5";
            COM.Text = port;
        }

        private void cOM6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            port = "COM6";
            COM.Text = port;
        }

        private void cOM7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            port = "COM7";
            COM.Text = port;
        }

        private void cOM8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            port = "COM8";
            COM.Text = port;
        }

        private void cOM9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            port = "COM9";
            COM.Text = port;
        }

        private void cOM10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            port = "COM10";
            COM.Text = port;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("0");
        }

        
    }
}
