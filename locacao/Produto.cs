using System;
using System.Collections.Generic;
using System.Text;
namespace locacao{
     class Produto
    {
        private int id;
        private string nome;
        private double diaria;
        private int qtdeDisponivel;
        private List<Contrato> contratos;
        private Stack<Contrato> liberados;

        public Produto(int id, string nome, double diaria, int qtdeDisponivel)
        {
            this.id = id;
            this.nome = nome;
            this.diaria = diaria;
            this.qtdeDisponivel = qtdeDisponivel;
            contratos = new List<Contrato>();
            liberados = new Stack<Contrato>();
        }

        public Produto()
            : this(0, "", 0, 0)
        {
            contratos = new List<Contrato>();
            liberados = new Stack<Contrato>();
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Diaria
        {
            get { return diaria; }
            set { diaria = value; }
        }

        public int QtdeDisponivel
        {
            get { return qtdeDisponivel; }
        }

        public List<Contrato> Contratos
        {
            get { return contratos; }
        }

        public Stack<Contrato> Liberados
        {
            get { return liberados; }
        }

        public Boolean adicionarContrato(Contrato contrato)
        {
            if(pesquisarContrato(contrato) != null)
            {
                return false;
            }
            if(contrato.DtSaida >= DateTime.Now && contrato.DtRetorno > contrato.DtSaida)
            {
                if (qtdeDisponivel == 0)
                {
                    foreach (Contrato c in contratos)
                    {
                        if(c.podeRegistrar(contrato) == true)
                        {
                            contratos.Add(contrato);
                            return true;
                        }
                    }
                    return false;
                }
                qtdeDisponivel -= 1;
                contratos.Add(contrato);
                return true;
            }
            return false;
        }

        public void adicionarEstoque(int qtde)
        {
            qtdeDisponivel += qtde;
        }

        public string listarContratos()
        {
            String retorno = "Contratos registrados:";
            foreach(Contrato contrato in contratos)
            {
                retorno += "\n" + contrato.ToString();
            }
            return retorno;
        }

        public Contrato pesquisarContrato(Contrato contrato)
        {
            foreach(Contrato c in contratos)
            {
                if (c.Equals(contrato))
                {
                    return c;
                }
            }
            return null;
        }

        public bool liberarContrato(Contrato contrato)
        {
            if(pesquisarContrato(contrato) == null)
            {
                return false;
            }
            pesquisarContrato(contrato).DtLiberacao = DateTime.Now;
            liberados.Push(pesquisarContrato(contrato));
            contratos.Remove(pesquisarContrato(contrato));
            return true;
        }

        public string listarLiberados()
        {
            string retorno = "";
            foreach(Contrato contrato in liberados)
            {
                retorno += "\n" + contrato.ToString() + ", Data de Liberação: " + contrato.DtLiberacao.ToString("dd/MM/yyyy");
            }
            return retorno;
        }

        public Contrato pesquisarLiberados(Contrato contrato)
        {
            foreach(Contrato c in liberados)
            {
                if (c.Equals(contrato))
                {
                    return c;
                }
            }
            return null;
        }

        public bool devolver(Contrato contrato)
        {
            Contrato c = pesquisarLiberados(contrato);
            if (c != null)
            {
                if (c.Devolveu == false)
                {
                    c.Devolveu = true;
                    qtdeDisponivel += 1;
                    return true;
                }
            }
            return false;
        }

        public override bool Equals(object obj)
        {
            Produto produto = (Produto)obj;
            return this.id.Equals(produto.Id);
        }

        public override string ToString()
        {
            return "ID: " + id + ", Nome: " + nome + ", Diária: " + diaria + ", Quantidade disponível: " + qtdeDisponivel;
        }
    }
}