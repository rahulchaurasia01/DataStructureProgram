/*
 *  Purpose: Program to test the UnOrderedSingleLinkedList Program.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   14-12-2019
 */

using System;

namespace DataStructureProgram
{
    class UnOrderedSingleLinkedListProgram
    {
        /// <summary>
        /// This Method is used to test the UnorderedSingleLinkedListProgram
        /// </summary>
        public static void SingleLinkedList()
        {

            Console.WriteLine();
            Console.WriteLine("--------------------UnOrdered Single Linked List Program--------------------");
            Console.WriteLine();


            UnorderedSingleLinkedList<int> singleLinkedList = new UnorderedSingleLinkedList<int>();
            Boolean flag = false;
            int choice, data;
            do
            {
                Console.WriteLine("1. Add Item.");
                Console.WriteLine("2. Remove Item");
                Console.WriteLine("3. Search Item");
                Console.WriteLine("4. IsEmpty");
                Console.WriteLine("5. Size.");
                Console.WriteLine("6. Append");
                Console.WriteLine("7. Index");
                Console.WriteLine("8. Insert the data");
                Console.WriteLine("9. Pop");
                Console.WriteLine("10. Pop at position");
                Console.WriteLine("11. Exit");
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
                        Console.Write("Enter the data to be appended: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        singleLinkedList.Append(data);
                        break;

                    case 7:
                        Console.Write("Enter the data to search its position: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        int result = singleLinkedList.Index(data);
                        if (result != -1)
                            Console.WriteLine("{0} position in the node is: {1}", data, result);
                        else
                            Console.WriteLine("Data not present");
                        break;

                    case 8:
                        Console.Write("Enter the Position you want to Add: ");
                        int post = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the Data: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        singleLinkedList.Insert(post, data);
                        break;

                    case 9:
                        singleLinkedList.Pop();
                        break;

                    case 10:
                        Console.Write("Enter the postion to pop the data from node: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        singleLinkedList.Pop(data);
                        break;

                    case 11:
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
