using System;
using System.Collections.Generic;
using System.Text;

namespace locacao{
    class Contrato
    {
        private int id;
        private DateTime dtSaida;
        private DateTime dtRetorno;
        private DateTime dtLiberacao;
        private double valorTotal;
        private bool devolveu;

        public Contrato(int id, DateTime dtSaida, DateTime dtRetorno, double valorTotal)
        {
            this.id = id;
            this.dtSaida = dtSaida;
            this.dtRetorno = dtRetorno;
            this.valorTotal = valorTotal;
            devolveu = false;
        }

        public Contrato()
            : this(0, DateTime.Now, DateTime.Now, 0)
        {
            devolveu = false;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime DtSaida
        {
            get { return dtSaida; }
            set { dtSaida = value; }
        }

        public DateTime DtRetorno
        {
            get { return dtRetorno; }
            set { dtRetorno = value; }
        }

        public DateTime DtLiberacao
        {
            get { return dtLiberacao; }
            set { dtLiberacao = value; }
        }

        public double ValorTotal
        {
            get { return valorTotal; }
        }

        public bool Devolveu
        {
            get { return devolveu; }
            set { devolveu = value; }
        }

        public bool podeRegistrar(Contrato contrato)
        {
            if((contrato.DtSaida >= dtSaida && contrato.DtSaida <= dtRetorno) || (contrato.DtRetorno >= dtSaida && contrato.DtRetorno <= dtRetorno))
            {
                return false;
            }
            return true;
        }

        public override bool Equals(object obj)
        {
            Contrato contrato = (Contrato)obj;
            return contrato.id.Equals(id);
        }

        public override string ToString()
        {
            return "ID do contrato: " + id +
                ", saída: " + dtSaida.ToString("dd/MM/yyyy") +
                ", retorno: " + dtRetorno.ToString("dd/MM/yyyy") +
                ", Valor total do Produto: " + valorTotal;
        }
    }
}