using Desafio.Cap06.Bruno;

Livro livro1 = new Livro()
{
    DadosLivro = new Romance()
    {
        Titulo = "A Cinco Passos de Você",
        Registro = "384219",
        NumeroPag = "200",
        Autor = "João Pereira",
        Editora = "Brasil"
    }
};

Livro livro2 = new Livro()
{
    DadosLivro = new Acao()
    {
        Titulo = "Avengers",
        Registro = "8840157",
        NumeroPag = "400",
        Autor = "Rafaela Silva",
        Editora = "Studio Arte"
    }
};

Livro livro3 = new Livro()
{
    DadosLivro = new Terror()
    {
        Titulo = "A casa Assombrada",
        Registro = "936184",
        NumeroPag = "350",
        Autor = "Fernando Gonzaga",
        Editora = "Studio Arte"
    }
};

Livro livro4 = new Livro()
{
    DadosLivro = new Biografia()
    {
        Titulo = "Steve Jobs",
        Registro = "163841",
        NumeroPag = "500",
        Autor = "Gabriela Domingues",
        Editora = "Brasil"
    }
};

Console.WriteLine(livro1.Mostrar());
Console.WriteLine("\n" + new string('-', 50) + "\n");
Console.WriteLine(livro2.Mostrar());
Console.WriteLine("\n" + new string('-', 50) + "\n");
Console.WriteLine(livro3.Mostrar());
Console.WriteLine("\n" + new string('-', 50) + "\n");
Console.WriteLine(livro4.Mostrar());
