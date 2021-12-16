using System;
using System.Collections.Generic;
using System.Text;

namespace projFila3_acessos
{
    class Log
    {
        private DateTime dtAcesso;
        private Usuario usuario;
        private bool tipoAcesso;

        public DateTime DtAcesso
        {
            get { return dtAcesso; }
        }

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public bool TipoAcesso
        {
            get { return tipoAcesso; }
            set { tipoAcesso = value; }
        }

        public Log(DateTime dtAcesso, Usuario usuario)
        {
            this.dtAcesso = dtAcesso;
            this.usuario = usuario;
            tipoAcesso = false;
            foreach(Ambiente ambiente in usuario.Ambientes)
            {
                foreach(Log log in ambiente.Logs)
                {
                    if(this.Equals(log))
                    {
                        tipoAcesso = true;
                    }
                }
            }
        }

        public Log()
            : this(DateTime.Now, new Usuario())
        {
            tipoAcesso = false;
        }

        public override string ToString()
        {
            return "Data de acesso: " + dtAcesso + ", Usuário: " + usuario.ToString() + ", Acesso: " + (tipoAcesso ? "autorizado" : "negado");
        }
    }
}