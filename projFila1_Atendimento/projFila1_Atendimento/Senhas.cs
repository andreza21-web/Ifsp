﻿using System;
using System.Collections.Generic;
using System.Text;

namespace projFila1_Atendimento
{
    class Senhas
    {
        private int proximoAtendimento;
        private Queue<Senha> filaSenhas;

        // construtor
        public Senhas()
        {
            this.filaSenhas = new Queue<Senha>();
            this.proximoAtendimento = 1;
        }

        // getters e setters
        public int ProximoAtendimento { get => proximoAtendimento; set => proximoAtendimento = value; }
        internal Queue<Senha> FilaSenhas { get => filaSenhas; set => filaSenhas = value; }

        // outros métodos
        public void Gerar()
        {
            this.filaSenhas.Enqueue(new Senha(this.ProximoAtendimento));
            this.proximoAtendimento++;
        }
    }
}
