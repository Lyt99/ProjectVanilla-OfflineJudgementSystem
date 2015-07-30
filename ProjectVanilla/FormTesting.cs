using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectVanilla
{
    public partial class FormTesting : Form
    {
        public static TestInfo test = new TestInfo();

        public FormTesting()
        {
            test.Exists = false;
            InitializeComponent();
        }

        private void FormTesting_Load(object sender, EventArgs e)
        {
            if (!test.Exists) return;
            this.Text = "试题:" + test.name;
            refershSubjects();
        }

        private void refershSubjects()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < test.subjects.Length; ++i)
            {
                listBox1.Items.Add(test.subjects[i].name);
            }
        
        }

        public FormTesting setTest(TestInfo t)
        {
            test = t;
            return this;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
