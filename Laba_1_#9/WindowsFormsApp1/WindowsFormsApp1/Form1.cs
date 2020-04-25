using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private TrieTree tree;
        public Form1()
        {
            InitializeComponent();
            tree = new TrieTree();
        }

       
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
       

        private void chooseFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tree.Clear();
            Result.Text = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Open file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tree.Load(openFileDialog.FileName);
                SourceText.Text = File.ReadAllText(openFileDialog.FileName)+Environment.NewLine;
            }
        }

        private void makeTheTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Words> wrds = tree.Sort();
            tree.Print(this.Result, wrds);
        }

        

        private void displayTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            TreeView treeV = new TreeView();
            tree.Show(treeV);
            treeV.Height = 360;
            treeV.Width = 540;
            treeV.Scrollable = true;
            treeV.MaximumSize = new Size(540, 360);
            treeV.Location = new Point(10, 10);
            form.Width = 600;
            form.Height = 460;
            form.Controls.Add(treeV);
            treeV.Visible = true;
            form.Show();
        }

        private void saveResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "txt files (*.txt)|*.txt";
            if (saveFile.ShowDialog()==DialogResult.OK)
            {
              //  File.Create(saveFile.FileName);
                File.WriteAllLines(saveFile.FileName, Result.Lines);
            }
        }

        private void addWordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string res = Interaction.InputBox("Input new word");
            if (res != String.Empty)
            {
                tree.Add(res);
                SourceText.Text += res+ Environment.NewLine;
            }
        }
    }
}
