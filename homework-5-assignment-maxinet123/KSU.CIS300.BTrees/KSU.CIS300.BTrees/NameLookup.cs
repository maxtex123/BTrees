/* Maxine Teixeira
 * NameLookup.cs
 */
using KansasStateUniversity.TreeViewer2;
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

namespace KSU.CIS300.BTrees
{
    public partial class NameLookup : Form
    {
        /// <summary>
        /// Globally stores the tree that is created by reading in a name information file.
        /// </summary>
        private BTree<string, NameInformation> _names;
        /// <summary>
        /// Initializes the UI components.
        /// </summary>
        public NameLookup()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Opens a OpenFileDialog box for selecting a name information text file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxOpen_Click(object sender, EventArgs e)
        {
            if (uxOpenDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _names = ReadFile(uxOpenDialog.FileName);
                    //MessageBox.Show("File found.");
                    new TreeForm(_names, 100).Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        /// <summary>
        /// Takes in the filename of a name information file and reads it using a StreamReader.
        /// </summary>
        /// <param name="filename">Name of the file.</param>
        /// <returns>BTree with the newly added information.</returns>
        private BTree<string, NameInformation> ReadFile(string filename)
        {
            int min = Convert.ToInt32(uxMinDegree.Value);
            BTree<string, NameInformation> tree = new BTree<string, NameInformation>(min);
            using (StreamReader sr = new StreamReader(filename))
            {
                while (!sr.EndOfStream)
                {
                    string name = sr.ReadLine().Trim();
                    float Frequency = Convert.ToSingle(sr.ReadLine());
                    int Rank = Convert.ToInt32(sr.ReadLine());
                    tree.Insert(name, new NameInformation(name, Frequency, Rank));
                }
            }
            return tree;
        }
        /// <summary>
        /// Takes the text from the name textbox and searches for it in the BTree by calling Find.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxLookup_Click(object sender, EventArgs e)
        {
            try
            {
                string name = uxName.Text.Trim().ToUpper();
                NameInformation info = _names.Find(name);
                if (info.Name == null)
                {
                    MessageBox.Show("Information not found.");
                    uxFrequency.Clear();
                    uxRank.Clear();
                }
                else
                {
                    uxFrequency.Text = info.Frequency.ToString();
                    uxRank.Text = info.Rank.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void UxMakeTree_Click(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(uxMinDegree.Value);
            BTree<int, int> tree = new BTree<int, int>(min);
            for (int i = 1; i <= Convert.ToInt32(uxCount.Text); i++)
            {
                tree.Insert(i, i);
            }
            new TreeForm(tree, 100).Show();
        }
    }
}
