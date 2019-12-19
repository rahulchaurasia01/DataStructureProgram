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
            try
            {
                Console.WriteLine();
                Console.WriteLine("--------------------Banking Cash Counter Program--------------------");
                Console.WriteLine();

                int choice;
                Queue depositQueue = new Queue();
                Queue withdrawQueue = new Queue();

                int cash = 100000;
                int depositCount = 0, withdrawCount = 0;


                bool flag;
                do
                {
                    Console.WriteLine("Welcome to bridgeLabz Bank");
                    Console.WriteLine();
                    do
                    {
                        Console.WriteLine("Collect your Token from here");
                        Console.WriteLine("1. Deposit your Money.");
                        Console.WriteLine("2. Withdraw your Money.");
                        Console.WriteLine("3. Exit");
                        Console.Write("Enter Your Choice: ");
                        flag = int.TryParse(Console.ReadLine(), out choice);
                        Utility.ErrorMessage(flag);
                        Console.WriteLine();
                    } while (!flag);

                    flag = false;

                    switch (choice)
                    {
                        case 1:
                            depositCount++;
                            depositQueue.Enqueue(depositCount);
                            Console.WriteLine("Your Token No is: {0}", depositCount);
                            Console.WriteLine();
                            break;

                        case 2:
                            withdrawCount++;
                            withdrawQueue.Enqueue(withdrawCount);
                            Console.WriteLine("Your Token No is: {0}", withdrawCount);
                            Console.WriteLine();
                            break;

                        case 3:
                            flag = true;
                            break;

                        default:
                            Console.WriteLine("Invalid Choice. !!");
                            break;
                    }
                } while (!flag);

                int deposit, withdraw;

                do
                {

                    if (!depositQueue.IsEmpty())
                    {
                        Console.WriteLine();
                        Console.WriteLine("DEPOSIT COUNTER");
                        Console.Write("Token ");
                        depositQueue.Dequeue();
                        do
                        {
                            Console.WriteLine();
                            Console.Write("Enter the Amount: ");
                            flag = int.TryParse(Console.ReadLine(), out deposit);
                            Utility.ErrorMessage(flag);
                        } while (!flag);
                        cash += deposit;
                        Console.WriteLine("Your Amount Has Been Successfully Deposited.");
                    }

                    if (!withdrawQueue.IsEmpty())
                    {
                        Console.WriteLine();
                        Console.WriteLine("Withdraw COUNTER");
                        Console.Write("Token ");
                        withdrawQueue.Dequeue();
                        do
                        {
                            Console.WriteLine();
                            Console.Write("Enter the Amount: ");
                            flag = int.TryParse(Console.ReadLine(), out withdraw);
                            Utility.ErrorMessage(flag);
                        } while (!flag);
                        cash -= withdraw;
                        Console.WriteLine("Your Amount Has Been Successfully withdrawn.");
                    }

                } while (!depositQueue.IsEmpty() || !withdrawQueue.IsEmpty());
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }
    }
}
