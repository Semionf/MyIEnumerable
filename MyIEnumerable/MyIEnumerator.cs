using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyIEnumerable
{
    internal class MyIEnumerator : IEnumerator
    {
        int[] arr = new int[100];
        int idx = 0;
        public void Add(int s)
        {
            arr[idx] = s;
            idx++;
        }
        public int GetId()
        {
            return 90;
        }
        int loop = -1;
        public object Current
        {
            get
            {
                return arr[loop];
            }
        }
        public bool MoveNext()
        {

            if (loop >= idx)
            {
                //Reset();
                return false;
            }
            else
            {
                loop++;
                if (arr[loop] == 33)
                {
                    return MoveNext();
                }
                return true;
            }

        }

        public void Reset()
        {
            loop = -1;
        }
    }
}
