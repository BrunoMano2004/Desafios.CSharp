Console.WriteLine("Este programa montará uma senha!");
Console.WriteLine("Por favor, escolha quantos dígitos terá a sua senha entre 4 - 10 dígitos! Lembrando que o número de dígitos deve ser par!!");
int digitos = Convert.ToInt32(Console.ReadLine());
string senha = "";

if (digitos % 2 == 0 && digitos >= 4 && digitos <= 10) {
    for (int i = 1; i <= digitos; i++)
    {
        int rnd = new Random().Next(0, 9);
        string inter = Convert.ToString(rnd);
        senha += inter;
    }
    Console.WriteLine(senha);
} else {
    Console.WriteLine("Digite um número dentro das especificações!!");
}
Console.ReadKey();