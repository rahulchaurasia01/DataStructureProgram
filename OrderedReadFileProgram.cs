/*
 *  Purpose: Program to read a file and store in Ordered linked List.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   16-12-2019
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructureProgram
{
    class OrderedReadFileProgram
    {
        /// <summary>
        /// This Method is used to test the OrderedReadFileProgram Class
        /// </summary>
        public static void OrderedReadFile()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------Ordered Read File Program--------------------");
            Console.WriteLine();


            Console.WriteLine("Reading Data from the File !!!");

            try
            {
                String[] fileData = File.ReadAllText(@"C:\Users\User\source\repos\DataStructureProgram\DataStructureProgram\OrderedInput.txt").Split(' ');

                Console.WriteLine("File Read Successful");

                OrderedSingleLinkedList singleLinkedList = new OrderedSingleLinkedList();

                foreach (string str in fileData)
                    singleLinkedList.AddNode(Convert.ToInt32(str));

                Console.Write("Enter the number to be searched: ");
                int data = Convert.ToInt32(Console.ReadLine());

                if (singleLinkedList.SearchNode(data))
                {
                    Console.WriteLine("number Found Successfully !!!");
                    Console.WriteLine("Deleting the number: {0}", data);
                    singleLinkedList.Remove(data);
                    Console.WriteLine("Updating the file.");
                    Console.WriteLine(singleLinkedList.ToString());
                    File.WriteAllText(@"C:\Users\User\source\repos\DataStructureProgram\DataStructureProgram\OrderedInput.txt", singleLinkedList.ToString());

                }
                else
                {
                    Console.WriteLine("Failed to find the Number !!");
                    Console.WriteLine("Adding Number to the File !!");
                    singleLinkedList.AddNode(data);
                    File.WriteAllText(@"C:\Users\User\source\repos\DataStructureProgram\DataStructureProgram\OrderedInput.txt", singleLinkedList.ToString());
                    Console.WriteLine(singleLinkedList.ToString());
                    Console.WriteLine("Number Added Successfully !!");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("{0} " + e.Message);
                Console.WriteLine("Failed to Read File");
            }

        }
    }
}
