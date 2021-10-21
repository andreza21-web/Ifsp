using System;
using System.Collections.Generic;
using System.Text;

namespace projLista1_Agenda
{
    class Contato
    {
        private string email;
        private string nome;
        private string telefone;
        private Data dtNasc;

        public Contato()
        {
            email = "";
            nome = "";
            telefone = "";
            dtNasc = new Data();
        }

        public Contato(string email, string nome, string telefone, Data dtNasc)
        {
            this.Email = email;
            this.Nome = nome;
            this.Telefone = telefone;
            this.DtNasc = dtNasc;
        }

        public string Email { get => email; set => email = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        internal Data DtNasc { get => dtNasc; set => dtNasc = value; }

        
        public int getIdate()
        {
          return 2021 - dtNasc.Ano;
        }

        public override bool Equals(object obj)
        {
            return this.email.Equals(((Contato)obj).Email);
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Nome: " + nome + " telefone: " + telefone + "Email: " + email + " idade: " + getIdate();
        }
    }
}
