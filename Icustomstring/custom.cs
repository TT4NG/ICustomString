using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icustomstring
{
    class custom
    {
        public interface ICustomString
        {
            string ToString();
            int Length();
            void Insert(string start, int position);
            void Remove(int startIndex, int numToRemove);
        }
    }
}
