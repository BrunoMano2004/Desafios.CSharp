Console.WriteLine("Este programa irá sortear um número de 0 a 100, e o seu objetivo é tentar adivinhar!");
int num = new Random().Next(0, 100);  
Console.WriteLine("Número sorteado!!"); 
int i, min, max, tent;
i = 0;
max = 100;
min = 0;
tent = 0;

do {
    Console.WriteLine("Digite um número entre " + min + " e " + max);
    int resp = Convert.ToInt32(Console.ReadLine());
    tent++;
    if (resp >= min && resp <= max) {
        if (resp < num) {
            min = resp;
        }
        else if (resp > num) {
            max = resp;
        }
        else {
            Console.WriteLine("Parabéns!! Você acertou o número!!");
            i++;
        }
    } else {
        Console.WriteLine("[ERRO] Digite um valor entre " + min + " e " + max + " por favor");
    }
} while (i == 0);