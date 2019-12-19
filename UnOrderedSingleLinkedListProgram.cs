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
            try
            {
                Console.WriteLine();
                Console.WriteLine("--------------------UnOrdered Single Linked List Program--------------------");

                UnorderedSingleLinkedList<int> singleLinkedList = new UnorderedSingleLinkedList<int>();
                
                bool flag = false, inputFlag;
                int choice, data, post;
                
                do
                {
                    do
                    {
                        Console.WriteLine();
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
                        inputFlag = int.TryParse(Console.ReadLine(), out choice);
                        Utility.ErrorMessage(inputFlag);
                    } while (!inputFlag);
                    switch (choice)
                    {
                        case 1:
                            do
                            {
                                Console.WriteLine();
                                Console.Write("Enter the data: ");
                                inputFlag = int.TryParse(Console.ReadLine(), out data);
                                Utility.ErrorMessage(inputFlag);
                            } while (!inputFlag);
                            singleLinkedList.AddNode(data);
                            break;

                        case 2:
                            do
                            {
                                Console.WriteLine();
                                Console.Write("Enter the Data to be Removed: ");
                                inputFlag = int.TryParse(Console.ReadLine(), out data);
                                Utility.ErrorMessage(inputFlag);
                            } while (!inputFlag);
                            singleLinkedList.Remove(data);
                            break;

                        case 3:
                            do
                            {
                                Console.WriteLine();
                                Console.Write("Enter the data to be searched: ");
                                inputFlag = int.TryParse(Console.ReadLine(), out data);
                                Utility.ErrorMessage(inputFlag);
                            } while (!inputFlag);
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
                            do
                            {
                                Console.WriteLine();
                                Console.Write("Enter the data to be appended: ");
                                inputFlag = int.TryParse(Console.ReadLine(), out data);
                                Utility.ErrorMessage(inputFlag);
                            } while (!inputFlag);
                            singleLinkedList.Append(data);
                            break;

                        case 7:
                            do
                            {
                                Console.WriteLine();
                                Console.Write("Enter the data to search its position: ");
                                inputFlag = int.TryParse(Console.ReadLine(), out data);
                                Utility.ErrorMessage(inputFlag);
                            } while (!inputFlag);
                            int result = singleLinkedList.Index(data);
                            if (result != -1)
                                Console.WriteLine("{0} position in the node is: {1}", data, result);
                            else
                                Console.WriteLine("Data not present");
                            break;

                        case 8:
                            do
                            {
                                Console.WriteLine();
                                Console.Write("Enter the Position you want to Add: ");
                                inputFlag = int.TryParse(Console.ReadLine(), out post);
                                Utility.ErrorMessage(inputFlag);
                            } while (!inputFlag);
                            do
                            {
                                Console.WriteLine();
                                Console.Write("Enter the Data: ");
                                inputFlag = int.TryParse(Console.ReadLine(), out data);
                                Utility.ErrorMessage(inputFlag);
                            } while (!inputFlag);
                            singleLinkedList.Insert(post, data);
                            break;

                        case 9:
                            singleLinkedList.Pop();
                            break;

                        case 10:
                            do
                            {
                                Console.WriteLine();
                                Console.Write("Enter the postion to pop the data from node: ");
                                inputFlag = int.TryParse(Console.ReadLine(), out data);
                                Utility.ErrorMessage(inputFlag);
                            } while (!inputFlag);
                            singleLinkedList.Pop(data);
                            break;

                        case 11:
                            flag = true;
                            break;

                        default:
                            Console.WriteLine("Invlaid Choice.");
                            break;
                    }
                } while (!flag);
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }
    }
}
