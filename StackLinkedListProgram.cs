/*
 *  Purpose: Program to test the StackLinkedList Program.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   17-12-2019
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProgram
{
    class StackLinkedListProgram
    {
        /// <summary>
        /// This method is used to test the 
        /// </summary>
        public static void StackLinkedList()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------Stack Linked List Program--------------------");
            Console.WriteLine();


            StackLinkedList stackLinkedList = new StackLinkedList();
            Boolean flag = false;
            int choice, data;
            do
            {
                Console.WriteLine("1. Push Item.");
                Console.WriteLine("2. Pop Item");
                Console.WriteLine("3. Peek Item");
                Console.WriteLine("4. IsEmpty");
                Console.WriteLine("5. Size.");
                Console.WriteLine("6. Display");
                Console.WriteLine("7. Exit");
                Console.Write("Enter ur Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: Console.Write("Enter the data: ");
                            data = Convert.ToInt32(Console.ReadLine());
                            stackLinkedList.Push(data);
                            break;

                    case 2: stackLinkedList.Pop();
                            break;

                    case 3: stackLinkedList.Peek();
                            break;

                    case 4: if (stackLinkedList.IsEmpty())
                                Console.WriteLine("Stack is Empty");
                            else
                                Console.WriteLine("Stack is not Empty");
                            break;

                    case 5: data = stackLinkedList.Size();
                            Console.WriteLine("The Size of the Queue is: {0}", data);
                            break;

                    case 6: Console.WriteLine("The list of item are: {0}", stackLinkedList.ToString());
                            break;

                    case 7: flag = true;
                            break;

                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }
                Console.WriteLine();
            } while (!flag);
        }
    }
}
