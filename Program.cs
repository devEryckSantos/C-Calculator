
Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("          C# Calculator");
    Console.WriteLine("==================================");
    Console.WriteLine("Escolha uma operação:");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Sair");
    Console.WriteLine("==================================");
    short op = short.Parse(Console.ReadLine());
}

static void Soma()
{
    Console.Clear();
    Console.WriteLine("Digite o primeiro valor: ");
    double v1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor: ");
    double v2 = double.Parse(Console.ReadLine());

    double result = v1 + v2;
    Console.WriteLine($"{v1} + {v2} = {result}");
    Console.ReadLine();

    Menu();

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
    Console.ReadLine();

    Menu();
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
    Console.ReadLine();

    Menu();    
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
    Console.ReadLine();

    Menu();
}