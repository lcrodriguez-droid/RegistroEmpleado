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
int menu()
{
    Console.Write("1. agregar \n2. mostrar \n3. eliminar \n4 salir  \n. digite  su opcion");
    int op = int.Parse(Console.ReadLine());
    return op;
}
int main()
{
    int op = 0, i = 0;
    do
    {
        Console.WriteLine($"registro  # {i + 1}");

        op = menu();
        switch (op)
        {
            case 1:
                agregarempleado(i++);

                break;
        }


    } while (op != 4);
        
    
    return 0;
}

main();



struct Empleado
{
    public string nombre;
    public string apellido;
    public string cargo;
    public double salario;

}