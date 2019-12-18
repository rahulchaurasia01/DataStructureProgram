/*
 *  Purpose: Program to simulate the banking Cash Counter.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   16-12-2019
 */

using System;

namespace DataStructureProgram
{
    class BankingCashCounterProgram
    {
        /// <summary>
        /// This method is used to test the BankingCashCounterProgram Class.
        /// </summary>
        public static void BankingCashCounter()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------Banking Cash Counter Program--------------------");
            Console.WriteLine();

            int choice;
            Boolean flag = false;

            Queue depositQueue = new Queue();
            Queue withdrawQueue = new Queue();

            int cash = 100000;
            int depositCount = 0, withdrawCount = 0;


            do
            {
                Console.WriteLine("Welcome to bridgeLabz Bank");
                Console.WriteLine();
                Console.WriteLine("Collect your Token");
                Console.WriteLine("1. Deposit your Money.");
                Console.WriteLine("2. Withdraw your Money.");
                Console.WriteLine("3. Exit");
                Console.Write("Enter Your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: depositCount++;
                            depositQueue.Enqueue(depositCount);
                            Console.WriteLine("Your Token No is: {0}", depositCount);
                            break;

                    case 2: withdrawCount++;
                            withdrawQueue.Enqueue(withdrawCount);
                            Console.WriteLine("Your Token No is: {0}", withdrawCount);
                            break;

                    case 3:
                        flag = true;
                        break;

                    default:
                        Console.WriteLine("Invalid Choice. !!");
                        break;
                }
            } while (!flag);


            do
            {
                
                if(!depositQueue.IsEmpty())
                {
                    Console.WriteLine("DEPOSIT COUNTER");
                    Console.Write("Token ");
                    depositQueue.Dequeue();
                    Console.WriteLine();
                    Console.Write("Enter the Amount: ");
                    int deposit = Convert.ToInt32(Console.ReadLine());
                    cash += deposit;
                    Console.WriteLine("Your Amount Has Been Successfully Deposited.");
                }

                if (!withdrawQueue.IsEmpty())
                {
                    Console.WriteLine("Withdraw COUNTER");
                    Console.Write("Token ");
                    withdrawQueue.Dequeue();
                    Console.WriteLine();
                    Console.Write("Enter the Amount: ");
                    int withdraw = Convert.ToInt32(Console.ReadLine());
                    cash -= withdraw;
                    Console.WriteLine("Your Amount Has Been Successfully withdrawn.");
                }


            } while (!depositQueue.IsEmpty() || !withdrawQueue.IsEmpty());

        }
    }
}
