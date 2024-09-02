using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmApp
{
    public partial class Frm08DoubleColorBall : Form
    {
        public Frm08DoubleColorBall()
        {
            InitializeComponent();
        }
        public Frm08DoubleColorBall(Frm06Main parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
        }
        Random rd = new Random();
        private void random_DCB()
        {
            textRed1.Text = rd.Next(0, 34).ToString("00");
            textRed2.Text = rd.Next(0, 34).ToString("00");
            textRed3.Text = rd.Next(0, 34).ToString("00");
            textRed4.Text = rd.Next(0, 34).ToString("00");
            textRed5.Text = rd.Next(0, 34).ToString("00");
            textRed6.Text = rd.Next(0, 34).ToString("00");
            textBlue.Text = rd.Next(0, 17).ToString("00");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "开始")
            {
                button1.Text = "停止";
                timer1.Enabled = true;
            }
            else if (button1.Text == "停止")
            {
                button1.Text = "开始";
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            random_DCB();
        }
    }
}
