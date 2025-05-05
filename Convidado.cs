namespace ScreenSoud;
class Convidado
{

    public string nome { get; set; }

    public Convidado(string nome)
    {
        this.nome = nome;
    }
    public void exibirConvidado()
    {
        Console.WriteLine($"Nome: {nome}");
    }

}