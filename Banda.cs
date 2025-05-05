using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSoud
{
    class Banda
    {
        private List<Album> albuns = new List<Album>();
        public string nome { get; }


        public Banda(string nome)
        {
            this.nome = nome;
        }


        public void adicionarAlbum(Album album)
        {
            albuns.Add(album);
        }
        public void listarAlbuns()
        {
            foreach (var album in albuns)
            {
                Console.WriteLine($"Nome: {album.Nome}, Duração: {album.Duracao} segundos");
            }
        }
    }
}
