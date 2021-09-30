using System;

namespace ED2_TP2
{
    class Program
    {
        static void Main(string[] args)
        {
         int opcao;
            Console.WriteLine("Digite o número máximo de eventos que deseja inserir: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Eventos eventos = new Eventos(n);

            do
            {   
                Console.WriteLine("0.Sair");
                Console.WriteLine("1. Adicionar evento (escolher o dia, onde 1=SEG, 2=TER, ..., 6=SAB)");
                Console.WriteLine("2. Pesquisar evento (deverá retornar os dados do evento + participantes)");
                Console.WriteLine("3. Listar eventos (informar dados básicos do evento + qtde participantes)");
                Console.WriteLine("4. Adicionar participante (retornando o status da operação com mensagem)");
                Console.WriteLine("5. Pesquisar participante (utilizar o e-mail como critério de pesquisa)");
                Console.WriteLine("6. Informar quantidade total de participantes nos eventos da semana");

                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Programa finalizado");
                        break;

                    case 1:
                        Console.WriteLine(" 1=SEG, 2=TER, ..., 6=SAB");
                        Console.Write("Digite um número de acordo com o dia da semana, como foi informado: ");
                        int dia = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Infome o id para cadastrar o evento: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Infome a descrição do: ");
                        string descricao = Convert.ToString(Console.ReadLine());

                        Console.Write("Infome a quantidade máxima de participantes do evento: ");
                        int qtdeMaxParticipantes = Convert.ToInt32(Console.ReadLine());
                        
                        Evento evento = new Evento(id, descricao, qtdeMaxParticipantes);
                        eventos.adicionarEvento(evento);
                        break;

                    case 2:
                        Console.Write("Infome o ID do evento que deseja pesquisar: ");
                        int idPesquisa = Convert.ToInt32(Console.ReadLine());
                        
                        Evento pesquisa = new Evento(idPesquisa, "", 0);
                        foreach (Evento e in eventos.OsEventos)
                        {
                            if (e.Equals(pesquisa))
                            {
                                pesquisa = e;
                            }
                        }
                        if (pesquisa.Descricao == "")
                        {
                            Console.WriteLine("Evento não encontrado");
                        }
                        else
                        {
                            Console.WriteLine(pesquisa.ToString());
                        }
                        break;

                    case 3:
                        if (eventos.Adicionados == 0)
                        {
                            Console.WriteLine("Não há eventos cadastrados");
                        }
                        else
                        {
                            Console.WriteLine(eventos.listaEventos());
                            break;
                        }
                        break;

                    case 4:
                        Console.Write("Informe o email do participante: ");
                        string email = Convert.ToString(Console.ReadLine());

                        Console.Write("Informe o nome do participante: ");
                        string nome = Convert.ToString(Console.ReadLine());

                        Participante adicionarParticipante = new Participante(email, nome);
                        Console.Write("Informe o ID do evento em que deseja adicioná-lo: ");
                       
                        int idEvento = Convert.ToInt32(Console.ReadLine());
                        Evento enventoAdicionado = new Evento(idEvento, "", 0);

                        if (adicionarParticipante.podeInscrever(eventos) == false)
                        {
                            foreach (Evento e in eventos.OsEventos)
                            {
                                if (e.Equals(enventoAdicionado))
                                {
                                    enventoAdicionado = e;
                                }
                            }
                            if (enventoAdicionado.Descricao == "")
                            {
                                Console.WriteLine("Evento não encontrado");
                            }
                            else
                            {
                                enventoAdicionado.inscreverParticipante(adicionarParticipante);
                                Console.WriteLine("Adicionado com sucesso!!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Não adicionado");
                        }
                        break;
                    case 5:
                        Console.Write("Informe o email do participante: ");
                        string emailPesquisar = Convert.ToString(Console.ReadLine());
                       
                        Participante pesquisar = new Participante(emailPesquisar, "");
                        Console.WriteLine(eventos.pesquisarParticipante(pesquisar));
                        break;
                        
                    case 6:
                        Console.WriteLine(eventos.qtdeParticipantes() + " participantes cadastrados no evento " );
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao > 0 && opcao <= 6);
        }
    }
}