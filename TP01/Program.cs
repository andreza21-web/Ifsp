using System;

namespace atividade0309
{
	class Program
	{
		static void Main(string[] args)
		{
			Vendedores vendedores = new Vendedores(10);
			int selecao = 0;
			int idAutoIncrementado = 0;

			do
			{
				Console.WriteLine("\nDigite um valor referente à opção:");
				Console.WriteLine("0. Sair");
				Console.WriteLine("1. Cadastrar Vendedor");
				Console.WriteLine("2. Consultar Vendedor");
				Console.WriteLine("3. Excluir Vendedor");
				Console.WriteLine("4. Registrar Venda");
				Console.WriteLine("5. Listar Vendedor");

				selecao = int.Parse(Console.ReadLine());

				if (selecao == 1)
				{
					string nome;
					double percComissao;

					Console.WriteLine("Digite o nome do vendedor");
					nome = Console.ReadLine();
					Console.WriteLine("Digite a porcentagem da comissao do vendedor");
					percComissao = double.Parse(Console.ReadLine());

					Vendedor v = new Vendedor(idAutoIncrementado, nome, percComissao);

					bool sucesso = vendedores.addVendedor(v);

					if (sucesso)
					{
						Console.WriteLine("Vendedor cadastrado com sucesso!");
						idAutoIncrementado++;
					}
					else Console.WriteLine("Ocorreu um erro ao cadastrar o vendedor");
				}
				else if (selecao == 2)
				{
					Console.WriteLine("Digite o Id do vendedor que deseja consultar: ");
					int id = int.Parse(Console.ReadLine());

					Vendedor vendedor = vendedores.searchVendedor(id);
					Console.WriteLine("Vendedor encontrado:");
					Console.WriteLine($"Id: {vendedor.Id}");
					Console.WriteLine($"Nome: {vendedor.Nome}");
					Console.WriteLine($"Valor vendas: {vendedor.valorVendas()}");
					Console.WriteLine($"Valor comissao: {vendedor.valorComissao()}");
				}
				else if (selecao == 3)
				{
					Console.WriteLine("Digite o Id do vendedor que deseja excluir");
					int id = int.Parse(Console.ReadLine());

					bool sucesso = vendedores.delVendedor(id);

					if (sucesso)
						Console.WriteLine("Vendedor excluido com sucesso!");
					else Console.WriteLine("Ocorreu um erro ao excluir o vendedor");
				}
				else if (selecao == 4)
				{
					Vendedor vendedor;
					Console.WriteLine("Digite o id do vendedor: ");
					int id = int.Parse(Console.ReadLine());

					double valor;
					int qtde, dia;

					Console.WriteLine("Digite o valor total da venda");
					valor = double.Parse(Console.ReadLine());
					Console.WriteLine("Digite a quantidade de produtos vendidos");
					qtde = int.Parse(Console.ReadLine());
					Console.WriteLine("Digite o dia da venda");
					dia = int.Parse(Console.ReadLine());

					Venda venda = new Venda(qtde, valor);
					vendedor = vendedores.searchVendedor(id);

					vendedor.registrarVenda(qtde, venda);

					Console.WriteLine("Venda cadastrada com sucesso");
				}
				else if (selecao == 5)
				{
					Console.WriteLine("\nListagem de Vendedores:");
					double totalVendas = 0, totalComissoes = 0;
					foreach (Vendedor vendedor in vendedores.OsVendedores)
					{
						if (vendedor != null)
						{
							Console.WriteLine($"Id: {vendedor.Id}");
							Console.WriteLine($"nome: {vendedor.Nome}");
							Console.WriteLine($"valor vendas: {vendedor.valorVendas()}");
							Console.WriteLine($"valor comissão: {vendedor.valorComissao()}");
							Console.WriteLine();

							totalVendas += vendedor.valorVendas();
							totalComissoes += vendedor.valorComissao();
						}
					}
					Console.WriteLine("========================================");
					Console.WriteLine($"Valor total de vendas: {totalVendas}");
					Console.WriteLine($"Valor total de comissoes: {totalComissoes}");
				}
			} while (selecao != 0);
		}
	}
}