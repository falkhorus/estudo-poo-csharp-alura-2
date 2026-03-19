

class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public string DescricaoResumida 
    {
        get 
        
        {
            return $"A música {Nome} é do artista {Artista}, tem duração de {Duracao} segundos e está {Disponivel} para escutar";
        
        }
    
    } 



    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Está disponível");
        }
        else
        {
            Console.WriteLine("Não está disponível, assine o plano premium para ouvir");
        }


    }

}



