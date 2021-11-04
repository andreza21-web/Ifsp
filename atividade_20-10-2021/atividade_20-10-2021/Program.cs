using System;

namespace atividade_20_10_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menu = false;
            string opcao;
            int num;

            Livros livros = new Livros();

            while (!menu)
            {

                Console.WriteLine("Selecione uma opção: ");
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Adicionar livro");
                Console.WriteLine("2. Pesquisar livro (sintético)");
                Console.WriteLine("3. Pesquisar livro (analítico)");
                Console.WriteLine("4. Adicionar exemplar");
                Console.WriteLine("5. Registrar empréstimo");
                Console.WriteLine("6. Registrar devolução");

                do
                {
                    Console.WriteLine("Digite a opção desejada: ");
                    opcao = Console.ReadLine();

                } while (!Int32.TryParse(opcao, out num) || num < 0 || num > 6);

                switch (num)
                {
                    case 0:
                        menu= true;
                        break;

                    case 1:
                        int isbn;
                        string titulo, autor, editora;

                        do
                        {
                            Console.WriteLine("Digite o código ISBN do livro: ");
                            opcao = Console.ReadLine();
                        } while (!Int32.TryParse(opcao, out isbn));
                       

                        Console.WriteLine("Digite o título do livro: ");
                        titulo = Console.ReadLine();
                       
                        Console.WriteLine("Digite o nome do autor do livro: ");
                        autor = Console.ReadLine();

                        Console.WriteLine("Digite o nome da editora do livro: ");
                        editora = Console.ReadLine();

                        Livro livroadicionado = new Livro( isbn,
                            titulo,  autor,  editora);

                        livros.Acervo.Add(livroadicionado);
                        Console.WriteLine("Livro cadastrado");
                        break;

                    case 2:
                        
                        Console.Write("Digite o ISBN do livro que deseja pesquisar: ");
                        isbn = Convert.ToInt32(Console.ReadLine());
                        Livro pesquisar = new Livro(isbn, "", "", "");
                        Livro encontrado = livros.pesquisar(pesquisar);
                        if (encontrado != null)
                        {
                            Console.WriteLine(encontrado.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Livro não encontrado");
                        }
                        break;

                    case 3:

                        Console.Write("Digite o ISBN do livro que deseja pesquisar: ");
                        isbn = Convert.ToInt32(Console.ReadLine());
                        pesquisar = new Livro(isbn, "", "", "");
                        encontrado = livros.pesquisar(pesquisar);
                        if (encontrado != null)
                        {
                            Console.WriteLine(encontrado.ToString());
                            Console.WriteLine("Empréstimos registrados");
                            foreach (Exemplar e in encontrado.Exemplares)
                            {
                                Console.WriteLine(e.ToString());
                            }
                        }
                        else
                        {
                            Console.WriteLine("Livro não encontrado");
                        }
                        break;

                    case 4:
                        Console.Write("Digite o ISBN do livro que deseja adicionar um exemplar: ");
                        isbn = Convert.ToInt32(Console.ReadLine());
                        Livro addExemplar = new Livro(isbn, "", "", "");
                        encontrado = livros.pesquisar(addExemplar);
                        if (encontrado != null)
                        {
                            Console.Write("Digite o número do tombo: ");
                            int tombo = Convert.ToInt32(Console.ReadLine());
                            Exemplar exemplar = new Exemplar(tombo);
                            encontrado.adicionarExemplar(exemplar);
                        }
                        else
                        {
                            Console.WriteLine("Livro não encontrado");
                        }
                        break;

                    case 5:

                        Console.Write("Digite o ISBN do livro: ");
                        isbn = Convert.ToInt32(Console.ReadLine());
                        Livro emprestar = new Livro(isbn, "", "", "");
                        encontrado = livros.pesquisar(emprestar);
                        
                        break;

                    case 6:
                        Console.Write("Digite o ISBN do livro: ");
                        isbn = Convert.ToInt32(Console.ReadLine());
                        Livro devolver = new Livro(isbn, "", "", "");
                        encontrado = livros.pesquisar(devolver);
                        break;
                }

            }   
        }
    }
}
