using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
//using System.Collections;

namespace ProjectVanilla
{

    public struct subject
    {
        public String name;
        public String option;
        public String folder;
        public String desc;
        public int memorylimit;
        public int timelimit;
        public int points;
    }

    public struct TestInfo
    {
        public Boolean Exists;
        public String name;
        public String desc;
        public String dir;
       // public String[] coption;
        public subject[] subjects;
        public JObject additional;
    }


    class ConfigureManager
    {
        static String[] compliers = new String[3];
        static JObject obj;

        public Boolean refresh()
        {
                String config;

                if (!File.Exists("config.json"))
                {
                    /*MessageBox.Show("没有找到配置文件！将自动生成默认文件！");
                    string json = "{\n    \"Compliers\": {\n        \"Cpp\":\"bin\\compliers\\cpp\",\n        \"C\": \"bin\\compliers\\C\",\n        \"Pascal\":\"bin\\Compliers\\pascal\"\n    }\n}";
                    File.WriteAllText("config.json", json);
                    */
                    MessageBox.Show(null,"没有找到config.json!","错误");
                    return false;
                }

                config = File.ReadAllText("config.json");

                try
                {
                    obj = (JObject)JsonConvert.DeserializeObject(config);

                    compliers[0] = obj["Compliers"]["Cpp"].ToString();
                    compliers[1] = obj["Compliers"]["C"].ToString();
                    compliers[2] = obj["Compliers"]["Pascal"].ToString();

                    return true;
                }
                catch(JsonReaderException)
                {
                    MessageBox.Show("config.json读取失败！");
                    return false;
                }
        }

        //TYPE 1=Cpp,2=C,3=PASCAL
        public String getComplier(int type)
        {
            if (type >= 0 && type <= 2)
            {
                return compliers[type];
            }
            else
            {
                return null;
            }
        }

        public Boolean setComplier(int type, String value)
        {
            if (type >= 0 && type <= 2)
            {
                compliers[type] = value;
                return true;
            }
            else
            {
                return false;
            }
        }

        public JObject getObject()
        {
            return obj;
        }

        public String getTestsDir()
        {
            return obj["Tests"]["Dir"].ToString();
        }

        public TestInfo getTestInfo(String dir)
        {
            TestInfo ret = new TestInfo();

            JObject obj;
            String json = File.ReadAllText(getTestsDir() + @"\" + dir + @"\test.vanilla");
            try
            {
                obj = (JObject)JsonConvert.DeserializeObject(json);
            }
            catch(JsonReaderException)
            {
                MessageBox.Show(null,"文件夹 " + dir + " 中test.va读取失败!可能是json格式错误!","错误");
                ret.Exists = false;
                return ret;
            }

            ret.Exists = true;
            ret.dir = dir;
            try
            {
                ret.name = obj["info"]["name"].ToString();
                ret.desc = obj["info"]["desc"].ToString();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show(null, "测试 " + dir + " 加载失败！","提示");
                ret.Exists = false;
                return ret;
            }
            

            subject[] sub = new subject[obj["subjects"].Count()];

            for (int i = 0; i < obj["subjects"].Count(); ++i)
            {
                try
                {
                sub[i].name = obj["subjects"][i]["name"].ToString();
                sub[i].memorylimit = int.Parse(obj["subjects"][i]["memorylimit"].ToString());
                sub[i].desc = obj["subjects"][i]["desc"].ToString();
                sub[i].folder = obj["subjects"][i]["folder"].ToString();
                sub[i].option = obj["subjects"][i]["option"].ToString();
                sub[i].points = int.Parse(obj["subjects"][i]["pointscount"].ToString());
                sub[i].timelimit = int.Parse(obj["subjects"][i]["timelimit"].ToString());
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show(null,"测试 " + ret.name + " 加载失败，可能存在缺少项！","提示");
                    ret.Exists = false;
                    return ret;
                }
                catch (FormatException)
                {
                    MessageBox.Show(null, "测试 " + ret.name + " 中test.va存在格式错误！","提示");
                }
            }

            ret.subjects = sub;

            //Additional options
            try
            {
                ret.additional = (JObject)obj["additional"];
            }
            catch (NullReferenceException) { };
            return ret;

        }
    }
}
