using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryNode
    {
        #region properties
        public Int64 key { get; set; }
        public Int64 value { get; set; }
        public BinaryNode leftNode { get; set; }
        public BinaryNode rightNode { get; set; }
        #endregion
    }
}
