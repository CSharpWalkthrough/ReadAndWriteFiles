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
        private void cboFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: Display the selected file's content in the listbox
        }

        private void ReadFile(string file)
        {
            // TODO: Read the file passed as parameter and display its content in the listbox
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            // TODO: Call the AppendToFile method, richTextBox should not be empty
        }
        private void AppendToFile(string content, string file)
        {
            // TODO: Append the content to the file and refresh the listbox
        }

        private void btnOverride_Click(object sender, EventArgs e)
        {
            // TODO: Call the OverrideFile method, richTextBox should not be empty
        }
        private void OverrideFile(string content, string file)
        {
            // TODO: Override the file's content and refresh the listbox
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // TODO: Reset the file's content to an empty string
        }
    }
}
