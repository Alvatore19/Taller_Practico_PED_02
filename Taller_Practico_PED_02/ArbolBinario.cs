using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_Practico_PED_02
{
    public class ArbolBinario
    {
        public Nodo Raiz { get; set; }

        public ArbolBinario()
        {
            Raiz = null;
        }

        // Método público que llamas desde tu formulario
        public void Insertar(int isbn)
        {
            // Si el árbol está vacío, el nuevo nodo es la raíz
            if (Raiz == null)
            {
                Raiz = new Nodo(isbn);
                return;
            }

            // Si ya hay raíz, iniciamos la recursión
            InsertarRecursivo(Raiz, isbn);
        }

        // Método privado recursivo
        private void InsertarRecursivo(Nodo actual, int isbn)
        {
            // Si el ISBN es menor, nos vamos por la izquierda
            if (isbn < actual.ISBN)
            {
                if (actual.Izquierdo == null)
                    actual.Izquierdo = new Nodo(isbn);
                else
                    InsertarRecursivo(actual.Izquierdo, isbn);
            }
            // Si el ISBN es mayor, nos vamos por la derecha
            else if (isbn > actual.ISBN)
            {
                if (actual.Derecho == null)
                    actual.Derecho = new Nodo(isbn);
                else
                    InsertarRecursivo(actual.Derecho, isbn);
            }
            // Si no es mayor ni menor, ¡es igual! (Duplicado)
            else
            {
                // Mostramos el mensaje tal como lo pide el documento sin alterar la estructura
                MessageBox.Show("ISBN ya registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
