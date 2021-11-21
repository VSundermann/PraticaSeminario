using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    class Lista
    {
        private No _cabeca, _cauda;

        //Inserir elemento no fim da lista
        public void insereFim(string elemento) {
            No novoNo = new No();
            novoNo.Valor = elemento;

            if(_cabeca == null)
            {
                _cabeca = novoNo;
            }
            else
            {
                _cauda.Proximo = novoNo;   
            }
            _cauda = novoNo;
        }

        //Inserir elemento no inicio da lista
        public void insereInicio(string elemento){
            No novo = new No();
            novo.Valor = elemento;

            if(_cabeca == null)
            {
                _cabeca = novo;
                _cauda = novo;
            }
            else
            {
                novo.Proximo = _cabeca;
            }
            _cabeca = novo;
        }
        
        //Retirar elemento do fim da lista
        public void retiraFim() {
            if (_cabeca == null)
                return;

            if (_cabeca.Proximo == null) {
                Console.WriteLine("Elemento retirado: " + _cabeca.Valor);
                _cabeca = null;               
            }
            else
            {
                No ultimo = _cabeca.Proximo;
                No penultimo = _cabeca;

                while (ultimo.Proximo != null) {
                    penultimo = ultimo;
                    ultimo = ultimo.Proximo;
                }
                penultimo.Proximo = null;
                Console.WriteLine("Elemento retirado: " + ultimo.Valor);
            }
            this.exibir();           
        }

        //Retirar elemento do inicio da lista
        public void retiraInicio()
        {
            if (_cabeca != null)
            {
                Console.WriteLine("Elemento retirado: " + _cabeca.Valor);
                _cabeca = _cabeca.Proximo;
            }
            exibir();
        }

        //Exibir elementos da lista
        public void exibir() {
            if(_cabeca != null)
            {
                No temp = _cabeca;
                while (temp != null) {
                    Console.Write(temp.Valor+" ");
                    temp = temp.Proximo;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("\nLista vazia");
            }
        }
    }
}
