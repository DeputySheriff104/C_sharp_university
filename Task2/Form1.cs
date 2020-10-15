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
using MyLogicLib.Task2Logic;

namespace Task2
{
    public partial class Form1 : Form
    {
        private string Name
        {
            get;
            set;
        }

        private string[] FileText
        {
            get;
            set;
        }

        private string[] FileNumbers
        {
            get;
            set;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void chooseTextFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open text file";
            openFileDialog.Filter = "Text files (*txt)|*txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Name = openFileDialog.FileName;
                richTextBoxTextFileInput.Text = File.ReadAllText(Name);
                FileText = File.ReadAllLines(Name);
            }
        }

        private void chooseNumbersFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open numbers file";
            openFileDialog.Filter = "Text files (*txt)|*txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Name = openFileDialog.FileName;
                richTextBoxNumbersFileInput.Text = File.ReadAllText(Name);
                FileNumbers = File.ReadAllLines(Name);
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            richTextBoxOutput.Text = string.Join("\n", Task2Logic.GetNewTextFile(FileNumbers, FileText));
        }
    }
}