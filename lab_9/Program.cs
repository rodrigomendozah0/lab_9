using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{
    internal class Program
    {
        static float caja = 0.0f;
        static float vendidosLimpieza = 0.0f;
        static float vendidosAbarrotes = 0.0f;
        static float vendidosGolosinas = 0.0f;
        static float vendidosElectronicos = 0.0f;
        static float devueltosLimpieza = 0.0f;
        static float devueltosAbarrotes = 0.0f;
        static float devueltosGolosinas = 0.0f;
        static float devueltosElectronicos = 0.0f;
        static void Main(string[] args)
        {
            PantallaPrincipal();
            Console.ReadKey();
        }
        static void PantallaPrincipal()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Tienda de Don Lucas");
            Console.WriteLine("================================");
            Console.WriteLine("1: Registrar venta");
            Console.WriteLine("2: Registrar devolución");
            Console.WriteLine("3: Cerrar caja");
            Console.WriteLine("================================");
            Console.WriteLine("Ingrese esa opción: ");
            int opciones;
            opciones = int.Parse(Console.ReadLine());

            switch (opciones)
            {
                case 1:
                    Console.Clear();
                    RegistroVenta();
                    break;
                case 2:
                    Console.Clear();
                    RegistroDevolucion();
                    break;
                case 3:
                    Console.Clear();
                    MostrarEstadisticasFinales();
                    break;
            }
        }
        static void RegistroVenta()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Registrar Venta de: ");
            Console.WriteLine("================================");
            Console.WriteLine("1: Limpieza");
            Console.WriteLine("2: Abarrotes");
            Console.WriteLine("3: Golosinas");
            Console.WriteLine("4: Electronicos");
            Console.WriteLine("5: <- Regresar");
            Console.WriteLine("Ingrese una opcion: ");
            int registrar;
            registrar = int.Parse(Console.ReadLine());
            switch (registrar)
            {
                case 1:
                    RegistroVenta1("Limpieza");
                    break;
                case 2:
                    RegistroVenta1("Abarrotes");
                    break;
                case 3:
                    RegistroVenta1("Golosinas");
                    break;
                case 4:
                    RegistroVenta1("Electronicos");
                    break;
                case 5:
                    Console.WriteLine("Regresar");
                    Console.Clear();
                    PantallaPrincipal();
                    break;
            }
        }
        static void RegistroDevolucion()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Registrar Devolución de: ");
            Console.WriteLine("================================");
            Console.WriteLine("1: Limpieza");
            Console.WriteLine("2: Abarrotes");
            Console.WriteLine("3: Golosinas");
            Console.WriteLine("4: Electronicos");
            Console.WriteLine("Ingrese una opcion: ");
            int registrar;
            registrar = int.Parse(Console.ReadLine());
            switch (registrar)
            {
                case 1:
                    RegistroDevolucion1("Limpieza");
                    break;
                case 2:
                    RegistroDevolucion1("Abarrotes");
                    break;
                case 3:
                    RegistroDevolucion1("Golosinas");
                    break;
                case 4:
                    RegistroDevolucion1("Electronicos");
                    break;
                case 5:
                    Console.WriteLine("Regresar");
                    Console.Clear();
                    PantallaPrincipal();
                    break;
            }
        }
        static void RegistroVenta1(string producto)
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("Registrar venta de " + producto);
            Console.WriteLine("================================");
            Console.Write("Ingrese la cantidad (unidades): ");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/ ");
            float precio = float.Parse(Console.ReadLine());
            float total;
            total = cantidad * precio;
            caja = caja + total;
            Console.WriteLine("================================");
            Console.WriteLine("Se han ingresado " + cantidad + " unidades");
            Console.WriteLine("Se han ingresado S/ " + total + " en caja");
            Console.WriteLine("================================");
            Console.WriteLine("1: Registrar más productos de " + producto);
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("================================");
            Console.WriteLine("Ingrese una opcion (1 o 2): ");

            int opcion1 = int.Parse(Console.ReadLine());    
            switch (opcion1)
            {
                case 1:
                    Console.Clear();
                    RegistroVenta1(producto);
                    break;
                case 2:
                    Console.Clear();
                    PantallaPrincipal();
                    break;
                default:
                    Console.WriteLine("Opción no valida");
                    return;
            }
        }
        static void RegistroDevolucion1(string producto1)
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("Registrar devolucion de " + producto1);
            Console.WriteLine("================================");
            Console.Write("Ingrese la cantidad (unidades): ");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/ ");
            float precio = float.Parse(Console.ReadLine());
            float total;
            total = cantidad * precio;
            caja = caja - total;
            Console.WriteLine("================================");
            Console.WriteLine("Se han ingresado " + cantidad + " unidades");
            Console.WriteLine("Se han ingresado S/ " + total + " en caja");
            Console.WriteLine("================================");
            Console.WriteLine("1: Registrar más productos de " + producto1);
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("================================");
            Console.WriteLine("Ingrese una opcion (1 o 2): ");

            int opcion1 = int.Parse(Console.ReadLine());
            switch (opcion1)
            {
                case 1:
                    Console.Clear();
                    RegistroDevolucion1(producto1);
                    break;
                case 2:
                    Console.Clear();
                    PantallaPrincipal();
                    break;
                default:
                    Console.WriteLine("Opción no valida");
                    return;
            }
        }
        static void MostrarEstadisticasFinales()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("Cerrando Caja");
            Console.WriteLine("=======================");
            Console.WriteLine("Totales");
            Console.WriteLine("=======================");

            MostrarEstadisticasPorRubro("Limpieza", vendidosLimpieza, devueltosLimpieza);
            MostrarEstadisticasPorRubro("Abarrotes", vendidosAbarrotes, devueltosAbarrotes);
            MostrarEstadisticasPorRubro("Golosinas", vendidosGolosinas, devueltosGolosinas);
            MostrarEstadisticasPorRubro("Electronicos", vendidosElectronicos, devueltosElectronicos);

            Console.WriteLine($"Queda en caja S/{caja:f2}");
            Console.ReadKey();
        }

        static void MostrarEstadisticasPorRubro(string rubro, float vendidos, float devueltos)
        {
            float total = vendidos - devueltos;

            Console.WriteLine($"\t\t| {vendidos} vendidos");
            Console.WriteLine($"{rubro} \t| {devueltos} devueltos");
            Console.WriteLine($"\t\t| {total} en total");
            Console.WriteLine($"\t\t| S/ {(total):f2} en caja");
            Console.WriteLine("=======================");
        }
    }
}
