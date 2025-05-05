using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSoud
{
    class Album
    {
        private List<Musica> musicas = new List<Musica>();
        public int Duracao { get; set; }
        public string Nome { get; set; }

        public Album(string nome, int duraco)
        {
            this.Nome = nome;
            this.Duracao = duraco;
        }
  
    public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }
    public void listarMusicas()
        {
            foreach (var musica in musicas)
            {
                Console.WriteLine($"Nome: {musica.nome}, Artista: {musica.banda}, Duração: {musica.duracao} segundos, Disponível: {(musica.disponivel ? "Sim" : "Não")}");
            }
        }
    }
}
