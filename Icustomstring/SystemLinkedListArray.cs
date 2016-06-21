using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icustomstring
{
    class SystemLinkedListArray:custom
    {
        public class node
        {
            public object nodecontent;
            public node next;
        }
        private int size;
        private node head;
        private node current;
        private int Count
        {
            get
            {
                return size;
            }
        }

        public void List()
        {
            size = 0;
            head = null;
        }
        public void Add(object content)
        {
            size++;
            var node = new node() { nodecontent = content };
            if (head == null)
            {
                head = node;
            }
            else
            {
                current.next = node;
            }
            current = node;
        }
        public void ListNodes()
        {
            node tempnode = head;
            while (tempnode != null)
            {
                Console.WriteLine(tempnode.nodecontent);
                tempnode = tempnode.next;
            }
        }
        public node Retrieve(int Position)
        {
            node tempnode = head;
            node retnode = null;
            int count = 0;
            while (tempnode != null)
            {
                if (count == Position - 1)
                {
                    retnode = tempnode;
                    break;
                }
                count++;
                tempnode = tempnode.next;
            }
            return retnode;
        }
        public bool Delete(int Position)
        {
            if (Position == 1)
            {
                head = null;
                current = null;
                return true;
            }
            if (Position > 1 && Position <= size)
            {
                node tempnode = head;
                node lastnode = null;
                int count = 0;
                while (tempnode != null)
                {
                    if (count == Position - 1)
                    {
                        lastnode.next = tempnode.next;
                        return true;
                    }
                    count++;
                    lastnode = tempnode;
                    tempnode = tempnode.next;
                }
            }
            return false;
        }
    }
}
