using ScreenSoud;
using System.ComponentModel;

class Musica
{
    public string nome { get;}
    public Banda banda { get; }
    public int duracao { get; set; } 
    public bool disponivel { get; set; }
    public string Descricao => $"A musica {nome} pertence a banda {nome}";
    public Album Album { get; set; }
    public string Genero { get; set; }  


    public Musica(Banda artista, string nome, Album album, string genero)
    {
        this.Genero = genero;
        this.Album = album;
        this.banda = artista;
        this.nome = nome;
    }
    public void exibirFichaTecnica()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Artista: " + banda);
        Console.WriteLine("Duração: " + duracao + " segundos");
        Console.WriteLine("Disponível: " + (disponivel ? "Sim" : "Não"));
    }

}

public class Genero
{
}