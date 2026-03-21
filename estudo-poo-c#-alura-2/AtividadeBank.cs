using Microsoft.VisualBasic;
using System;
using System.Data;
using System.IO.Pipes;
using System.Runtime.InteropServices.Java;
using System.Security.Cryptography.X509Certificates;



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










// PROGRAMA DE CARRO COM MÉTODOS DE ACELERAR, FREAR E BUZINAR, E EXIBIR AS INFORMAÇÕES DO CARRO.

//class Program  //Preciso criar e instanciar um objeto da classe Carro dentro da Main para chamar os métodos de acelerar, frear e buzinar. E também exibir as informações do carro usando o método ExibirInformacoes().
//{

//    static void Main()
//    { 
//    Carro meuCarro = new Carro();

//        meuCarro.ExibirInformacoes();
//        Console.WriteLine("");
//        meuCarro.Acelerar();
//        Console.WriteLine("");
//        meuCarro.Buzinar();
//        Console.WriteLine("");
//        meuCarro.Frear();



//    }




//}

//class Carro
//{
//    public string fabricante = "Ford";
//    public string modelo = "Bronco";
//    public int ano = 2020;
//    public int velocidade = 0;

//    public void ExibirInformacoes()
//    {

//        Console.WriteLine($"informações do carro: {fabricante}, {modelo}, {ano}");


//    }



//    public void Acelerar() 
//    {
//        if (velocidade < 5)
//        {
//            velocidade++;
//            velocidade++;
//            velocidade++;
//            velocidade++;
//            velocidade++;

//            Console.WriteLine($"Acelerando, velocidade agora é {velocidade}");
//            return;
//        }
//        Console.WriteLine();
//        Console.WriteLine("Velocidade máxima atingida!");
//    }


//    public void Buzinar()
//    {
//        if (velocidade == 5)
//        {

//            Console.WriteLine("buzinando:BEEP BEEP!");

//        }

//    }


//    public void Frear()
//    {
//        if (velocidade == 5)
//        {
//            velocidade--;
//            velocidade--;
//            velocidade--;
//            velocidade--;
//            velocidade--;
//            Console.WriteLine("Freando... Velocidade agora é 0");

//        }

//    }


//}



// 1. CRIANDO UMA CLASSE CHAMADA CONTA:

//class Conta
//{
//    public string Titular { get; set; }
//    public int NumeroDaConta { get; set; }
//    public string NumeroCpf { get; set; }


//    public void ExibirInformacoes()
//    {
//        Console.WriteLine($" O titular da conta é " +
//            $"{Titular}, o número da conta é {NumeroDaConta} e o CPF dele é {NumeroCpf} ");
//    }
//}


//class Program
//{

//    static void Main()
//    {
//        Conta conta1 = new Conta();
//        conta1.Titular = "Maria Silva";
//        conta1.NumeroDaConta = 121212;
//        conta1.NumeroCpf = "1234-56789";
//        conta1.ExibirInformacoes();



//    }

//}




// 2. REESCREVER OS ATRIBUTOS DA CLASSE CARRO SENDO PROPERTIES E ADICIONAR
// UMA NOVA PROPERTIE DescricaoDetalhada, QUE MOSTRA O FABRICANTE , MODELO E ANO DO CARRO




//class Carro
//{
//    public string Fabricante { get; set; }
//    public string Modelo { get; set; }
//    public int Ano { get; set; }
//    public string DescricaoDetalhada
//    {
//        get
//        {
//            return $"O carro é um {Modelo}, da Fabricante {Fabricante} do ano de {Ano}";
//        }



//    }


//    class Program

//    {
//        static void Main()
//        {
//            Carro carro1 = new Carro();
//            carro1.Fabricante = "Ford";
//            carro1.Modelo = "Bronco";
//            carro1.Ano = 2020;
//            Console.WriteLine(carro1.DescricaoDetalhada);


//        }



//    }
//}






//3. REESCREVER A PROPRIEDADE ANO DA CLASSE CARRO PARA QUE ELA APENAS ACEITE VALORES ENTRE 1960 E 2023

