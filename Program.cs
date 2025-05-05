using ScreenSoud;

Banda radiohead = new Banda("Radiohead");

// Criando uma música e definindo suas propriedades
Musica musica1 = new Musica(radiohead, "Fake plastic trees");
musica1.duracao = 240;
musica1.disponivel = true;
musica1.Genero = GeneroMusical.Rock;


// Criando uma música e definindo suas propriedades
Musica musica2 = new Musica(radiohead, "Just");
musica2.duracao = 240;
musica2.disponivel = true;
musica2.Genero = GeneroMusical.Rock;
//----

// Criando um álbum e adicionando músicas a ele
Album album1 = new Album("The Bends", 49);
album1.AdicionarMusica(musica1);
album1.AdicionarMusica(musica2);
album1.listarMusicas();
//---
radiohead.adicionarAlbum(album1);
radiohead.listarAlbuns();