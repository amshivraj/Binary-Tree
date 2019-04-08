using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryTree
    {
        public List<BinaryNode> tree { get; set; }
        public BinaryTree()
        {
            tree = new List<BinaryNode>();
        }
        public BinaryTree(Int64[] arr)
        {
            tree = new List<BinaryNode>();
            MakeATree(arr);
        }

        public List<BinaryNode> MakeATree(Int64[] arr)
        {
            foreach(var item in arr)
            {
                Insert(item);
            }
            return tree;
        }

        public void Insert(Int64 element)
        {
            if (tree.Any())
            {
                var item = tree.First();
            x :  if (element < item.key)
                    {
                    if (item.leftNode != null)
                    {
                        item = item.leftNode;
                        goto x;
                    }
                    else
                    {
                        item.leftNode = new BinaryNode();
                        item.leftNode.key = element;
                        //return true;
                    }
                    }
                    else if (element > item.key)
                    {
                        if (item.rightNode != null)
                    {
                        item = item.rightNode;
                        goto x;
                    }
                        
                    else
                        {
                            item.rightNode = new BinaryNode();
                            item.rightNode.key = element;
                           // return true;
                        }
                    }
                
            }
            else
            {
                var node = new BinaryNode();
                node.key = element;
                tree.Add(node);
                //return true;
            }
        }

        public bool IsContains(Int64 element)
        {
            if (tree != null)
            {
                var treeNode = tree.First();
                var res = IsContains(treeNode, element);
                return res;
            }
            else return false;
            
        }
        private bool IsContains(BinaryNode node,Int64 searchElement)
        {
            try
            {
                if (node != null)
                {
                    if (node.key == searchElement)
                    {
                        Console.WriteLine(searchElement + "--" + true);
                        return true;
                    }
                    //else 
                    //{
                    //    Console.WriteLine(searchElement + "--" + contains);
                    //    return false;
                    //} 
                    if (node.leftNode != null)
                        IsContains(node.leftNode, searchElement);
                    if (node.rightNode != null)
                        IsContains(node.rightNode, searchElement);
                }
                //Console.WriteLine(searchElement + "--" + false);
                return false;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            
        }
    }
}
