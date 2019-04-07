using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark
{
    public class Zemin : IKuyruk
    {
        public string[] Queue;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;
        public Zemin(int size)
        {
            this.size = size;
            Queue = new string[size];
        }
        public void Insert(string o)
        {
            if (count == size)
                throw new Exception("Queue dolu.");

            if (front == -1)
                front = 0;

            if (rear == size - 1)
            {
                rear = 0;
                Queue[rear] = o;
            }
            else
                Queue[++rear] = o;

            count++;
        }

        public string Remove()
        {
            if (IsEmpty())
                throw new Exception("Queue boş.");

            string temp = Queue[front];
            Queue[front] = null;
            if (front == size - 1)
                front = 0;
            else
                front++;

            count--;

            return temp;
        }

        public string Peek()
        {
            return Queue[front];
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }
    }
}
