using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CopyFilesSaveStract
{
    internal class DataFiles : IDataProvider
    {
        private string PathDirTarget { get; }
        private string PathDirSrc { get; }
        private string FileName { get;}
        private string FileNewName = "Undefined";
        public string fileNewName { 
            get { return FileName.Replace(PathDirSrc, PathDirTarget); }
            set { fileNewName = value; }
        }

        public DataFiles(string pathDirTarget, string pathDirSrc, string fileName)
        {
            PathDirTarget = pathDirTarget;
            PathDirSrc = pathDirSrc;
            FileName = fileName;

        }

        public void FileCopy()
        {
            string NewPathDir = fileNewName.Remove(fileNewName.LastIndexOf("\\"));
            try
            {
                if (!Directory.Exists(NewPathDir))
                    Directory.CreateDirectory(NewPathDir);
                if(FileName.Length > 255 | fileNewName.Length > 255)
                {
                    File.Copy("\\\\?\\"+FileName, "\\\\?\\" + fileNewName, true);
                } else
                {
                    File.Copy(FileName, fileNewName, true);
                }
            } catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public int GetLengthFileName() => FileName.Length;
    }
}
