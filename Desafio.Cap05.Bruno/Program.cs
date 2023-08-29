using Desafio.Cap05.Bruno; 

Cursos treinamento1 = new Cursos();

treinamento1.SetTreinamento("Treinamento C#", 1);
Console.WriteLine(treinamento1.GetTreinamento() + "\n");

Console.WriteLine("\n" + new string('-', 50) + "\n");

Cursos treinamento2 = new Cursos();

treinamento2.SetTreinamento("Treinamento Java", 2);
Console.WriteLine(treinamento2.GetTreinamento() + "\n");

Console.WriteLine("\n" + new string('-', 50) + "\n");

Cursos treinamento3 = new Cursos();

treinamento3.SetTreinamento("Treinamento JavaScript", 3);
Console.WriteLine(treinamento3.GetTreinamento() + "\n");