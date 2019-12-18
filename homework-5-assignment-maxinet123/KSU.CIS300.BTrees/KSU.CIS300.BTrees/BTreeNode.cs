/* Maxine Teixeira
 * BTreeNode.cs
 */
using KansasStateUniversity.TreeViewer2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSU.CIS300.BTrees
{
    public class BTreeNode<TKey, TValue> : ITree where TKey : IComparable<TKey>
    {
        /// <summary>
        /// Keeps track of how many keys are currently in this node.
        /// </summary>
        public int KeyCount { get; private set; }
        /// <summary>
        /// Stores the minimum number of keys this node can have.
        /// </summary>
        public int _minKeyCount { get; private set; }
        /// <summary>
        /// Holds the keys of this node in ascending order.
        /// </summary>
        private TKey[] _keys;
        /// <summary>
        /// Keeys track of the number of children in this node.
        /// </summary>
        public int ChildCount { get; private set; }
        /// <summary>
        /// Stores the pointers to the children of this node.
        /// </summary>
        private BTreeNode<TKey, TValue>[] _children;
        /// <summary>
        /// Stores the values of the corresponding keys from the _keys array.
        /// </summary>
        private TValue[] _values;
        /// <summary>
        /// Indicates if this node is a leaf or not.
        /// </summary>
        public bool IsLeaf { get; private set; }
        /// <summary>
        /// A property that returns if the number of keys in this node is 0.
        /// </summary>
        public bool IsEmpty => KeyCount == 0;
        /// <summary>
        /// A property that returns this.
        /// </summary>
        public object Root => this;
        /// <summary>
        /// Holds all the children trees
        /// </summary>
        public ITree[] Children => _children;
        /// <summary>
        /// Holds all the children trees
        /// </summary>
        public BTreeNode<TKey, TValue>[] GetChildren
        {
            get { return _children; }
        }
        /// <summary>
        /// Initializes the corresponding private fields.
        /// </summary>
        /// <param name="minKeyCount"></param>
        /// <param name="maxKeyCount"></param>
        /// <param name="maxChildCount"></param>
        /// <param name="leaf"></param>
        public BTreeNode(int minKeyCount, int maxKeyCount, int maxChildCount, bool leaf)
        {
            _minKeyCount = minKeyCount;
            _keys = new TKey[maxKeyCount];
            _values = new TValue[maxKeyCount];
            _children = new BTreeNode<TKey, TValue>[maxChildCount];
            IsLeaf = leaf;
        }
        /// <summary>
        /// Inserts the key in ascending order and inserts the value at that index. 
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        public void AddItem(TKey key, TValue value)
        {
            for (int i = KeyCount - 1; i >= 0; i--)
            {
                int c = _keys[i].CompareTo(key);
                if (c <= 0)
                {
                    _keys[i + 1] = key;
                    _values[i + 1] = value;
                    KeyCount++;
                    return;
                }
                else
                {
                    _keys[i + 1] = _keys[i];
                    _values[i + 1] = _values[i];
                }
            }
            _keys[0] = key;
            _values[0] = value;
            KeyCount++;
        }
        /// <summary>
        /// Helper method that stores the child node in the _children array at index i and increments the number of children.
        /// </summary>
        /// <param name="i">The index.</param>
        /// <param name="child">The child node.</param>
        public void AddChild(int i, BTreeNode<TKey, TValue> child)
        {
            _children[i] = child;
            ChildCount++;
        }
        /// <summary>
        /// Splits parts of the new node once a node in the BTree is full.
        /// </summary>
        /// <param name="index">The index that indicates what child to split.</param>
        public void SplitChild(int index)
        {
            BTreeNode<TKey, TValue> split =  _children[index];
            BTreeNode<TKey, TValue> b = new BTreeNode<TKey, TValue>(_minKeyCount, _keys.Length, _children.Length, split.IsLeaf);
            for (int i = 0, k = i +_minKeyCount  + 1; i < _minKeyCount; i++, k++)
            {
                b.AddItem(split._keys[k], split._values[k]);
                split._keys[k] = default;
                split._values[k] = default;
            }
            if (!b.IsLeaf)
            {
                for (int i = (_children.Length + 1) / 2, k = 0; i < _children.Length; i++, k++)
                {
                    if (split._children[i] != null)
                    {
                        b.AddChild(k, split._children[i]);
                        split._children[i] = null;
                        split.ChildCount--;
                    }
                }
            }
            split.KeyCount = _minKeyCount;
            for (int i = KeyCount; i >= index + 1; i--)
            {
                _children[i + 1] = _children[i];
            }
            AddChild(index + 1, b);
            AddItem(split._keys[_minKeyCount], split._values[_minKeyCount]);
            split._keys[_minKeyCount] = default;
            split._values[_minKeyCount] = default;
        }
        /// <summary>
        /// Inserts into a tre whose root node is not full already.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        public void InsertNonFull(TKey key, TValue value)
        {
            if (IsLeaf)
            {
                AddItem(key, value);
            }
            else
            {
                int k = 0;
                while (k < KeyCount && _keys[k].CompareTo(key) < 0)
                {
                    k++;
                }
                //for (; k < KeyCount && _keys[k].CompareTo(key) < 0; k++) ;
                if (_children[k].KeyCount == _keys.Length)
                {
                    SplitChild(k);
                    if (_keys[k].CompareTo(key) < 0)
                    {
                        k++;
                    }
                }
                _children[k].InsertNonFull(key, value);
            }
        }
        /// <summary>
        /// Recursively binary searches for value of the index.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>The value of the index.</returns>
        public TValue Find(TKey key)
        {
            int num = Array.IndexOf(_keys, key);
            if (num > -1)
            {
                return _values[num];
            }
            if (IsLeaf)
            {
                return default;
            }
            else
            {
                int k = 0;
                while (k < KeyCount && _keys[k].CompareTo(key) < 0)
                {
                    k++;
                }
                return _children[k].Find(key);
            }
        }
        /// <summary>
        /// Converts the array of keys to a string.
        /// </summary>
        /// <returns>A string of the keys.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (IsLeaf)
            {
                sb.Append("*: ");
            }
            for (int i = 0; i < KeyCount; i++)
            {
                int c = _keys[i].CompareTo(default);
                if (_keys[i] != null && c != 0)
                {
                    sb.Append(_keys[i]);
                    sb.Append(" | ");
                }
            }
            sb.Length -= 3;
            return sb.ToString();
        }
    }
}
