Empleado[] empleados = new Empleado[10];

    void agregarempleado(int pos)
{ 
    console.writeline("nombres")
empleados[pos].nombre = console.readline();
    Console.WriteLine("apellidos");
    empleados[pos].apellido = console.readline();
    Console.WriteLine("cargos");
    empleados[pos].cargo = console.readline();
    Console.WriteLine("salarios");
    empleados[pos].salario = double.Parse(console.readline());
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