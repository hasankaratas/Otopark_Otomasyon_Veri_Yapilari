using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark
{
    public class Oncelikli : IKuyruk
    {
        public Araba[] Queue;
        private int front = -1;
        private int size = 0;
        private int count = 0;

        public Oncelikli(int size)
        {
            this.size = size;
            Queue = new Araba[size];
        }
        public void Insert(Araba o)
        {

            if (count ==0 )
            {
                front++;
                Queue[front] = o;
                count++;
            }
            else
            {
                int i;
                for (i = count - 1; i >= 0; i--)
                {
                    if ((int)o.AracCikisSuresi < (int) Queue[i].AracCikisSuresi)
                        Queue[i + 1] = Queue[i];
                    else
                        break;
                }
                Queue[i + 1] = o;
                
                count++;
            }
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
