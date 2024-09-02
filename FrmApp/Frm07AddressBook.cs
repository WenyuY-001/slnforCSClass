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
    public partial class Frm07AddressBook : Form
    {
        List<Address> addresses = new List<Address>();
        string NameText { get { return textBox_Name.Text; } }
        string NumberText { get { return textBox_Num.Text; } }
        string YearsText { get { return textBox_Yo.Text; } }
        string FzText { get { return textBox_Fz.Text; } }

        public Frm07AddressBook()
        {
            InitializeComponent();
        }

        public Frm07AddressBook(Frm06Main main)
        {
            InitializeComponent();
            this.MdiParent = main;
        }

        private void ReLoad()
        {
            comboBox_Name.Visible = true;
            comboBox_Name.SelectedItem = NameText;
            textBox_Name.Visible = false;
            textBox_Name.Text = null;
            textBox_Num.ReadOnly = true;
            textBox_Yo.ReadOnly = true;
            textBox_Fz.ReadOnly = true;
        }
        private void Add_Method()
        {
            comboBox_Name.Items.Add(NameText);
            MessageBox.Show("添加成功!");
            ReLoad();
        }
        private void Add_Mod()
        {
            comboBox_Name.Visible = false;
            textBox_Name.Visible = true;
            textBox_Num.ReadOnly = false;
            textBox_Num.Text = null;
            textBox_Yo.ReadOnly = false;
            textBox_Yo.Text = null;
            textBox_Fz.ReadOnly = false;
            textBox_Fz.Text = null;
        }
        private void Change_Mod()
        {
            textBox_Num.ReadOnly = false;
            textBox_Yo.ReadOnly = false;
            textBox_Fz.ReadOnly = false;
        }

        private void Frm07AddressBook_Load(object sender, EventArgs e)
        {
            addresses.Add(new Address("fhm", "1324578655", "22", "朋友"));
            addresses.Add(new Address("zy", "1354755568", "21", "朋友"));
            addresses.Add(new Address("tbr", "1254878553", "22", "傻逼"));
            addresses.Add(new Address("tcx", "1584632487", "21", "朋友"));
            addresses.Add(new Address("zs", "1235667452", "34"));
            ReLoad();
            foreach (var address in addresses)
            {
                comboBox_Name.Items.Add(address.name);
            }
        }

        private void comboBox_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox_Name.SelectedIndex;
            textBox_Num.Text = addresses[index].phoneNumber;
            textBox_Yo.Text = addresses[index].yearsOld;
            textBox_Fz.Text = addresses[index].fenZu;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NameText))
            {
                if (!string.IsNullOrEmpty(NumberText))
                {
                    if (!string.IsNullOrEmpty(YearsText))
                    {
                        if (!string.IsNullOrEmpty(FzText))
                        {
                            addresses.Add(new Address(NameText, NumberText, YearsText, FzText));
                            Add_Method();
                        }
                        else
                        {
                            addresses.Add(new Address(NameText, NumberText, YearsText));
                            Add_Method();
                        }
                    }
                    else
                    {
                        addresses.Add(new Address(NameText, NumberText));
                        Add_Method();
                    }
                }
                else
                {
                    addresses.Add(new Address(NameText));
                    Add_Method();
                }
            }
            else
            {
                Add_Mod();
            }
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            int i = comboBox_Name.SelectedIndex;
            if (textBox_Num.Visible == false)
            {
                Change_Mod();
            }
            else
            {
                addresses[i].phoneNumber = textBox_Num.Text;
                addresses[i].yearsOld = textBox_Yo.Text;
                addresses[i].fenZu = textBox_Fz.Text;
                ReLoad();
            }
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            addresses.RemoveAt(comboBox_Name.SelectedIndex);
            comboBox_Name.Items.Remove(comboBox_Name.SelectedIndex);
        }
    }
}
