namespace FrmApp
{
    partial class Frm08Score
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
            listView1 = new ListView();
            Header_Name = new ColumnHeader();
            Header_Score1 = new ColumnHeader();
            Header_Score2 = new ColumnHeader();
            Header_Total = new ColumnHeader();
            buttonAdd = new Button();
            buttonRemove = new Button();
            groupBoxMore = new GroupBox();
            buttonBack = new Button();
            buttonComfirm = new Button();
            textBoxOS = new TextBox();
            textBoxPC = new TextBox();
            textBoxClasses = new TextBox();
            textBoxName = new TextBox();
            labelClasses = new Label();
            labelPC = new Label();
            labelName = new Label();
            labelOS = new Label();
            labelID = new Label();
            textBoxID = new TextBox();
            groupBoxMore.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Header_Name, Header_Score1, Header_Score2, Header_Total });
            listView1.Location = new Point(100, 50);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(600, 300);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.ItemActivate += listView1_ItemActivate;
            // 
            // Header_Name
            // 
            Header_Name.Text = "姓名";
            Header_Name.Width = 80;
            // 
            // Header_Score1
            // 
            Header_Score1.Text = "操作系统";
            Header_Score1.TextAlign = HorizontalAlignment.Center;
            Header_Score1.Width = 70;
            // 
            // Header_Score2
            // 
            Header_Score2.Text = "计算机";
            Header_Score2.TextAlign = HorizontalAlignment.Center;
            // 
            // Header_Total
            // 
            Header_Total.Text = "总分";
            Header_Total.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(600, 356);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(100, 30);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "添    加";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(494, 356);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(100, 30);
            buttonRemove.TabIndex = 2;
            buttonRemove.Text = "删    除";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // groupBoxMore
            // 
            groupBoxMore.Controls.Add(buttonBack);
            groupBoxMore.Controls.Add(buttonComfirm);
            groupBoxMore.Controls.Add(textBoxOS);
            groupBoxMore.Controls.Add(textBoxPC);
            groupBoxMore.Controls.Add(textBoxClasses);
            groupBoxMore.Controls.Add(textBoxName);
            groupBoxMore.Controls.Add(labelClasses);
            groupBoxMore.Controls.Add(labelPC);
            groupBoxMore.Controls.Add(labelName);
            groupBoxMore.Controls.Add(labelOS);
            groupBoxMore.Controls.Add(labelID);
            groupBoxMore.Controls.Add(textBoxID);
            groupBoxMore.Location = new Point(100, 50);
            groupBoxMore.Name = "groupBoxMore";
            groupBoxMore.Size = new Size(600, 300);
            groupBoxMore.TabIndex = 3;
            groupBoxMore.TabStop = false;
            groupBoxMore.Text = "详细信息";
            groupBoxMore.Visible = false;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(406, 203);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(85, 25);
            buttonBack.TabIndex = 11;
            buttonBack.Text = "返回";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonComfirm
            // 
            buttonComfirm.Location = new Point(315, 203);
            buttonComfirm.Name = "buttonComfirm";
            buttonComfirm.Size = new Size(85, 25);
            buttonComfirm.TabIndex = 10;
            buttonComfirm.Text = "确认";
            buttonComfirm.UseVisualStyleBackColor = true;
            buttonComfirm.Click += buttonComfirm_Click;
            // 
            // textBoxOS
            // 
            textBoxOS.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxOS.Location = new Point(357, 48);
            textBoxOS.Name = "textBoxOS";
            textBoxOS.Size = new Size(134, 25);
            textBoxOS.TabIndex = 9;
            // 
            // textBoxPC
            // 
            textBoxPC.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPC.Location = new Point(357, 125);
            textBoxPC.Name = "textBoxPC";
            textBoxPC.Size = new Size(134, 25);
            textBoxPC.TabIndex = 8;
            // 
            // textBoxClasses
            // 
            textBoxClasses.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxClasses.Location = new Point(113, 205);
            textBoxClasses.Name = "textBoxClasses";
            textBoxClasses.Size = new Size(134, 25);
            textBoxClasses.TabIndex = 7;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(113, 125);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(134, 25);
            textBoxName.TabIndex = 6;
            // 
            // labelClasses
            // 
            labelClasses.AutoSize = true;
            labelClasses.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelClasses.Location = new Point(61, 207);
            labelClasses.Name = "labelClasses";
            labelClasses.Size = new Size(46, 21);
            labelClasses.TabIndex = 5;
            labelClasses.Text = "班级:";
            // 
            // labelPC
            // 
            labelPC.AutoSize = true;
            labelPC.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPC.Location = new Point(289, 127);
            labelPC.Name = "labelPC";
            labelPC.Size = new Size(62, 21);
            labelPC.TabIndex = 4;
            labelPC.Text = "计算机:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(61, 127);
            labelName.Name = "labelName";
            labelName.Size = new Size(46, 21);
            labelName.TabIndex = 3;
            labelName.Text = "姓名:";
            // 
            // labelOS
            // 
            labelOS.AutoSize = true;
            labelOS.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelOS.Location = new Point(273, 50);
            labelOS.Name = "labelOS";
            labelOS.Size = new Size(78, 21);
            labelOS.TabIndex = 2;
            labelOS.Text = "操作系统:";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelID.Location = new Point(61, 50);
            labelID.Name = "labelID";
            labelID.Size = new Size(46, 21);
            labelID.TabIndex = 1;
            labelID.Text = "学号:";
            // 
            // textBoxID
            // 
            textBoxID.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxID.Location = new Point(113, 48);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(134, 25);
            textBoxID.TabIndex = 0;
            // 
            // Frm08Score
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxMore);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(listView1);
            Name = "Frm08Score";
            Text = "学生成绩";
            Load += Frm08Score_Load;
            groupBoxMore.ResumeLayout(false);
            groupBoxMore.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader Header_Name;
        private ColumnHeader Header_Score1;
        private ColumnHeader Header_Score2;
        private ColumnHeader Header_Total;
        private Button buttonAdd;
        private Button buttonRemove;
        private GroupBox groupBoxMore;
        private Label labelID;
        private TextBox textBoxID;
        private Button buttonBack;
        private Button buttonComfirm;
        private TextBox textBoxOS;
        private TextBox textBoxPC;
        private TextBox textBoxClasses;
        private TextBox textBoxName;
        private Label labelClasses;
        private Label labelPC;
        private Label labelName;
        private Label labelOS;
    }
}