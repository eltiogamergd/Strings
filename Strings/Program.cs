// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Los strings SIEMPRE van en comillas

Console.WriteLine("Ricardo Perez ID!");
int altura = 168;
int edad = 89;
string nombre = "Ricardo Perez";
string informacion = "Nació en Hidalgo, es estudiante de gastronomía y astronomía";
var hobby = "deportista";


string tarjetadeidentificacion = $"La información de {nombre} es la siguiente, \n Su edad es {edad} años \n " +
    $"su altura es {altura} cm \n Información relevante {informacion} \n Su hobby es {hobby}";

Console.WriteLine(tarjetadeidentificacion);