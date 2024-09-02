namespace FrmApp
{
    partial class Frm06Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm06Game));
            comeCatch = new Label();
            BeCatched = new Label();
            SuspendLayout();
            // 
            // comeCatch
            // 
            comeCatch.Image = (Image)resources.GetObject("comeCatch.Image");
            comeCatch.ImageAlign = ContentAlignment.TopCenter;
            comeCatch.Location = new Point(200, 125);
            comeCatch.Name = "comeCatch";
            comeCatch.Size = new Size(45, 50);
            comeCatch.TabIndex = 1;
            comeCatch.Text = "\r\n\r\n来抓我\r\n";
            comeCatch.MouseEnter += ComeCatch_MouseEnter;
            // 
            // BeCatched
            // 
            BeCatched.Image = (Image)resources.GetObject("BeCatched.Image");
            BeCatched.ImageAlign = ContentAlignment.TopCenter;
            BeCatched.Location = new Point(618, 91);
            BeCatched.Name = "BeCatched";
            BeCatched.Size = new Size(68, 53);
            BeCatched.TabIndex = 2;
            BeCatched.Text = "\r\n\r\n你抓到我了";
            // 
            // Frm06Game
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BeCatched);
            Controls.Add(comeCatch);
            Name = "Frm06Game";
            Text = "Game:来抓我";
            Load += Frm06Game_Load;
            MouseDoubleClick += Frm06Game_MouseDoubleClick;
            ResumeLayout(false);
        }

        #endregion
        private Label comeCatch;
        private Label BeCatched;
    }
}