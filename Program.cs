﻿/*
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
            int choice;

            bool flag;
            do
            {
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
                    Console.WriteLine("6. Banking Cash Counter Program");
                    Console.WriteLine("7. Palindrome Program");
                    Console.WriteLine("8. Number Slot Program");
                    Console.WriteLine("9. Calendar Program");
                    Console.WriteLine("10. Prime Number Program");
                    Console.WriteLine("11. Prime Number that are Anagram using 2D Program");
                    Console.WriteLine("12. Stack Linked List Program");
                    Console.WriteLine("13. Prime Number that are Anagram using Stack Program");
                    Console.WriteLine("14. Queue Linked List Program");
                    Console.WriteLine("15. Prime Number that are Anagram using Queue Program");
                    Console.WriteLine("16. Exit");
                    Console.Write("Enter Your Choice. ");
                    flag = int.TryParse(Console.ReadLine(), out choice);
                    Utility.ErrorMessage(flag);
                } while (!flag);
                flag = false;
                switch (choice)
                {
                    case 1:
                        UnOrderedSingleLinkedListProgram.SingleLinkedList();
                        break;

                    case 2:
                        UnOrderedReadFileProgram.ReadFile();
                        break;

                    case 3:
                        OrderedSingleLinkedListProgram.OrderedSingleLinkedList();
                        break;

                    case 4:
                        OrderedReadFileProgram.OrderedReadFile();
                        break;

                    case 5:
                        SimpleBalancedParenthesesProgram.SimpleBalancedParentheses();
                        break;

                    case 6:
                        BankingCashCounterProgram.BankingCashCounter();
                        break;

                    case 7:
                        PalindromeCheckerProgram.PalindromeChecker();
                        break;

                    case 8:
                        NumberSlotProgram.NumberSlot();
                        break;

                    case 9:
                        CalendarProgram.Calendar();
                        break;

                    case 10:
                        PrimeNumberProgram.PrimeNumber();
                        break;

                    case 11:
                        PrimeNumberAnagram2DProgram.PrimeNumberAnagram2D();
                        break;

                    case 12:
                        StackLinkedListProgram.StackLinkedList();
                        break;

                    case 13:
                        PrimeNumberAnagramStackProgram.PrimeNumberAnagramStack();
                        break;

                    case 14:
                        QueueLinkedListProgram.QueueLinkedList();
                        break;

                    case 15:
                        PrimeNumberAnagramQueueProgram.PrimeNumberAnagramQueue();
                        break;

                    case 16:
                        flag = true;
                        break;

                    default:
                        Console.WriteLine("Invalid Choice !!!");
                        break;
                }

            } while (!flag);
        }
    }
}
