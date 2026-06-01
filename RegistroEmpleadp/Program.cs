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
    Console.ReadKey();
    Console.ResetColor();

}
void mostrardatos(int pos)
    { 
    Console.WriteLine("mostrar  registrados");
    
    for (int i = 0; i < pos; i++)
    {
        Console.WriteLine($"nombre: {empleados[i].nombre}\n Apellido: {empleados[i].apellido} \nCargo: {empleados[i].cargo} \n salario: {empleados[i].salario}");


    }
    Console.ReadKey();
}
int menu()
{
    Console.ForegroundColor= ConsoleColor.Green;
    Console.Write("1. agregar \n2. mostrar \n3. guardar \n4 salir  \n. digite  su opcion");
    int op = int.Parse(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.Blue;
    return op;
    Console.ResetColor();
}
void guardarempleados (int pos )

{
    StreamWriter archivo = new StreamWriter(" C:\\programacion \\empleados.csv ");
    for (int i=0; i < pos; i++)

    {
        archivo.WriteLine($"{empleados[i].nombre}; { empleados[i].apellido};{ empleados[i].cargo};{ empleados[i].salario}");
        archivo.Close();
        Console.ReadKey();
    }
        

    

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
            case 2:
                mostrardatos(i);
                break;
                default: 
                Console.WriteLine("opcion no valida...");
                break;
                case 3:
                guardarempleados(i);
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


