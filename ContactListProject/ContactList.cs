using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListProject
{
    internal class ContactList
    {
        Contact? head;
        Contact? tail;

        public ContactList()
        {
            this.head = null;
            this.tail = null;
        }

        public void Add(Contact contact)
        {
            if (isEmpty())
            {
                this.head = contact;
                this.tail = contact;
            }
            else
            {
                int compare = string.Compare(contact.GetName(), head.GetName(), comparisonType: StringComparison.OrdinalIgnoreCase);
                if (compare <= 0)
                {
                    Contact aux = head;
                    head = contact;
                    head.SetNext(aux);
                }
                else
                {
                    Contact aux = head;
                    Contact prev = head;

                    do
                    {
                        compare = string.Compare(contact.GetName(), aux.GetName());
                        if (compare > 0)
                        {
                            prev = aux;
                            aux = aux.GetNext();
                        }

                    } while (aux != null && compare > 0);

                    prev.SetNext(contact);
                    contact.SetNext(aux);
                    if (aux == null)
                        tail = contact;
                }
            }
        }

        bool isEmpty() { return this.head == null && this.tail == null; }

        public void RemoveByName(string name)
        {
            if (!isEmpty())
            {
                if (name == this.head.GetName())
                {
                    if (head == tail)
                        tail = head = null;
                    else
                    {
                        head = head.GetNext();
                    }
                }
                else
                {
                    Contact aux = head;
                    Contact prev = head;
                    bool compare;
                    do
                    {
                        compare = name.Equals(aux.GetName());
                        if (!compare)
                        {
                            prev = aux;
                            aux = aux.GetNext();
                        }
                        else
                        {
                            prev.SetNext(aux.GetNext());
                            if (prev.GetNext() == null)
                                tail = prev;
                        }

                    } while (compare == false && aux != null);

                    if (aux == null)
                    {
                        Console.WriteLine("Não existe o contato na lista.");
                    }
                }
            }
        }

        public void ShowAll()
        {
            Contact aux = head;
            do
            {
                Console.WriteLine(aux.ToString());
                aux = aux.GetNext();
            } while (aux != null);
        }
    }
}