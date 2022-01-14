using System;
using System.Collections.Generic;
using System.Text;

namespace locacao{
   
    class Produtos
    {
        private Queue<Produto> listaProdutos;

        public Produtos()
        {
            listaProdutos = new Queue<Produto>();
        }

        public Queue<Produto> ListaProdutos
        {
            get { return listaProdutos; }
        }

        public Boolean adicionarProduto(Produto produto)
        {
            if (pesquisarProduto(produto) == null)
            {
                listaProdutos.Enqueue(produto);
                return true;
            }
            return false;
        }

        public void removerProduto()
        {
            listaProdutos.Dequeue();
        }

        public Produto pesquisarProduto(Produto produto)
        {
            foreach(Produto p in listaProdutos)
            {
                if(p.Equals(produto))
                {
                    return p;
                }
            }
            return null;
        }
    }
}