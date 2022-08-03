using System;
using System.Collections.Generic;
using System.Text;

namespace PilhasFilas
{
    internal class FilaEstatica
    {
        int[] _dezenas = new int[10];
        int _inicio = -1;
        int _fim = -1;

        public FilaEstatica()
        {

        }

        bool estaVazia()
        {
            return _inicio == _fim;
        }

        bool estaCheia()
        {
            return _fim == (_dezenas.Length - 1);
        }

        public void enQueue(int dezena)
        {
            if (!estaCheia())
            {
                if(_inicio == -1)
                {
                    _inicio = 0;                    
                }
                _fim++;
                _dezenas[_fim] = dezena;
            }
            else
            {
                throw new Exception("Fila está cheia.");
            }
        }

        public void deQueue()
        {
            if (_fim != -1)
            {
                _dezenas[_dezenas.Length - 1] = 0;
                for (int i = 0; i < (_dezenas.Length-1); i++)
                {
                        _dezenas[i] = _dezenas[i+1];                   
                }
                _fim--;
            }
            else
            {
                throw new Exception("Fila está vazio.");
            }
        }

        public string[] data
        {
            get
            {
                string[] _data = new string[_dezenas.Length];
                if (_inicio !=-1)
                {
                    for (int i = 0; i < _dezenas.Length; i++)
                    {
                        if (i==_fim)
                        {
                            _data[i] = _dezenas[i].ToString() + " <- fim";
                        }
                        else if (i==_inicio)
                        {
                            _data[i] = _dezenas[i].ToString() + " <- inicio";
                        }
                        else
                        {
                            _data[i] = _dezenas[i].ToString();
                        }
                    }
                }
                return _data;
            }
        }
    }
}
