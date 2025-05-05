using System.ComponentModel;

class Musica
{
    public string nome { get; set; }
    public string artista { get; set; }
    public int duracao { get; set; } 
    public bool disponivel { get; set; }
    public string Descricao => $"A musica {nome} pertence a banda {nome}";


    public void exibirFichaTecnica()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Artista: " + artista);
        Console.WriteLine("Duração: " + duracao + " segundos");
        Console.WriteLine("Disponível: " + (disponivel ? "Sim" : "Não"));
    }

}