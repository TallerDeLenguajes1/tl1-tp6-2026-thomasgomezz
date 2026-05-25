using System.Data;

Console.WriteLine("Hello, World!");

int a;

int b;

a = 10;
b = a;

Console.WriteLine("Valor de a:" + a);

Console.WriteLine("Valor de b:" + b);

//ejercicio 1

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

    //Ejercicio 2

    bool continuar = true;

    while(continuar)
{
    Console.WriteLine("----CALCULADORA----");
    Console.WriteLine("1- Sumar"); 
    Console.WriteLine("2- Restar"); 
    Console.WriteLine("3- Multiplicar");    
    Console.WriteLine("4- Dividir"); 
    Console.WriteLine("Seleccione una opcion: ");

    string opcionTexto = Console.ReadLine(); 

    int opcion;

    if (int.TryParse(opcionTexto, out opcion))
    {
        if(opcion >= 1 && opcion <= 4)
        {
            Console.WriteLine("Ingrese el primer numero:");
            string texto1 = Console.ReadLine();

            Console.WriteLine("Ingrese el segundo numero: ");
            string texto2 = Console.ReadLine();

            double num1;
            double num2; 

            if(double.TryParse(texto1, out num1) && double.TryParse(texto2, out num2))
            {
                double resultado = 0;

                switch(opcion)
                {
                    case 1: 
                            resultado = num1 + num2;
                            Console.WriteLine("La suma de " + num1 + " y de " + num2 + " es igual a: " + resultado);
                            break;

                    case 2: 
                            resultado = num1 - num2;
                            //Console.WriteLine("Resultado: " + resultado);
                            Console.WriteLine("La resta de " + num1 + " y de " + num2 + " es igual a: " + resultado);
                            break;
                            
                    
                    case 3: 
                            resultado = num1 * num2;
                           // Console.WriteLine("Resultado :" + resultado);
                           Console.WriteLine("La multiplicacion de " + num1 + " y de " + num2 + " es igual a: " + resultado);
                            break;

                    case 4:
                            if(num2 != 0)
                            {
                                resultado = num1 / num2;
                                //Console.WriteLine("Resultado: " + resultado);
                                Console.WriteLine("La division de " + num1 + " y de " + num2 + " es igual a: " + resultado);
                                break;
                            }else
                                {
                                    Console.WriteLine("No se puede dividir por cero.");
                                }
                                break;
                }
            }
            else
            {
                Console.WriteLine("Debe ingresar numeros validos.");
            }
        }
        else
        {
            Console.WriteLine("Opcion invalida.");
        }

    }else
    {
        Console.WriteLine("Debe ingresar un numero de opcion.");
    }

    Console.WriteLine("Desea realizar otro calculo? (s/n)");

string respuesta = Console.ReadLine();

if (respuesta.ToLower() != "s")
{
    continuar = false;
}
}

//ejercicio 3

    Console.WriteLine("Ingrese un numero: ");

string textoDouble = Console.ReadLine();

double numeroDouble;

if (double.TryParse(textoDouble, out numeroDouble))
{
    Console.WriteLine("Valor absoluto: " + Math.Abs(numeroDouble));

    Console.WriteLine("Cuadrado: " + Math.Pow(numeroDouble, 2));

    if(numeroDouble >= 0)
    {
        Console.WriteLine("Raiz cuadrada: " + Math.Sqrt(numeroDouble));
    }else
    {
        Console.WriteLine("No se puede calcular la raiz de un numero negativo.");
    }

    Console.WriteLine("Seno: " + Math.Sin(numeroDouble));

    Console.WriteLine("Coseno: " + Math.Cos(numeroDouble));

    Console.WriteLine("Parte entera: " + Math.Truncate(numeroDouble));
}
else
{
    Console.WriteLine("Debe ingresar un numero valido.");
}

Console.WriteLine("Ingrese el primer numero: ");
string textoNum1 = Console.ReadLine();

Console.WriteLine("Ingrese el segundo numero");

string textoNum2 = Console.ReadLine();

double numero1;
double numero2;

if((double.TryParse(textoNum1, out numero1)) && (double.TryParse(textoNum2, out numero2)))
{
    Console.WriteLine("Maximo: " + Math.Max(numero1, numero2));

    Console.WriteLine("Minimo: " + Math.Min(numero1, numero2));
}else
{
    Console.WriteLine("Debe ingresar un numero valido.");
}


//Ejercicio 4

Console.WriteLine("Ingrese una cadena de texto: ");
string cadena = Console.ReadLine();

Console.WriteLine("Longitud de la cadena: " + cadena.Length);

//Concatenar

Console.WriteLine("Ingrese otra cadena: ");

string cadena2 = Console.ReadLine();

string concatenada = cadena + " " + cadena2;

Console.WriteLine("Cadena concatenada : " + concatenada);


//Subcadena

if(cadena.Length >= 3)
{
    string subcadena = cadena.Substring(0 , 3);
    Console.WriteLine("Subcadena: " + subcadena);
}

//Recorrer con foreach

Console.WriteLine("Recorriendo la cadena:");
foreach(char letra in cadena)
{
    Console.WriteLine(letra);
}

//Buscar palabra
Console.WriteLine("Ingrese una palabra para buscar: ");

string palabra = Console.ReadLine();

if(cadena.Contains(palabra))
{
    Console.WriteLine("La palabra existe en la cadena.");
}
else
{
    Console.WriteLine("La palabra no existe.");
}

//Convertir cadena a mayuscula y miniscula

Console.WriteLine("Cadena en Mayusculas: " + cadena.ToUpper());

Console.WriteLine("Cadena en Minusculas: " + cadena.ToLower());

//Split
Console.WriteLine("Ingrese palabras separadas por coma:");
string textoSplit = Console.ReadLine();

string [] partes = textoSplit.Split(',');

foreach(string parte in partes)
{
    Console.WriteLine(parte.Trim());
}

//Ecuacion simple

Console.WriteLine("Ingrese una ecuacion simple: ");
string ecuacion = Console.ReadLine();

if(ecuacion.Contains("+"))  //contains: verifica si la ecuacion tiene ()
{
    string [] numeros = ecuacion.Split('+');    //split: divide por partes donde esta()

    int num1 = int.Parse(numeros[0]);       //int.parse para convertir un texto a numero entero-- numero[0] = primer numero antes de +
    int num2 = int.Parse(numeros[1]);
    int resultado  =num1 + num2;

    Console.WriteLine("Resultado : " + resultado );
}