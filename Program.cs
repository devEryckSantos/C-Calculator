
Divisao();

static void Soma()
{
    Console.Clear();
    Console.WriteLine("Digite o primeiro valor: ");
    double v1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor: ");
    double v2 = double.Parse(Console.ReadLine());

    double result = v1 + v2;
    Console.WriteLine($"{v1} + {v2} = {result}");

}

static void Subtracao()
{
    Console.Clear();
    Console.WriteLine("Digite o primeiro valor: ");
    double v1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor: ");
    double v2 = double.Parse(Console.ReadLine());

    double result = v1 - v2;
    Console.WriteLine($"{v1} - {v2} = {result}");
}

static void Multiplicacao()
{
    Console.Clear();
    Console.WriteLine("Digite o primeiro valor: ");
    double v1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor: ");
    double v2 = double.Parse(Console.ReadLine());

    double result = v1 * v2;
    Console.WriteLine($"{v1} x {v2} = {result}");
}

static void Divisao()
{
    Console.Clear();
    Console.WriteLine("Digite o primeiro valor: ");
    double v1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor: ");
    double v2 = double.Parse(Console.ReadLine());

    double result = v1 / v2;
    Console.WriteLine($"{v1} ÷ {v2} = {result}");
}