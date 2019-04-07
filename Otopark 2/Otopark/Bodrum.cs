using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark
{
    public class Bodrum : IYigit
    {
        public string[] items;
        public int top = -1;

        public Bodrum(int itemCount)
        {
            this.items = new string[itemCount];
        }
        public void Push(string item)
        {
            if (items.Length == Top + 1)
            {
                throw new Exception("Hata: Stack doldu... (Overflow)");
            }
            items[++Top] = item;
        }

        public string Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Hata: Stack boş...(Downflow)");
            }
            string temp = items[Top--];
            return temp;
        }

        public string Peek()
        {
            return items[Top];
        }

        public bool IsEmpty()
        {
            return Top == -1 ? true : false;
        }

        public int Top
        {
            get
            {
                return top;
            }
            set
            {
                top = value;
            }
        }
    }
}
