using System.Runtime.CompilerServices;

namespace FrmApp
{
    partial class Frm06Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm06Main));
            menuStrip1 = new MenuStrip();
            MenuLab06 = new ToolStripMenuItem();
            MenuLab06Login = new ToolStripMenuItem();
            MenuLab06Logout = new ToolStripMenuItem();
            MenuLab06Game = new ToolStripMenuItem();
            MenuLab07 = new ToolStripMenuItem();
            MenuLab07SxAh = new ToolStripMenuItem();
            MenuLab07Recipes = new ToolStripMenuItem();
            MenuLab07Addresses = new ToolStripMenuItem();
            MenuLab08 = new ToolStripMenuItem();
            MenuLab08DoubleColorBall = new ToolStripMenuItem();
            MenuLab08Scores = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            StatusLabelAuthor = new ToolStripStatusLabel();
            StatusLabelMousePos = new ToolStripStatusLabel();
            StatusLabelTime = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            toolStripButtonLogin = new ToolStripButton();
            toolStripButtonLogout = new ToolStripButton();
            toolStripButtonGame = new ToolStripButton();
            toolStripButtonSxAh = new ToolStripButton();
            toolStripButtonRecipes = new ToolStripButton();
            toolStripButtonAddress = new ToolStripButton();
            toolStripButtonDCB = new ToolStripButton();
            toolStripButtonScore = new ToolStripButton();
            timer_Now = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuLab06, MenuLab07, MenuLab08 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 25);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuLab06
            // 
            MenuLab06.DropDownItems.AddRange(new ToolStripItem[] { MenuLab06Login, MenuLab06Logout, MenuLab06Game });
            MenuLab06.Name = "MenuLab06";
            MenuLab06.Size = new Size(56, 21);
            MenuLab06.Text = "实验六";
            // 
            // MenuLab06Login
            // 
            MenuLab06Login.Name = "MenuLab06Login";
            MenuLab06Login.Size = new Size(112, 22);
            MenuLab06Login.Text = "登录";
            MenuLab06Login.Click += MenuLab06Login_Click;
            // 
            // MenuLab06Logout
            // 
            MenuLab06Logout.Name = "MenuLab06Logout";
            MenuLab06Logout.Size = new Size(112, 22);
            MenuLab06Logout.Text = "登出";
            MenuLab06Logout.Click += MenuLab06Logout_Click;
            // 
            // MenuLab06Game
            // 
            MenuLab06Game.Name = "MenuLab06Game";
            MenuLab06Game.Size = new Size(112, 22);
            MenuLab06Game.Text = "来抓我";
            MenuLab06Game.Click += MenuLab06Game_Click;
            // 
            // MenuLab07
            // 
            MenuLab07.DropDownItems.AddRange(new ToolStripItem[] { MenuLab07SxAh, MenuLab07Recipes, MenuLab07Addresses });
            MenuLab07.Name = "MenuLab07";
            MenuLab07.Size = new Size(56, 21);
            MenuLab07.Text = "实验七";
            // 
            // MenuLab07SxAh
            // 
            MenuLab07SxAh.Name = "MenuLab07SxAh";
            MenuLab07SxAh.Size = new Size(124, 22);
            MenuLab07SxAh.Text = "生肖爱好";
            MenuLab07SxAh.Click += MenuLab07SxAh_Click;
            // 
            // MenuLab07Recipes
            // 
            MenuLab07Recipes.Name = "MenuLab07Recipes";
            MenuLab07Recipes.Size = new Size(124, 22);
            MenuLab07Recipes.Text = "电子菜单";
            MenuLab07Recipes.Click += MenuLab07Recipes_Click;
            // 
            // MenuLab07Addresses
            // 
            MenuLab07Addresses.Name = "MenuLab07Addresses";
            MenuLab07Addresses.Size = new Size(124, 22);
            MenuLab07Addresses.Text = "通讯录";
            MenuLab07Addresses.Click += MenuLab07Addresses_Click;
            // 
            // MenuLab08
            // 
            MenuLab08.DropDownItems.AddRange(new ToolStripItem[] { MenuLab08DoubleColorBall, MenuLab08Scores });
            MenuLab08.Name = "MenuLab08";
            MenuLab08.Size = new Size(56, 21);
            MenuLab08.Text = "实验八";
            // 
            // MenuLab08DoubleColorBall
            // 
            MenuLab08DoubleColorBall.Name = "MenuLab08DoubleColorBall";
            MenuLab08DoubleColorBall.Size = new Size(124, 22);
            MenuLab08DoubleColorBall.Text = "双色球";
            MenuLab08DoubleColorBall.Click += MenuLab08DoubleColorBall_Click;
            // 
            // MenuLab08Scores
            // 
            MenuLab08Scores.Name = "MenuLab08Scores";
            MenuLab08Scores.Size = new Size(124, 22);
            MenuLab08Scores.Text = "学生成绩";
            MenuLab08Scores.Click += MenuLab08Scores_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { StatusLabelAuthor, StatusLabelMousePos, StatusLabelTime });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabelAuthor
            // 
            StatusLabelAuthor.Name = "StatusLabelAuthor";
            StatusLabelAuthor.Size = new Size(261, 17);
            StatusLabelAuthor.Spring = true;
            StatusLabelAuthor.Text = "作者：WenyuY";
            // 
            // StatusLabelMousePos
            // 
            StatusLabelMousePos.Name = "StatusLabelMousePos";
            StatusLabelMousePos.Size = new Size(261, 17);
            StatusLabelMousePos.Spring = true;
            StatusLabelMousePos.Text = "MousePosition：(0,0)";
            // 
            // StatusLabelTime
            // 
            StatusLabelTime.Name = "StatusLabelTime";
            StatusLabelTime.Size = new Size(261, 17);
            StatusLabelTime.Spring = true;
            StatusLabelTime.Text = "00:00:00";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonLogin, toolStripButtonLogout, toolStripButtonGame, toolStripButtonSxAh, toolStripButtonRecipes, toolStripButtonAddress, toolStripButtonDCB, toolStripButtonScore });
            toolStrip1.Location = new Point(0, 25);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonLogin
            // 
            toolStripButtonLogin.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonLogin.ImageTransparentColor = Color.Magenta;
            toolStripButtonLogin.Name = "toolStripButtonLogin";
            toolStripButtonLogin.Size = new Size(36, 22);
            toolStripButtonLogin.Text = "登录";
            toolStripButtonLogin.Click += MenuLab06Login_Click;
            // 
            // toolStripButtonLogout
            // 
            toolStripButtonLogout.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonLogout.Image = (Image)resources.GetObject("toolStripButtonLogout.Image");
            toolStripButtonLogout.ImageTransparentColor = Color.Magenta;
            toolStripButtonLogout.Name = "toolStripButtonLogout";
            toolStripButtonLogout.Size = new Size(36, 22);
            toolStripButtonLogout.Text = "登出";
            toolStripButtonLogout.Click += MenuLab06Logout_Click;
            // 
            // toolStripButtonGame
            // 
            toolStripButtonGame.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonGame.Image = (Image)resources.GetObject("toolStripButtonGame.Image");
            toolStripButtonGame.ImageTransparentColor = Color.Magenta;
            toolStripButtonGame.Name = "toolStripButtonGame";
            toolStripButtonGame.Size = new Size(48, 22);
            toolStripButtonGame.Text = "来抓我";
            toolStripButtonGame.Click += MenuLab06Game_Click;
            // 
            // toolStripButtonSxAh
            // 
            toolStripButtonSxAh.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonSxAh.Image = (Image)resources.GetObject("toolStripButtonSxAh.Image");
            toolStripButtonSxAh.ImageTransparentColor = Color.Magenta;
            toolStripButtonSxAh.Name = "toolStripButtonSxAh";
            toolStripButtonSxAh.Size = new Size(60, 22);
            toolStripButtonSxAh.Text = "生肖爱好";
            toolStripButtonSxAh.Click += MenuLab07SxAh_Click;
            // 
            // toolStripButtonRecipes
            // 
            toolStripButtonRecipes.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonRecipes.Image = (Image)resources.GetObject("toolStripButtonRecipes.Image");
            toolStripButtonRecipes.ImageTransparentColor = Color.Magenta;
            toolStripButtonRecipes.Name = "toolStripButtonRecipes";
            toolStripButtonRecipes.Size = new Size(60, 22);
            toolStripButtonRecipes.Text = "电子菜单";
            toolStripButtonRecipes.Click += MenuLab07Recipes_Click;
            // 
            // toolStripButtonAddress
            // 
            toolStripButtonAddress.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonAddress.Image = (Image)resources.GetObject("toolStripButtonAddress.Image");
            toolStripButtonAddress.ImageTransparentColor = Color.Magenta;
            toolStripButtonAddress.Name = "toolStripButtonAddress";
            toolStripButtonAddress.Size = new Size(48, 22);
            toolStripButtonAddress.Text = "通讯录";
            toolStripButtonAddress.Click += MenuLab07Addresses_Click;
            // 
            // toolStripButtonDCB
            // 
            toolStripButtonDCB.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonDCB.ImageTransparentColor = Color.Magenta;
            toolStripButtonDCB.Name = "toolStripButtonDCB";
            toolStripButtonDCB.Size = new Size(48, 22);
            toolStripButtonDCB.Text = "双色球";
            toolStripButtonDCB.Click += MenuLab08DoubleColorBall_Click;
            // 
            // toolStripButtonScore
            // 
            toolStripButtonScore.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonScore.ImageTransparentColor = Color.Magenta;
            toolStripButtonScore.Name = "toolStripButtonScore";
            toolStripButtonScore.Size = new Size(60, 22);
            toolStripButtonScore.Text = "学生成绩";
            toolStripButtonScore.ToolTipText = "学生成绩";
            toolStripButtonScore.Click += MenuLab08Scores_Click;
            // 
            // timer_Now
            // 
            timer_Now.Enabled = true;
            timer_Now.Interval = 1000;
            timer_Now.Tick += timer_Now_Tick;
            // 
            // Frm06Main
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Frm06Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            MouseHover += Frm06Main_MouseHover;
            MouseMove += Frm06Main_MouseMove;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuLab06;
        private ToolStripMenuItem MenuLab06Login;
        private ToolStripMenuItem MenuLab06Logout;
        private ToolStripMenuItem MenuLab07;
        private ToolStripMenuItem MenuLab07SxAh;
        private ToolStripMenuItem MenuLab08;
        private ToolStripMenuItem MenuLab08DoubleColorBall;
        private ToolStripMenuItem MenuLab08Scores;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel StatusLabelAuthor;
        private ToolStripStatusLabel StatusLabelMousePos;
        private ToolStripStatusLabel StatusLabelTime;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonLogin;
        private ToolStripButton toolStripButtonGame;
        private ToolStripButton toolStripButtonSxAh;
        private ToolStripButton toolStripButtonRecipes;
        private ToolStripButton toolStripButtonAddress;
        private ToolStripButton toolStripButtonDCB;
        private ToolStripButton toolStripButtonScore;
        private ToolStripMenuItem MenuLab06Game;
        private ToolStripMenuItem MenuLab07Recipes;
        private ToolStripMenuItem MenuLab07Addresses;
        private ToolStripButton toolStripButtonLogout;
        private System.Windows.Forms.Timer timer_Now;
    }
}