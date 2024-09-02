using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace FrmApp
{
    public partial class Frm08Score : Form
    {
        //存储学生成绩类
        List<Score> listScore = new List<Score>();

        //父级窗体
        public Frm06Main? parent;

        //运行中不同状态模式
        Dictionary<string, int> inTheMod = new Dictionary<string, int>() {
            {"ReadMode", 0}, {"AddMode", 1}, {"RemoveMode", 2}, {"ReadMoreMode", 3}
        };
        private int whichMod = 0;

        //获取详细信息文本
        string TheID { get { return textBoxID.Text; } }
        string TheName { get { return textBoxName.Text; } }
        string TheClass { get { return textBoxClasses.Text; } }
        int TheOSScore
        {
            get
            {
                int OSScore = 0;
                return int.TryParse(textBoxOS.Text, out OSScore) ? OSScore : 0;
            }
        }
        int ThePCScore
        {
            get
            {
                int PCScore = 0;
                return int.TryParse(textBoxPC.Text, out PCScore) ? PCScore : 0;
            }
        }

        public Frm08Score()
        {
            InitializeComponent();
        }

        public Frm08Score(Frm06Main parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.MdiParent = parent;
        }

        //显示表单
        private void ShowListView()
        {
            groupBoxMore.Visible = false;
            listView1.Visible = true;
            buttonAdd.Enabled = true;
            buttonRemove.Enabled = true;
        }

        //显示详细信息
        private void ShowGroupBox()
        {
            listView1.Visible = false;
            groupBoxMore.Visible = true;
            buttonAdd.Enabled = false;
            buttonRemove.Enabled = false;
        }

        //重置详细信息页
        private void ReloadGroupBox()
        {
            groupBoxMore.Text = "详细信息";
            textBoxID.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxClasses.Text = string.Empty;
            textBoxOS.Text = string.Empty;
            textBoxPC.Text = string.Empty;
        }

        //详细信息页内容更新
        void UpdateGroupBox(Score score)
        {
            textBoxID.Text = score.ID.ToString();
            textBoxName.Text = score.name.ToString();
            textBoxClasses.Text = score.classes.ToString();
            textBoxOS.Text = score.score_OS.ToString();
            textBoxPC.Text = score.score_PC.ToString();
        }

        //比较学生信息
        bool CheckInfo(Score score)
        {
            return listScore.Any(s => s.ID == score.ID && s.name == score.name && s.classes == score.classes);
        }

        //更新学生成绩
        void UpdateScore(Score score)
        {
            Score? findScore = listScore.FirstOrDefault(s => s.ID == score.ID);
            if (findScore != null)
            {
                findScore.score_OS = score.score_OS;
                findScore.score_PC = score.score_PC;
            }
        }

        //添加方法
        void Addsolution()
        {
            Score score_Now = new Score(
                        TheID, TheName, TheClass, TheOSScore, ThePCScore);
            if (CheckInfo(score_Now))
            {
                //更新
                UpdateScore(score_Now);
            }
            else
            {
                listScore.Add(score_Now);
                listView1.Items.Add(score_Now.name);
                listView1.Items[listView1.Items.Count - 1].SubItems.AddRange(new[]
                { score_Now.score_OS.ToString(), score_Now.score_PC.ToString(), score_Now.Total.ToString()});
            }
        }

        //删除方法
        void Removesolution()
        {
            DialogResult result = MessageBox.Show("确认删除选中的记录吗?", "提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    listView1.Items.Remove(item);
                    listScore.RemoveAt(listView1.SelectedIndices[0]);
                }
            }
        }

        private void Frm08Score_Load(object sender, EventArgs e)
        {
            listScore.AddRange(new[] {
                new Score("3215523114","刘二", "数媒2班", 78, 89),
                new Score("3215523117", "张三", "数媒2班", 67, 76),
                new Score("3215523120", "李四", "数媒2班", 87, 56),
                new Score("3215523123", "王五", "数媒2班", 63, 72)
            });
            int index = 0;
            foreach (var i in listScore)
            {
                listView1.Items.Add(i.name);
                listView1.Items[index].SubItems.AddRange(new[] {
                    i.score_OS.ToString(), i.score_PC.ToString(), i.Total.ToString() });
                index++;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ShowGroupBox();
            ReloadGroupBox();
            groupBoxMore.Text = buttonAdd.Text;
            whichMod = inTheMod["AddMode"];
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ShowGroupBox();
                ReloadGroupBox();
                groupBoxMore.Text = buttonRemove.Text;
                UpdateGroupBox(listScore[listView1.SelectedIndices[0]]);
                whichMod = inTheMod["RemoveMode"];
            }
            else { MessageBox.Show("未选择", "提示"); }
        }

        private void buttonComfirm_Click(object sender, EventArgs e)
        {
            switch (whichMod)
            {
                case 0:
                    //观看模式
                    break;
                case 1:
                    //添加模式
                    Addsolution();
                    break;
                case 2:
                    //删除模式
                    Removesolution();
                    break;
                case 3:
                    //详细模式
                    break;
            }
            ShowListView();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ShowListView();
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            ShowGroupBox();
            ReloadGroupBox();
            UpdateGroupBox(listScore[listView1.SelectedIndices[0]]);
            whichMod = inTheMod["ReadMoreMode"];
        }

    }
}
