using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDMap
{
    [Serializable]
    public class Couple<T>
    {
        public T i { get; set; }
        public T j { get; set; }

        public Couple()
        {
        }

        public Couple(T a, T b)
        {
            i = a;
            j = b;
        }

    }
}
