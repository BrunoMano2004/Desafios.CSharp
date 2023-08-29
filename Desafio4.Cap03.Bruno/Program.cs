Colecao livro = new Colecao();

Console.WriteLine("Este programa armazenará e exibirá os dados de seus livros!");
livro.RegistrarLivro();
int i = 0;
string resp;

do
{
    Console.WriteLine("\nDeseja registrar um novo livro? Y/N");
    resp = Console.ReadLine();
    if (resp == "Y")
    {
        livro.RegistrarLivro();
    } else if (resp == "N")
    {
        i++;
    } else
    {
        Console.Write("[ERRO] Digite um valor válido!");
    }
} while (i == 0);

struct Colecao
{
    public string Titulo;
    public string Autor;
    public string Genero;
    public string Registro;

    public void RegistrarLivro()
    {
        Console.WriteLine("Digite o título do livro: ");
        this.Titulo = Console.ReadLine();

        Console.WriteLine("Digite o autor do livro: ");
        this.Autor = Console.ReadLine();

        Console.WriteLine("Digite o gênero do livro: ");
        this.Genero = Console.ReadLine();

        Console.WriteLine("Digite o nº de registo do livro: ");
        this.Registro = Console.ReadLine();

        Console.WriteLine(new string('-', 50));

        Console.WriteLine("LIVRO REGISTRADO!!");
        Console.WriteLine("\nTítulo: " + this.Titulo);
        Console.WriteLine("Autor: " + this.Autor);
        Console.WriteLine("Gênero: " + this.Genero);
        Console.WriteLine("Nº de registro: " + this.Registro);
    }
}