double resultado = 0;

double somarValor(double valor)
{
    return resultado + valor;
}

double subtrairValor(double valor)
{
    return resultado - valor;
}

double dividirValor(double valor)
{
    return resultado / valor;
}

double multiplicarValor(double valor)
{
    return resultado * valor;
}

double zerarResultado()
{
    return 0;

}

double pegarResultadoDaUltimaOperacaoMatematica()
{
    double resultado = definirResultadoDaUltimaOperacaoMatematica();
    return resultado;
}

double definirResultadoDaUltimaOperacaoMatematica()
{
    Console.WriteLine("Escolha qual operação deseja realizar:\n1 - Somar\n2 - Subtrair\n3 - Multiplicar\n4 - Dividir\n5 - Zerar Calculadora");
    int operacao = int.Parse(Console.ReadLine());
    double resultado = 0;
    if (operacao == 1)
    {
        Console.WriteLine("Você digitou 1 - Somar\nQual valor deseja somar?");
        double valor = double.Parse(Console.ReadLine());
        resultado = somarValor(valor);
        return resultado;
    }
    else if (operacao == 2)
    {
        Console.WriteLine("Você digitou 2 - Subtrair\nQual valor deseja subtrair?");
        double valor = double.Parse(Console.ReadLine());
        resultado = subtrairValor(valor);
        return resultado;
    }
    else if (operacao == 3)
    {
        Console.WriteLine("Você digitou 3 - Multiplicar\nQual valor deseja multiplicar?");
        double valor = double.Parse(Console.ReadLine());
        resultado = multiplicarValor(valor);
        return resultado;
    }
    else if (operacao == 4)
    {
        Console.WriteLine("Você digitou 4 - Dividir\nPor qual valor deseja dividir?");
        double valor = double.Parse(Console.ReadLine());
        resultado = dividirValor(valor);
        return resultado;
    }
    else if (operacao == 5)
    {
        Console.WriteLine("Você digitou 5 - Calculadora zerada");
        resultado = zerarResultado();
        return resultado;
    }
    else
    {
        Console.WriteLine("Você digitou um valor inválido. Por favor, tente novamente");
        return resultado;
    }
}