using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaDinamica
{
    internal class FilaPessoa
    {
        Pessoa? head;
        Pessoa? tail;

        public FilaPessoa()
        {
            head = null;
            tail = null;
        }

        public void Push(Pessoa aux)
        {
            if (IsEmpty())
            {
                head = tail = aux;
            }
            else
            {
                tail.SetNext(aux);
                tail = aux;
            }
        }

        public bool Pop()
        {
            if (!IsEmpty())
            {
                if(head == tail)
                {
                    head = tail = null;
                }
                else
                {
                    head = head.GetNext();
                }
                return true;
            }
            return false;
        }

        public void Print()
        {
            Pessoa aux = head;
            if(!IsEmpty())
            {
                int i = 1;
                do
                {
                    Console.WriteLine($"\nPessoa{i}: {aux.GetNome()}");
                    aux = aux.GetNext();
                    i++;
                } while(aux != null);
            }
            else
            {
                Console.WriteLine("\n**Fila Vazia**");
            }
        }

        public bool IsEmpty()
        {
            return head == null && tail == null;
        }
    }
}
