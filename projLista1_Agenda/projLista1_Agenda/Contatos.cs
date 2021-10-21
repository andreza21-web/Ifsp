using System;
using System.Collections.Generic;
using System.Text;

namespace projLista1_Agenda
{
    class Contatos
    {
        private List<Contato> agenda;

        public Contatos(List<Contato> agenda)
        {
            this.Agenda = agenda;
        }

        public Contatos(int v)
        {
        }

        public List<Contato> Agenda { get => agenda; set => agenda = value; }

        /**
         * 
         * adicionar(Contato c): bool |
|        * pesquisar(Contato c): Contato |
|        * alterar(Contato c): bool |
|        * remover(Contato c): bool |
|        * Equals(object obj): bool (override)
         */

        public bool adicionar(Contato contato)
        {
            bool adiciona = false;
            foreach(Contato c in agenda)
            {
                if(c.Nome == contato.Nome)
                {
                    adiciona = true;
                }
            }
            
            return adiciona;
        }

        public Contato pesquisar(Contato contato)
        {
            Contato encontar = new Contato();
           Boolean pesquisa = false;
            for (int i = 0; i < agenda.Count; i++)
            {
                Contato c = agenda[i];
                pesquisa = c.Equals(contato);
                if(pesquisa == true)
                {
                    encontar = c;
                    pesquisa = false;
                }
            }
            return encontar;
        }

        public bool alterar(Contato contato)
        {
            bool achou = false;
            foreach (Contato c in agenda)
            {
                if(c.Equals(contato))
                {
                    c.Nome = contato.Nome;
                    c.Telefone = contato.Telefone;
                    c.Email = contato.Email;
                    c.DtNasc = contato.DtNasc;
                    achou = true;
                }
               
            }
            return achou;
        }

        public Contato remover(Contato contato)
        {
            Contato encontar = new Contato();
            Boolean pesquisa = false;
            foreach (Contato c in agenda)
            {
                pesquisa = c.Equals(contato);
                if (pesquisa == true)
                {
                    encontar = c;
                    pesquisa = false;
                }
            }
            if (pesquisa == true)
            {
                agenda.Remove(encontar);
            }
            return encontar;
        }




    }
}
