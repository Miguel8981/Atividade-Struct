namespace AtividadeStruct;

public struct EquipeEsports
{
    public string nome;
    public int anoEstreia;
    public int campeonatosVencidos;
    public double totalPremiacoes;

    public void atualizarValorTotalPremiacoes(double valor)
    {
        totalPremiacoes += valor;
    }

    public void registrarCampeonatoVencido(double valorPremio)
    {
        campeonatosVencidos++;
        atualizarValorTotalPremiacoes(valorPremio);
    }

    public void verificarAnoEstreia()
    {
        if (anoEstreia == DateTime.Now.Year)
            Console.WriteLine(nome + " é uma equipe NOVATA.");
        else
            Console.WriteLine(nome + " é uma equipe VETERANA.");
    }

    public void imprimir()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Ano de estreia: " + anoEstreia);
        Console.WriteLine("Campeonatos vencidos: " + campeonatosVencidos);
        Console.WriteLine("Total de premiações: R$ " + totalPremiacoes);
    }
}