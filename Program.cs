using ScreenSoud;

Banda radiohead = new Banda("Radiohead");

// Criando um álbum
Album album1 = new Album("The Bends", 49);
album1.listarMusicas();

// Criando uma música e definindo suas propriedades
Musica musica1 = new Musica(radiohead, "Fake plastic trees", album1, "Rock");
musica1.duracao = 240;
musica1.disponivel = true;



// Criando uma música e definindo suas propriedades
Musica musica2 = new Musica(radiohead, "Just", album1, "Rock");
musica2.duracao = 240;
musica2.disponivel = true;


album1.AdicionarMusica(musica1);
album1.AdicionarMusica(musica2);


//---
radiohead.adicionarAlbum(album1);
radiohead.listarAlbuns();

Podcast podcast = new Podcast("ScreenSound", "Podcast sobre musica", "Vitor Host");
Episodio episodio1 = new Episodio(10, "Introdução ao podcast", "30", "Conversa sobre a discografia de radiohead e o fato de Fake Plastic Trees ser a maior musica de todos os tempos");
podcast.adicionarEpisodio(episodio1);
podcast.listarEpisodios();
podcast.exibirPodcast();


