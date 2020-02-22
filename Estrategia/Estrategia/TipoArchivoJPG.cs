using System;
using System.Collections.Generic;
using System.Text;

namespace Estrategia
{
    class TipoArchivoJPG : IEstrategia
    {
        public void mostrarMensaje(string cNombre)
        {
            Console.WriteLine(string.Format("Se ha guardado la imagen {0}.jpg", cNombre));
        }
    }
}
