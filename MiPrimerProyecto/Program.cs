//VARIABLES
/*
Console.WriteLine("Hello, World!");


bool esRojo;
bool esGuitarra;

esRojo = false; 
esGuitarra = false;

int Edad = 12;
int edadPromedio = 18;

float peso = 45.7f;

double temp = 651.87825;


char letra = 'A';
char letra2 = 'B';

string palabra = "Buenas noches";

Console.WriteLine(esRojo);
Console.WriteLine(esGuitarra);
Console.WriteLine(Edad);
Console.WriteLine(edadPromedio);
Console.WriteLine(peso);
Console.WriteLine(temp);
Console.WriteLine(letra);
Console.WriteLine(letra2);
Console.WriteLine(palabra);
*/

//IMPRESION Y ENTRADA DE DATOS
/*
Console.WriteLine("Bienvenido");
Console.Write("Ingresa Tu Nombre: ");
string name = Console.ReadLine();

Console.Write("Ingrese su edad: ");
int edad = Int32.Parse(Console.ReadLine());

Console.Write("Ingrese su Peso: ");
float peso = float.Parse(Console.ReadLine());

Console.Write("Ingrese su Temperatura: ");
double temp = double.Parse(Console.ReadLine());


Console.WriteLine("Hola " + name + 
    ", Tu edad es: " + edad + 
    ", Tu peso es: " + peso + 
    ", Su temperatura es ... " + temp);
*/

//VAR
/*
var x = 21;
var y = "Variable String";
var z = 45.98;
var w = true;
*/

//OPERACIONES MATEMATICAS
Console.Write("Ingrese su primer Numero :");
int a = Int32.Parse(Console.ReadLine());

Console.Write("Ingrese su segundo Numero :");
int b = Int32.Parse(Console.ReadLine());

//SUMA
int suma = a + b;
//RESTA
int resta = a - b;
//MULTIPLICACION 
int multiplicacion = a * b;
//DIVISION
float division = a / b;
//MODULO
int modulo = a % b;


Console.WriteLine("La Suma es: " + suma);
Console.WriteLine("La Resta es: " + resta);
Console.WriteLine("La Multiplicacion es: " + multiplicacion);
Console.WriteLine("La Divicion es: " + division);
Console.WriteLine("La Modulo es: " + modulo);