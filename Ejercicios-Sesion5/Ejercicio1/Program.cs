/*
 * Ejercicio 1 - If
 Escribe un programa que:

Pida datos a un cliente: Nombre, email, cupón

Determine si un cliente tiene un cupon descuento

Muestre un precio rebajado en función del descuento

Muestre el precio de un producto sin descuento si no hay cupón

Nota: puedes poner un precio fijo de un producto o uno variable.
 */
Console.WriteLine("Ingrese Nombre:");
string nombre = Console.ReadLine();
Console.WriteLine("Ingrese email");
string email = Console.ReadLine();
Console.WriteLine("tiene cupon?\ningreselo");
double cupon = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("El cupon ingresado es de {0}",cupon+"%");
double producto;
double fideos = 12;
Console.WriteLine("Precio original: {0}",fideos+"$");
if (cupon != null)
{
    producto=fideos*(1-(cupon/100));
    Console.WriteLine("Precio con cupon: {0}",producto+"$");
}