﻿/*
 *  Purpose: Logic of the UnOrderedSingleLinkedList Program.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   14-12-2019
 */

using System;
using System.Text;

namespace DataStructureProgram
{
    class UnorderedSingleLinkedList<T>
    {

        public class Node
        {
            public T data;
            public Node next;

        }
        
        Node start, end;

        /// <summary>
        /// Add the item to the node
        /// </summary>
        /// <param name="data"></param>
        public void AddNode(T data)
        {

            Node newNode = new Node();

            if(start == null)
            {
                newNode.data = data;
                newNode.next = null;
                start = newNode;
                end = newNode;
            }
            else
            {
                if (!SearchNode(data))
                {
                    newNode.data = data;
                    newNode.next = null;
                    end.next = newNode;
                    end = newNode;
                }
                else
                    Console.WriteLine("{0} is already present in the Node.", data);

            }
            
        }

        /// <summary>
        /// To Search the element in the Node.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public Boolean SearchNode(T data)
        {
            for (Node p = start; p != null; p = p.next)
            {
                if (p.data.Equals(data))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// This will check whether the node is empty or not.
        /// </summary>
        /// <returns></returns>
        public Boolean IsEmpty()
        {
            if (start == null)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Append the item at the end of the node.
        /// </summary>
        /// <param name="data"></param>
        public void Append(T data)
        {
            if(start == null)
            {
                Console.WriteLine("First add an Element in the node !!");
                return;
            }
            else
            {
                if(!SearchNode(data))
                {
                    Node newNode = new Node
                    {
                        data = data,
                        next = null
                    };
                    end.next = newNode;
                    end = newNode;
                }
                else
                    Console.WriteLine("{0} is already present in the Node.", data);
            }
        }

        /// <summary>
        /// It gives the number of item present in the list.
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            int count = 0;
            if (start == null)
                return count;
            else
            {
                for (Node p = start; p != null; p = p.next)
                    count++;

                return count;
            }
        }

        /// <summary>
        /// Return the position of the item in the node.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public int Index(T data)
        {
            int index = 0;
            if (start == null)
                return -1;
            else
            {
                for(Node p = start; p != null; p = p.next)
                {
                    index++;
                    if (p.data.Equals(data))
                        return index;
                }
            }

            return -1;
        }

        /// <summary>
        /// It removes the last item form the node.
        /// </summary>
        public void Pop()
        {
            Node temp = null;
            if(start == null)
                Console.WriteLine("The Node are Empty.");
            else
            {
                for(Node p = start; p != null; p=p.next)
                {
                    if(p.next == null)
                    {
                        Console.WriteLine("{0}, is successfully removed.",p.data);
                        if(start == end)
                            start = end = null;
                        else
                        {
                            end = temp;
                            end.next = null;
                        }
                        return;
                    }
                    temp = p;
                }
            }
           
        }

        /// <summary>
        /// It removes the item from the specific location from the node.
        /// </summary>
        /// <param name="postion"></param>
        public void Pop(int postion)
        {
            int index = 1;

            if (start == null)
                Console.WriteLine("The Node are Empty.");
            else
            {
                for (Node p = start; p != null; p = p.next)
                {
                    if(postion == index+1)
                    {
                        Console.WriteLine(p.next.data);
                        if(p.next.next == null)
                            end = p.next;
                        p.next = p.next.next;
                        return;
                    }
                    index++;
                }
            }
            Console.WriteLine("Data not found");
        }

        /// <summary>
        /// It removes the data from the node.
        /// </summary>
        /// <param name="data"></param>
        public void Remove(T data)
        {
            Node temp = start;
            if (start == null)
            {
                Console.WriteLine("The Node are Empty.");
                return;
            }
            else
            {
                for (Node p = start; p != null; p = p.next)
                {
                    if (p.data.Equals(data))
                    {
                        if (start == end)
                            start = end = null;
                        else if (p.next != null)
                        {
                            temp.next = p.next;
                            if (start.data.Equals(data))
                                start = start.next;
                        }
                        else
                        {
                            end = temp;
                            end.next = null;
                        }
                        return;
                    }
                    temp = p;
                }
            }
            Console.WriteLine("Data not found");
        }
    
        /// <summary>
        /// It insert the data at a specific location.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="data"></param>
        public void Insert(int position, T data)
        {
            int count=0;
            Node temp = start;
            if (start == null)
                Console.WriteLine("Node is Empty");
            else
            {
                for(Node p = start; p != null; p = p.next)
                {
                    if (position == count+1)
                    {
                        Node newNode = new Node();
                        newNode.data = data;
                        newNode.next = null;

                        Console.WriteLine("Hola");
                        if(start == end)
                        {
                            newNode.next = start;
                            start = newNode;
                        }
                            
                        else if(p.next != null)
                        {
                            newNode.next = p;
                            temp.next = newNode;
                        }
                        else
                        {
                            p.next = newNode;
                        }
                        Console.WriteLine("Data Added Successfully");
                    }
                    count++;
                    temp = p;
                }
            }
        }
    
        /// <summary>
        /// It Converts all the Data in the unordered Linked List to String.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            if (start == null)
                return str.ToString();
            else
            {
                for (Node P = start; P != null; P = P.next)
                    str.Append(P.data + " ");
            }
            return str.ToString();
        }
    
    }
}
