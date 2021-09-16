using System;
using System.Collections.Generic;
using System.Text;

namespace TP01
{
    class Vendedor
	{
		private int id;
		private string nome;
		private double percComissao;
		private Venda[] asVendas;

		public Vendedor()
			: this(0, "", 0.0)
		{ }
		public Vendedor(int id, string nome, double percComissao)
		{
			this.id = id;
			this.nome = nome;
			this.percComissao = percComissao;
			this.asVendas = new Venda[31];
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

		public double PercComissao
		{
			get { return percComissao; }
			set { percComissao = value; }
		}

		public Venda[] AsVendas
		{
			get { return asVendas; }
			set { asVendas = value; }
		}

		public void registrarVenda(int dia, Venda venda)
		{
			if (dia <= 31 && dia >= 1)
				this.asVendas[dia] = venda;
			else
				Console.WriteLine("Digita um inteiro entre 01 e 31 para que este seja o valor de dia");
		}

		public double valorVendas()
		{
			double total = 0;
			foreach (Venda venda in asVendas)
			{
				if (venda != null)
					total += venda.Valor;
			}

			return total;
		}

		public double valorComissao()
		{
			return this.valorVendas() * percComissao;
		}class Vendedor
	{
		private int id;
		private string nome;
		private double percComissao;
		private Venda[] asVendas;

		public Vendedor()
			: this(0, "", 0.0)
		{ }
		public Vendedor(int id, string nome, double percComissao)
		{
			this.id = id;
			this.nome = nome;
			this.percComissao = percComissao;
			this.asVendas = new Venda[31];
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

		public double PercComissao
		{
			get { return percComissao; }
			set { percComissao = value; }
		}

		public Venda[] AsVendas
		{
			get { return asVendas; }
			set { asVendas = value; }
		}

		public void registrarVenda(int dia, Venda venda)
		{
			if (dia <= 31 && dia >= 1)
				this.asVendas[dia] = venda;
			else
				Console.WriteLine("Digita um inteiro entre 01 e 31 para que este seja o valor de dia");
		}

		public double valorVendas()
		{
			double total = 0;
			foreach (Venda venda in asVendas)
			{
				if (venda != null)
					total += venda.Valor;
			}

			return total;
		}

		public double valorComissao()
		{
			return this.valorVendas() * percComissao;
		}
    }
}