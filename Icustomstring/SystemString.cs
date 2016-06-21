using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icustomstring
{
    class SystemString:custom
    {
        private string NewString = null;
        public SystemString(string data)
        {
            NewString = data;
        }
        public override string ToString()
        {
            return NewString;
        }
        public int Length()
        {
            return NewString.Length;
        }
        public void Insert(string StringAdd)
        {
            NewString.Insert(NewString.Count(), StringAdd);
            
        }
        public void Remove(int startIndex, int numToRemove)
        {
            NewString.Remove(startIndex, numToRemove);
        }
    }
}
