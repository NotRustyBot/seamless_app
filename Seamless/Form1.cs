using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Text.RegularExpressions;
using System.Net;
using Newtonsoft.Json;
using System.Net.Http;

namespace Seamless
{
    public partial class Form1 : Form
    {

        const string start = "/* SCRIPT STARTS HERE - COPY BELOW INTO THE SCRIPT WINDOW */";
        const string startClass = "/* CLASS STARTS HERE - COPY BELOW INTO THE SCRIPT WINDOW */";
        const string end = "/* SCRIPT ENDS HERE - COPY ABOVE INTO THE SCRIPT WINDOW */";
        const string endClass = "/* CLASS ENDS HERE - COPY ABOVE INTO THE SCRIPT WINDOW */";

        const string programTemplate = @"using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using SFDGameScriptInterface;


namespace SFDScript
{

    public partial class GameScript : GameScriptInterface
    {
        /// <summary>
        /// Placeholder constructor that's not to be included in the ScriptWindow!
        /// </summary>
        public GameScript() : base(null) { }

        /* SCRIPT STARTS HERE - COPY BELOW INTO THE SCRIPT WINDOW */

        #region Startup Calls

        public void OnStartup()
        {

        }

        public void AfterStartup()
        {

        }

        #endregion

        /* SCRIPT ENDS HERE - COPY ABOVE INTO THE SCRIPT WINDOW */

    }
}

";
        const string classTemplate = @"using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using SFDGameScriptInterface;


namespace SFDScript
{

    public partial class GameScript : GameScriptInterface
    {

        /* CLASS STARTS HERE - COPY BELOW INTO THE SCRIPT WINDOW */
                
        class NewClass
        {

        }

        /* CLASS ENDS HERE - COPY ABOVE INTO THE SCRIPT WINDOW */

    }
}
";
        const string seamlessReloaderTemplate = @"        public void OnStartup() {
            Events.PlayerKeyInputCallback.Start((IPlayer ply, VirtualKeyInfo[] info) => {
                if (ply.KeyPressed(VirtualKey.WALKING) && ply.KeyPressed(VirtualKey.ACTIVATE)) {
                    Game.RunCommand(""/stopscript seamless"");
                    Game.RunCommand(""/startscript seamless"");
                }
});
        }";

        const string aboutExample = @"# package name

A short description of the package.

## usage
An explanation showing how to use the package.

    //use the following code:
    Test.Run();

## changelog
If you've updated the package, consider logging the changes.

> **v1.2**
> - fixed a bug with the added feature

> **v1.1**
> - added a feature
> - fixed a bug



## feedback
Show where users can send feedback about the package.
For example, on [Discord](https://discordapp.com/users/645206726097764364)";

        FileSystemWatcher watcher = new FileSystemWatcher();
        WebClient client = new WebClient();
        public Form1()
        {
            InitializeComponent();
            status.AutoSize = false;
            status.Width = 460;
            status.Height = 20;
            status.BackColor = Color.Black;
            status.ForeColor = Color.White;

            watcher.SynchronizingObject = this;
            watcher.Changed += OnSave;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        bool seamless = false;
        private void seamlessMode_CheckedChanged(object sender, EventArgs e)
        {
            seamless = seamlessMode.Checked;
            if (seamless)
            {
                if (!Directory.Exists(sourceText.Text))
                {
                    ShowError("source directory does not exist");
                    seamless = false;
                    seamlessMode.Checked = false;
                    return;
                }
                watcher.Path = sourceText.Text;
                watcher.EnableRaisingEvents = true;
            }
        }

        private void OnSave(object sender, FileSystemEventArgs e)
        {
            if (seamless)
            {
                try
                {
                    Thread.Sleep(300);
                    File.WriteAllText(targetText.Text, GetCode());
                    ShowStatus("change detected, source copied to target");
                }
                catch
                {
                    Task.Run(() =>
                    {
                        ShowError("failure when writing");
                    });

                }
            }

            if (clip)
            {
                Thread.Sleep(300);
                Clipboard.SetText(GetCode());
                ShowStatus("change detected, source copied to clipboard");
            }
        }

        private string GetCode()
        {
            string output = "";
            foreach (string path in Directory.GetFiles(sourceText.Text))
            {
                if (!path.EndsWith(".cs")) continue;
                string content = File.ReadAllText(path);
                content = content.Replace(startClass, start).Replace(endClass, end);
                content = content.Replace('\t', ' ');
                Regex rx = new Regex(Regex.Escape(start) + "(.|\n)*?" + Regex.Escape(end));
                Match rxm = rx.Match(content);
                if (rxm.Success)
                {
                    output += rxm.Value.Replace(start, "/* " + Path.GetFileName(path) + " */").Replace(end, "\r\n");
                }
            }
            return output;
        }

        private void BrowseSource_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                sourceText.Text = "";
                dialog.CookieIdentifier = Guid.Parse("c8d352b6-b6cc-4e06-b566-de13eb706b90");
                sourceText.AppendText(dialog.FileName);
                ShowStatus("source folder selected");
            }
        }

