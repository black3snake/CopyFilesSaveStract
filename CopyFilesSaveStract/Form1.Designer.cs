namespace CopyFilesSaveStract
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opemDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destinationDirectoriyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearSelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maskForFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.labDirSrc = new System.Windows.Forms.Label();
            this.labDirSrcName = new System.Windows.Forms.Label();
            this.labCountN = new System.Windows.Forms.Label();
            this.labCountFiles = new System.Windows.Forms.Label();
            this.labDirTarget = new System.Windows.Forms.Label();
            this.labDirTargetName = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.labDostupnoGb = new System.Windows.Forms.Label();
            this.labDostupno = new System.Windows.Forms.Label();
            this.ConsoleTB = new System.Windows.Forms.TextBox();
            this.labTimeName = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.labRazmerName = new System.Windows.Forms.Label();
            this.labRazmer = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.copyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1187, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opemDirectoryToolStripMenuItem,
            this.destinationDirectoriyToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.clearSelectToolStripMenuItem,
            this.maskForFilesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // opemDirectoryToolStripMenuItem
            // 
            this.opemDirectoryToolStripMenuItem.Name = "opemDirectoryToolStripMenuItem";
            this.opemDirectoryToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.opemDirectoryToolStripMenuItem.Text = "&Opem Directory";
            this.opemDirectoryToolStripMenuItem.Click += new System.EventHandler(this.opemDirectoryToolStripMenuItem_Click);
            // 
            // destinationDirectoriyToolStripMenuItem
            // 
            this.destinationDirectoriyToolStripMenuItem.Name = "destinationDirectoriyToolStripMenuItem";
            this.destinationDirectoriyToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.destinationDirectoriyToolStripMenuItem.Text = "Destination Directoriy";
            this.destinationDirectoriyToolStripMenuItem.Click += new System.EventHandler(this.destinationDirectoriyToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.selectAllToolStripMenuItem.Text = "&Select All";
            // 
            // clearSelectToolStripMenuItem
            // 
            this.clearSelectToolStripMenuItem.Name = "clearSelectToolStripMenuItem";
            this.clearSelectToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.clearSelectToolStripMenuItem.Text = "&Clear Select";
            // 
            // maskForFilesToolStripMenuItem
            // 
            this.maskForFilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.maskForFilesToolStripMenuItem.Name = "maskForFilesToolStripMenuItem";
            this.maskForFilesToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.maskForFilesToolStripMenuItem.Text = "&Mask for Files";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox1.Text = "*.srt";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyFilesToolStripMenuItem});
            this.copyToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // copyFilesToolStripMenuItem
            // 
            this.copyFilesToolStripMenuItem.Name = "copyFilesToolStripMenuItem";
            this.copyFilesToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.copyFilesToolStripMenuItem.Text = "&Copy Files";
            this.copyFilesToolStripMenuItem.Click += new System.EventHandler(this.copyFilesToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 51);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1178, 235);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // labDirSrc
            // 
            this.labDirSrc.AutoSize = true;
            this.labDirSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labDirSrc.Location = new System.Drawing.Point(13, 32);
            this.labDirSrc.Name = "labDirSrc";
            this.labDirSrc.Size = new System.Drawing.Size(79, 18);
            this.labDirSrc.TabIndex = 2;
            this.labDirSrc.Text = "Источник:";
            // 
            // labDirSrcName
            // 
            this.labDirSrcName.AutoSize = true;
            this.labDirSrcName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labDirSrcName.Location = new System.Drawing.Point(98, 32);
            this.labDirSrcName.Name = "labDirSrcName";
            this.labDirSrcName.Size = new System.Drawing.Size(120, 18);
            this.labDirSrcName.TabIndex = 2;
            this.labDirSrcName.Text = "______________";
            // 
            // labCountN
            // 
            this.labCountN.AutoSize = true;
            this.labCountN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labCountN.Location = new System.Drawing.Point(977, 32);
            this.labCountN.Name = "labCountN";
            this.labCountN.Size = new System.Drawing.Size(155, 18);
            this.labCountN.TabIndex = 2;
            this.labCountN.Text = "Количество файлов:";
            // 
            // labCountFiles
            // 
            this.labCountFiles.AutoSize = true;
            this.labCountFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labCountFiles.Location = new System.Drawing.Point(1132, 32);
            this.labCountFiles.Name = "labCountFiles";
            this.labCountFiles.Size = new System.Drawing.Size(32, 18);
            this.labCountFiles.TabIndex = 2;
            this.labCountFiles.Text = "___";
            // 
            // labDirTarget
            // 
            this.labDirTarget.AutoSize = true;
            this.labDirTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labDirTarget.Location = new System.Drawing.Point(12, 299);
            this.labDirTarget.Name = "labDirTarget";
            this.labDirTarget.Size = new System.Drawing.Size(46, 18);
            this.labDirTarget.TabIndex = 2;
            this.labDirTarget.Text = "Куда:";
            // 
            // labDirTargetName
            // 
            this.labDirTargetName.AutoSize = true;
            this.labDirTargetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labDirTargetName.Location = new System.Drawing.Point(64, 299);
            this.labDirTargetName.Name = "labDirTargetName";
            this.labDirTargetName.Size = new System.Drawing.Size(120, 18);
            this.labDirTargetName.TabIndex = 2;
            this.labDirTargetName.Text = "______________";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "leo.jpg");
            // 
            // labDostupnoGb
            // 
            this.labDostupnoGb.AutoSize = true;
            this.labDostupnoGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labDostupnoGb.Location = new System.Drawing.Point(1055, 299);
            this.labDostupnoGb.Name = "labDostupnoGb";
            this.labDostupnoGb.Size = new System.Drawing.Size(120, 18);
            this.labDostupnoGb.TabIndex = 2;
            this.labDostupnoGb.Text = "______________";
            // 
            // labDostupno
            // 
            this.labDostupno.AutoSize = true;
            this.labDostupno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labDostupno.Location = new System.Drawing.Point(904, 299);
            this.labDostupno.Name = "labDostupno";
            this.labDostupno.Size = new System.Drawing.Size(145, 18);
            this.labDostupno.TabIndex = 2;
            this.labDostupno.Text = "Доступно на диске:";
            // 
            // ConsoleTB
            // 
            this.ConsoleTB.Location = new System.Drawing.Point(3, 322);
            this.ConsoleTB.Multiline = true;
            this.ConsoleTB.Name = "ConsoleTB";
            this.ConsoleTB.Size = new System.Drawing.Size(1177, 214);
            this.ConsoleTB.TabIndex = 3;
            // 
            // labTimeName
            // 
            this.labTimeName.AutoSize = true;
            this.labTimeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labTimeName.Location = new System.Drawing.Point(4, 537);
            this.labTimeName.Name = "labTimeName";
            this.labTimeName.Size = new System.Drawing.Size(146, 18);
            this.labTimeName.TabIndex = 2;
            this.labTimeName.Text = "Затрачено вресени:";
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labTime.Location = new System.Drawing.Point(146, 537);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(120, 18);
            this.labTime.TabIndex = 2;
            this.labTime.Text = "______________";
            // 
            // labRazmerName
            // 
            this.labRazmerName.AutoSize = true;
            this.labRazmerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labRazmerName.Location = new System.Drawing.Point(878, 539);
            this.labRazmerName.Name = "labRazmerName";
            this.labRazmerName.Size = new System.Drawing.Size(180, 18);
            this.labRazmerName.TabIndex = 2;
            this.labRazmerName.Text = "Размер файлов в папки:";
            // 
            // labRazmer
            // 
            this.labRazmer.AutoSize = true;
            this.labRazmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labRazmer.Location = new System.Drawing.Point(1055, 537);
            this.labRazmer.Name = "labRazmer";
            this.labRazmer.Size = new System.Drawing.Size(120, 18);
            this.labRazmer.TabIndex = 2;
            this.labRazmer.Text = "______________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 622);
            this.Controls.Add(this.ConsoleTB);
            this.Controls.Add(this.labRazmer);
            this.Controls.Add(this.labDostupnoGb);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.labDirTargetName);
            this.Controls.Add(this.labDirSrcName);
            this.Controls.Add(this.labCountFiles);
            this.Controls.Add(this.labCountN);
            this.Controls.Add(this.labRazmerName);
            this.Controls.Add(this.labDostupno);
            this.Controls.Add(this.labTimeName);
            this.Controls.Add(this.labDirTarget);
            this.Controls.Add(this.labDirSrc);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "CopyFiles";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opemDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maskForFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearSelectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyFilesToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label labDirSrc;
        private System.Windows.Forms.Label labDirSrcName;
        private System.Windows.Forms.ToolStripMenuItem destinationDirectoriyToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Label labCountN;
        private System.Windows.Forms.Label labCountFiles;
        private System.Windows.Forms.Label labDirTarget;
        private System.Windows.Forms.Label labDirTargetName;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label labDostupnoGb;
        private System.Windows.Forms.Label labDostupno;
        private System.Windows.Forms.TextBox ConsoleTB;
        private System.Windows.Forms.Label labTimeName;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Label labRazmerName;
        private System.Windows.Forms.Label labRazmer;
    }
}

