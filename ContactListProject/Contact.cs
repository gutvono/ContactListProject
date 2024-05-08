using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListProject
{
    internal class Contact
    {
        string Name;
        List<string> PhoneList;
        Adress Adress;
        string Email;

        public Contact(string name, List<string> phoneList, Adress adress, string email)
        {
            Name = name;
            PhoneList = phoneList;
            Adress = adress;
            Email = email;
        }

        public void SetName(string name) { this.Name = name; }
        public string GetName() { return this.Name; }
        public void SetPhoneList(List<string> PhoneList) { this.PhoneList = PhoneList; }
        public List<string> GetPhoneList() {  return this.PhoneList; }
        public string ShowAllPhones(List<string> phones)
        {
            int counter = 0;
            string phonesString = "";
            foreach (var phone in phones)
            {
                counter++;
                if (counter == phones.Count) phonesString += $"{counter} - {phone}.";
                else phonesString += $"{counter} - {phone}, \n";
            }

            return phonesString;
        }
        public void SetAdress(Adress adress) { this.Adress = adress; }
        public Adress GetAdress() { return this.Adress; }
        public void SetEmail(string email) {  this.Email = email; }
        public string GetEmail() { return this.Email; }
        public string Print()
        {
            return $"Nome: {Name}\n" +
                $"Telefones:\n{ShowAllPhones(this.PhoneList)}\n" +
                $"Endereço: {Adress.Print()}\n" +
                $"E-mail: {Email}";
        }

        public string ConvertContactToCSV()
        {
            string phones = "";
            foreach (var phone in this.PhoneList)
            {
                phones += $"{phone};";
            }

            return $"{Name};{ConvertContactToCSV()}{Adress.ConvertAdressToCSV()};{Email}";
        }
    }
}
