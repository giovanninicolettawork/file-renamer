using System;
using System.IO;
using System.Windows.Forms;

namespace RenameFileInFolder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Remove(object sender, EventArgs e)
        {
            FileInfo[] files = GetFilesInFolder(out string replaceString);

            foreach (FileInfo f in files)
            {
                if (f.Name.Contains(replaceString))
                {
                    File.Move(f.FullName, f.FullName.Replace(replaceString, ""));
                    resultBox.Text += "File modificato: " + f.Name + Environment.NewLine;
                }

            }

        }



        private void AddAtEnd(object sender, EventArgs e)
        {
            FileInfo[] files = GetFilesInFolder(out string replaceString);

            foreach (FileInfo f in files)
            {
                {
                    string extension = Path.GetExtension(f.Name);
                    string newName = f.Name.Replace(extension, "") + replaceString + extension;
                    File.Move(f.FullName, Path.Combine(f.DirectoryName, newName));
                    resultBox.Text += "File modificato: " + f.Name + Environment.NewLine;
                }
            }
        }

        private void AddAtInit(object sender, EventArgs e)
        {
            FileInfo[] files = GetFilesInFolder(out string replaceString);

            foreach (FileInfo f in files)
            {
                File.Move(f.FullName, Path.Combine(f.DirectoryName, replaceString + f.Name));
                resultBox.Text += "File modificato: " + f.Name + Environment.NewLine;
            }
        }

        private FileInfo[] GetFilesInFolder(out string replaceString)
        {
            resultBox.Text = "";
            string folderPath = folderBox.Text;
            replaceString = stringBox.Text;

            if (String.IsNullOrEmpty(folderPath) || String.IsNullOrEmpty(replaceString))
            {
                resultBox.Text = "Compilare i campi!";
                return new FileInfo[0];
            }
            DirectoryInfo d = new DirectoryInfo(folderPath);
            return d.GetFiles("*", SearchOption.TopDirectoryOnly);

        }
    }
}
