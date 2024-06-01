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
