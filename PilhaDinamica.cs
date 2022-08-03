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

        public int peek()
        {
            if(estaVazia())
            {
                throw new Exception("Pilha está vazia");
            }
            return this._top.dezena;
        }

        public void pop()
        {
            if (estaVazia())
            {
                throw new Exception("Pilha está vazia");
            }

            this._top = this._top.proximo;
            this._contador--;

        }

        public bool estaVazia()
        {
            return this._contador == 0;
        }

        public string[] data 
        { 
            get
            {
                string[] _data = new string[this._contador];
                NO noAtual = this._top;
                for (int i = 0; i < this._contador; i++)
                {
                    if (i == 0)
                    {
                        _data[i] = noAtual.dezena.ToString() + " <- topo";
                        noAtual = noAtual.proximo;
                    }
                    else
                    {
                        _data[i] = noAtual.dezena.ToString();
                        noAtual = noAtual.proximo;
                    }
                }
                return _data;
            } 
        }
    }
}
