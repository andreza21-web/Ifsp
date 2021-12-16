using System;
using System.Collections.Generic;
using System.Text;

namespace projFila3_acessos

{
    class Usuario
    {
        private int id;
        private string nome;
        private List<Ambiente> ambientes;

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

        public List<Ambiente> Ambientes
        {
            get { return ambientes; }
        }

        public Usuario(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
            ambientes = new List<Ambiente>();
        }

        public Usuario()
            : this (0, "")
        {
            ambientes = new List<Ambiente>();
        }

        public bool concederPermissao(Ambiente ambiente)
        {
            bool encontrou = false;
            foreach(Ambiente a in ambientes)
            {
                if(a.Id == ambiente.Id)
                {
                    encontrou = true;
                }
            }
            if(encontrou == false)
            {
                ambientes.Add(ambiente);
                return true;
            }
            return false;
        }

        public bool revogarPermissao(Ambiente ambiente)
        {
            foreach (Ambiente a in ambientes)
            {
                if (a.Id == ambiente.Id)
                {
                    ambientes.Remove(a);
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return "Nome: " + nome + ", ID: " + id;
        }
    }
}