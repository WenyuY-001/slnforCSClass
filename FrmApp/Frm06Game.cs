using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmApp
{
    public partial class Frm06Game : Form
    {
        public Frm06Game()
        {
            InitializeComponent();
        }

        public Frm06Game(Frm06Main main)
        {
            InitializeComponent();
            this.MdiParent = main;
        }

        private Random random = new Random();
        private void RandomLocation()
        {
            int x = random.Next(0, this.ClientSize.Width - comeCatch.Width);
            int y = random.Next(0, this.ClientSize.Height - comeCatch.Height);
            comeCatch.Location = new Point(x, y);
        }
        public bool isCatched = false;
        private void ReLoad()
        {
            isCatched = false;
            BeCatched.Hide();
            comeCatch.Show();
            RandomLocation();
        }

        private void ComeCatch_MouseEnter(object sender, EventArgs e)
        {
            if (!isCatched) { RandomLocation(); }
            else
            {
                comeCatch.Hide();
                BeCatched.Location = comeCatch.Location;
                BeCatched.Show();
            }
        }

        private void Frm06Game_Load(object sender, EventArgs e)
        {
            ReLoad();
        }
        private void Frm06Game_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) { isCatched = true; }
            if (e.Button == MouseButtons.Left) { ReLoad(); }
        }
    }
}
