using System;
using System.Collections.Generic;
using System.Text;

namespace projFila1_Atendimento
{
    class Guiche
    {
        private int id;
        private Queue<Senha> atendimentos;

        public int Id { get => id; set => id = value; }
        internal Queue<Senha> Atendimentos { get => atendimentos; set => atendimentos = value; }

        public Guiche()
        {
            Atendimentos = new Queue<Senha>();
            Id = 0;
        }

        public Guiche(int id)
        {
            Atendimentos = new Queue<Senha>();
            Id = id;
        }

        public bool Chamar(Queue<Senha> filaSenhas)
        {
            if(filaSenhas.Count == 0)
            {
                return false;
            }

                Senha senha = filaSenhas.Dequeue();
                atendimentos.Enqueue(senha);
                senha.DataAtend = DateTime.Now.ToString("dd/MM/yyyy");
                senha.HoraAtend = DateTime.Now.ToString("HH:mm:ss");

            return true;

        }
    }
}
