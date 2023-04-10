/*
 Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:

Coche: puertas, ruedas, marca, ITV vigente

Mesa: peso, largo, material, color

Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es almacenar los datos en los tipos más adecuados.
 */
Console.WriteLine("Ingrese datos del coche: ");
Console.WriteLine("Cantidad de puertas: ");
int puertas=Convert.ToInt32( Console.ReadLine());
Console.WriteLine("Cantidad de ruedas: ");
int ruedas= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Indique la marca: ");
string Marca= Console.ReadLine();
Console.WriteLine("ITV vigente?");
string itv=Console.ReadLine();
Console.Clear();

Console.WriteLine("---Vehiculo---");
Console.WriteLine($"Puertas:{puertas}\nRuedas:{ruedas}\nMarca:{Marca}\nITV:{itv}");

Console.Clear();
//Mesa
Console.WriteLine("Peso: ");
double peso=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Largo: ");
double largo=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Material: ");
string material=Console.ReadLine();
Console.WriteLine("Color");
string color=Console.ReadLine();
Console.Clear();

Console.WriteLine("---Mesa---");
Console.WriteLine($"Peso:{peso}Kg\nLargo:{largo}Com\nMaterial:{material}\ncolor:{color}");
