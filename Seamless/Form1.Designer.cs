namespace Seamless {
    partial class Form1 {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.localPackageList = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.docs = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fileClass = new System.Windows.Forms.Button();
            this.fileMain = new System.Windows.Forms.Button();
            this.copyAbout = new System.Windows.Forms.Button();
            this.fileAbout = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.copyClass = new System.Windows.Forms.Button();
            this.copySeamless = new System.Windows.Forms.Button();
            this.fileSeamless = new System.Windows.Forms.Button();
            this.copyMain = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.clipMode = new System.Windows.Forms.CheckBox();
            this.clipboard = new System.Windows.Forms.Button();
            this.seamlessMode = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sourceText = new System.Windows.Forms.TextBox();
            this.targetText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.browseTarget = new System.Windows.Forms.Button();
            this.browseSource = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.PackageList = new System.Windows.Forms.ListView();
            this.package = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.creator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.used = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showDocs = new System.Windows.Forms.Button();
            this.removePackage = new System.Windows.Forms.Button();
            this.downloadPackage = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "loaded packages";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "download package";
            // 
            // localPackageList
            // 
            this.localPackageList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.author,
            this.date});
            this.localPackageList.FullRowSelect = true;
            this.localPackageList.GridLines = true;
            this.localPackageList.HideSelection = false;
            this.localPackageList.Location = new System.Drawing.Point(3, 58);
            this.localPackageList.MultiSelect = false;
            this.localPackageList.Name = "localPackageList";
            this.localPackageList.Size = new System.Drawing.Size(325, 81);
            this.localPackageList.TabIndex = 4;
            this.localPackageList.UseCompatibleStateImageBehavior = false;
            this.localPackageList.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "name";
            this.name.Width = 150;
            // 
            // author
            // 
            this.author.Text = "author";
            this.author.Width = 75;
            // 
            // date
            // 
            this.date.Text = "date";
            this.date.Width = 75;
            // 
            // docs
            // 
            this.docs.Location = new System.Drawing.Point(0, 0);
            this.docs.Name = "docs";
            this.docs.Size = new System.Drawing.Size(75, 23);
            this.docs.TabIndex = 0;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(0, 200);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(94, 13);
            this.status.TabIndex = 7;
            this.status.Text = "no problems found";
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.fileClass);
            this.tabPage2.Controls.Add(this.fileMain);
            this.tabPage2.Controls.Add(this.copyAbout);
            this.tabPage2.Controls.Add(this.fileAbout);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.copyClass);
            this.tabPage2.Controls.Add(this.copySeamless);
            this.tabPage2.Controls.Add(this.fileSeamless);
            this.tabPage2.Controls.Add(this.copyMain);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(419, 145);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Templates";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // fileClass
            // 
            this.fileClass.Location = new System.Drawing.Point(243, 40);
            this.fileClass.Name = "fileClass";
            this.fileClass.Size = new System.Drawing.Size(75, 23);
            this.fileClass.TabIndex = 6;
            this.fileClass.Text = "create file";
            this.fileClass.UseVisualStyleBackColor = true;
            this.fileClass.Click += new System.EventHandler(this.fileClass_Click);
            // 
            // fileMain
            // 
            this.fileMain.Location = new System.Drawing.Point(243, 11);
            this.fileMain.Name = "fileMain";
            this.fileMain.Size = new System.Drawing.Size(75, 23);
            this.fileMain.TabIndex = 5;
            this.fileMain.Text = "create file";
            this.fileMain.UseVisualStyleBackColor = true;
            this.fileMain.Click += new System.EventHandler(this.fileMain_Click);
            // 
            // copyAbout
            // 
            this.copyAbout.Location = new System.Drawing.Point(162, 98);
            this.copyAbout.Name = "copyAbout";
            this.copyAbout.Size = new System.Drawing.Size(75, 23);
            this.copyAbout.TabIndex = 4;
            this.copyAbout.Text = "copy";
            this.copyAbout.UseVisualStyleBackColor = true;
            this.copyAbout.Click += new System.EventHandler(this.copyAbout_Click);
            // 
            // fileAbout
            // 
            this.fileAbout.Location = new System.Drawing.Point(243, 98);
            this.fileAbout.Name = "fileAbout";
            this.fileAbout.Size = new System.Drawing.Size(75, 23);
            this.fileAbout.TabIndex = 3;
            this.fileAbout.Text = "create file";
            this.fileAbout.UseVisualStyleBackColor = true;
            this.fileAbout.Click += new System.EventHandler(this.fileAbout_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "about file";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // copyClass
            // 
            this.copyClass.Location = new System.Drawing.Point(162, 40);
            this.copyClass.Name = "copyClass";
            this.copyClass.Size = new System.Drawing.Size(75, 23);
            this.copyClass.TabIndex = 1;
            this.copyClass.Text = "copy";
            this.copyClass.UseVisualStyleBackColor = true;
            this.copyClass.Click += new System.EventHandler(this.copyClass_Click);
            // 
            // copySeamless
            // 
            this.copySeamless.Location = new System.Drawing.Point(162, 69);
            this.copySeamless.Name = "copySeamless";
            this.copySeamless.Size = new System.Drawing.Size(75, 23);
            this.copySeamless.TabIndex = 1;
            this.copySeamless.Text = "copy";
            this.copySeamless.UseVisualStyleBackColor = true;
            this.copySeamless.Click += new System.EventHandler(this.copySeamless_Click);
            // 
            // fileSeamless
            // 
            this.fileSeamless.Location = new System.Drawing.Point(243, 69);
            this.fileSeamless.Name = "fileSeamless";
            this.fileSeamless.Size = new System.Drawing.Size(75, 23);
            this.fileSeamless.TabIndex = 1;
            this.fileSeamless.Text = "create file";
            this.fileSeamless.UseVisualStyleBackColor = true;
            this.fileSeamless.Click += new System.EventHandler(this.fileSeamless_Click);
            // 
            // copyMain
            // 
            this.copyMain.Location = new System.Drawing.Point(162, 11);
            this.copyMain.Name = "copyMain";
            this.copyMain.Size = new System.Drawing.Size(75, 23);
            this.copyMain.TabIndex = 1;
            this.copyMain.Text = "copy";
            this.copyMain.UseVisualStyleBackColor = true;
            this.copyMain.Click += new System.EventHandler(this.copyMain_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "seamless reloader script";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "class template";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "main program template";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(427, 171);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.clipMode);
            this.tabPage1.Controls.Add(this.clipboard);
            this.tabPage1.Controls.Add(this.seamlessMode);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.sourceText);
            this.tabPage1.Controls.Add(this.targetText);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.browseTarget);
            this.tabPage1.Controls.Add(this.browseSource);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(419, 145);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Code";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // clipMode
            // 
            this.clipMode.AutoSize = true;
            this.clipMode.Location = new System.Drawing.Point(134, 104);
            this.clipMode.Name = "clipMode";
            this.clipMode.Size = new System.Drawing.Size(83, 17);
            this.clipMode.TabIndex = 8;
            this.clipMode.Text = "clip on save";
            this.clipMode.UseVisualStyleBackColor = true;
            this.clipMode.CheckedChanged += new System.EventHandler(this.clipMode_CheckedChanged);
            // 
            // clipboard
            // 
            this.clipboard.Location = new System.Drawing.Point(257, 100);
            this.clipboard.Name = "clipboard";
            this.clipboard.Size = new System.Drawing.Size(75, 23);
            this.clipboard.TabIndex = 7;
            this.clipboard.Text = "to clipboard";
            this.clipboard.UseVisualStyleBackColor = true;
            this.clipboard.Click += new System.EventHandler(this.clipboard_Click);
            // 
            // seamlessMode
            // 
            this.seamlessMode.AutoSize = true;
            this.seamlessMode.Location = new System.Drawing.Point(9, 104);
            this.seamlessMode.Name = "seamlessMode";
            this.seamlessMode.Size = new System.Drawing.Size(96, 17);
            this.seamlessMode.TabIndex = 6;
            this.seamlessMode.Text = "export on save";
            this.seamlessMode.UseVisualStyleBackColor = true;
            this.seamlessMode.CheckedChanged += new System.EventHandler(this.seamlessMode_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "target file";
            // 
            // sourceText
            // 
            this.sourceText.Location = new System.Drawing.Point(6, 17);
            this.sourceText.Name = "sourceText";
            this.sourceText.Size = new System.Drawing.Size(326, 20);
            this.sourceText.TabIndex = 1;
            this.sourceText.TextChanged += new System.EventHandler(this.sourceText_TextChanged);
            // 
            // targetText
            // 
            this.targetText.Location = new System.Drawing.Point(6, 54);
            this.targetText.Name = "targetText";
            this.targetText.Size = new System.Drawing.Size(326, 20);
            this.targetText.TabIndex = 0;
            this.targetText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "source folder";
            // 
            // browseTarget
            // 
            this.browseTarget.Location = new System.Drawing.Point(338, 52);
            this.browseTarget.Name = "browseTarget";
            this.browseTarget.Size = new System.Drawing.Size(75, 23);
            this.browseTarget.TabIndex = 3;
            this.browseTarget.Text = "browse...";
            this.browseTarget.UseVisualStyleBackColor = true;
            this.browseTarget.Click += new System.EventHandler(this.BrowseTarget_Click);
            // 
            // browseSource
            // 
            this.browseSource.Location = new System.Drawing.Point(338, 15);
            this.browseSource.Name = "browseSource";
            this.browseSource.Size = new System.Drawing.Size(75, 23);
            this.browseSource.TabIndex = 2;
            this.browseSource.Text = "browse...";
            this.browseSource.UseVisualStyleBackColor = true;
            this.browseSource.Click += new System.EventHandler(this.BrowseSource_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.PackageList);
            this.tabPage3.Controls.Add(this.showDocs);
            this.tabPage3.Controls.Add(this.removePackage);
            this.tabPage3.Controls.Add(this.downloadPackage);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(419, 145);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Packages";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // PackageList
            // 
            this.PackageList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.package,
            this.creator,
            this.used});
            this.PackageList.FullRowSelect = true;
            this.PackageList.GridLines = true;
            this.PackageList.HideSelection = false;
            this.PackageList.Location = new System.Drawing.Point(0, 3);
            this.PackageList.MultiSelect = false;
            this.PackageList.Name = "PackageList";
            this.PackageList.Size = new System.Drawing.Size(335, 139);
            this.PackageList.TabIndex = 4;
            this.PackageList.UseCompatibleStateImageBehavior = false;
            this.PackageList.View = System.Windows.Forms.View.Details;
            this.PackageList.SelectedIndexChanged += new System.EventHandler(this.PackageList_SelectedIndexChanged_1);
            // 
            // package
            // 
            this.package.Text = "package";
            this.package.Width = 130;
            // 
            // creator
            // 
            this.creator.Text = "creator";
            this.creator.Width = 130;
            // 
            // used
            // 
            this.used.Text = "used";
            this.used.Width = 35;
            // 
            // showDocs
            // 
            this.showDocs.Enabled = false;
            this.showDocs.Location = new System.Drawing.Point(341, 61);
            this.showDocs.Name = "showDocs";
            this.showDocs.Size = new System.Drawing.Size(75, 23);
            this.showDocs.TabIndex = 3;
            this.showDocs.Text = "docs";
            this.showDocs.UseVisualStyleBackColor = true;
            this.showDocs.Click += new System.EventHandler(this.showDocs_Click);
            // 
            // removePackage
            // 
            this.removePackage.Enabled = false;
            this.removePackage.Location = new System.Drawing.Point(341, 32);
            this.removePackage.Name = "removePackage";
            this.removePackage.Size = new System.Drawing.Size(75, 23);
            this.removePackage.TabIndex = 2;
            this.removePackage.Text = "remove";
            this.removePackage.UseVisualStyleBackColor = true;
            this.removePackage.Click += new System.EventHandler(this.removePackage_Click);
            // 
            // downloadPackage
            // 
            this.downloadPackage.Enabled = false;
            this.downloadPackage.Location = new System.Drawing.Point(341, 3);
            this.downloadPackage.Name = "downloadPackage";
            this.downloadPackage.Size = new System.Drawing.Size(75, 23);
            this.downloadPackage.TabIndex = 1;
            this.downloadPackage.Text = "download";
            this.downloadPackage.UseVisualStyleBackColor = true;
            this.downloadPackage.Click += new System.EventHandler(this.downloadPackage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 216);
            this.Controls.Add(this.status);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Seamless";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button docs;
        private System.Windows.Forms.ListView localPackageList;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader author;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button fileClass;
        private System.Windows.Forms.Button fileMain;
        private System.Windows.Forms.Button copyClass;
        private System.Windows.Forms.Button copySeamless;
        private System.Windows.Forms.Button fileSeamless;
        private System.Windows.Forms.Button copyMain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox clipMode;
        private System.Windows.Forms.Button clipboard;
        private System.Windows.Forms.CheckBox seamlessMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sourceText;
        private System.Windows.Forms.TextBox targetText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browseTarget;
        private System.Windows.Forms.Button browseSource;
        private System.Windows.Forms.Button copyAbout;
        private System.Windows.Forms.Button fileAbout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button showDocs;
        private System.Windows.Forms.Button removePackage;
        private System.Windows.Forms.Button downloadPackage;
        private System.Windows.Forms.ListView PackageList;
        private System.Windows.Forms.ColumnHeader used;
        private System.Windows.Forms.ColumnHeader package;
        private System.Windows.Forms.ColumnHeader creator;
    }
}

