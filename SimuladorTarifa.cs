public class SimuladorTarifa
{
    public static void Main(string[] args)
    {
        Console.WriteLine("-------------------");
        Console.WriteLine("Indrive simulador de Tarifa");
        Console.WriteLine("-------------------");
        //Declaracion de variables
        string nombre, nombreVehiculo;
        double distancia,tarifaBase,costoKm,subtotal,descuento,tarifaFinal;
        int hora, tipoVehiculo;
        bool esHoraPico;
        //INGRESO DE DATOS
        //Nombre
        Console.WriteLine("Ingrese Nombre del Pasajero:");
         nombre = Console.ReadLine();
        //Distancia
        Console.WriteLine("Ingrese la distancia del viaje en (km): ");
         distancia = Convert.ToDouble(Console.ReadLine());
        //Hora
        Console.WriteLine("Ingrese hora salida (0 hrs - 23 hrs):");
         hora = int.Parse(Console.ReadLine());
        //Tipo de vehículo
        Console.WriteLine("\nIngrese el tipo de vehículo :");
        Console.WriteLine("1. Economico");
        Console.WriteLine("2. Comfort");
        Console.WriteLine("3. Premium");
        Console.WriteLine("4. Moto");
         tipoVehiculo = int.Parse(Console.ReadLine());

         //PROCESO
        switch (tipoVehiculo)
        {
            case 1:
                nombreVehiculo = "Economico";
                tarifaBase = 2.0;
                costoKm = 1.5;
                break;
            case 2:
                nombreVehiculo = "Comfort";
                tarifaBase = 3.0;
                costoKm = 2.0;
                break;
            case 3:
                nombreVehiculo = "Premium";
                tarifaBase = 5.0;
                costoKm = 3.0;
                break;
            case 4:
                nombreVehiculo = "Moto";
                tarifaBase = 1.50;
                costoKm = 1;
                break;
            default:
                Console.WriteLine("\nTipo de vehículo no válido. Fin Program.");
                return;
        }
        //Calculo subtotal base
        subtotal = tarifaBase + (distancia * costoKm);

        // Condicional hora pico
        if (hora >= 7 && hora <= 9 || hora >= 17 && hora <= 20)
        {
            esHoraPico = true;
            subtotal = subtotal * 1.30; // Aumenta un 30% en hora pico
        }
        else
        {
            esHoraPico = false;
        }
        //Descuento por distancia larga
        if (distancia > 15)
        {
            descuento = subtotal * 0.05;
            subtotal = subtotal - descuento;
        }
        // Tarifa minima y redondeo
        tarifaFinal = Math.Max(subtotal, 5.00); // Tarifa mínima de S/. 5.00
        tarifaFinal = Math.Round(tarifaFinal, 2); // Redondeo a 2 decimales

        //SALIDA DE RESULTADOS
        Console.WriteLine("\n===============================================");
        Console.WriteLine("         RESUMEN DEL VIAJE");
        Console.WriteLine("=================================================");
        Console.WriteLine("Pasajero: " + nombre);
        Console.WriteLine("Vehículo: " + nombreVehiculo);
        Console.WriteLine("Distancia: " + distancia + " km");
        Console.WriteLine("Hora Pico: " + (esHoraPico?"Sí (+30%)":"No")); // inline if -> condicional?es verdad: es falso; 
        if(descuento > 0){
            Console.WriteLine("Descuento: S/ " + Math.Round(descuento, 2));
        }else{
            Console.WriteLine("Descuento: No Aplica");
        }
        Console.WriteLine("===============================================");
        Console.WriteLine("TARIFA FINAL: S/ " + tarifaFinal);
        Console.WriteLine("===============================================");
    }
}