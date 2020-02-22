using System;

namespace Estrategia
{
    class Program
    {
        static void Main(string[] args)
        {
            IEstrategia tipoArchivo;
            string cNombre = "";
            string cValor = "";
            Console.WriteLine("Ingresa el nombre de la imagen");
            cNombre = Console.ReadLine();
            Console.WriteLine("\nEn que formato deseas guardar la imagen:\n"+
                "1.-BPN\n"+
                "2.-PNG\n"+
                "3.-JPGE\n");
            cValor = Console.ReadLine();

            switch (cValor) {
                case "1":
                    tipoArchivo = new TipoArchivoBPM();
                    break;
                case "2":
                    tipoArchivo = new TipoArchivoPNG();
                    break;
                case "3":
                    tipoArchivo = new TipoArchivoJPG();
                    break;
                default:
                    throw new Exception("Formato no valido");
            }
            tipoArchivo.mostrarMensaje(cNombre);
        }
    }
}
