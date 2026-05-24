Console.WriteLine("Ingrese un numero: ");

string texto = Console.ReadLine();

double numero;

if (double.TryParse(texto, out numero))
{
    Console.WriteLine("Valor absoluto: " + Math.Abs(numero));

    Console.WriteLine("Cuadrado: " + Math.Pow(numero, 2));

    if(numero >= 0)
    {
        Console.WriteLine("Raiz cuadrada: " + Math.Sqrt(numero));
    }else
    {
        Console.WriteLine("No se puede calcular la raiz de un numero negativo.");
    }

    Console.WriteLine("Seno: " + Math.Sin(numero));

    Console.WriteLine("Coseno: " + Math.Cos(numero));

    Console.WriteLine("Parte entera: " + Math.Truncate(numero));
}
else
{
    Console.WriteLine("Debe ingresar un numero valido.");
}

Console.WriteLine("Ingrese el primer numero: ");
string texto1 = Console.ReadLine();

Console.WriteLine("Ingrese el segundo numero");

string texto2 = Console.ReadLine();

double num1;
double num2;

if((double.TryParse(texto, out num1)) && (double.TryParse(texto2, out num2)))
{
    Console.WriteLine("Maximo: " + Math.Max(num1, num2));

    Console.WriteLine("Minimo: " + Math.Min(num1, num2));
}else
{
    Console.WriteLine("Debe ingresar un numero valido.");
}
