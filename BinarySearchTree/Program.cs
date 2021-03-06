﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {

            BinaryTree.MaxSubArrayNonNegative();
            BinaryTree theTree = new BinaryTree();

            theTree.InsertIteratively(42);
            theTree.InsertIteratively(25);
            theTree.InsertIteratively(65);
            theTree.InsertIteratively(12);
            theTree.InsertIteratively(37);
            theTree.InsertIteratively(13);
            theTree.InsertIteratively(30);
            theTree.InsertIteratively(43);
            theTree.InsertIteratively(87);
            theTree.InsertIteratively(99);
            theTree.InsertIteratively(9);

           theTree.Delete(42);
           theTree.Delete(37); 
            theTree.Delete(13);
            theTree.Delete(9);

            theTree.Delete(999);// not tested
          //theTree.InsertRecrusively(42);
           //theTree.InsertRecrusively(25);
          //  theTree.InsertRecrusively(65);
           // theTree.InsertRecrusively( 12);
            //theTree.InsertRecrusively(37);
            //theTree.InsertRecrusively(13);
            //theTree.InsertRecrusively(30);
            //theTree.InsertRecrusively(43);
            //theTree.InsertRecrusively(87);
            //theTree.InsertRecrusively(99);
            //theTree.InsertRecrusively(9);
 
        }
    }
}
