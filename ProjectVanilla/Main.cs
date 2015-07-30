using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace ProjectVanilla
{
    public partial class Main : Form
    {

        static ArrayList tests = new ArrayList();
        static ConfigureManager cm = new ConfigureManager();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ButtonLoad.Enabled = false;
            labeldesc.Text = "";

            if (!cm.refresh())
            {
                System.Environment.Exit(0);
            }

            refreshTestList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this,cm.getComplier(0),"Cpp");
        }

        private void refreshTestList()
        {
            listBox1.Items.Clear();
            string path = cm.getTestsDir();
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            DirectoryInfo di = new DirectoryInfo(path);
            
            DirectoryInfo[] list = di.GetDirectories();

            for (int i = 0; i < list.Length; ++i)//只有目录根部包含test.va的文件才被加入
            {
                if ((list[i].GetFiles("test.vanilla", SearchOption.TopDirectoryOnly)).Length != 0)
                {
                    TestInfo cur = cm.getTestInfo(list[i].Name);
                    if(cur.Exists)
                        tests.Add(cm.getTestInfo(list[i].Name));
                }
            }

            refreshlist(tests);
            LabelTestCount.Text = tests.Count.ToString();

            //for()
        }

        void refreshlist(ArrayList list)
        {
            for (int i = 0; i < list.Count; ++i)
            {
                listBox1.Items.Add(((TestInfo)list[i]).name + "[" + ((TestInfo)list[i]).dir + "]");
            }
            LabelTestCount.Text = list.Count.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index == -1) return;
            {
                ButtonLoad.Enabled = true;   
            }
            String teststr = "";
            for (int i = 0; i < ((TestInfo)tests[index]).subjects.Length; ++i)
            {
                teststr += ((TestInfo)tests[index]).subjects[i].name + @",";
            }
            teststr = teststr.Substring(0, teststr.Length - 1);
            labeldesc.Text = "测试名称: " + ((TestInfo)tests[index]).name + "\n"
                           + "测试说明: " + ((TestInfo)tests[index]).desc + "\n"
                           + "包含题目: " + teststr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            FormTesting testing = new FormTesting().setTest((TestInfo)tests[listBox1.SelectedIndex]);
            //testing.Visible = false;

            testing.Show();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            button2_Click(sender,e);
        }

        private void listBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                button2_Click(sender, e);
        }
    }
}
