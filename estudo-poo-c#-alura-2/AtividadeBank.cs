
using System;

class Program
{
    static void Main(string[] args)
    { 

        Banco conta = new Banco();
        conta.numeroIndicador = 12345;
        conta.nomeTitular = "João Silva";
        conta.saldo = 1000.00;
        conta.senha = 1212;

        conta.ExibirFichaTecnica();
    }
}

class Banco
{
    public int numeroIndicador;
    public string nomeTitular;
    public double saldo;
    public int senha;


        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Numero Indificador: {numeroIndicador}");
            Console.WriteLine($"nome do Titular: {nomeTitular}");
        
        }

}

