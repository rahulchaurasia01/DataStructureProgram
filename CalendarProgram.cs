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
            Console.WriteLine();
            Console.WriteLine("--------------------Calendar Program--------------------");
            Console.WriteLine();

            int month, year;

            Console.Write("Enter the Month: ");
            month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the year: ");
            year = Convert.ToInt32(Console.ReadLine());

            Utility utils = new Utility();

            utils.Calendar(month, year);
        }
    }
}
