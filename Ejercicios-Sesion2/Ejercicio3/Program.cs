/*
 Ejercicio 3

Operadores Determina los operadores para verificar las siguientes condiciones:

Un número es mayor o igual a 18

Un char es ‘a’

Se cumplen dos conciones a la vez (ambas verdaderas)

Se cumple una de dos condiciones a la vez (una true y otra false)

Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es almacenar los datos en los tipos más adecuados.
 */
Console.WriteLine("Ingrese numero");
int numero = Convert.ToInt32(Console.ReadLine());
if (numero >= 18)
{
    Console.WriteLine("El numero ingresado es mayor o igual a 18");
}
else
{
    Console.WriteLine("El numero ingresado es menos a 18");
}
Console.ReadKey();
Console.Clear();
Console.WriteLine("Ingrese caracter");
char caracter=Convert.ToChar(Console.ReadLine());
if(caracter == 'a')
{
    Console.WriteLine("Su caracter ingresado es 'a'");
}
else
{
    Console.WriteLine("Ingreso el caracter {0}",caracter);
}