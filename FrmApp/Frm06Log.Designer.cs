namespace FrmApp
{
    partial class Frm06Log
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
            buttonLogin = new Button();
            buttonCancel = new Button();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonLogin.Location = new Point(280, 176);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(90, 40);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonCancel.Location = new Point(394, 176);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(90, 40);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUsername.Location = new Point(284, 100);
            textBoxUsername.MaxLength = 10;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(200, 23);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.Location = new Point(284, 138);
            textBoxPassword.MaxLength = 10;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(200, 23);
            textBoxPassword.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(211, 103);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 141);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // Frm06Log
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(buttonCancel);
            Controls.Add(buttonLogin);
            Name = "Frm06Log";
            Text = "Login";
            Load += Frm06Log_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private Button buttonCancel;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label label1;
        private Label label2;
    }
}