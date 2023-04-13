/*
 Ejercicio 3 - For

Escribe un programa que realice estos pasos:

Reciba 3 datos:

ancho

alto

relleno o no

Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo de las dimensiones introducidas y use el tercer dato para discernir si el rectángulo está relleno (tiene más * dentro) o no.

En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introduce el ancho: ");
        int ancho = int.Parse(Console.ReadLine());

        Console.Write("Introduce el alto: ");
        int alto = int.Parse(Console.ReadLine());

        Console.Write("¿El rectángulo está relleno? (S/N): ");
        bool completo = Console.ReadLine().ToLower() == "s";
        int cantidad = Convert.ToInt32(Console.ReadLine());
        for (int f = 0; f < cantidad; f++) { 
        
            if (ancho == alto)
            {
                // Es un cuadrado
                for (int i = 0; i < alto; i++)
                {
                    for (int j = 0; j < ancho; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < alto; i++)
                {
                    for (int j = 0; j < ancho; j++)
                    {
                        if (completo || i == 0 || i == alto - 1 || j == 0 || j == ancho - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();

                }
            }
            Console.WriteLine();
        }
    }
}
