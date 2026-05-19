Console.WriteLine("Hello, World!");

int a;

int b;

a = 10;
b = a;

Console.WriteLine("Valor de a:" + a);

Console.WriteLine("Valor de b:" + b);


Console.WriteLine("Ingrese un numero:");

string texto = Console.ReadLine();

int numero;

if(int.TryParse(texto, out numero))
{
    if(numero > 0)
    {
        int invertido = 0;

        while(numero > 0)
        {
            int digito = numero % 10;
            invertido = invertido * 10 + digito;
            numero = numero / 10;
        }

        Console.WriteLine("Numero invertido:" + invertido);
    }else
    {
        Console.WriteLine("El numero debe ser mayor a 0.");
    }
}else
    {
        Console.WriteLine("Lo ingresado no es un numero válido.");
    }