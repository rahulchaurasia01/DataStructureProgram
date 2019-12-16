/*
 *  Purpose: Program to read a file and store in UnOrdered linked List.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   16-12-2019
 */

using System;
using System.IO;

namespace DataStructureProgram
{
    class UnOrderedReadFileProgram
    {
        /// <summary>
        /// This method is used to test the ReadFileProgram Class.
        /// </summary>
        public static void ReadFile()
        {

            Console.WriteLine();
            Console.WriteLine("--------------------UnOrdered Read File Program--------------------");
            Console.WriteLine();


            Console.WriteLine("Reading Data from the File !!!");

            try
            {
                String[] fileData = File.ReadAllText(@"C:\Users\User\source\repos\DataStructureProgram\DataStructureProgram\UnOrderedInput.txt").Split(' ');

                Console.WriteLine("File Read Successful");

                UnorderedSingleLinkedList<string> singleLinkedList = new UnorderedSingleLinkedList<string>();

                foreach (string str in fileData)
                    singleLinkedList.AddNode(str);

                Console.Write("Enter the word to be searched: ");
                string str1 = Console.ReadLine();

                if(singleLinkedList.SearchNode(str1))
                {
                    Console.WriteLine("Word Found Successfully !!!");
                    Console.WriteLine("Deleting the Word: {0}", str1);
                    singleLinkedList.Remove(str1);
                    Console.WriteLine("Updating the file.");
                    File.WriteAllText(@"C:\Users\User\source\repos\DataStructureProgram\DataStructureProgram\UnOrderedInput.txt", singleLinkedList.ToString());

                }
                else
                {
                    Console.WriteLine("Failed to find the word !!");
                    Console.WriteLine("Adding Word to the File !!");
                    singleLinkedList.Append(str1);
                    File.WriteAllText(@"C:\Users\User\source\repos\DataStructureProgram\DataStructureProgram\UnOrderedInput.txt", singleLinkedList.ToString());
                    Console.WriteLine("Word Added Successfully !!");
                }
                
            }
            catch(Exception e)
            {
                Console.WriteLine("{0} "+e.Message);
                Console.WriteLine("Failed to Read File");
            }
        }
    }
}
