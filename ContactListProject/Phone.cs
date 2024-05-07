using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListProject
{
    internal class Phone
    {
        string phone;
        Phone? next;

        public Phone(string phone)
        {
            this.phone = phone;
            this.next = null;
        }

        public string GetPhone() { return this.phone; }
        public void SetPhone(string phone) { this.phone = phone; }
        public Phone? GetNext() { return this.next; }
        public void SetNext(Phone next) {  this.next = next; }
    }
}
