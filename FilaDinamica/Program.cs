namespace FilaDinamica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FilaPessoa filaPessoa = new();

            filaPessoa.Push(new Pessoa("Odair"));
            filaPessoa.Push(new Pessoa("Jose"));
            filaPessoa.Push(new Pessoa("Adalberto"));
            filaPessoa.Push(new Pessoa("Jucicleide"));
            filaPessoa.Push(new Pessoa("Juliana"));

            filaPessoa.Print();

            Console.WriteLine("==========================");

            filaPessoa.Pop();
            filaPessoa.Pop();

            filaPessoa.Print();

            Console.WriteLine("\n==========================");

            filaPessoa.Pop();
            filaPessoa.Pop();
            filaPessoa.Pop();

            filaPessoa.Print();
        }
    }
}
