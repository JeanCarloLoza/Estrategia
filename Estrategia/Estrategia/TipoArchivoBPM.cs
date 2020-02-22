using System;
using System.Collections.Generic;
using System.Text;

namespace Estrategia
{
    class TipoArchivoBPM : IEstrategia
    {
        public void mostrarMensaje(string cNombre)
        {
            Console.WriteLine(string.Format("Se ha guardado la imagen {0}.bpn", cNombre));
        }
    }
}
