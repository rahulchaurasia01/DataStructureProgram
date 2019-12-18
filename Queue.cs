/*
 *  Purpose: Logic of queue.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   16-12-2019
 */

using System;

namespace DataStructureProgram
{
    class Queue
    {

        int[] queue = new int[1000];

        int rear = -1, front = -1;


        /// <summary>
        /// It enqueue the item in the array.
        /// </summary>
        /// <param name="no"></param>
        public void Enqueue(int no)
        {
            if(front == -1)
            {
                front++;
                queue[front] = no;
                rear++;
            }
            else
            {
                rear++;
                queue[rear] = no;
            }
            
        }

        /// <summary>
        /// It return and remove the front element from the array.
        /// </summary>
        public void Dequeue()
        {
            if (front == -1)
                Console.WriteLine("There is no Item in the queue");
            else
            {
                Console.Write(queue[front]);
                for(int i = 0; i< rear;i++)
                    queue[i] = queue[i + 1];
                queue[rear] = -1;
                rear--;
                if (rear == -1)
                    front = -1;
                
            }
        }

        /// <summary>
        /// It return true if the queue is empty or else false.
        /// </summary>
        /// <returns></returns>
        public Boolean IsEmpty()
        {
            if (front == -1 && rear == -1)
                return true;
            else
                return false;
        }
    
        /// <summary>
        /// It return the size of the queue.
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            if (front == -1 && rear == -1)
                return 0;
            else
                return rear - front;
        }
    
    }
}
