using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyFilesSaveStract
{
	public partial class Form1
	{
		internal void DirRefresh(string path, string mask)
		{
            try
            {
                string[] files = Directory.GetFiles(path, mask, SearchOption.AllDirectories);
                if (files.Length > 0)
                {
                    if (listView1.Items.Count > 0)
                        listView1.Items.Clear();

                    foreach (string file in files)
                    {
                        ListViewItem lvi = new ListViewItem();
                        // установка названия файла
                        //lvi.Text = file.Remove(0, file.LastIndexOf('\\') + 1);
                        lvi.Text = file;
                        lvi.ImageIndex = 0; // установка картинки для файла
                                            // добавляем элемент в ListView
                        listView1.Items.Add(lvi);

                    }
                    labCountFiles.Text = files.Length.ToString();
                }
            }
			catch (Exception ex)
			{
                MessageBox.Show(ex.Message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

		}

		internal bool OneChoiseM(int count, string spath)
		{
			if (count > 0 & !string.IsNullOrEmpty(spath))
				return true;
			else return false;
		}

		internal bool TwoChoiseM(string spath)
		{
			if (!string.IsNullOrEmpty(spath) & !spath.Contains("__________"))
                return true;
            else return false;
        }
        
        
        internal static long GetDirectorySize(string folderPath)
        {
            DirectoryInfo di = new DirectoryInfo(folderPath);
            return di.EnumerateFiles("*.*", SearchOption.AllDirectories).Sum(fi => fi.Length);
        }

    }
}
