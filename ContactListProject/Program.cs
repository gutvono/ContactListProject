using ContactListProject;

//VARIAVEIS
int option;
string file = "contacts.txt";
List<Contact> contacts = new();

//FUNCOES
void ShowAllContacts(List<Contact> list)
{
    foreach (var item in list) { Console.WriteLine(item.Print()); }
}

List<string> EditPhoneList(Contact contact)
{
    List<string> PhoneList = contact.GetPhoneList();
    int choice;
    do
    {
        Console.WriteLine($"Qual numero deseja editar?\n" +
            $"{contact.ShowAllPhones(PhoneList)}");
        Console.Write("0 - Voltar.\n" +
            "Opção: ");
        choice = int.Parse(Console.ReadLine());

        int counter = 0;
        foreach (var phone in PhoneList)
        {
            counter++;
            if (counter == choice)
            {
                PhoneList.Remove(phone);
                PhoneList.Add(Console.ReadLine());
                break;
            }
        }
    } while (choice != 0);
    return PhoneList;
}

Adress EditAdress(Adress adress)
{
    int choice;
    do
    {
        Console.WriteLine("1 - Editar bairro;\n" +
            "2 - Editar rua;\n" +
            "3 - Editar cidade;\n" +
            "4 - Editar estado;\n" +
            "5 - Editar numero;");
        choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                adress.SetDistrict(Console.ReadLine());
                break;
            case 2:
                adress.SetStreet(Console.ReadLine());
                break;
            case 3:
                adress.SetCity(Console.ReadLine());
                break;
            case 4:
                adress.SetState(Console.ReadLine());
                break;
            case 5:
                adress.SetNumber(int.Parse(Console.ReadLine()));
                break;
            default:
                Console.WriteLine("Selecione uma opção válida...");
                break;
        }
    } while (choice != 0);
    return adress;
}

Contact CreateContact()
{
    int addMore = 0;

    Console.WriteLine("Dados do novo contato:");
    Console.Write("Nome: ");
    string Name = Console.ReadLine();

    List<string> PhoneList = new();
    do
    {
        Console.Write("Celular: ");
        PhoneList.Add(Console.ReadLine());
        Console.WriteLine("Adicionar mais um número...\n" +
            "1 - SIM;\n" +
            "0 - NÃO");
        addMore = int.Parse(Console.ReadLine());
    } while (addMore != 0);

    Console.WriteLine("Informe os dados do endereço:");
    Console.Write("Bairro: ");
    string District = Console.ReadLine();
    Console.Write("\nRua: ");
    string Street = Console.ReadLine();
    Console.Write("\nCidade: ");
    string City = Console.ReadLine();
    Console.Write("\nEstado: ");
    string State = Console.ReadLine();
    Console.Write("\nNumero: ");
    int Number = int.Parse(Console.ReadLine());
    Adress Adress = new(District, Street, City, State, Number);

    Console.Write("\nEmail: ");
    string Email = Console.ReadLine();

    return new Contact(Name, PhoneList, Adress, Email);
};

//Contact SelectContactToEdit(List<Contact> contacts)
//{
//    ShowAllContacts(contacts);
//    Console.WriteLine("Digite o nome exato do contato que deseja editar:");
//    contacts.
//}

Contact EditContact(Contact contact)
{
    Console.WriteLine("1 - Editar nome;\n" +
        "2 - Editar telefones;\n" +
        "3 - Editar endereço\n" +
        "4 - Editar e-mail;\n" +
        "0 - Terminar edição.");

    switch (option)
    {
        case 1:
            contact.SetName(Console.ReadLine());
            break;
        case 2:
            contact.SetPhoneList(EditPhoneList(contact));
            break;
        case 3:
            contact.SetAdress(EditAdress(contact.GetAdress()));
            break;
        case 4:
            contact.SetEmail(Console.ReadLine());
            break;
        default:
            Console.WriteLine("Selecione uma opção válida...");
            break;
    }
    return contact;
}

void CheckFiles(string f)
{
    if (!File.Exists(f)) File.Create(f);
}

void SaveFile(List<Contact> contacts, string f)
{
    CheckFiles(f);
    StreamWriter sw = new(f);

    foreach (var contact in contacts)
    {
        sw.WriteLine(contact.ConvertContactToCSV());
    }

    sw.Close();

    Console.WriteLine("\n\nArquivo salvo:");
    StreamReader sr = new(f);
    sr.ReadToEnd();
    sr.Close();
}

//PROGRAMA
do
{
    Console.WriteLine("-------------------CONTATOS-------------------\n" +
        "1 - Ver contatos;\n" +
        "2 - Adicionar contato;\n" +
        "3 - Editar contato;\n" +
        "4 - Salvar contatos em contatos.txt;\n" +
        "5 - Ler arquivo contatos.txt\n" +
        "0 - SAIR do sistema.");
    option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            ShowAllContacts(contacts);
            break;
        case 2:
            contacts.Add(CreateContact());
            break;
        case 3:
            //EditContact(contacts);
            break;
        case 4:
            SaveFile(contacts, file);
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
} while (option != 0);