using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaCopier
{
    public partial class Form1 : Form
    {
        [Obsolete]
        public Form1()
        {
            InitializeComponent();
            fromPath.Text = System.Configuration.ConfigurationSettings.AppSettings["fromPath"];
            toPath.Text = System.Configuration.ConfigurationSettings.AppSettings["toPath"];
            copied.Text = "0";
        }

        private void fromButton_Click(object sender, EventArgs e)
        {
            fromPath.Text = GetPathFromDialog();
        }

        private void toButton_Click(object sender, EventArgs e)
        {
            toPath.Text = GetPathFromDialog();
        }
        private string GetPathFromDialog()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    return fbd.SelectedPath;
                }
                else
                {
                    throw new Exception("Error Reading The Path");
                }
            }
        }

        private async void copy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fromPath.Text) || string.IsNullOrEmpty(toPath.Text))
            {
                MessageBox.Show("Select From And To Pathes");
                return;
            }
            copy.Enabled = false;
            fromPath.Enabled = false;
            toPath.Enabled = false;
            fromButton.Enabled = false;
            toButton.Enabled = false;
            var from = new DirectoryInfo(fromPath.Text);
            var filesToCopy = from.GetFiles();
            var count = 0;
            foreach (var file in filesToCopy)
            {
                var isExist = File.Exists($"{toPath.Text}\\{file.Name}");
                if (!isExist)
                {
                    logs.AppendText($"Copying {file.Name}\n");
                    await CopyFileAsync(file.FullName, $"{toPath.Text}\\{file.Name}");
                    count += 1;
                    copied.Text = count.ToString();
                }
                else
                {
                    logs.AppendText($"Skipping {file.Name}\n");
                }
                logs.ScrollToCaret();
            }
            copy.Enabled = true;
            fromPath.Enabled = true;
            toPath.Enabled = true;
            fromButton.Enabled = true;
            toButton.Enabled = true;
        }

        private void clean_Click(object sender, EventArgs e)
        {
            logs.Text = "";
        }
        public async Task CopyFileAsync(string sourcePath, string destinationPath)
        {
            using (Stream source = File.Open(sourcePath, FileMode.Open))
            {
                using (Stream destination = File.Create(destinationPath))
                {
                    await source.CopyToAsync(destination);
                }
            }
        }
    }
}
