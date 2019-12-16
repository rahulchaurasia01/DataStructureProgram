/*
 *  Purpose: Program to test the OrderedSingleLinkedList Program.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   16-12-2019
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProgram
{
    class OrderedSingleLinkedListProgram
    {
        /// <summary>
        /// This Method is used to test the OrderedSingleLinkedListProgram
        /// </summary>
        public static void OrderedSingleLinkedList()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------Ordered Single Linked List Program--------------------");
            Console.WriteLine();


            OrderedSingleLinkedList singleLinkedList = new OrderedSingleLinkedList();
            Boolean flag = false;
            int choice, data;
            do
            {
                Console.WriteLine("1. Add Item.");
                Console.WriteLine("2. Remove Item");
                Console.WriteLine("3. Search Item");
                Console.WriteLine("4. IsEmpty");
                Console.WriteLine("5. Size.");
                Console.WriteLine("6. Index");
                Console.WriteLine("7. Pop");
                Console.WriteLine("8. Pop at position");
                Console.WriteLine("9. Display");
                Console.WriteLine("10. Exit");
                Console.Write("Enter ur Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the data: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        singleLinkedList.AddNode(data);
                        break;

                    case 2:
                        Console.Write("Enter the Data to be Removed: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        singleLinkedList.Remove(data);
                        break;

                    case 3:
                        Console.Write("Enter the data to be searched: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        if (singleLinkedList.SearchNode(data))
                            Console.WriteLine("Data Found");
                        else
                            Console.WriteLine("Data not found");
                        break;

                    case 4:
                        if (singleLinkedList.IsEmpty())
                            Console.WriteLine("Node is Empty");
                        else
                            Console.WriteLine("Node is not Empty");
                        break;

                    case 5:
                        data = singleLinkedList.Size();
                        Console.WriteLine("The Size of the node is: {0}", data);
                        break;

                    case 6:
                        Console.Write("Enter the data to search its position: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        int result = singleLinkedList.Index(data);
                        if (result != -1)
                            Console.WriteLine("{0} position in the node is: {1}", data, result);
                        else
                            Console.WriteLine("Data not present");
                        break;

                    case 7:
                        singleLinkedList.Pop();
                        break;

                    case 8:
                        Console.Write("Enter the postion to pop the data from node: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        singleLinkedList.Pop(data);
                        break;

                    case 9: Console.WriteLine("The list of item are: {0}", singleLinkedList.ToString());
                        break;

                    case 10:
                        flag = true;
                        break;

                    default:
                        Console.WriteLine("Invlaid Choice.");
                        break;
                }
                Console.WriteLine();
            } while (!flag);
        }
    }
}
