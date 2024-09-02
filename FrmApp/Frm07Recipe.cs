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
    public partial class Frm07Recipe : Form
    {
        public Frm07Recipe()
        {
            InitializeComponent();
        }

        public Frm07Recipe(Frm06Main main)
        {
            InitializeComponent();
            this.MdiParent = main;
        }

        private void Frm07Recipe_Load(object sender, EventArgs e)
        {
            List_Menu.Items.AddRange(new[] { "番茄炒蛋", "宫保鸡丁", "回锅肉",
                "麻婆豆腐", "泡椒牛柳", "青椒肉丝", "时令蔬菜", "水煮肉片",
                "糖醋里脊", "土豆烧牛肉", "鱼香茄子", "芋儿烧鸡", "纸包鱼" });
        }

        private void button_addAll_Click(object sender, EventArgs e)
        {
            foreach (var item in List_Menu.Items)
            {
                if (!List_Ordered.Items.Contains(item))
                {
                    List_Ordered.Items.Add(item);
                }
            }
        }

        private void button_removeAll_Click(object sender, EventArgs e)
        {
            List_Ordered.Items.Clear();
        }

        private void button_addSelect_Click(object sender, EventArgs e)
        {
            if (List_Menu.SelectedItems != null)
            {
                foreach (var item in List_Menu.SelectedItems)
                {
                    if (!List_Ordered.Items.Contains(item))
                    {
                        List_Ordered.Items.Add(item);
                    }
                }
            }
            else
            {
                MessageBox.Show("请先选择要添加的菜", "提示");
            }
        }

        private void button_removeSelect_Click(object sender, EventArgs e)
        {
            if (List_Ordered.SelectedItems != null)
            {
                object[] selected = new object[List_Ordered.SelectedItems.Count];
                List_Ordered.SelectedItems.CopyTo(selected, 0);
                foreach (var item in selected)
                {
                    List_Ordered.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("请先选择要添加的菜", "提示");
            }
        }
    }
}
