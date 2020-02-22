using System;
using System.Collections.Generic;
using System.Text;

namespace Estrategia
{
    class ProcesadorImagen : IProcesador
    {
        IEstrategia estrategia;
        public ProcesadorImagen(IEstrategia estrategia)
        {
            this.estrategia = estrategia;
        }
        public void procesar(String cNombre)
        {
            estrategia.mostrarMensaje(cNombre);
        }
    }
}
