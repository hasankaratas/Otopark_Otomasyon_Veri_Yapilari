using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark
{
    public interface IYigit
    {
        void Push(string item);
        string Pop();
        string Peek();
        bool IsEmpty();
        int Top { get; set; }
    }
}
