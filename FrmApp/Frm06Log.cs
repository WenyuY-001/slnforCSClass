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
    public partial class Frm06Log : Form
    {
        public bool isOnline = false;

        Dictionary<string, string> usersPass = new Dictionary<string, string>();
        public Frm06Log()
        {
            InitializeComponent();
        }

        public Frm06Log(Frm06Main main)
        {
            InitializeComponent();
            this.MdiParent = main;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
            {
                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("用户名不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxUsername.Focus();
                }
                else
                {
                    MessageBox.Show("密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxPassword.Focus();
                }
            }
            else if (!usersPass.ContainsKey(username))
            {
                MessageBox.Show("用户名和密码均错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxUsername.Focus();
                textBoxUsername.SelectAll();
            }
            else if (usersPass.ContainsKey(username) && password != usersPass[username])
            {
                MessageBox.Show("密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPassword.Focus();
                textBoxPassword.SelectAll();
            }
            else
            {
                MessageBox.Show("登录成功！");
                isOnline = true;
                this.Close();
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm06Log_Load(object sender, EventArgs e)
        {
            this.isOnline = false;
            usersPass.Add("123", "321");
        }
    }
}