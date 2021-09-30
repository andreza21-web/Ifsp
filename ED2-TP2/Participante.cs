using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED2_TP2
{
    class Participante
    {
        private string email;
        private string nome;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Participante(string email, string nome)
        {   
            this.email = email;
            this.nome = nome;
        }

        public Participante()
            : this("", "")
        { }

        public bool podeInscrever(Eventos e)
        {
            if(e.pesquisarParticipante(this) == "participante encontrado")
            {
                return true;
            }
            return false;
        }

        public bool Equals(Participante p)
        {
            if(p.Email == this.email)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            if (nome != "")
            {
                return  "nome:" +nome + ", " + "email:" + email + "\n";
            }
            return null;
        }
    }
}