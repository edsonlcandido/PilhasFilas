using System;
using System.Collections.Generic;
using System.Text;

namespace PilhasFilas
{
    class NO
    {
        public int dezena;
        public NO proximo;

        public NO(int dezena)
        {
            this.dezena = dezena;
            this.proximo = null;
        }

        public NO(int dezena, NO proximo)
        {
            this.dezena=dezena;
            this.proximo = proximo;
        }   
    }
    internal class PilhaDinamica
    {
        private NO _top;
        private int _contador;
        public int contador { get { return _contador; } }

        public PilhaDinamica()
        {
            this._contador = 0;
            this._top = null;
        }

        public void push(int dezena)
        {
            if(this._top == null)
            {
                this._top=new NO(dezena);
            }
            else
            {
                NO novoNO = new NO(dezena, this._top);
                this._top = novoNO;
            }
            this._contador++;
        }
    }
}
