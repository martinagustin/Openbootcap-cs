/*
 Variables Escribe un programa que reciba datos de una persona y genera un mensaje,
usa una variable para cada dato y otra para el mensaje. Ej: nombre, apellido, edad, sabe programar, etc.
 */
string Nombre, Apellido, sabeProgramar, Mensaje;
int edad;
Console.WriteLine("Ingrese Nombre: ");
Nombre=Console.ReadLine();
Console.WriteLine("Ingrese apellido: ");
Apellido=Console.ReadLine();
Console.WriteLine("ingrese edad: ");
edad=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sabe programar? ");
sabeProgramar=Console.ReadLine();

//creamos el mensaje
Console.WriteLine("Bienvenid@" + Environment.NewLine+"Nombre: {0} \nApellido: {1} \nEdad: {2} \nSabe Programar: {3}\n",Nombre,Apellido,edad,sabeProgramar);