using System;

namespace projLista1_Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            Contatos contatos = new Contatos(20);
            int opcoes;

            Console.WriteLine("0. Sair ");
            Console.WriteLine("1. Adicionar contato ");
            Console.WriteLine("2. Pesquisar contato ");
            Console.WriteLine("3. Alterar contato ");
            Console.WriteLine("4. Remover contato ");
            Console.WriteLine("5. Listar contatos");

            opcoes = int.Parse(Console.ReadLine());

            while(opcoes != 0)
            {
                if(opcoes ==1)
                {
                    Contato contato = new Contato();
                    Console.WriteLine("Nome:");
                    string nome = Console.ReadLine();

                    Console.WriteLine("email: ");
                    string email = Console.ReadLine();

                    Console.WriteLine("telefone: ");
                    string telefone = Console.ReadLine();

                    Console.WriteLine("Informe dia do Nascimento: ");
                    int dia = int.Parse(Console.ReadLine());

                    Console.WriteLine("Informe mes do Nascimento: ");
                    int mes = int.Parse(Console.ReadLine());

                    Console.WriteLine("Informe ano do Nascimento: ");
                    int ano = int.Parse(Console.ReadLine());

                    Data dataNascimento = new Data();
                    dataNascimento.setData(dia, mes, ano);

                    //adicionar dentro de contato
                    contato.Nome = nome;
                    contato.Email = email;
                    contato.Telefone = telefone;
                    contato.DtNasc = dataNascimento;

                    contatos.adicionar(contato);

                }

                if (opcoes == 2)
                {
                    Contato contato = new Contato();
                    Console.WriteLine("Nome:");
                    string nome = Console.ReadLine();

                

                    //adicionar dentro de contato
                    contato.Nome = nome;

                    contato = contatos.pesquisar(contato);

                    if (contato.Nome != "")
                    {
                        Console.WriteLine(contato.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Contato não encontrado!");
                    }

                }

                if (opcoes == 3)
                {
                    Contato contato = new Contato();
                    Console.WriteLine("Nome:");
                    string nome = Console.ReadLine();

                    Console.WriteLine("email: ");
                    string email = Console.ReadLine();

                    Console.WriteLine("telefone: ");
                    string telefone = Console.ReadLine();

                    Console.WriteLine("Informe dia do Nascimento: ");
                    int dia = int.Parse(Console.ReadLine());

                    Console.WriteLine("Informe mes do Nascimento: ");
                    int mes = int.Parse(Console.ReadLine());

                    Console.WriteLine("Informe ano do Nascimento: ");
                    int ano = int.Parse(Console.ReadLine());

                    Data dataNascimento = new Data();
                    dataNascimento.setData(dia, mes, ano);

                    //adicionar dentro de contato
                    contato.Nome = nome;
                    contato.Email = email;
                    contato.Telefone = telefone;
                    contato.DtNasc = dataNascimento;

                    contatos.alterar(contato);

                }

                if (opcoes == 4)
                {
                    Contato contato = new Contato();
                    Console.WriteLine("Nome:");
                    string nome = Console.ReadLine();



                    //adicionar dentro de contato
                    contato.Nome = nome;

                    contatos.remover(contato);

                }

                if (opcoes == 5)
                {
                    foreach (Contato c in contatos.Agenda)
                    {
                        if (c.Nome != "")
                        {
                            Console.WriteLine(c.ToString());
                        }
                    }
                }
            }
        }
    }
}
