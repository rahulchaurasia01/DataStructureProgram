/*
 *  Purpose: Entry Point For the Program.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   14-12-2019
 */

using System;

namespace DataStructureProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean flag = false;
            int choice;

            do
            {

                Console.WriteLine();
                Console.WriteLine("Welcome to BridgeLabz");
                Console.WriteLine();
                Console.WriteLine("1. UnOrdered Single Linked List Program");
                Console.WriteLine("2. UnOrdered Read File Program");
                Console.WriteLine("3. Ordered Single Linked List Program");
                Console.WriteLine("4. Ordered Read File Program");
                Console.WriteLine("5. Simple Balanced Parentheses");
                Console.WriteLine("6. Exit");
                Console.Write("Enter Your Choice. ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1: UnOrderedSingleLinkedListProgram.SingleLinkedList();
                            break;

                    case 2: UnOrderedReadFileProgram.ReadFile();
                            break;

                    case 3: OrderedSingleLinkedListProgram.OrderedSingleLinkedList();
                            break;

                    case 4: OrderedReadFileProgram.OrderedReadFile();
                            break;

                    case 5: SimpleBalancedParenthesesProgram.SimpleBalancedParentheses();
                            break;

                    case 6: flag = true;
                            break;

                    default: Console.WriteLine("Invalid Choice !!!");
                            break;
                }


            } while (!flag);
        }
    }
}
