using System;

namespace Estrategia
{
    class Program
    {
        static void Main(string[] args)
        {
            string cNombre = "";
            string cValor = "";
            string cFormato = "";
            Console.WriteLine("Ingresa el nombre de la imagen");
            cNombre = Console.ReadLine();
            Console.WriteLine("\nEn que formato deseas guardar la imagen:\n"+
                "1.-BPN\n"+
                "2.-PNG\n"+
                "3.-JPGE\n");
            cValor = Console.ReadLine();

            switch (cValor) {
                case "1":
                    cFormato = "bpn";
                    break;
                case "2":
                    cFormato = "png";
                    break;
                case "3":
                    cFormato = "jpg";
                    break;
                default:
                    throw new Exception("Formato no valido");
            }
            Console.WriteLine(string.Format("Se ha guardado la imagen {0}.{1}",cNombre, cFormato));
        }
    }
}
