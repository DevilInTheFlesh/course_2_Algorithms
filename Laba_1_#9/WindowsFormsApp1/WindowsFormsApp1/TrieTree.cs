using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public struct Words
    {
        private string Wrd;
        private int count;
        public Words(string word, int count)
        {
            Wrd = word;
            this.count = count;
        }
        public void Print(TextBox text)
        {
            text.Text += (Wrd + " - " + count.ToString() + Environment.NewLine);
        }
    }
    class TrieTree
    {
        
        private TrieNode root;
        public TrieTree()
        {
            root = new TrieNode();
        }
        public TrieTree(string Path)
        {
            root = new TrieNode();
            Load(Path);
        }
        public void Load(string path)
        {
            StreamReader reader;
            string[] words;
            using (reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    words = reader.ReadLine().Trim().Split(' ');
                    for (int i=0; i<words.Length; ++i)
                    {
                        words[i] = words[i].ToLower();
                        if (!root.Find(words[i]))
                            root.Add(words[i]);
                    }
                }
            }
        }
        public void Clear ()
        {
            root.Clear();
        }
        
        public List<Words> Sort()
        {
            List<Words> res = new List<Words>();
            string buff = "";
            root.View(res, buff);
            return res;
        }
        public void Print (TextBox t, List<Words> w)
        {
            for (int i = 0; i < w.Count; ++i)
                w.ElementAt(i).Print(t);
        }
        public void Show(TreeView tree)
        {
            tree.Nodes.Clear();
            root.Show(tree);
        }
        public void Add( string wrd)
        {
            root.Add(wrd);
        }
    }
}
