using System;
using System.Collections.Generic;
using System.Text;

namespace projLista1_Agenda
{
    class Data
    {
        private int dia;
        private int mes;
        private int ano;


        public Data()
        {
            dia = 0;
            mes = 0;
            ano = 0;
        }

        public void setData(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }

        public int Dia { get => dia; set => dia = value; }
        public int Mes { get => mes; set => mes = value; }
        public int Ano { get => ano; set => ano = value; }


        public override string ToString()
        {
           return  dia + "/" + mes + "/" + ano;
        }
    }
}
