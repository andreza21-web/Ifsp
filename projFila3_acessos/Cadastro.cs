using System;
using System.Collections.Generic;
using System.Text;

namespace projFila3_acessos
{
    class Cadastro
    {
        private List<Usuario> usuarios;
        private List<Ambiente> ambientes;

        public List<Usuario> Usuarios
        {
            get { return usuarios; }
        }

        public List<Ambiente> Ambientes
        {
            get { return ambientes; }
        }

        public Cadastro()
        {
            usuarios = new List<Usuario>();
            ambientes = new List<Ambiente>();
        }

        public void adicionarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public bool removerUsuario(Usuario usuario)
        {
            Usuario remover = pesquisarUsuario(usuario);
            if(remover.Ambientes.Count == 0 && remover != null)
            {
                usuarios.Remove(remover);
                return true;
            }
            return false;
        }

        public Usuario pesquisarUsuario(Usuario usuario)
        {
            foreach(Usuario u in usuarios)
            {
                if(u.Id == usuario.Id)
                {
                    return u;
                }
            }
            return null;
        }

        public void adicionarAmbiente(Ambiente ambiente)
        {
            ambientes.Add(ambiente);
        }

        public bool removerAmbiente(Ambiente ambiente)
        {
            Ambiente remover = pesquisarAmbiente(ambiente);
            if(remover != null)
            {
                ambientes.Remove(remover);
                return true;
            }
            return false;
        }

        public Ambiente pesquisarAmbiente(Ambiente ambiente)
        {
            foreach (Ambiente a in ambientes)
            {
                if (a.Id == ambiente.Id)
                {
                    return a;
                }
            }
            return null;
        }

        public void upload()
        {

        }

        public void download()
        {

        }
    }
}