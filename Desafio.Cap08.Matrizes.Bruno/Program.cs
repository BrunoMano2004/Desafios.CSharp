int[,] matrizA = new int[3,3];
int[,] matrizB = new int[3,3];
int[,] matrizAB = new int[3,1];

Console.WriteLine("Este programa fará a multiplacação de duas matriz 3x3!\n");
Console.WriteLine("Digite os 9 valores da matriz A!\n");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine("Digite um valor:");
        matrizA[i,j] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
    }
}

Console.WriteLine("Agora digite os 9 valores da matriz B!\n");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine("Digite um valor:");
        matrizB[i, j] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
    }
}

//fiz a operação dessa forma manual pois a matriz era pequena
matrizAB[0, 0] = matrizA[0, 0] * matrizB[0, 0] + matrizA[0, 1] * matrizB[1, 0] + matrizA[0, 2] * matrizB[2, 0];
matrizAB[1, 0] = matrizA[1, 0] * matrizB[0, 1] + matrizA[1, 1] * matrizB[1, 1] + matrizA[1, 2] * matrizB[2, 1];
matrizAB[2, 0] = matrizA[2, 0] * matrizB[0, 2] + matrizA[2, 1] * matrizB[1, 2] + matrizA[2, 2] * matrizB[2, 2];

//escrevi dessa forma mais trabalhosa para ficar melhor visualmente
Console.WriteLine("A multiplicação da Matriz A:\n");
Console.WriteLine(matrizA[0,0] + ", " + matrizA[0,1] + ", " + matrizA[0,2] + "\n" +
                  matrizA[1,0] + ", " + matrizA[1,1] + ", " + matrizA[1,2] + "\n" +
                  matrizA[2,0] + ", " + matrizA[2,1] + ", " + matrizA[2,2] + "\n");

Console.WriteLine("Com a Matriz B:\n");
Console.WriteLine(matrizB[0, 0] + ", " + matrizB[0, 1] + ", " + matrizB[0, 2] + "\n" +
                  matrizB[1, 0] + ", " + matrizB[1, 1] + ", " + matrizB[1, 2] + "\n" +
                  matrizB[2, 0] + ", " + matrizB[2, 1] + ", " + matrizB[2, 2] + "\n");

Console.WriteLine("Resulta na Matriz AB:\n");
Console.WriteLine(matrizAB[0,0] + "\n" + matrizAB[1,0] + "\n" + matrizAB[2,0]);