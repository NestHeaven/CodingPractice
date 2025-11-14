using System.ComponentModel.DataAnnotations;

namespace Coding_Main.DataStructure.BinaryTree
{
    public class BinarySearchTree
    {
        public LinkedNode<int>? Root { get; set; }

        private int size;

        public BinarySearchTree()
        {
            Root = null;
            size = 0;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }


        public void InsertElementInABinarySearchTree(int e)
        {
            LinkedNode<int> linkedNode = new(e, null, null);

            if (Root == null)
                Root = linkedNode;
            else
            {
                var p = Root;

                while (p != null)
                {
                    if (p.Element == e)
                    {
                        Console.WriteLine("Element Already Exists in BST");
                        break;
                    }
                    else if (e < p.Element)
                    {
                        if (p.Left is null)
                        {
                            p.Left = linkedNode;
                            break;
                        }
                        p = p.Left;
                    }
                    else if (e > p.Element)
                    {
                        if (p.Right is null)
                        {
                            p.Right = linkedNode;
                            break;
                        }
                        p = p.Right;
                    }
                }
            }
            size++;
        }

        public LinkedNode<int> RecursiveMethodToInsertElementInABinarySearchTree(int e, LinkedNode<int>? node)
        {
            if (node != null)
            {
                if (e < node.Element)
                {
                    node.Left = RecursiveMethodToInsertElementInABinarySearchTree(e, node.Left);
                }
                if (e > node.Element)
                {
                    node.Right = RecursiveMethodToInsertElementInABinarySearchTree(e, node.Right);
                }
            }
            else
            {
                var newnode = new LinkedNode<int>(e, null, null);
                node = newnode;
            }
            return node;
        }


        public void WrapperMethodForRecursiveInsert(int value)
        {
            Root = RecursiveMethodToInsertElementInABinarySearchTree(value, Root);
        }

        public bool SearchAnElementInABinarySearchTreeRecursively(int e, LinkedNode<int>? node)
        {
            if (node != null)
            {
                if (e == node.Element)
                {
                    return true;
                }
                else if (e < node.Element)
                {
                    return SearchAnElementInABinarySearchTreeRecursively(e, node.Left);
                }
                else if (e > node.Element)
                {
                    return SearchAnElementInABinarySearchTreeRecursively(e, node.Right);
                }
            }
            return false;
        }

        public bool SearchAnElementInABinarySearchTreeIteratively(int e)
        {
            if (Root != null)
            {
                var p = Root;

                while (p != null)
                {
                    if (e == p.Element) { return true; }
                    else if (e < p.Element) { p = p.Left; }
                    else if (e > p.Element) { p = p.Right; }
                }
            }
            return false;
        }


        public void InOrderTraversalBST(LinkedNode<int> node)
        {
            if (node is not null)
            {
                InOrderTraversalBST(node.Left);
                Console.WriteLine(node.Element);
                InOrderTraversalBST(node.Right);
            }

        }


        public void PreOrderTraversalBST(LinkedNode<int> node)
        {
            if (node is not null)
            {
                Console.WriteLine(node.Element);
                PreOrderTraversalBST(node.Left);
                PreOrderTraversalBST(node.Right);
            }
        }

        public void PostOrderTraversal(LinkedNode<int> node)
        {
            if (node is not null)
            {
                PostOrderTraversal(node.Left);
                PostOrderTraversal(node.Right);
                Console.WriteLine(node.Element);
            }
        }


        public void LevelOrderTraversal()
        {
            if(Root is not null)
            {
                Queue<LinkedNode<int>> queue = new();

                queue.Enqueue(Root);

                while(queue.Any())
                {

                    var t = queue.Dequeue();

                    Console.WriteLine(t.Element);
                    if (t.Left is not null)
                    {
                        queue.Enqueue(t.Left);
                    }

                    if(t.Right is not null)
                    {
                        queue.Enqueue(t.Right);
                    }
                }
            }
        }


        public bool DeleteElementFromBST(int e)
        {
            if(Root is not null)
            {
                LinkedNode<int> parent = null;

                LinkedNode<int> current = Root;

                while (current != null && current.Element != e)
                {
                    parent = current;
                    if (e < current.Element)
                        current = current.Left;
                    else
                        current = current.Right;
                }

                if(current == null)
                {
                    Console.WriteLine("Element not found in BST");
                    return false;
                }

                if(current.Left is not null && current.Right is not null)
                {
                    LinkedNode<int> successorParent = null;
                    LinkedNode<int> successor = current.Right;

                    while(successor is not null)
                    {
                        successorParent = successor;
                        successor = successorParent.Left;
                    }

                    current.Element = successor.Element;

                    current = successor;
                    parent = successorParent;
                }

                LinkedNode<int> child = current.Left != null? current.Left : current.Right;

                if(parent == null)
                {
                    Root = child;
                }
                else
                {
                    if(parent.Left == current)
                    {
                        parent.Left = child;
                    }
                    else
                        parent.Right = child;
                }
                return true;
            }
            else 
                return false;
        }

        public int CountNoOfNodesInBST(LinkedNode<int> current)
        {

            if(current == null)
                return 0;
            var count = 1 + CountNoOfNodesInBST(current.Left) + CountNoOfNodesInBST(current.Right);
            return count;
        }

    }

    public class LinkedNode<T>
    {
        public LinkedNode<T>? Left { get; set; }

        public T Element { get; set; }


        public LinkedNode<T>? Right { get; set; }


        public LinkedNode(T element, LinkedNode<T>? right, LinkedNode<T>? left)
        {
            Left = left;
            Element = element;
            Right = right;
        }
    }
}




