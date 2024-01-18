using System;
using System.IO;

namespace RegistroCumpleaños
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string directoryPath = "C:\\test";
                string filePath = Path.Combine(directoryPath, "cumpleaños.txt");

                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Close();
                }

                while (true)
                {
                    Console.Clear(); 

                    Console.WriteLine("*****************************");
                    Console.WriteLine("  Registro de Cumpleaños");
                    Console.WriteLine("*****************************\n");
                    Console.WriteLine("1. Agregar Cumpleaños");
                    Console.WriteLine("2. Mostrar Cumpleaños Registrados");
                    Console.WriteLine("3. Eliminar Cumpleaños");
                    Console.WriteLine("4. Salir\n");

                    Console.Write("Seleccione una opción: ");
                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            AgregarCumpleaños(filePath);
                            break;

                        case "2":
                            MostrarCumpleaños(filePath);
                            break;

                        case "3":
                            EliminarCumpleaños(filePath);
                            break;

                        case "4":
                            Console.WriteLine("¡Hasta luego!");
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void AgregarCumpleaños(string filePath)
        {
            Console.Clear(); 

            Console.WriteLine("***************************");
            Console.WriteLine("   Agregar Cumpleaños");
            Console.WriteLine("***************************\n");

            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la fecha de cumpleaños (DD/MM): ");
            string fechaCumpleaños = Console.ReadLine();

            string registro = $"{nombre} - {fechaCumpleaños}";

            // Agregar el registro al archivo
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(registro);
            }

            Console.WriteLine("Cumpleaños registrado con éxito.");
            Console.ReadKey(); 
        }

        static void MostrarCumpleaños(string filePath)
        {
            Console.Clear();

            Console.WriteLine("******************************");
            Console.WriteLine(" Cumpleaños Registrados");
            Console.WriteLine("******************************\n");

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string linea = reader.ReadLine();
                    Console.WriteLine(linea);
                }
            }

            Console.ReadKey(); 
        }

        static void EliminarCumpleaños(string filePath)
        {
            Console.Clear();

            Console.WriteLine("******************************");
            Console.WriteLine("  Eliminar Cumpleaños");
            Console.WriteLine("******************************\n");

            MostrarCumpleaños(filePath);

            Console.Write("Ingrese el nombre a eliminar: ");
            string nombreEliminar = Console.ReadLine();

            string archivoTemporal = Path.Combine("C:\\test", "temporal.txt");

            using (StreamReader reader = new StreamReader(filePath))
            using (StreamWriter writer = new StreamWriter(archivoTemporal))
            {
                while (!reader.EndOfStream)
                {
                    string linea = reader.ReadLine();
                    if (!linea.Contains(nombreEliminar))
                    {
                        writer.WriteLine(linea);
                    }
                }
            }

            File.Delete(filePath);
            File.Move(archivoTemporal, filePath);

            Console.WriteLine($"Cumpleaño de {nombreEliminar} eliminado con éxito.");
            Console.ReadKey();
        }
    }
}
