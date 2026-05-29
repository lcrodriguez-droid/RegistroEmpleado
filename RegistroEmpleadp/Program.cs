Empleado[] empleados = new Empleado[10];

    void agregarempleado(int pos)
{ 
    Console.WriteLine("nombres");
    empleados[pos].nombre = Console.ReadLine();
    Console.WriteLine("apellidos");
    empleados[pos].apellido = Console.ReadLine();
    Console.WriteLine("cargos");
    empleados[pos].cargo = Console.ReadLine();
    Console.WriteLine("salarios");
    empleados[pos].salario = double.Parse(Console.ReadLine ());
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("registro guardado sastisfactoriamente ");
    Console.ResetColor();
}




struct Empleado
{
    public string nombre;
    public string apellido;
    public string cargo;
    public double salario;

}