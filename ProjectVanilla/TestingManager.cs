using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ProjectVanilla
{
    class TestingManager
    {
        private subject sub;
        public Boolean valid;
        public int points;
        public TestingManager(String testdir,subject s,ConfigureManager cm)
        {
            sub = s;
            DirectoryInfo subdir = new DirectoryInfo(cm.getTestsDir() + @"\" + testdir + @"\" + s.folder);

            if (!subdir.Exists)
            {
                valid = false;
                return;
            }

            FileInfo[] indata = subdir.GetFiles("*.in");
            if (indata.Length == 0)
            {
                valid = false;
                return;
            }

            for (int i = 0; i < indata.Length; ++i)
            {

            }

        }
   
    
    }
}
