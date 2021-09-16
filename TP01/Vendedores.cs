using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TP01
{
    class Vendedores
	{
		private Vendedor[] osVendedores;
		private int max;
		private int qtde;

		public Vendedor[] OsVendedores
		{
			get { return osVendedores; }
			set { osVendedores = value; }
		}

		public int Max
		{
			get { return max; }
			set { max = value; }
		}

		public int Qtde
		{
			get { return qtde; }
			set { qtde = value; }
		}

		public Vendedores(int max)
		{
			this.max = max;
			this.osVendedores = new Vendedor[max];
			this.qtde = 0;
		}

		public Vendedor searchVendedor(int id)
		{
			return Array.Find(this.osVendedores, vendedor => vendedor.Id == id);
		}

		public bool addVendedor(Vendedor v)
		{
			if (this.qtde < max)
			{
				int index = Array.IndexOf(this.osVendedores, null);
				this.osVendedores[index] = v;
				this.qtde++;
				return true;
			}
			else return false;
		}

		public bool delVendedor(int id)
		{
			Vendedor v = this.searchVendedor(id);
			bool hasVendas = Array.Find(v.AsVendas, venda => venda != null) != null;
			if (this.qtde > 0 && !hasVendas)
			{
				int index = Array.IndexOf(this.osVendedores, v);
				this.osVendedores[index] = null;
				return true;
			}
			else return false;
		}

		public double valorVendas()
		{
			double valorTotal = 0;

			foreach (Vendedor vendedor in this.osVendedores)
			{
				valorTotal += vendedor.valorVendas();
			}

			return valorTotal;
		}

		public double valorComissao()
		{
			double comissao = 0;

			foreach (Vendedor vendedor in this.osVendedores)
			{
				comissao += vendedor.valorComissao();
			}

			return comissao;
		}
    }
}