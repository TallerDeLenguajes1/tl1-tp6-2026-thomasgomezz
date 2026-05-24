
    //Ejercicio 2

    bool continuar = true;

    while(continuar)
{
    Console.WriteLine("----CALCULADORA----");
    Console.WriteLine("- Sumar"); 
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
                            Console.WriteLine("Resultado : " + resultado);
                            break;

                    case 2: 
                            resultado = num1 - num2;
                            Console.WriteLine("Resultado: " + resultado);
                            break;
                    
                    case 3: 
                            resultado = num1 * num2;
                            Console.WriteLine("Resultado :" + resultado);
                            break;

                    case 4:
                            if(num2 != 0)
                            {
                                resultado = num1 / num2;
                                Console.WriteLine("Resultado: " + resultado);
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

    Console.WriteLine("Desea realizar otro calculo? (s/n) :");
    
    string respuesta = Console.ReadLine();
    if (respuesta.ToLower() != "s")
    {
        continuar = false;
    }
}
