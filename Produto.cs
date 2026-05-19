namespace AtividadeStruct;

public struct Produto
{
    public string nome;
    public double preco;
    public int quantidadeEstoque;

    public void aplicarCupomDescontoValor(double valor)
    {
        preco -= valor;
    }

    public void aplicarCupomDescontoPorcentagem(double porcentagem)
    {
        preco -= preco * (porcentagem / 100);
    }

    public void verificarQuantidadeEmEstoque()
    {
        if (quantidadeEstoque > 0)
            Console.WriteLine(nome + " possui " + quantidadeEstoque + " unidade(s) em estoque.");
        else
            Console.WriteLine(nome + " está fora de estoque.");
    }

    public void imprimir()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Preço: R$ " + preco);
        Console.WriteLine("Estoque: " + quantidadeEstoque);
    }
}