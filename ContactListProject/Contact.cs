using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListProject
{
    internal class Contact
    {
        string Name;
        PhoneList PhoneList;
        Adress Adress;
        string Email;
        Contact Next;

        public Contact(string name, PhoneList phoneList, Adress adress, string email)
        {
            Name = name;
            PhoneList = phoneList;
            Adress = adress;
            Email = email;
        }

        public void SetName(string name) { this.Name = name; }
        public string GetName() { return this.Name; }
        public void RestartPhoneList() { this.PhoneList = new PhoneList(); }
        public PhoneList GetPhoneList() {  return this.PhoneList; }
        public void SetAdress(Adress adress) { this.Adress = adress; }
        public Adress GetAdress() { return this.Adress; }
        public void SetEmail(string email) {  this.Email = email; }
        public string GetEmail() { return this.Email; }
        public void SetNext(Contact contact) { this.Next = contact; }
        public Contact GetNext() { return this.Next; }
    }
}
