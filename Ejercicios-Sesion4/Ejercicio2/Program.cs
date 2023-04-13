/*
 Ejercicio 2 - Do while

Escribe un programa que realice estos pasos:

Reciba al menos un número por consola

Determine si el número es positivo o negativo

Presente un contador para cada tipo (positivo y negativo).

Nota: el cero se puede abordar en una clase adicional ya que no es ni positivo ni negativo. Tienes completa libertad para elegir el formato de la salida.
 */
int numeroPositivo=0 ;
int numeroNegativo=0;
int numeroNeutro=0;
int opcion;
int i=0 ;
do
{
    Console.WriteLine("Ingrese nuemro:");
    opcion = Convert.ToInt32(Console.ReadLine());
    i++;
    if (opcion > 0)
    {
        numeroPositivo++;
    }
    if (opcion == 0)
    {
        numeroNeutro++;
    }
    else
    {
        numeroNegativo++;
    }
}
while (i<5);
Console.WriteLine("Fin de bucle");
Console.WriteLine($"numero neutros:{numeroNeutro}\nnumeros positivos:{numeroPositivo}\nnumero negativo:{numeroNegativo}");

