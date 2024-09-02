namespace FrmApp
{
    partial class Frm07AddressBook
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
            label_Name = new Label();
            label_Num = new Label();
            label_Yo = new Label();
            label_Fz = new Label();
            comboBox_Name = new ComboBox();
            textBox_Num = new TextBox();
            textBox_Yo = new TextBox();
            textBox_Fz = new TextBox();
            button_Add = new Button();
            button_Change = new Button();
            button_Remove = new Button();
            textBox_Name = new TextBox();
            SuspendLayout();
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(287, 75);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(32, 17);
            label_Name.TabIndex = 0;
            label_Name.Text = "姓名";
            // 
            // label_Num
            // 
            label_Num.AutoSize = true;
            label_Num.Location = new Point(263, 129);
            label_Num.Name = "label_Num";
            label_Num.Size = new Size(56, 17);
            label_Num.TabIndex = 1;
            label_Num.Text = "手机号码";
            // 
            // label_Yo
            // 
            label_Yo.AutoSize = true;
            label_Yo.Location = new Point(287, 179);
            label_Yo.Name = "label_Yo";
            label_Yo.Size = new Size(32, 17);
            label_Yo.TabIndex = 2;
            label_Yo.Text = "年龄";
            // 
            // label_Fz
            // 
            label_Fz.AutoSize = true;
            label_Fz.Location = new Point(287, 227);
            label_Fz.Name = "label_Fz";
            label_Fz.Size = new Size(32, 17);
            label_Fz.TabIndex = 3;
            label_Fz.Text = "分组";
            // 
            // comboBox_Name
            // 
            comboBox_Name.FormattingEnabled = true;
            comboBox_Name.Location = new Point(325, 72);
            comboBox_Name.Name = "comboBox_Name";
            comboBox_Name.Size = new Size(121, 25);
            comboBox_Name.TabIndex = 4;
            comboBox_Name.SelectedIndexChanged += comboBox_Name_SelectedIndexChanged;
            // 
            // textBox_Num
            // 
            textBox_Num.Location = new Point(325, 126);
            textBox_Num.Name = "textBox_Num";
            textBox_Num.ReadOnly = true;
            textBox_Num.Size = new Size(121, 23);
            textBox_Num.TabIndex = 5;
            // 
            // textBox_Yo
            // 
            textBox_Yo.Location = new Point(325, 173);
            textBox_Yo.Name = "textBox_Yo";
            textBox_Yo.ReadOnly = true;
            textBox_Yo.Size = new Size(121, 23);
            textBox_Yo.TabIndex = 6;
            // 
            // textBox_Fz
            // 
            textBox_Fz.Location = new Point(325, 221);
            textBox_Fz.Name = "textBox_Fz";
            textBox_Fz.ReadOnly = true;
            textBox_Fz.Size = new Size(121, 23);
            textBox_Fz.TabIndex = 7;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(501, 123);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(75, 23);
            button_Add.TabIndex = 8;
            button_Add.Text = "添加";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // button_Change
            // 
            button_Change.Location = new Point(501, 176);
            button_Change.Name = "button_Change";
            button_Change.Size = new Size(75, 23);
            button_Change.TabIndex = 9;
            button_Change.Text = "修改";
            button_Change.UseVisualStyleBackColor = true;
            button_Change.Click += button_Change_Click;
            // 
            // button_Remove
            // 
            button_Remove.Location = new Point(501, 224);
            button_Remove.Name = "button_Remove";
            button_Remove.Size = new Size(75, 23);
            button_Remove.TabIndex = 10;
            button_Remove.Text = "删除";
            button_Remove.UseVisualStyleBackColor = true;
            button_Remove.Click += button_Remove_Click;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(325, 75);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(121, 23);
            textBox_Name.TabIndex = 11;
            // 
            // Frm07AddressBook
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox_Name);
            Controls.Add(button_Remove);
            Controls.Add(button_Change);
            Controls.Add(button_Add);
            Controls.Add(textBox_Fz);
            Controls.Add(textBox_Yo);
            Controls.Add(textBox_Num);
            Controls.Add(comboBox_Name);
            Controls.Add(label_Fz);
            Controls.Add(label_Yo);
            Controls.Add(label_Num);
            Controls.Add(label_Name);
            Name = "Frm07AddressBook";
            Text = "通讯录";
            Load += Frm07AddressBook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Name;
        private Label label_Num;
        private Label label_Yo;
        private Label label_Fz;
        private ComboBox comboBox_Name;
        private TextBox textBox_Num;
        private TextBox textBox_Yo;
        private TextBox textBox_Fz;
        private Button button_Add;
        private Button button_Change;
        private Button button_Remove;
        private TextBox textBox_Name;
    }
}