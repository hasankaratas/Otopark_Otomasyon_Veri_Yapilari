using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark
{
    public interface IKuyruk
    {
        void Insert(string o);
        string Remove();
        string Peek();
        Boolean IsEmpty();
    }
}
