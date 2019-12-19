/*
 *  Purpose: Program to test the StackLinkedList Program.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   17-12-2019
 */

using System;

namespace DataStructureProgram
{
    class StackLinkedListProgram
    {
        /// <summary>
        /// This method is used to test the 
        /// </summary>
        public static void StackLinkedList()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("--------------------Stack Linked List Program--------------------");


                StackLinkedList stackLinkedList = new StackLinkedList();
                bool flag=false, inputFlag;
                int choice, data;
                do
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("1. Push Item.");
                        Console.WriteLine("2. Pop Item");
                        Console.WriteLine("3. Peek Item");
                        Console.WriteLine("4. IsEmpty");
                        Console.WriteLine("5. Size.");
                        Console.WriteLine("6. Display");
                        Console.WriteLine("7. Exit");
                        Console.Write("Enter ur Choice: ");
                        inputFlag = int.TryParse(Console.ReadLine(), out choice);
                        Utility.ErrorMessage(inputFlag);
                    } while (!inputFlag);
                    flag = false;
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
                            stackLinkedList.Push(data);
                            break;

                        case 2:
                            stackLinkedList.Pop();
                            break;

                        case 3:
                            stackLinkedList.Peek();
                            break;

                        case 4:
                            if (stackLinkedList.IsEmpty())
                                Console.WriteLine("Stack is Empty");
                            else
                                Console.WriteLine("Stack is not Empty");
                            break;

                        case 5:
                            data = stackLinkedList.Size();
                            Console.WriteLine("The Size of the Queue is: {0}", data);
                            break;

                        case 6:
                            Console.WriteLine("The list of item are: {0}", stackLinkedList.ToString());
                            break;

                        case 7:
                            flag = true;
                            break;

                        default:
                            Console.WriteLine("Invalid Choice.");
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
