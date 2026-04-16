using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_Practico_PED_02
{
    public class Nodo
    {
        public int ISBN { get; set; }
        public Nodo Izquierdo { get; set; }
        public Nodo Derecho { get; set; }

        // Constructor para inicializar un nuevo nodo
        public Nodo(int isbn)
        {
            ISBN = isbn;
            Izquierdo = null;
            Derecho = null;
        }
    }
}
