namespace ScreenSoud;
class Podcast
{

    public string Nome { get; set; }
    public string Descricao { get; set; }
    public string Host { get; set; }
    public int totalEpisodios { get; set; }
    public List<Episodio> episodios = new List<Episodio>();

    public Podcast(string nome, string descricao, string host)
    {
        Nome = nome;
        Descricao = descricao;
        Host = host;
    }   

    public void adicionarEpisodio(Episodio episodio)
    {
        Episodio novoEpisodio = new Episodio (episodio.Duracao, episodio.Titulo, episodio.Ordem, episodio.Resumo);
        episodios.Add(novoEpisodio);
    }

    public void listarEpisodios()
    {
        foreach (var episodio in episodios)
        {
            Console.WriteLine($"Título: {episodio.Titulo}, Duração: {episodio.Duracao} segundos, Ordem: {episodio.Ordem}, Resumo: {episodio.Resumo}");
        }
    }

    public void exibirPodcast()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Descrição: {Descricao}");
        Console.WriteLine($"Host: {Host}");
        Console.WriteLine($"Total de Episódios: {episodios.Count}");
    }
}