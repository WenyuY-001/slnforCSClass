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
    public partial class Frm06Main : Form
    {
        public Frm06Main()
        {
            InitializeComponent();
            this.Text = "WenyuY的C#开发基础课程实验";
            this.WindowState = FormWindowState.Maximized;
            this.MenuLab06Logout.Enabled = this.toolStripButtonLogout.Enabled = false;
        }
        private bool isOnline = false;

        private void MenuLab06Login_Click(object sender, EventArgs e)
        {
            Frm06Log FrmLogin = new Frm06Log(this);
            FrmLogin.Show();
            isOnline = FrmLogin.isOnline;
            toolStripButtonLogin.Enabled = MenuLab06Login.Enabled = !isOnline;
            toolStripButtonLogout.Enabled = MenuLab06Logout.Enabled = isOnline;
        }

        private void MenuLab06Logout_Click(object sender, EventArgs e)
        {
            isOnline = false;
            toolStripButtonLogin.Enabled = MenuLab06Login.Enabled = !isOnline;
            toolStripButtonLogout.Enabled = MenuLab06Logout.Enabled = isOnline;
        }

        private void MenuLab06Game_Click(object sender, EventArgs e)
        {
            if (isOnline)
            {
                Frm06Game frm06Game = new Frm06Game(this);
                frm06Game.Show();
            }
            else
            {
                MessageBox.Show("请先登录！");
            }
        }

        private void MenuLab07SxAh_Click(object sender, EventArgs e)
        {
            if (isOnline)
            {
                Frm07Sx_Ah frm07Sx_Ah = new Frm07Sx_Ah(this);
                frm07Sx_Ah.Show();
            }
            else
            {
                MessageBox.Show("请先登录！");
            }
        }

        private void MenuLab07Recipes_Click(object sender, EventArgs e)
        {
            if (isOnline)
            {
                Frm07Recipe frm07Recipe = new Frm07Recipe(this);
                frm07Recipe.Show();
            }
            else
            {
                MessageBox.Show("请先登录！");
            }
        }

        private void MenuLab07Addresses_Click(object sender, EventArgs e)
        {
            if (isOnline)
            {
                Frm07AddressBook frm07Address = new Frm07AddressBook(this);
                frm07Address.Show();
            }
            else
            {
                MessageBox.Show("请先登录！");
            }
        }

        private void MenuLab08DoubleColorBall_Click(object sender, EventArgs e)
        {
            if (isOnline)
            {
                Frm08DoubleColorBall frm08DoubleColorBall = new Frm08DoubleColorBall(this);
                frm08DoubleColorBall.Show();
            }
            else
            {
                MessageBox.Show("请先登录！");
            }
        }

        private void MenuLab08Scores_Click(object sender, EventArgs e)
        {
            if (isOnline)
            {
                Frm08Score frm08Score = new Frm08Score(this);
                frm08Score.Show();
            }
            else
            {
                MessageBox.Show("请先登录！");
            }
        }

        private void timer_Now_Tick(object sender, EventArgs e)
        {
            StatusLabelTime.Text = DateTime.Now.ToString("HH:mm:ss");
            //StatusLabelMousePos.Text = $"MousePosition：({MousePosition.X},{MousePosition.Y})";
        }

        private void Frm06Main_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            StatusLabelMousePos.Text = $"MousePosition：({x},{y})";

        }

        private void Frm06Main_MouseHover(object sender, EventArgs e)
        {
            int x = MousePosition.X;
            int y = MousePosition.Y;
            StatusLabelMousePos.Text = $"MousePosition：({x},{y})";
        }
    }
}

