namespace ScreenSoud;   
class Episodio { 

    public int Duracao { get; set; }
    public string Titulo { get; set; }
    public string Ordem { get; set; }
    public string Resumo { get; set; }
    public List<string> Convidados { get; set; } = new List<string>();

    public Episodio(int duracao, string titulo, string ordem, string resumo)
    {
        this.Duracao = duracao;
        this.Titulo = titulo;
        this.Ordem = ordem;
        this.Resumo = resumo;
    }


    public void adicionarConvidados()
    {
        Convidado convidado = new Convidado("Vitor");
        Convidados.Add(convidado.nome);
    }

}
