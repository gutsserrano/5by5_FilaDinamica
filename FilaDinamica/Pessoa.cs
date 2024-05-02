using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaDinamica
{
    internal class Pessoa
    {
        string nome;
        Pessoa? proximo;

        public Pessoa(string nome)
        {
            this.nome = nome;
            proximo = null;
        }

        public void SetNext(Pessoa aux)
        {
            proximo = aux;
        }

        public string GetNome()
        {
            return nome;
        }

        public Pessoa? GetNext()
        {
            return proximo;
        }

    }
}
