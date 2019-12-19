/*
 *  Purpose: Program to test the QueueLinkedList Program.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   16-12-2019
 */

using System;

namespace DataStructureProgram
{
    class QueueLinkedListProgram
    {
        /// <summary>
        /// This method is used to test the QueueLinkedListProgram Class.
        /// </summary>
        public static void QueueLinkedList()
        {
            try
            {

                Console.WriteLine();
                Console.WriteLine("--------------------Queue Linked List Program--------------------");


                QueueLinkedList queueLinkedList = new QueueLinkedList();
                bool flag= false, inputFlag;
                int choice, data;

                do
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("1. Enqueue Item.");
                        Console.WriteLine("2. Dequeue Item");
                        Console.WriteLine("3. IsEmpty");
                        Console.WriteLine("4. Size.");
                        Console.WriteLine("5. Display");
                        Console.WriteLine("6. Exit");
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
                            queueLinkedList.Enqueue(data);
                            break;

                        case 2:
                            queueLinkedList.Dequeue();
                            break;

                        case 3:
                            if (queueLinkedList.IsEmpty())
                                Console.WriteLine("Queue is Empty");
                            else
                                Console.WriteLine("Queue is not Empty");
                            break;

                        case 4:
                            data = queueLinkedList.Size();
                            Console.WriteLine("The Size of the Queue is: {0}", data);
                            break;

                        case 5:
                            Console.WriteLine("The list of item are: {0}", queueLinkedList.ToString());
                            break;

                        case 6:
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
