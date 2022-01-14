using System;

namespace locacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            Produtos produtos = new Produtos();
            do
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Cadastrar tipo de equipamento");
                Console.WriteLine("2. Consultar tipo de equipamento ");
                Console.WriteLine("3. Cadastrar equipamento ");
                Console.WriteLine("4. Registrar Contrato de Locação");
                Console.WriteLine("5. Consultar Contratos de Locação");
                Console.WriteLine("6. Liberar de Contrato de Locação");
                Console.WriteLine("7. Consultar Contratos de Locação liberados");
                Console.WriteLine("8. Devolver equipamentos de Contrato de Locação liberado");
                opcao = Convert.ToInt32(Console.ReadLine());
               switch (opcao)
                {
                    case 0:
                        Console.WriteLine("saindo");
                        break;
                    case 1:
                        Console.Write("Digite o ID do equipamento: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o nome do equipamento: ");
                        string nome = Console.ReadLine();
                        Console.Write("Digite o preço do aluguel diário: ");
                        double diaria = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite a quantidade: ");
                        int qtde = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(produtos.adicionarProduto(new Produto(id, nome, diaria, qtde)) ? "Adicionado" : "Não adicionado");
                        break;
                    case 2:
                        Console.Write("Digite o ID do equipamento: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Produto consulta = produtos.pesquisarProduto(new Produto(id, "", 0, 0));
                        if(consulta != null)
                        {
                            Console.WriteLine(consulta.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Equipamento não encontrado");
                        }
                        break;
                    case 3:
                        Console.Write("Digite o ID do equipamento: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        if(produtos.pesquisarProduto(new Produto(id, "", 0, 0)) != null)
                        {
                            Console.Write("Digite a quantidade que deseja adicionar: ");
                            qtde = Convert.ToInt32(Console.ReadLine());
                            produtos.pesquisarProduto(new Produto(id, "", 0, 0)).adicionarEstoque(qtde);
                        }
                        else
                        {
                            Console.WriteLine("Equipamento não encontrado");
                        }
                        break;
                    case 4:
                        Console.Write("Digite o ID do equipamento: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Produto encontrado = produtos.pesquisarProduto(new Produto(id, "", 0, 0));
                        if (encontrado != null)
                        {
                            Console.Write("Digite o ID do contrato: ");
                            int idContrato = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite a data de saída: ");
                            DateTime dtSaida = DateTime.Parse(Console.ReadLine());
                            Console.Write("Digite a data de retorno: ");
                            DateTime dtRetorno = DateTime.Parse(Console.ReadLine());
                            double valorTotal = Convert.ToDouble(((dtRetorno - dtSaida).TotalDays) * encontrado.Diaria);
                            Console.WriteLine(encontrado.adicionarContrato(new Contrato(idContrato, dtSaida, dtRetorno, valorTotal)) ? "Adicionado" : "Não adicionado");
                        }
                        else
                        {
                            Console.WriteLine("Equipamento não encontrado");
                        }
                        break;
                    case 5:
                        Console.Write("Digite o ID do equipamento: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        encontrado = produtos.pesquisarProduto(new Produto(id, "", 0, 0));
                        if (encontrado != null)
                        {
                            Console.WriteLine(encontrado.listarContratos());
                        }
                        else
                        {
                            Console.WriteLine("Equipamento não encontrado");
                        }
                        break;
                    case 6:
                        Console.Write("Digite o ID do equipamento: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        encontrado = produtos.pesquisarProduto(new Produto(id, "", 0, 0));
                        if (encontrado != null)
                        {
                            Console.Write("Digite o ID do contrato: ");
                            int idContrato = Convert.ToInt32(Console.ReadLine());
                            Contrato contrato = encontrado.pesquisarContrato(new Contrato(idContrato, DateTime.Now, DateTime.Now, 0));
                            if (contrato != null)
                            {
                                Console.WriteLine(encontrado.liberarContrato(contrato) ? "Liberado" : "Não encontrado");
                            }
                            else
                            {
                                Console.WriteLine("Contrato não encontrado");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Equipamento não encontrado");
                        }
                        break;
                    case 7:
                        Console.Write("Digite o ID do equipamento: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        encontrado = produtos.pesquisarProduto(new Produto(id, "", 0, 0));
                        if (encontrado != null)
                        {
                            Console.WriteLine("Contratos liberados:" + encontrado.listarLiberados());
                        }
                        else
                        {
                            Console.WriteLine("Equipamento não encontrado");
                        }
                        break;
                    case 8:
                        Console.Write("Digite o ID do equipamento: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        encontrado = produtos.pesquisarProduto(new Produto(id, "", 0, 0));
                        if (encontrado != null)
                        {
                            Console.Write("Digite o ID do contrato: ");
                            int idContrato = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(encontrado.devolver(new Contrato(idContrato, DateTime.Now, DateTime.Now, 0)) ? "Devolvido" : "Não devolvido");
                        }
                        else
                        {
                            Console.WriteLine("Equipamento não encontrado");
                        }
                        break;
                }
            } while (opcao > 0 && opcao <= 8);
        }
    }
}