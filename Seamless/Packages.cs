using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Seamless
{
    internal class Package
    {
        public bool used = false;
        public string author;
        public string name;
        public string path;
        public string docs;

        const string main = "https://raw.githubusercontent.com/NotRustyBot/Seamless/master/";
        public static List<Package> packages = new List<Package>();
        static string projectPath = "";
        public static Package[] FetchPackages(WebClient client, string projectPath)
        {
            Package.projectPath = projectPath;
            packages.Clear();
            string[] rotues = client.DownloadString(main + "router.txt").Split('\n');
            foreach (string rotue in rotues)
            {
                if (rotue.Contains(";"))
                {
                    string author = rotue.Split(';')[0];
                    string path = rotue.Split(';')[1];
                    string[] index = client.DownloadString(path + "index.txt").Split('\n');
                    foreach (string item in index)
                    {
                        if (item.Length == 0) continue;

                        string docs = "";
                        if (item.Contains(';'))
                        {
                            docs = item.Split(';')[1];
                        }
                        string name = item.Split(';')[0];
                        packages.Add(new Package(author, name, path + name + ".cs", docs));
                    }
                }
            }
            return packages.ToArray();
        }

        Package(string author, string name, string path, string docs)
        {
            this.author = author;
            this.name = name;
            this.path = path;
            this.docs = docs;
            if (projectPath == "") return;
            used = File.Exists(projectPath + "\\" + name + ".cs") && File.ReadLines(projectPath + "\\" + name + ".cs").First() == "//" + path;
        }

        internal void Download(WebClient client)
        {
            if (File.Exists(projectPath + "\\" + name + ".cs"))
            {
                DialogResult result = MessageBox.Show("file with this name already exists. Overwrite?", "filename collision", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            used = true;
            File.WriteAllText(projectPath + "\\" + name + ".cs", "//" + path + "\n" + client.DownloadString(path));
        }

        internal void Remove()
        {
            File.Delete(projectPath + "\\" + name + ".cs");
        }

        internal void ShowDocs()
        {
            System.Diagnostics.Process.Start(docs);
        }
    }
}
