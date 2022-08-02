using System;
using System.Collections.Generic;
using System.Text;

namespace PilhasFilas
{
    internal class PilhaEstatica
    {
        int[] _dezenas = new int[10];//pilha estática
        int _topo = -1;

        public PilhaEstatica()
        {
            for (int i = 0; i < _dezenas.Length; i++)
            {
                _dezenas[i] = 0;
            }
        }
        public void push(int n)
        {
            if (!estaCheia())
            {
                _topo++;
                _dezenas[_topo] = n;
            }
            else
            {
                throw new Exception("Pilha está cheia");
            }            
        }

        public bool estaVazia()
        {
            if (_topo==-1)
            {
                return  true;
            }
            else
            {
                return false;
            }            
        }

        public bool estaCheia()
        {
            if (_topo == (_dezenas.Length -1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void pop()
        {
            if (!estaVazia())
            {
                _dezenas[_topo]=0;
                _topo--;
            }
            else
            {
                throw new Exception("Pilha está vazia");
            }
        }

        public string[] data
        {
            get
            {
                string[]  _data = new string[_dezenas.Length];
                if (_topo != -1)
                {
                    for (int i = 0; i < _dezenas.Length; i++)
                    {
                        if (i == _topo)
                        {
                            _data[i] = _dezenas[i].ToString() + " <- topo";
                        }
                        else
                        {
                            _data[i] = _dezenas[i].ToString();
                        }
                    }
                }
                else
                {
                    //_data = new string[_dezenas.Length];
                }
                return  _data;
            }
        }
    }
}
