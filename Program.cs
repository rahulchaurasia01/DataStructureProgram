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
                Console.WriteLine("1. SingleLinkedProgram");
                Console.WriteLine("2. Exit");
                Console.Write("Enter Your Choice.");
                choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1: SingleLinkedListProgram.SingleLinkedList();
                            break;

                    case 2: flag = true;
                            break;
                }


            } while (!flag);
        }
    }
}
