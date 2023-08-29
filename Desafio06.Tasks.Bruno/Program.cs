async Task<DateTime> ExibirData()
{
    DateTime data = DateTime.Now;
    return data;
}

var resultado = ExibirData().Result;
Console.WriteLine(resultado);