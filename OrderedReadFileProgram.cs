/*
 *  Purpose: Program to read a file and store in Ordered linked List.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   16-12-2019
 */

using System;
using System.IO;

namespace DataStructureProgram
{
    class OrderedReadFileProgram
    {
        /// <summary>
        /// This Method is used to test the OrderedReadFileProgram Class
        /// </summary>
        public static void OrderedReadFile()
        {
            try
            { 
                Console.WriteLine();
                Console.WriteLine("--------------------Ordered Read File Program--------------------");
                Console.WriteLine();

                string path = @"C:\Users\User\source\repos\DataStructureProgram\DataStructureProgram\Orderednput.txt";
                bool flag;
                int data;

                Console.WriteLine("Reading Data from the File !!!");

                string[] fileData = File.ReadAllText(path).Split(' ');

                Console.WriteLine("File Read Successful");

                OrderedSingleLinkedList singleLinkedList = new OrderedSingleLinkedList();

                foreach (string str in fileData)
                    singleLinkedList.AddNode(Convert.ToInt32(str));

                do
                {
                    Console.WriteLine();
                    Console.Write("Enter the number to be searched: ");
                    flag = int.TryParse(Console.ReadLine(), out data);
                    Utility.ErrorMessage(flag);
                } while (!flag);

                if (singleLinkedList.SearchNode(data))
                {
                    Console.WriteLine("number Found Successfully !!!");
                    Console.WriteLine("Deleting the number: {0}", data);
                    singleLinkedList.Remove(data);
                    Console.WriteLine("Updating the file.");
                    Console.WriteLine(singleLinkedList.ToString());
                    File.WriteAllText(path, singleLinkedList.ToString());
                    Console.WriteLine("File Updated Successfully");
                }
                else
                {
                    Console.WriteLine("Failed to find the Number !!");
                    Console.WriteLine("Adding Number to the File !!");
                    singleLinkedList.AddNode(data);
                    File.WriteAllText(path, singleLinkedList.ToString());
                    Console.WriteLine(singleLinkedList.ToString());
                    Console.WriteLine("Number Added Successfully !!");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Failed to Read File");
            }

        }
    }
}
