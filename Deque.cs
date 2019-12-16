/*
 *  Purpose: Logic of Deque.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   16-12-2019
 */

using System;

namespace DataStructureProgram
{
    class Deque
    {

        char[] deque = new char[1000];

        int front = -1, rear = -1;

        /// <summary>
        /// It add the Element at the front of deque.
        /// </summary>
        /// <param name="character"></param>
        public void AddFront(char character)
        {
            if(front == -1)
            {
                front++;
                deque[front] = character;
                rear++;
            }
            else
            {
                rear++;
                for(int i=1;i<=rear;i++)
                    deque[i] = deque[i - 1];

                deque[front] = character;
            }
        }


        /// <summary>
        /// It Add the element at the rear of the deque.
        /// </summary>
        /// <param name="character"></param>
        public void AddRear(char character)
        {
            if (rear == -1)
            {
                rear++;
                deque[rear] = character;
                front++;
            }
            else
            {
                rear++;
                deque[rear] = character;
            }
        }

        /// <summary>
        /// It removes the element from the front of deque.
        /// </summary>
        public void RemoveFront()
        {
            if (front == -1)
                Console.WriteLine("Deque is Empty");
            else
            {
                Console.WriteLine(deque[front]);
                for (int i = 0; i < rear; i++)
                    deque[i] = deque[i + 1];

                rear--;
            }
        }

        /// <summary>
        /// It Removes the element from the rear of deque.
        /// </summary>
        public void RemoveRear()
        {
            if (rear == -1)
                Console.WriteLine("Deque is Empty");
            else
            {
                Console.WriteLine(deque[rear]);
                deque[rear] = ' ';
                rear--;
            }
        }
    
        /// <summary>
        /// It returns true if the deque is empty or else false
        /// </summary>
        /// <returns></returns>
        public Boolean IsEmpty()
        {
            if (front == -1 && rear == -1 || front == rear)
                return true;
            else
                return false;
        }
    
        /// <summary>
        /// It return the number of element in deque
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
