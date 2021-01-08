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

namespace ReadAndWriteFiles.Exercice
{
    public partial class FrmMain : Form
    {
        private string[] files = new string[] { "fruits.txt", "sports.txt", "games.txt" };
        public FrmMain()
        {
            InitializeComponent();
            cboFiles.Items.AddRange(files);
            cboFiles.SelectedIndex = 0;
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtxWriter.Text))
                return;
            string content = rtxWriter.Text + Environment.NewLine;
            string file = cboFiles.SelectedItem.ToString();
            AppendToFile(content, file);
        }

        private void btnOverride_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtxWriter.Text))
                return;
            string content = rtxWriter.Text + Environment.NewLine;
            string file = cboFiles.SelectedItem.ToString();
            OverrideFile(content, file);
        }

        private void cboFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string file = cboFiles.SelectedItem.ToString();
            ReadFile(file);
        }

        private void ReadFile(string file)
        {
            lstReader.Items.Clear();
            if (!File.Exists(file))
                return;

            string[] lines = File.ReadAllLines(file);
            foreach (string line in lines)
                lstReader.Items.Add(line);
        }

        private void AppendToFile(string content, string file)
        {
            File.AppendAllText(file, content);
            ReadFile(file);
        }

        private void OverrideFile(string content, string file)
        {
            File.WriteAllText(file, content);
            ReadFile(file);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string file = cboFiles.SelectedItem.ToString();
            File.WriteAllText(file, string.Empty);
            ReadFile(file);
        }
    }
}
