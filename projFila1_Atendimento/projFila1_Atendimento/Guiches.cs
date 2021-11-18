using System;
using System.Collections.Generic;
using System.Text;

namespace projFila1_Atendimento
{
    class Guiches
    {
        private List<Guiche> listaGuiches;

        // construtor
        public Guiches()
        {
            this.listaGuiches = new List<Guiche>();
        }

        // getter e setter
        internal List<Guiche> ListaGuiches { get => listaGuiches; set => listaGuiches = value; }

        // outro método
        public void Adicionar(Guiche guiche)
        {
            this.listaGuiches.Add(guiche);
        }
    }
}
