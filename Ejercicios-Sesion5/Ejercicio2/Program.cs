/*
 Ejercicio 2 - Switch

Haz una lista de lenguajes de programación, por ejemplo: C#, Java, C++. Presenta la lista en consola y pide que el usuario seleccione el lenguaje mediante 1, 2, 3 o a, b, c. Presenta el resultado en consola.

Nota: puedes añadir al resultado el “Hola, mundo” para el caso de C#.
 */
string[] lenguajes = { "C#", "Java", "C++" };
Console.WriteLine("Seleccione un numero\n1-\n2-\n3-",Environment.NewLine);
Console.WriteLine();
string opcion=Console.ReadLine();
Console.WriteLine();
switch (opcion)
{
    case "1":
        Console.WriteLine("Su lenguaje es {0}", lenguajes[0]+Environment.NewLine);
        Console.WriteLine("Hola Mundo");
            break;
    case "2":
        Console.WriteLine("Su lenguaje es {1}", lenguajes[1]);
        break;
    case "3":
        Console.WriteLine("Su lenguaje es {2}", lenguajes[2]);
        break;
    default:
        break;
}