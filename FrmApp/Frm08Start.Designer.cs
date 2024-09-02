namespace FrmApp
{
    partial class Frm08Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm08Start));
            timerStartFrm = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // timerStartFrm
            // 
            timerStartFrm.Enabled = true;
            timerStartFrm.Interval = 3000;
            timerStartFrm.Tick += TimerStartFrm_Tick;
            // 
            // Frm08Start
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 400);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm08Start";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Frm08Start_Load;
            ResumeLayout(false);
        }



        #endregion

        private System.Windows.Forms.Timer timerStartFrm;
    }
}