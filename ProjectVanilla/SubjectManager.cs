using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Collections;

namespace ProjectVanilla
{
    class SubjectManager
    {
        private subject sub;
        public Boolean Valid;
        public int points;
        public String[] Pointlist;
        public SubjectManager(String testdir,subject s,ConfigureManager cm)
        {
            sub = s;
            String parentdir = cm.getTestsDir() + @"\" + testdir + @"\" + sub.folder + @"\";
            DirectoryInfo subdir = new DirectoryInfo( parentdir + s.folder);

            if (!subdir.Exists)
            {
                Valid = false;
                return;
            }

            FileInfo[] indata = subdir.GetFiles("*.in");
            if (indata.Length == 0)
            {
                Valid = false;
                return;
            }

            ArrayList pl = new ArrayList();
            for (int i = 0; i < indata.Length; ++i)
            {
                if (File.Exists(parentdir + s.folder + @"\" + Path.GetFileNameWithoutExtension(indata[i].Name) + ".out" ))
                {
                    pl.Add(Path.GetFileNameWithoutExtension(indata[i].Name));
                }
            }

            if (pl.Count == 0)
            {
                Valid = false;
                return;
            }

            Pointlist = (String[]) pl.ToArray();       
        }
   
    
    }
}
