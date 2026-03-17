
using System;
using System.Data;
using System.Runtime.InteropServices.Java;



//class Program
//{
//    static void Main(string[] args)
//    { 

//        Banco conta = new Banco();
//        conta.numeroIndicador = 12345;
//        conta.nomeTitular = "João Silva";
//        conta.saldo = 1000.00;
//        conta.senha = 1212;

//        conta.ExibirFichaTecnica();
//    }
//}

//class Banco
//{
//    public int numeroIndicador;
//    public string nomeTitular;
//    public double saldo;
//    public int senha;


//        public void ExibirFichaTecnica()
//        {
//            Console.WriteLine($"Numero Indificador: {numeroIndicador}");
//            Console.WriteLine($"nome do Titular: {nomeTitular}");

//        }

//}



//class Program
//{
//    static void Main()

//    {
//        Veiculo combe = new Veiculo();
//        combe.Ligar();
//        combe.Ligar("combe");
//    }


//}
//class Veiculo   // Exemplo de classe com sobrecarga de métodos
//{
//    public string marca;
//    public int aceleracao;
//    public int freio;
//    public void MostrarMarca()
//    {
//        Console.WriteLine($"Marca: {marca}");
//    }

//    public void Ligar()
//    {
//        Console.WriteLine("Ligar pow");
//    }

//    public void Ligar(string nome)
//    {
//        Console.WriteLine($"Ligar {nome} veio");
//    }

//}


// metodo de buzinar, acelerar e frear

// fabricante, modelo, ano, cor, ligar, desligar, acelerar, frear





class Program  //Preciso criar e instanciar um objeto da classe Carro dentro da Main para chamar os métodos de acelerar, frear e buzinar. E também exibir as informações do carro usando o método ExibirInformacoes().
{

    static void Main()
    { 
    Carro meuCarro = new Carro();

        meuCarro.ExibirInformacoes();
        Console.WriteLine("");
        meuCarro.Acelerar();
        Console.WriteLine("");
        meuCarro.Frear();
        Console.WriteLine("");
        meuCarro.Buzinar();


    }




}







class Carro
{
    public string fabricante = "Ford";
    public string modelo = "Bronco";
    public int ano = 2020;
    public int velocidade = 0;

    public void ExibirInformacoes()
    {

        Console.WriteLine($"informações do carro: {fabricante}, {modelo}, {ano}");


    }


   
    public void Acelerar() 
    {
        if (velocidade < 5)
        {
            velocidade++;
            velocidade++;
            velocidade++;
            velocidade++;
            velocidade++;
            
            Console.WriteLine($"Acelerando, velocidade agora é {velocidade}");
            return;
        }
        Console.WriteLine();
        Console.WriteLine("Velocidade máxima atingida!");
    }


    


    public void Frear()
    {
        if (velocidade == 5)
        {
            Console.WriteLine("Freando, velocidade agora é 0");

        }

    }



    public void Buzinar()
    {
        if (velocidade == 5)
        {

            Console.WriteLine("buzinando:BEEP BEEP!");

        }

    }


    

    

}










