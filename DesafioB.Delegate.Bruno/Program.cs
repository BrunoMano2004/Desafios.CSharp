using DesafioB.Delegate.Bruno;

Soma.Somar soma = new Soma.Somar(Soma.Somando);
Subtracao.Subtrair subtracao = new Subtracao.Subtrair(Subtracao.Subtraindo);
Divisao.Dividir divisao = new Divisao.Dividir(Divisao.Dividindo);
Multiplicacao.Multiplicar multiplicacao = new Multiplicacao.Multiplicar(Multiplicacao.Multiplicando);

Console.WriteLine("Diga quais das seguintes operações você deseja realizar:\nSoma\nSubtração\nDivisão\nMultiplicação\n");
string resp = Console.ReadLine();

Console.WriteLine("Digite os dois valores: ");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());

switch (resp)
{
    case "Soma":
        soma(a, b);
        break;

    case "Subtração":
        subtracao(a, b);
        break;

    case "Divisão":
        divisao(a, b);
        break;

    case "Multiplicação":
        multiplicacao(a, b);
        break;
}