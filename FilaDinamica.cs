using System;
using System.Collections.Generic;
using System.Text;

namespace PilhasFilas
{
    class NO_Fila
    {
        public int dezena;
        public NO_Fila proximo;

        public NO_Fila(int dezena)
        {
            this.dezena = dezena;
            this.proximo = null;
        }

        public NO_Fila(int dezena, NO_Fila anterior)
        {
            this.dezena = dezena;
            this.proximo = null;
            anterior.proximo = this;
        }
    }
    internal class FilaDinamica
    {

    }
}
