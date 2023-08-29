Console.WriteLine("Este programa calculará o preço da entrada para o clube Santa Mônica!");
Console.WriteLine("Informe o nome e a idade para calcularmos o preço!");
Console.WriteLine("Nome: ");
string nome = Console.ReadLine();
Console.WriteLine("Idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

if (idade <= 17) {
    Console.WriteLine("O valor da entrada de " + nome + " será de R$30,00");
} else if (idade > 17 && idade <= 59) {
    Console.WriteLine("O valor da entrada de " + nome + " será de R$40,00");
} else if (idade > 59) {
    Console.WriteLine("O valor da entrada de " + nome + " será de R$20,00");
}

