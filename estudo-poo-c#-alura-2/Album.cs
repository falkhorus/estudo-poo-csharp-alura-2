class Album
{
    private List<Musica> musicas = new List<Musica>();                          // Eu escrevo List<Musica> porque é uma lista de objetos do tipo Musica, e o nome do atributo é musicas, com letra minúscula. O nome do atributo pode ser qualquer coisa, mas é comum usar o nome da classe no plural para indicar que é uma coleção daquela classe.   
    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);                     // Eu escrevo musicas porque é o nome do atributo que é uma lista de músicas, e eu uso o método Sum para somar a duração de todas as músicas da lista, usando uma expressão lambda para acessar a propriedade Duracao de cada música. a expressão lambda significa que para cada música m na lista de músicas eu quero acessar a propriedade Duracao dela e somar todas essas durações para obter a duração total do álbum.
    
    public void AdicionarMusica(Musica musica)                                 // Eu escrevo Musica porque é o nome da classe, e o nome do parâmetro é musica, com letra minúscula. O nome do parâmetro pode ser qualquer coisa, mas é comum usar o nome da classe com letra minúscula para indicar que é uma instância daquela classe.
    {
        musicas.Add(musica);                                                    // Eu escrevo musicas porque é o nome do atributo que é uma lista de músicas, e eu uso o método Add para adicionar a música passada como parâmetro à lista.
    }

    //Abaixo: Criar uma função vazia e mostrar no console o nome do album 
    // depois percorrer toda a lista de músicas e mostrar para mostrar o nome de cada música

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Bem vindo ao álbum: {Nome}\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($" Música: {musica.Nome}");
        }
        Console.WriteLine($"\n Para ouvir esse álbum inteiro você precisará de {(decimal)DuracaoTotal /60} minutos.");
    }

}