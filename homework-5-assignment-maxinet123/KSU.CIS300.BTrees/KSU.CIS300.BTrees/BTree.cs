/* Maxine Teixeira
 * BTree.cs
 */
using KansasStateUniversity.TreeViewer2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSU.CIS300.BTrees
{
    public class BTree<TKey, TValue> : ITree where TKey : IComparable<TKey>
    {
        /// <summary>
        /// The minimum degree of the tree and minimum number of children for nodes in the tree.
        /// </summary>
        public int _size { get; private set; }
        /// <summary>
        /// The maximum number of children for the nodes in the tree.
        /// </summary>
        public int _maxChildren { get; private set; }
        /// <summary>
        /// The minimum number of keys for each node of the tree, excluding the root.
        /// </summary>
        public int _minKeys { get; private set; }
        /// <summary>
        /// The maximum number of keys for each node of the tree.
        /// </summary>
        public int _maxKeys { get; private set; }
        /// <summary>
        /// The root node of the tree.
        /// </summary>
        private BTreeNode<TKey, TValue> _root;
        /// <summary>
        /// A public property that returns boolean depending if root is null.
        /// </summary>
        public bool IsEmpty
        {
            get
            {
                return _root == null;
            }
        }
        /// <summary>
        /// A public property that returns the children of the root node.
        /// </summary>
        public ITree[] Children => (ITree[])_root.Children;
        /// <summary>
        /// A public property that gets the root of the node.
        /// </summary>
        public BTreeNode<TKey, TValue> Root => _root;
        /// <summary>
        /// Gets the Root Node.
        /// </summary>
        public BTreeNode<TKey, TValue> GetRootNode
        {
            get
            {
                return _root;
            }
        }

        object ITree.Root => _root;
        /// <summary>
        /// Initializes all corresponding fields.
        /// </summary>
        /// <param name="size">The size.</param>
        public BTree(int size)
        {
            if (size < 2)
            {
                throw new InvalidOperationException();
            }
            _size = size;
            _maxChildren = size * 2;
            _minKeys = size - 1;
            _maxKeys = size * 2 - 1;
            _root = new BTreeNode<TKey, TValue>(_minKeys, _maxKeys, _maxChildren, true);
        }
        /// <summary>
        /// Inserts a node into the BTree starting at the root.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        public void Insert(TKey key, TValue value)
        {
            if (_root.IsEmpty)
            {
                _root.AddItem(key, value);
            }
            else
            {
                if (_root.KeyCount >= _maxKeys)
                {
                    BTreeNode<TKey, TValue> newRoot = new BTreeNode<TKey, TValue>(_minKeys, _maxKeys, _maxChildren, false);
                    newRoot.AddChild(0, _root);
                    newRoot.SplitChild(0);
                    _root = newRoot;
                    _root.InsertNonFull(key, value);
                }
                else
                {
                    _root.InsertNonFull(key, value);
                }
            }
        }
        /// <summary>
        /// Helper method that calls Find on the root node.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>The value results of the search</returns>
        public TValue Find(TKey key)
        {
            return _root.Find(key);
        }
    }
}