//class Carro
//{
//    private int ano { get; set; }
//    public string Fabricante { get; set; }
//    public string Modelo { get; set; }
//    public int Ano
//    {
//        get => ano;
//        set 
//        {
//            if (value < 1960 || value > 2023)
//            {
//                Console.WriteLine(" Valor inválido, digite uma data válida.");


//            }
//            else 
//            {
//                ano = value;

//            }

//        }

//    }


//}

//class Program
//{
//    static void Main()
//    {
//        Carro carro1 = new Carro();
//        carro1.Fabricante = "Ford";
//        carro1.Modelo = "bronco";
//        carro1.Ano = 1950;
//        Console.WriteLine($"{carro1.Ano}");

//    }
//}



//4. DESENVOLVER A CLASSE PRODUTO COM OS ATRIBUTOS NOME, MARCA, PRECO E ESTOQUE. ALÉM DISSO, GARANTIR QUE O PREÇO E O ESTOQUE DO PRODUTO
//    SEJAM VALORES POSITIVOS E CRIAR UMA PROPRIEDADE QUE MOSTRA DETALHADAMENTE AS INFORMAÇÕES DO PRODUTO.

//class Produto
//{


//    public int Somar(int a, int b) => a + b;
//    public string Nome { get; set; }
//    public string Marca { get; set; }

//    private int preco;
//    public int Preco
//    {
//        get => preco;
//        set
//        {
//            if (value < 0)
//            {
//                Console.WriteLine("O preço não pode ser menor que zero, digite um valor válido.");
//                return;
//            }
//            preco = value;
//        }
//    }

//    private int estoque;
//    public int Estoque
//    {
//        get => estoque;
//        set
//        {
//            if (value < 0)
//            {
//                Console.WriteLine("O estoque não pode ser menor que zero, digite um valor válido.");
//                return;
//            }
//            estoque = value;
//        }
//    }

//    public string DetalhesDoProduto
//    {
//        get
//        {
//            return $"O produto é {Nome}, da marca {Marca} e custa R${Preco}. No momento possuímos {Estoque} unidades em estoque. ";
//        }
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        Produto escova = new Produto();
//        escova.Nome = "Escova de Dente";
//        escova.Marca = "Colgate";
//        escova.Preco = 10;
//        escova.Estoque = 50;
//        Console.WriteLine($"{escova.DetalhesDoProduto}");
//        Console.WriteLine($"A soma de Preço + Estoque é {escova.Somar(escova.Preco, escova.Estoque)}" );
//    }
//}








//ATIVIDADE: Modelar uma classe Conta, que tenha como atributos uma classe Titular, além de informações da conta, como agência, número da conta,
//    saldo e limite, bem como um método que devolva as informações da conta de forma detalhada.


class Titular
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public int Idade { get; set; }


}


class Conta
{
    public Titular TitularDaConta { get; set; }
    public string Agencia { get; set; }
    public string NumeroDaConta { get; set; }
    public double Saldo { get; set; }         // usei double porque o saldo pode conter valores decimais, como R$ 1000,50 por exemplo. O tipo double é adequado para representar valores monetários, pois ele tem uma boa precisão e pode armazenar números com casas decimais.
    public double Limite { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"O titular da conta é {TitularDaConta.Nome}, com o CPF {TitularDaConta.Cpf} e de idade {TitularDaConta.Idade}\n");
        Console.WriteLine($"A agência é {Agencia} e o número da conta é {NumeroDaConta}, com saldo de R$ {Saldo} e limite de R$ {Limite}. ");
    }


    

}   

class Program
{
    static void Main()
    {
        Titular titular1 = new Titular();
        titular1.Nome = "Maria Silveira";
        titular1.Cpf = "123.456.789-00";
        titular1.Idade = 30;



        Conta conta1 = new Conta();
        conta1.Agencia = "1234";
        conta1.NumeroDaConta = "56789-0";
        conta1.Saldo = 1000.50;
        conta1.Limite = 500.00;

        conta1.TitularDaConta = titular1;           // associando o titular à conta.
        conta1.ExibirDetalhes();

        
    }

}
