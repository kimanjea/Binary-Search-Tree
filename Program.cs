using System;
using System.Dynamic;
using System.Runtime;
using System.Runtime.CompilerServices;

namespace Tree{
    class Program {
        static void Main(string [] args){  // Balanced Binary Tree with O(log n)

            BST tree = new BST(); // binary search tree is a tree with a left and right child
            tree.Insert(23); // this is how we insert in our binary tree
            tree.Insert(45);
            tree.Insert(12);
            tree.Insert(78);
            tree.Insert(55);

            tree.Find(45); //now we find data

        }



        class Node{ // every note holds a value and points to its left and right child
            public int data {get; set;}
            public Node? leftChild{get; set;}
            public Node? rightChild{get; set;}
           
        }

        class BST { // binary search tree data structure
            public Node? root;
            public void Insert(int data){ // we use this insert function recursively
                root = InsertChild(root, data);                
            }

            public Node InsertChild(Node? node, int data){ // we need to create insert helper function 
                if(node == null){ // this is what helps end the recursion
                    Node newNode = new Node();
                    newNode.data = data;
                    node = newNode;
                    return node; // returning node when we insert in a null root / child 
                }

                if(data< node.data){ // we compare  and put the smaller values to the left of root 
                    node.leftChild = InsertChild(node.leftChild, data);
                } else { // we compare and put the larger values to the right 
                    node.rightChild = InsertChild(node.rightChild, data);
                }

                return node;
            }

            public void Find(int data){ // we use this to search, try to follow same format as insert.
                root = FindNode(root, data); // we begin recursion 
            }

            public Node? FindNode(Node? node, int data){

                 if(node == null) { // always check if the node is null
                    Console.WriteLine("node does not exist"); 
                    return node;
                } 

                if(data == node?.data) { // we use this as base
                    Console.WriteLine($"found {data}");
                    return node;
                } 

                if(data < node?.data) { //we check if its in left node

                    return FindNode(node.leftChild, data);
                   
                } else { // we check if its in right node

                    return FindNode(node?.rightChild, data);
                   
                }
            }

            public Node? IsEmpty(){
                if(root == null) {
                    Console.WriteLine("Tree is null");
                }

                return null;
            }
        }
    }

}