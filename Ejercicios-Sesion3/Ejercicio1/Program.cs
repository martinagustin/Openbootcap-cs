/*
 Crea una estructura de datos para un cliente con estos campos:

Nombre completo

Teléfono

Dirección

Email

Si es nuevo cliente

Bonus: escribe un método para presentar estos datos desde la estructura al hacer Console.WriteLine(...)
 */
Cliente cliente1 = new Cliente("Hugo Boss","3487347519","Guemes 2050","mag@live.com",true);
Console.WriteLine(cliente1.ToString());
public struct Cliente
{
    //metodo
    public Cliente(string nombre, string telefono, string address, string email,bool cliente )
    {
        this.nombre = nombre;
        this.telefono = telefono;
        this.direccion = address;
        this.mail = email;
        this.ifCliente = cliente;
        Console.WriteLine("---Cliente---"+Environment.NewLine);
        Console.WriteLine($"Nombre:{nombre}\nTelefono:{telefono}\nDireccion:{direccion}\nEmail:{mail}\nCliente:{ifCliente}");
    }
    //atributos
    public string nombre { get; set; }
    public string telefono { get; set; }
    public string direccion { get; set; }
    public string mail { get; set; }
    public bool ifCliente { get; set; }
}