        private void BrowseTarget_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Superfighters Deluxe\Scripts\Custom";
            dialog.DefaultFileName = "seamless.txt";
            dialog.CookieIdentifier = Guid.Parse("ecd2b6c0-7d59-4ba2-a05e-819933e33364");
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                targetText.Text = "";
                targetText.AppendText(dialog.FileName);
                ShowStatus("target file selected");
            }
        }

        private void clipboard_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(sourceText.Text))
            {
                ShowError("source directory does not exist");
                seamless = false;
                seamlessMode.Checked = false;
                return;
            }
            string code = GetCode();
            if (code == "")
            {
                ShowError("nothing to copy");
                return;
            }
            Clipboard.SetText(code);
            ShowStatus("copied to clipboard");
        }

        private void ShowError(string text)
        {
            status.ForeColor = Color.Red;
            status.Text = text;
        }

        private void ShowStatus(string text)
        {
            status.ForeColor = Color.White;
            status.Text = text;
        }

        private void copyMain_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(programTemplate);
            ShowStatus("copied to clipboard");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void copyClass_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(classTemplate);
            ShowStatus("copied to clipboard");
        }

        private void copySeamless_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(seamlessReloaderTemplate);
            ShowStatus("copied to clipboard");
        }

        private void fileMain_Click(object sender, EventArgs e)
        {
            CommonSaveFileDialog dialog = new CommonSaveFileDialog();
            dialog.DefaultDirectory = sourceText.Text;
            dialog.DefaultFileName = "Program.cs";
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                File.WriteAllText(dialog.FileName, programTemplate);
            }
        }

        private void fileClass_Click(object sender, EventArgs e)
        {
            CommonSaveFileDialog dialog = new CommonSaveFileDialog();
            dialog.DefaultDirectory = sourceText.Text;
            dialog.DefaultFileName = "Class.cs";
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                File.WriteAllText(dialog.FileName, classTemplate);
            }
        }

        private void fileSeamless_Click(object sender, EventArgs e)
        {
            CommonSaveFileDialog dialog = new CommonSaveFileDialog();
            dialog.DefaultDirectory = Path.GetDirectoryName(targetText.Text);
            dialog.DefaultFileName = "reloader.txt";
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                File.WriteAllText(dialog.FileName, seamlessReloaderTemplate);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        bool clip = false;
        private void clipMode_CheckedChanged(object sender, EventArgs e)
        {

            clip = clipMode.Checked;
            if (clip)
            {
                if (!Directory.Exists(sourceText.Text))
                {
                    ShowError("source directory does not exist");
                    clip = false;
                    clipMode.Checked = false;
                    return;
                }
                watcher.Path = sourceText.Text;
                watcher.EnableRaisingEvents = true;
            }
        }

        private void sourceText_TextChanged(object sender, EventArgs e)
        {
            seamless = false;
            seamlessMode.Checked = false;

        }

        private void status_Click(object sender, EventArgs e)
        {
            status.Text = "no problems found";
        }

        private void PackageList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                if (Directory.Exists(sourceText.Text))
                {
                    ShowPackages();
                    ShowStatus("packages fetched");
                }
                else
                {
                    ShowError("select source folder before managing packages");
                }
            }

        }

        void ShowPackages() {
            Package[] packages = Package.FetchPackages(client, sourceText.Text);
            PackageList.Items.Clear();
            foreach (Package p in packages)
            {
                ListViewItem item = new ListViewItem(p.name);
                if (p.used) item.BackColor = Color.FromArgb(200, 255, 200);
                item.SubItems.Add(p.author);
                item.SubItems.Add(p.used ? "yes" : "");
                PackageList.Items.Add(item);
            }

            removePackage.Enabled = false;
            downloadPackage.Enabled = false;
            showDocs.Enabled = false;
        }

        private void downloadPackage_Click(object sender, EventArgs e)
        {
            Package package = Package.packages[PackageList.SelectedItems[0].Index];
            package.Download(client);
            ShowPackages();
        }

        private void PackageList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (PackageList.SelectedItems.Count != 0)
            {
                Package package = Package.packages[PackageList.SelectedItems[0].Index];
                if (package.used)
                {
                    removePackage.Enabled = true;
                    downloadPackage.Enabled = true;
                }
                else
                {
                    removePackage.Enabled = false;
                    downloadPackage.Enabled = true;
                }
                showDocs.Enabled = package.docs.Length > 0;
            }
            else
            {
                removePackage.Enabled = false;
                downloadPackage.Enabled = false;
                showDocs.Enabled = false;
            }
        }

        private void removePackage_Click(object sender, EventArgs e)
        {
            Package package = Package.packages[PackageList.SelectedItems[0].Index];
            package.Remove();
            ShowPackages();
        }

        private void showDocs_Click(object sender, EventArgs e)
        {
            Package package = Package.packages[PackageList.SelectedItems[0].Index];
            package.ShowDocs();
        }

        private void copyAbout_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(aboutExample);
            ShowStatus("copied to clipboard");
        }

        private void fileAbout_Click(object sender, EventArgs e)
        {
            CommonSaveFileDialog dialog = new CommonSaveFileDialog();
            dialog.DefaultDirectory = sourceText.Text;
            dialog.DefaultFileName = "about.md";
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                File.WriteAllText(dialog.FileName, aboutExample);
            }
        }
    }
}
