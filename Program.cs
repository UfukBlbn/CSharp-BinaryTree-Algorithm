using System;

namespace BinaryTree
{ 
    class Program
    {
        class Node 
        {
            public Node Left {get;set;}
            public Node Right {get;set;}
            public int Data {get;set;}
            
        }
        class BinaryTree{
            
            public static Insert(Node root,int value)
            {
                if (root==null)
                {
                    root = new Node();
                    root.Data=value;
                    return root
                }
                else{
                    
                    if (value<root.Data)
                    {
                        root.Left=Insert(root.Left,value)
                    } 
                    else if (value>root.Data){
                        root.Right=Insert(root.Right,value)
                    }    
                }
                return root;
            }

        }
        static void Main(string[] args)
        {
            Node rootNode = new Node();
            rootNode.Data=6;
            BinaryTree.Insert(rootNode,2);
            BinaryTree.Insert(rootNode,4);
            BinaryTree.Insert(rootNode,5);
            BinaryTree.Insert(rootNode,6);
            BinaryTree.Insert(rootNode,8);
        }
    }
}
