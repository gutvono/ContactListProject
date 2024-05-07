using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListProject
{
    internal class PhoneList
    {
        Phone? head;
        Phone? tail;

        public PhoneList()
        {
            this.head = null;
            this.tail = null;
        }

        public void Add()
        {
            if (isEmpty()) { this.head = this.tail = null; }
            else
            {

            }

        bool isEmpty() { return this.head == null && this.tail == null; }
    }
}