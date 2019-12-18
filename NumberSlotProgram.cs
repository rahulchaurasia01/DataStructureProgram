/*
 *  Purpose: Program to implement the Number slot Prgram.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   17-12-2019
 */

using System;
using System.IO;

namespace DataStructureProgram
{
    class NumberSlotProgram
    {
        /// <summary>
        /// This Method is used to test the NumberSlotProgram Class
        /// </summary>
        public static void NumberSlot()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------Function to search a Number in a slot Program--------------------");
            Console.WriteLine();


            OrderedSingleLinkedList[] slot = new OrderedSingleLinkedList[11];
            OrderedSingleLinkedList orderedSingleLinkedList;
            int data, remainder;

            Console.WriteLine("Reading Data from the File !!!");

            try
            {
                string[] fileData = File.ReadAllText(@"C:\Users\User\source\repos\DataStructureProgram\DataStructureProgram\NumberSlot.txt").Split(' ');

                Console.WriteLine("File Read Successful");

                foreach (string str in fileData) {
                    data = Convert.ToInt32(str);

                    remainder = data % 11;

                    if (slot[remainder] == null)
                    {
                        orderedSingleLinkedList = new OrderedSingleLinkedList();
                        orderedSingleLinkedList.AddNode(data);
                        slot[remainder] = orderedSingleLinkedList;
                    }
                    else
                    {
                        orderedSingleLinkedList = slot[remainder];
                        orderedSingleLinkedList.AddNode(data);
                    }

                }

                for (int i = 0; i < fileData.Length; i++)
                    Console.Write(fileData[i] + " ");

                Console.WriteLine();

                Console.Write("Enter the number to be searched: ");
                data = Convert.ToInt32(Console.ReadLine());

                remainder = data % 11;

                orderedSingleLinkedList = slot[remainder];
                if(orderedSingleLinkedList.SearchNode(data))
                {
                    Console.WriteLine("number Found Successfully !!!");
                    Console.WriteLine("Deleting the number: {0}", data);
                    orderedSingleLinkedList.Remove(data);
                    Console.WriteLine("Updating the file.");
                    using(StreamWriter writer = new StreamWriter(@"C:\Users\User\source\repos\DataStructureProgram\DataStructureProgram\NumberSlot.txt"))
                    {
                        for (int i = 0; i < 11; i++)
                        {
                            writer.Write(i + "\t");
                            if (slot[i] != null)
                            {
                                orderedSingleLinkedList = slot[i];
                                writer.Write(orderedSingleLinkedList.ToString());
                            }
                            writer.WriteLine();
                        }
                    }
                    Console.WriteLine("File Updated SUccessfully");
                }
                else
                {
                    Console.WriteLine("Failed to find the Number !!");
                    Console.WriteLine("Adding Number to the File !!");
                    orderedSingleLinkedList.AddNode(data);
                    using (StreamWriter writer = new StreamWriter(@"C:\Users\User\source\repos\DataStructureProgram\DataStructureProgram\NumberSlot.txt"))
                    {
                        for (int i = 0; i < 11; i++)
                        {
                            writer.Write(i + "\t");
                            if (slot[i] != null)
                            {
                                orderedSingleLinkedList = slot[i];
                                writer.Write(orderedSingleLinkedList.ToString());
                            }
                            writer.WriteLine();
                        }
                    }
                    Console.WriteLine("Number Added Successfully !!");
                }

                for (int i = 0; i < 11; i++)
                {
                    Console.Write(i + "\t");
                    if (slot[i] != null)
                    {
                        orderedSingleLinkedList = slot[i];
                        Console.Write(orderedSingleLinkedList.ToString());
                    }
                    Console.WriteLine();
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
