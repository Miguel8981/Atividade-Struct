namespace AtividadeStruct;

public struct JogadorFutebol
{
    public string nome;
    public string clube;
    public int cartoesAmarelos;
    public int cartoesVermelhos;

    public void registrarNumeroCatoesAmarelos()
    {
        cartoesAmarelos++;
    }

    public void registrarNumeroCatoesVermelhos()
    {
        cartoesVermelhos++;
    }

    public void verificarVinculoClube()
    {
        if (clube != "")
            Console.WriteLine("Jogador possui vínculo com o clube: " + clube);
        else
            Console.WriteLine("Jogador não possui vínculo com nenhum clube.");
    }

    public void imprimir()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Clube: " + clube);
        Console.WriteLine("Cartões amarelos: " + cartoesAmarelos);
        Console.WriteLine("Cartões vermelhos: " + cartoesVermelhos);
    }
}