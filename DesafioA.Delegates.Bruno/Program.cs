using DesafioA.Delegates.Bruno;

Circulo circulo = new Circulo();
Retangulo retangulo = new Retangulo();

Circulo.Perimetro perimetroCirculo = new Circulo.Perimetro(circulo.CalculoPerimetro);
Retangulo.Perimetro perimetroRetangulo = new Retangulo.Perimetro(retangulo.CalculoPerimetro);

perimetroCirculo(4);
perimetroRetangulo(8, 10);
