namespace FrmApp
{
    partial class Frm07Recipe
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
            List_Menu = new ListBox();
            List_Ordered = new ListBox();
            button_addAll = new Button();
            button_addSelect = new Button();
            button_removeSelect = new Button();
            button_removeAll = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // List_Menu
            // 
            List_Menu.FormattingEnabled = true;
            List_Menu.ItemHeight = 17;
            List_Menu.Location = new Point(147, 56);
            List_Menu.Name = "List_Menu";
            List_Menu.SelectionMode = SelectionMode.MultiExtended;
            List_Menu.Size = new Size(150, 310);
            List_Menu.TabIndex = 0;
            // 
            // List_Ordered
            // 
            List_Ordered.FormattingEnabled = true;
            List_Ordered.ItemHeight = 17;
            List_Ordered.Location = new Point(502, 56);
            List_Ordered.Name = "List_Ordered";
            List_Ordered.SelectionMode = SelectionMode.MultiSimple;
            List_Ordered.Size = new Size(150, 310);
            List_Ordered.TabIndex = 1;
            // 
            // button_addAll
            // 
            button_addAll.Location = new Point(358, 117);
            button_addAll.Name = "button_addAll";
            button_addAll.Size = new Size(75, 23);
            button_addAll.TabIndex = 2;
            button_addAll.Text = "添加所有";
            button_addAll.UseVisualStyleBackColor = true;
            button_addAll.Click += button_addAll_Click;
            // 
            // button_addSelect
            // 
            button_addSelect.Location = new Point(359, 87);
            button_addSelect.Name = "button_addSelect";
            button_addSelect.Size = new Size(75, 23);
            button_addSelect.TabIndex = 3;
            button_addSelect.Text = "添加选中";
            button_addSelect.UseVisualStyleBackColor = true;
            button_addSelect.Click += button_addSelect_Click;
            // 
            // button_removeSelect
            // 
            button_removeSelect.Location = new Point(359, 242);
            button_removeSelect.Name = "button_removeSelect";
            button_removeSelect.Size = new Size(75, 23);
            button_removeSelect.TabIndex = 4;
            button_removeSelect.Text = "移除选中";
            button_removeSelect.UseVisualStyleBackColor = true;
            button_removeSelect.Click += button_removeSelect_Click;
            // 
            // button_removeAll
            // 
            button_removeAll.Location = new Point(359, 271);
            button_removeAll.Name = "button_removeAll";
            button_removeAll.Size = new Size(75, 23);
            button_removeAll.TabIndex = 5;
            button_removeAll.Text = "移除所有";
            button_removeAll.UseVisualStyleBackColor = true;
            button_removeAll.Click += button_removeAll_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 36);
            label1.Name = "label1";
            label1.Size = new Size(32, 17);
            label1.TabIndex = 6;
            label1.Text = "菜单";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(502, 36);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 7;
            label2.Text = "已选菜";
            // 
            // Frm07Recipe
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_removeAll);
            Controls.Add(button_removeSelect);
            Controls.Add(button_addSelect);
            Controls.Add(button_addAll);
            Controls.Add(List_Ordered);
            Controls.Add(List_Menu);
            Name = "Frm07Recipe";
            Text = "电子菜单";
            Load += Frm07Recipe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox List_Menu;
        private ListBox List_Ordered;
        private Button button_addAll;
        private Button button_addSelect;
        private Button button_removeSelect;
        private Button button_removeAll;
        private Label label1;
        private Label label2;
    }
}