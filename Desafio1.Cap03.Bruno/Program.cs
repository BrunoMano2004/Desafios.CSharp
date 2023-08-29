using Desafio1.Cap03.Bruno;

Cubo medida = new Cubo();

Console.WriteLine("Este programa calculará o volume do cubo, por favor, informa a medida da aresta do cubo em cm: ");
medida.Aresta = Convert.ToInt32(Console.ReadLine());

medida.Res = medida.Aresta * medida.Aresta * medida.Aresta;
Convert.ToString(medida.Res);
Console.WriteLine("O volume do cubo é de: " + medida.Res + "cm³");