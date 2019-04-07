using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark
{
    public class FIFO : IKuyruk
    {
        public Araba[] Queue ;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;
        public FIFO(int size)
        {
            this.size = size;
            Queue = new Araba[size];
        }
        public void Insert(Araba o)
        {
            if (front == -1)
                front = 0;
            Queue[++rear] = o;
            count++;
        }

        public Araba Remove()
        {
            Araba temp = Queue[front];
            Queue[front] = null;
            front++;
            count--;

            return temp;
        }

    }
}
