using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projMedicamento
{
    class Medicamento
    {
        private int id;
        private string nome;
        private string laboratorio;
        private Queue<Lote> lotes;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Laboratorio { get => laboratorio; set => laboratorio = value; }
        internal Queue<Lote> Lotes { get => lotes; set => lotes = value; }

        public Medicamento()
        {
            this.id = 0;
            this.nome = "";
            this.laboratorio = "";
            this.lotes = new Queue<Lote>();
        }

        public Medicamento(int id, string nome, string laboratorio)
        {
            this.id = id;
            this.nome = nome;
            this.laboratorio = laboratorio;
            this.lotes = new Queue<Lote>();
        }

        public int qtdeDisponivel()
        {
            int qtde = 0;
            foreach(Lote lote in lotes)
            {
                qtde +=lote.Qtde;
            }
            return qtde;
        }

        public void comprar(Lote lote)
        {
            this.lotes.Enqueue(lote);
        }

        public bool vender (int qtde)
        {
            bool vender = false;
            int resta = qtde;
            if (qtdeDisponivel() < qtde)
            {
                Console.WriteLine("O medicamento possui somente " + qtdeDisponivel() + " unidade(s) disponíveis.");
            }
            else
            {
                while (resta > 0)
                {
                    foreach (Lote l in lotes.ToList())
                    {
                        if (l.Qtde > resta)
                        {
                            l.Qtde -= resta;
                            resta = 0;
                        }
                        else
                        {
                            resta-=l.Qtde;
                            l.Qtde = 0;
                            lotes.Dequeue();
                        }
                    }
                }
                vender = true;
            }
            return vender;
        }

        public override string ToString()
        {
            return id+" - "+nome+" - "+laboratorio + " - "+qtdeDisponivel().ToString();
        }

        public override bool Equals(object obj)
        {
            return this.id.Equals(((Medicamento)obj).id);
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}