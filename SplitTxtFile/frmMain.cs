using System;
using System.IO;
using System.Windows.Forms;

namespace SplitTxtFile
{
    public partial class frmMain : Form
    {
        string pathFile = "";
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLoadContact_Click(object sender, EventArgs e)
        {
            pathFile = "";
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All File txt|*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pathFile = open.FileName;
                StreamReader read = new StreamReader(open.FileName);
                while (read.Peek() > -1)
                {
                    string mobile = read.ReadLine();
                    _lbItemList.Items.Add(mobile);
                }
                read.Close();
                _lblItemCount.Text = (_lbItemList.Items.Count).ToString();
            }
        }

        private void BtnSplit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pathFile))
            {
                MessageBox.Show("Select TxT File");
                return;
            }

            if (string.IsNullOrEmpty(txtMaxSplit.Text))
            {
                MessageBox.Show("Fill Max Number");
                return;
            }

            var maxLines = int.Parse(txtMaxSplit.Text);
            var filename = pathFile;
            var fileStream = File.OpenRead(filename);
            var readStream = new StreamReader(fileStream);
            var newPath = Path.GetDirectoryName(pathFile);
            var nameBase = Path.GetFileNameWithoutExtension(filename); //strip .txt

            var parts = 0;
            var notfinished = true;
            while (notfinished)
            {
                var part = File.OpenWrite($"{newPath}\\{nameBase}-{parts}.txt");
                var writer = new StreamWriter(part);
                for (int i = 0; i < maxLines; i++)
                {
                    writer.WriteLine(readStream.ReadLine());
                    if (readStream.EndOfStream)
                    {
                        notfinished = false;
                        break;
                    }
                }
                writer.Close();
                parts++;
            }
            MessageBox.Show($"Done splitting the file into {parts} parts.");
        }

        private void btnClearContact_Click(object sender, EventArgs e)
        {
            _lbItemList.Items.Clear();
            _lblItemCount.Text = _lbItemList.Items.Count.ToString();
            pathFile = "";
        }
    }
}
