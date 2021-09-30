using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED2_TP2
{
    class Eventos
    {
        private Evento[] osEventos;
        private int adicionados;

        public Evento[] OsEventos
        {
            get { return osEventos; }
        }

        public int Adicionados
        {
            get { return adicionados; }
        }

        public Eventos(int n)
        {
            osEventos = new Evento[n];
            for(int i=0; i<n; i++)
            {
                osEventos[i] = new Evento(0, "", 0);
            }
            adicionados = 0;
        }

        public void adicionarEvento(Evento e)
        {
            osEventos[adicionados] = e;
            adicionados++;
        }

        public string pesquisarParticipante (Participante p)
        {
            for(int i=0; i<adicionados; i++)
            {
                foreach(Participante participante in osEventos[i].Participantes)
                {
                    if(participante.Equals(p))
                    {
                        return "participante encontrado";
                    }
                }
            }
            return "participante não encontrado";
        }

        public int qtdeParticipantes()
        {
            int qtdTotalParticipante = 0;
            foreach(Evento e in osEventos)
            {
               qtdTotalParticipante += e.qtdeParticipantes();
            }
            return qtdTotalParticipante;
        }

        public string listaEventos()
        {
            string lista = "";
            foreach(Evento e in osEventos)
            {
                lista += e.ToString();
            }
            return lista;
        }
    }
}