using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class TrieNode
    {
        static readonly int ToLetter = (int)'a';
        public TrieNode()
        {
            Point = null;
            for (int i = 0; i < Next.Length; ++i)
            {
                Next[i] = null;
            }
        }
        public TrieNode this[char letter]
        {
            get
            {
                return Next[letter - ToLetter];
            }
            set
            {
                Next[letter - ToLetter] = new TrieNode();
            }
        }
        public static bool CheckWord (string wrd)
        {
            for (int i = 0; i < wrd.Length; ++i)
                if (wrd[i] < 'a' || wrd[i] > 'z')
                    return false;
            return true;
        }
        uint? Point;
        TrieNode[] Next = new TrieNode[(int)'z' - ToLetter + 1];

        public bool Add (string wrd)
        {
            if (wrd==String.Empty)
            {
                bool res = Point==null;
                if (res)
                    Point = 1;
                else
                    Point++;
                return res;
            }
            else
            {
                //MessageBox.Show("In Adding");
                char ch = wrd[0];
                wrd = wrd.Remove(0, 1);
                if (this[ch] == null)
                    this[ch] = new TrieNode();
                return this[ch].Add(wrd);
            }
        }
        public bool Find (string wrd)
        {
            if (wrd == String.Empty)
            {
                Point++;
                return Point-1 > 0;
            }
            return (this[wrd[0]] != null && this[wrd[0]].Find(wrd.Remove(0, 1)));
        }
        public bool Delete (string wrd)
        {
            char c;
            if (wrd==String.Empty)
            {
                Point = null;
                return false;
            }
            else
            {
                c = wrd[0];
                wrd = wrd.Remove(0, 1);
                bool b = Next[c] != null && Next[c].Delete(wrd);
                return b;
            }
        }
        public bool IsEmpty()
        {
            for (int i = 0; i < Next.Length; ++i)
                if (Next[i] != null)
                    return false;
            return true;
        }
        public void Clear()
        {
            for (int i = 0; i < Next.Length; ++i)
                if (Next[i] != null)
                {
                    Next[i].Clear();
                    Next[i] = null;
                }
                    
            Point = null;
        }
        public void View(List<Words> words, string buff)
        {
            if (Point!=null)
                words.Add(new Words(buff, (int)Point));
            else
                for (int i = 0; i < Next.Length; ++i)
                    if (Next[i] != null)
                        Next[i].View(words, buff + (char)(i + ToLetter));
        }
        void HelpShow (TreeNode node)
        {
            for (char i = 'a'; i<='z'; ++i)
                if (this[i]!=null)
                {
                    TreeNode treeNode = new TreeNode(i.ToString());
                    node.Nodes.Add(treeNode);
                    this[i].HelpShow(treeNode);
                }
        }
        public void Show (TreeView tree)
        {
            TreeNode treeNode = new TreeNode();
            tree.Nodes.Add(treeNode);
            HelpShow(treeNode);
        }
    }
}
