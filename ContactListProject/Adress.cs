using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListProject
{
    internal class Adress
    {
        string District;
        string Street;
        string City;
        string State;
        int Number;

        public Adress(string district, string street, string city, string state, int number)
        {
            District = district;
            Street = street;
            City = city;
            State = state;
            Number = number;
        }

        public void SetDistrict(string district) { this.District = district; }
        public string GetDistrict() {  return this.District; }
        public void SetStreet(string street) {  this.Street = street; }
        public string GetStreet() { return this.Street; }
        public void SetCity(string city) {  this.City = city; }
        public string GetCity() { return this.City; }
        public void SetState(string state) {  this.State = state; }
        public string GetState() {  return this.State; }
        public void SetNumber(int number) { this.Number = number; }
        public int GetNumber() { return this.Number; }

        public string Print()
        {
            return $"{City} - {State}, {District}, {Street} - nº{Number}";
        }

        public string ConvertAdressToCSV()
        {
            return $"{City};{State};{District};{Street};{Number}";
        }
    }
}
