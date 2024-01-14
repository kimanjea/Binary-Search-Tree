# Binary Search Tree
This program implements a binary search tree data structure in C#.

# Overview
A binary search tree is a binary tree data structure where each node has at most two children, called left and right. The left child of a node contains a value less than its parent, and the right child of a node contains a value greater than its parent. This allows for quick lookups, insertions, and deletions in O(log n) time on average.

This program contains the following components:
* BST class - Represents the binary search tree
* Node class - Represents each node in the tree
* Program class - Contains the Main method to test the BST

# Usage
The BST class contains methods to insert, find, and check if empty.

# To insert:
BST tree = new BST();
* tree.Insert(23); 
* tree.Insert(45);

# To find a value:
* tree.Find(45);
To check if empty:

* tree.IsEmpty();
The Main method shows simple example usage of inserting and finding values in a binary search tree.

# Implementation
Insert and find are implemented recursively.
Insert works by comparing the node value to the inserted value, and placing the new node in the left or right child accordingly.

Find works similarly by traversing left or right based on comparing the target value to the current node value.

# Time Complexity
Average time complexity for search, insert, and delete in a balanced binary search tree is O(log n).
In the worst case, the tree can become skewed and degrade to O(n) performance.

# Space Complexity
Space usage is O(n) to store the tree.