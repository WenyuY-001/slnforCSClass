namespace FrmApp
{
    partial class Frm08DoubleColorBall
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
            textRed1 = new TextBox();
            textRed2 = new TextBox();
            textRed3 = new TextBox();
            textRed4 = new TextBox();
            textRed5 = new TextBox();
            textRed6 = new TextBox();
            textBlue = new TextBox();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // textRed1
            // 
            textRed1.Font = new Font("微软雅黑", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textRed1.ForeColor = Color.Red;
            textRed1.Location = new Point(3, 42);
            textRed1.Name = "textRed1";
            textRed1.Size = new Size(35, 35);
            textRed1.TabIndex = 0;
            // 
            // textRed2
            // 
            textRed2.Font = new Font("微软雅黑", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textRed2.ForeColor = Color.Red;
            textRed2.Location = new Point(44, 42);
            textRed2.Name = "textRed2";
            textRed2.Size = new Size(35, 35);
            textRed2.TabIndex = 1;
            // 
            // textRed3
            // 
            textRed3.Font = new Font("微软雅黑", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textRed3.ForeColor = Color.Red;
            textRed3.Location = new Point(85, 42);
            textRed3.Name = "textRed3";
            textRed3.Size = new Size(35, 35);
            textRed3.TabIndex = 2;
            // 
            // textRed4
            // 
            textRed4.Font = new Font("微软雅黑", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textRed4.ForeColor = Color.Red;
            textRed4.Location = new Point(126, 42);
            textRed4.Name = "textRed4";
            textRed4.Size = new Size(35, 35);
            textRed4.TabIndex = 3;
            // 
            // textRed5
            // 
            textRed5.Font = new Font("微软雅黑", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textRed5.ForeColor = Color.Red;
            textRed5.Location = new Point(167, 42);
            textRed5.Name = "textRed5";
            textRed5.Size = new Size(35, 35);
            textRed5.TabIndex = 4;
            // 
            // textRed6
            // 
            textRed6.Font = new Font("微软雅黑", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textRed6.ForeColor = Color.Red;
            textRed6.Location = new Point(208, 42);
            textRed6.Name = "textRed6";
            textRed6.Size = new Size(35, 35);
            textRed6.TabIndex = 5;
            // 
            // textBlue
            // 
            textBlue.Font = new Font("微软雅黑", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBlue.ForeColor = Color.Blue;
            textBlue.Location = new Point(249, 42);
            textBlue.Name = "textBlue";
            textBlue.Size = new Size(35, 35);
            textBlue.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(107, 111);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "开始";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Frm08DoubleColorBall
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 161);
            Controls.Add(button1);
            Controls.Add(textBlue);
            Controls.Add(textRed6);
            Controls.Add(textRed5);
            Controls.Add(textRed4);
            Controls.Add(textRed3);
            Controls.Add(textRed2);
            Controls.Add(textRed1);
            Name = "Frm08DoubleColorBall";
            StartPosition = FormStartPosition.Manual;
            Text = "双色球";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textRed1;
        private TextBox textRed2;
        private TextBox textRed3;
        private TextBox textRed4;
        private TextBox textRed5;
        private TextBox textRed6;
        private TextBox textBlue;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}