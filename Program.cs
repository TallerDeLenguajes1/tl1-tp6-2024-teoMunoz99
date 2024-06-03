// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//int a;
//int b;
//a = 10;
//b = a;
//Console.WriteLine("valor de a:" + a);
//Console.WriteLine("valor de b:" + b);

//Ejercicio 1 
/*Este ejercicio pide el ingreso de un numero, que validemos si es un numero y que encontremos su invertido
para verificar que es un numero, usamos tryParse, es un metodo que transforma un string a int, devuelve un booleano 
para saber si se transformo o no*/

/*
string numIngresado;//en esta variable guardo lo ingresado por el usuario, sea texto o numeros
int numero = 0;//acá guardo lo ingresado pero transformado si o si a int

//este bucle pide el ingreso de un numero, y se repite si no fue posible pasarlo a int
do
{
    Console.WriteLine("Ingrese un numero: ");
    numIngresado = Console.ReadLine();

} while (!int.TryParse(numIngresado, out numero) || numero <= 0);

//invierto el numero
string numeroInvertido = new string(numero.ToString().Reverse().ToArray());


Console.WriteLine($"Ingresado: {numero}");
Console.WriteLine($"Invertido: {numeroInvertido}");
*/

/*Ejercicio 2. Ingrese al branch CalculadoraV1 y construya un programa que sea una
calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar,
Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y que luego
pida dos números y que devuelva el resultado de la operación seleccionada. Además
una vez que termine de realizar la operación le pregunte si desea realizar otro cálculo.*/



/*Ejercicio 3. Ingrese al Branch CalculadoraV2 para implementar las mejoras en la
calculadora.. Solicite al usuario un número y muestre por pantalla:
● El valor absoluto de un número
● El cuadrado
● La raíz cuadrada
● El seno
● El Coseno
● La parte entera de un tipo float.

Luego de esto, solicite dos números al usuario y determine:
● El Máximo entre los dos números
● El Mínimo entre los dos números
Para TODOS los casos, no olvide contemplar siempre el caso de que el usuario no
ingrese un número válido.
Suba al repositorio github ambas ramas.
Combine el código del branch CalculadoraV2 en el branch de CalculadoraV1 y
resuelva los conflictos surgidos.
*/

        static void Menu()
        {
            Console.WriteLine("1- Sumar");
            Console.WriteLine("2- Restar");
            Console.WriteLine("3- Multiplicar");
            Console.WriteLine("4- Dividir");
            Console.WriteLine("5- Valor Absoluto");
            Console.WriteLine("6- Cuadrado");
            Console.WriteLine("7- Seno");
            Console.WriteLine("8- Coseno");
            Console.WriteLine("9- La parte entera de un tipo float");
            Console.WriteLine("10- El Máximo entre los dos números");
            Console.WriteLine("11- El Mínimo entre los dos números");
        }

        int opcion;
        float num1 = 0, num2 = 0;
        bool numerosIngresados = false;

        do
        {
            Console.WriteLine("Elija una operacion del menu:");
            Console.WriteLine("");
            Menu();

            string opcionIngresada = Console.ReadLine();
            if (int.TryParse(opcionIngresada, out opcion) && opcion >= 1 && opcion <= 11)
            {
                if (!numerosIngresados)
                {
                    Console.WriteLine("Ingrese el primer número: ");
                    string numIngresado1 = Console.ReadLine();
                    Console.WriteLine("Ingrese el segundo número: ");
                    string numIngresado2 = Console.ReadLine();

                    if (!float.TryParse(numIngresado1, out num1) || !float.TryParse(numIngresado2, out num2))
                    {
                        Console.WriteLine("Números ingresados no son válidos.");
                        continue;
                    }
                    numerosIngresados = true;
                }

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($">>SUMA<< Resultado = {num1 + num2}");
                        break;
                    case 2:
                        Console.WriteLine($">>RESTA<< Resultado = {num1 - num2}");
                        break;
                    case 3:
                        Console.WriteLine($">>MULTIPLICACION<< Resultado = {num1 * num2}");
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            Console.WriteLine($">>DIVISION<< Resultado = {num1 / num2}");
                        }
                        else
                        {
                            Console.WriteLine("No se puede dividir entre 0.");
                        }
                        break;
                    case 5:
                        Console.WriteLine($">>VALOR ABSOLUTO<< Resultado = {Math.Abs(num1)}");
                        break;
                    case 6:
                        Console.WriteLine($">>CUADRADO<< Resultado = {num1 * num1}");
                        break;
                    case 7:
                        Console.WriteLine($">>SENO<< Resultado = {Math.Sin(num1)}");
                        break;
                    case 8:
                        Console.WriteLine($">>COSENO<< Resultado = {Math.Cos(num1)}");
                        break;
                    case 9:
                        Console.WriteLine($">>PARTE ENTERA<< Resultado = {Math.Truncate(num1)}");
                        break;
                    case 10:
                        Console.WriteLine($">>MÁXIMO<< Resultado = {Math.Max(num1, num2)}");
                        break;
                    case 11:
                        Console.WriteLine($">>MÍNIMO<< Resultado = {Math.Min(num1, num2)}");
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opción ingresada no es válida.");
            }

            Console.WriteLine("¿Desea realizar otra operación? 0-SI / 1-NO");
            string continuar = Console.ReadLine();
            if (!int.TryParse(continuar, out opcion) || opcion != 0)
            {
                opcion = 1;
            }else{
                numerosIngresados = false;
            }
        } while (opcion == 0);

        