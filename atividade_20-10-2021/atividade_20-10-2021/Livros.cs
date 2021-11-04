using System;
using System.Collections.Generic;
using System.Text;

namespace atividade_20_10_2021
{
    class Livros
    {
      
            private List<Livro> acervo;

            public List<Livro> Acervo { get => acervo; set => acervo = value; }

            public Livros()
            {
                this.acervo = new List<Livro>();
            }

            public void adicionar(Livro livro)
            {
            acervo.Add(livro);
            }

            public Livro pesquisar(Livro livro)
            {
                
                foreach (Livro l in acervo)
                {
                if (livro.Equals(l))
                {
                    return l;
                }
                }
                return null;
            }
        }
    }