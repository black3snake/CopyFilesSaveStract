using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CopyFilesSaveStract
{
    public partial class Form1 : Form
    {
        List<string> listSelectFiles = new List<string>();
        //static bool CompliteChoise = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void opemDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            DialogResult result = folderBrowser.ShowDialog();

            if (!string.IsNullOrEmpty(folderBrowser.SelectedPath))
            {
                labDirSrcName.Text = folderBrowser.SelectedPath;

                DirRefresh(folderBrowser.SelectedPath, toolStripTextBox1.Text);

            }
            
            listView1.SmallImageList = imageList1;
            
        }

        private void destinationDirectoriyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            DialogResult result = folderBrowser.ShowDialog();

            if (!string.IsNullOrEmpty(folderBrowser.SelectedPath))
            {
                DiskInfo diskInfo = new DiskInfo(folderBrowser.SelectedPath);

                labDirTargetName.Text = folderBrowser.SelectedPath;

                DriveInfo[] drives = DriveInfo.GetDrives();

                var test = drives.Where(s => s.Name == folderBrowser.SelectedPath.Remove(folderBrowser.SelectedPath.IndexOf("\\") + 1));
                var SizeD = test.Select(s =>s.AvailableFreeSpace).ToArray();
                labDostupnoGb.Text = ((double)SizeD[0]/1024/1024/1024).ToString("F2") + " Gb"; 
                
            }


        }

        private async void copyFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( !OneChoiseM(listView1.Items.Count, labDirSrcName.Text) & !TwoChoiseM(labDirTargetName.Text))
            {
                MessageBox.Show("Всё пошло не так..(ничего не выбрано", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!OneChoiseM(listView1.Items.Count, labDirSrcName.Text))
            {
                MessageBox.Show("В верхнем окне нет файлов или не выбрана директория", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            }
            else if (!TwoChoiseM(labDirTargetName.Text))
            {
                MessageBox.Show("В нижнеи окне не выбрана директория", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            }

            foreach (ListViewItem item in listView1.Items )
            {
                listSelectFiles.Add(item.Text);
            }
            ConsoleTB.AppendText($"Все проверки прошли запускаем копирование.." + Environment.NewLine);

            ConsoleTB.ScrollBars = ScrollBars.Vertical;

            copyFilesToolStripMenuItem.Enabled = false;
            await ZapuskAsync(listSelectFiles);
            copyFilesToolStripMenuItem.Enabled = true;

            labRazmer.Text = ((double)GetDirectorySize(labDirTargetName.Text)/ 1024 / 1024).ToString("F2") + " Mb";
            
            ConsoleTB.AppendText($"Общее количество файлов скопировано: {bc.Count}" + Environment.NewLine);

        }
    }
}
