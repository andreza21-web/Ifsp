using System;
using System.Collections.Generic;
using System.Text;

namespace atividade_20_10_2021
{
    class Emprestimo
    {
        private DateTime dtEmprestimo;
        private DateTime dtDevolucao;


        public DateTime DtDevolucao { get => dtDevolucao; set => dtDevolucao = value; }
        public DateTime DtEmprestimo { get => dtEmprestimo; set => dtEmprestimo = value; }

        public Emprestimo(DateTime dtEmprestimo)
        {
            this.DtEmprestimo = dtEmprestimo;
        }

        public Emprestimo(DateTime dtDevolucao, DateTime dtEmprestimo)
        {
            this.DtDevolucao = dtDevolucao;
            this.DtEmprestimo = dtEmprestimo;
        }

        public override string ToString()
        {
            return "Emprestimo do livro foi feito " + dtEmprestimo.ToString() + "\n" + "Devolução do livro: " + dtDevolucao.ToString();
        }

    }
}
