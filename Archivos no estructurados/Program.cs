using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos_no_estructurados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ruta del archivo a procesar
            string filePath = "archivo.txt";

            try
            {
                // Verifica si el archivo existe
                if (File.Exists(filePath))
                {
                    // Lee todo el contenido del archivo
                    string contenido = File.ReadAllText(filePath);

                    // Procesa el contenido según sea necesario
                    ProcesarContenido(contenido);

                    Console.WriteLine("Procesamiento completo.");
                }
                else
                {
                    Console.WriteLine("El archivo no existe.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error al procesar el archivo: " + ex.Message);
            }

        }



        static void ProcesarContenido(string contenido)
        {
            // Aquí puedes implementar la lógica para procesar el contenido del archivo
            // Por ejemplo, puedes dividir el contenido en líneas, palabras, etc., y realizar operaciones específicas

            // Ejemplo: Dividir el contenido en líneas y mostrar cada línea en la consola
            string[] lineas = contenido.Split('\n');
            foreach (string linea in lineas)
            {
                Console.WriteLine(linea);
            }
        }

    }
}
