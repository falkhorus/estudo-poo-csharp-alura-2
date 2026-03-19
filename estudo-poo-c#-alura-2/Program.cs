
Musica musica1 = new Musica();
musica1.Nome = "Mulher de fases";
musica1.Artista = "Raimundos";
musica1.Duracao = 370;
musica1.Disponivel = true;



Musica musica2 = new Musica();
musica2.Nome = "Pescador de ilusões";
musica2.Artista = "O Rappa";
musica2.Duracao = 300;
musica2.Disponivel = false;


Console.WriteLine(musica1.DescricaoResumida);
musica1.ExibirFichaTecnica();
Console.WriteLine(" ");
musica2.ExibirFichaTecnica();

