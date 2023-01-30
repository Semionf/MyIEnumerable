using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyIEnumerable
{
    internal class MyIEnumerable : IEnumerable
    {
        MyIEnumerator i = new MyIEnumerator();
        public void Add(int a)
        {
            i.Add(a);
        }
        public IEnumerator GetEnumerator()
        {
            return i;
        }
    }
}
