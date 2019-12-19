/*
 *  Purpose: Program to print the Calendar.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   17-12-2019
 */

using System;

namespace DataStructureProgram
{
    class CalendarProgram
    {
        /// <summary>
        /// This Method is used to test the CalendarProgram Class.
        /// </summary>
        public static void Calendar()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("--------------------Calendar Program--------------------");
                Console.WriteLine();

                Utility utils = new Utility();

                int month, year;
                bool flag;

             
                do
                {
                    Console.WriteLine();
                    Console.Write("Enter the Month: ");
                    flag = int.TryParse(Console.ReadLine(), out month);
                    Utility.ErrorMessage(flag);
                } while (!flag);


                do
                {
                    Console.WriteLine();
                    Console.Write("Enter the year: ");
                    flag = int.TryParse(Console.ReadLine(), out year);
                    Utility.ErrorMessage(flag);
                } while (!flag);
            
                utils.Calendar(month, year);
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }
    }
}
