using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void print(BinaryNode result)
        {
            //x:Console.WriteLine("me - " + result.key);
            //    if (result.leftNode != null)
            //    {
            //        Console.WriteLine("my left child - " + result.leftNode.key);
            //        result = result.leftNode;
            //        goto x;
            //    }

            //    if (result.rightNode != null)
            //    {
            //        Console.WriteLine("my right child - " + result.rightNode.key);
            //        result = result.rightNode;
            //        goto x;
            //    }
            if (result != null)
            {
                Console.WriteLine(result.key);
                print(result.leftNode);
                print(result.rightNode);
            }            
        }
        static void Main(string[] args)
        {
            Int64 [] arr = { 1, 9, 8, 16, 999, 566, 91 };
            var obj = new BinaryTree(arr);
            var result = obj.tree.FirstOrDefault();
            // foreach (var item in result)
            // {
            if (result != null)
            {
                print(result);
            }
            // }
            var a=obj.IsContains(999);
            var b= obj.IsContains(888);
            var c = obj.IsContains(8);
            Console.WriteLine(a + "-" + b + "-" + c);
            Console.ReadKey();
        }
    }
}
