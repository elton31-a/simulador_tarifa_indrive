public class SimuladorTarifa
{
    public static void Main(string[] args)
    {
        Console.WriteLine("-------------------");
        Console.WriteLine("Indrive simulador de Tarifa");
        Console.WriteLine("-------------------");
        //INGRESO DE DATOS
        //Nombre
        Console.WriteLine("Ingrese Nombre del Pasajero:");
        string nombre = Console.ReadLine();
        //Distancia
        Console.WriteLine("Ingrese la distancia del viaje en (km): ");
        double distancia = Convert.ToDouble(Console.ReadLine());
        //Hora
        Console.WriteLine("Ingrese hora salida (0 hrs - 23 hrs):");
        int hora = int.Parse(Console.ReadLine());
        //Tipo de vehículo
        Console.WriteLine("\nIngrese el tipo de vehículo :");
        Console.WriteLine("1. Economico");
        Console.WriteLine("2. Comfort");
        Console.WriteLine("3. Premium");
        Console.WriteLine("4. Moto");
        int tipoVehiculo = int.Parse(Console.ReadLine());
    }
}