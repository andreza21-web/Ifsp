using System;
using System.Collections.Generic;
using System.Text;

namespace  projFila3_acessos
{
    class Ambiente
    {
        private int id;
        private string nome;
        private Queue<Log> logs;

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

        public Queue<Log> Logs
        {
            get { return logs; }
        }

        public Ambiente(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
            logs = new Queue<Log>(100);
        }

        public Ambiente()
            : this(0, "")
        {
            logs = new Queue<Log>(100);
        }

        public void registrarLog(Log log)
        {
            if(logs.Count <= 100)
            {
                logs.Enqueue(log);
            }
        }

        public override string ToString()
        {
            return "Nome: " + nome + ", ID: " + id;
        }
    }
}