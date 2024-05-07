using ContactListProject;

//VARIAVEIS
int option = 0;
ContactList contactList = new();

//FUNCOES
void CreateContact();

void CreateAdress();

void CreatePhone();

//PROGRAMA
do
{
    Console.WriteLine("-------------------CONTATOS-------------------\n" +
        "1 - Ver contatos;\n" +
        "2 - Adicionar contato;\n" +
        "0 - SAIR do sistema.");

    switch (option)
    {
        case 1:

            break;
        case 2:
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
} while (option != 0) ;