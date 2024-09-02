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
    public partial class Frm08Start : Form
    {
        public Frm08Start()
        {
            InitializeComponent();
        }

        private void Frm08Start_Load(object sender, EventArgs e)
        {
            timerStartFrm.Start();
        }
        private void TimerStartFrm_Tick(object sender, EventArgs e)
        {
            timerStartFrm.Stop();
            this.Close();
        }
    }
}
