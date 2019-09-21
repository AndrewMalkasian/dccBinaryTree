using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresCode
{
    class BinaryTree
    {
        //node
        
        public Node BTreeRoot;
       

        public void Add(int value)
        {
            Node newNode = new Node(value);
            if (BTreeRoot == null)
            {
                BTreeRoot = newNode;
                return;
            }
            else
            {
                Node nextNode = BTreeRoot;
                Node parentNode;
                while(true)
                {
                    parentNode = nextNode;
                    if ( value < nextNode.data)
                    {
                        nextNode = nextNode.moveLeft;
                        if (nextNode == null)
                        {
                            parentNode.moveLeft = newNode;
                            break;
                        }
                    
                        else
                        {
                            nextNode = nextNode.moveRight;
                            if (nextNode == null)
                            {
                                nextNode.moveRight = newNode;
                                break;
                            }

                        }
                    }
                }
            }
        }
      
    }
}


//void MoveRight()
//{

//}

//void MoveLeft()
//{

//}
//1.set the parent node to be the current node, which is the root node. ////
//2.if the data value in the new node is less than the data value in the current node, 
//set the current node to be the left child of the current node.if the data value in the new node is greater than the data
//value in the current node, skip to step 4.
//3.if the value of the left child of the current node is null, insert the new node here and exit the loop.otherwise, skip to the next iteration
//of the while loop.
//4.set the current node to the right child node of the current node.
//5.if the value of the right child of the current node is null, insert the new node here and exit the loop.otherwise, skip to the next iteration
//of the while loop
///Data structures and Algorithms using C# Michael McMilan
