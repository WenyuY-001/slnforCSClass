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
    public partial class Frm07Sx_Ah : Form
    {
        List<CheckBox> checkBox_Sx = new List<CheckBox>();
        public Frm07Sx_Ah()
        {
            InitializeComponent();
        }

        public Frm07Sx_Ah(Frm06Main main)
        {
            InitializeComponent();
            this.MdiParent = main;
        }

        private void Frm07Sx_Ah_Load(object sender, EventArgs e)
        {
            checkBox_Sx.AddRange(new[] { cBox_Hou, cBox_Ji, cBox_Gou, cBox_Zhu, cBox_Shu, cBox_Niu, cBox_Hu, cBox_Tu, cBox_Long, cBox_She, cBox_Ma, cBox_Yang });
            for (int i = DateTime.Now.Year - 20; i <= DateTime.Now.Year + 10; i++)
            {
                comboYears.Items.Add(i);
            }
            comboYears.SelectedItem = DateTime.Now.Year;
        }
        private void ComboYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var i in checkBox_Sx)
            {
                i.Checked = false;
            }
            int bec = (int)comboYears.SelectedItem % 12;
            checkBox_Sx[bec].Checked = true;
        }
        private void CBHobby_CheckedChanged(object sender, EventArgs e)
        {
            string textHobby = "";
            foreach (CheckBox i in groupBox_Ah.Controls)
            {
                if (i.Checked)
                    textHobby += i.Text + ",";
            }
            textBox_Ah.Text = textHobby.Trim(',');
        }
    }
}
