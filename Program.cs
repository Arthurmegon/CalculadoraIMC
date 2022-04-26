Individuo i1 = new Individuo();

Console.WriteLine("Calculadora IMC");

Console.WriteLine("Informe seu nome:");
i1.Nome = Console.ReadLine();

Console.WriteLine("Informe sua altura:");
i1.Altura = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Informe seu peso:");
i1.Peso = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("\nNome: {0}", i1.Nome);
Console.WriteLine("Altura: {0}", i1.Altura);
Console.WriteLine("Peso: {0}", i1.Peso);

Console.WriteLine("\nClassificação do IMC: {0}", i1.Classificacao);

if(i1.IMC < 18.5)
{
    Console.WriteLine("\nPara chegar ao peso ideal, você deve ganhar {0} kg", i1.GanharPeso());
}

if(i1.IMC > 24.9)
{
    Console.WriteLine("\nPara chegar ao peso ideal, você deve perder {0} kg", i1.PerderPeso());
}

Console.WriteLine("Calculadora IMC");

Console.WriteLine("Informe seu nome:");
i1.Nome = Console.ReadLine();

Console.WriteLine("Informe sua altura:");
i1.Altura = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Informe seu peso:");
i1.Peso = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("\nNome: {0}", i1.Nome);
Console.WriteLine("Altura: {0}", i1.Altura);
Console.WriteLine("Peso: {0}", i1.Peso);

Console.WriteLine("\nClassificação do IMC: {0}", i1.Classificacao);

if(i1.IMC < 18.5)
{
    Console.WriteLine("\nPara chegar ao peso ideal, você deve ganhar {0} kg", i1.GanharPeso());
}

if(i1.IMC > 24.9)
{
    Console.WriteLine("\nPara chegar ao peso ideal, você deve perder {0} kg", i1.PerderPeso());
}
