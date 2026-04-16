using System;
using System.Collections.Generic;
using System.Drawing;
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

        public bool Insertar(int isbn)
        {
            if (Raiz == null)
            {
                Raiz = new Nodo(isbn);
                return true; // Inserción exitosa
            }
            return InsertarRecursivo(Raiz, isbn);
        }

        private bool InsertarRecursivo(Nodo actual, int isbn)
        {
            if (isbn < actual.ISBN)
            {
                if (actual.Izquierdo == null)
                {
                    actual.Izquierdo = new Nodo(isbn);
                    return true;
                }
                return InsertarRecursivo(actual.Izquierdo, isbn);
            }
            else if (isbn > actual.ISBN)
            {
                if (actual.Derecho == null)
                {
                    actual.Derecho = new Nodo(isbn);
                    return true;
                }
                return InsertarRecursivo(actual.Derecho, isbn);
            }
            // Si es igual, es un duplicado
            return false;
        }

        // --- 2. ELIMINACIÓN (3 Casos) ---
        public bool Eliminar(int isbn)
        {
            bool eliminado = false;
            Raiz = EliminarRecursivo(Raiz, isbn, ref eliminado);
            return eliminado;
        }

        private Nodo EliminarRecursivo(Nodo raiz, int isbn, ref bool eliminado)
        {
            if (raiz == null) return raiz;

            if (isbn < raiz.ISBN)
                raiz.Izquierdo = EliminarRecursivo(raiz.Izquierdo, isbn, ref eliminado);
            else if (isbn > raiz.ISBN)
                raiz.Derecho = EliminarRecursivo(raiz.Derecho, isbn, ref eliminado);
            else
            {
                // Encontrado
                eliminado = true;

                // Caso 1 y 2: Sin hijos o con un solo hijo
                if (raiz.Izquierdo == null) return raiz.Derecho;
                else if (raiz.Derecho == null) return raiz.Izquierdo;

                // Caso 3: Dos hijos (Buscar sucesor InOrden - el menor del subárbol derecho)
                raiz.ISBN = ValorMinimo(raiz.Derecho);
                raiz.Derecho = EliminarRecursivo(raiz.Derecho, raiz.ISBN, ref eliminado);
            }
            return raiz;
        }

        private int ValorMinimo(Nodo nodo)
        {
            int minv = nodo.ISBN;
            while (nodo.Izquierdo != null)
            {
                minv = nodo.Izquierdo.ISBN;
                nodo = nodo.Izquierdo;
            }
            return minv;
        }

        // --- 3. BÚSQUEDA ---
        public bool Buscar(int isbn, out List<int> camino, out int comparaciones)
        {
            camino = new List<int>();
            comparaciones = 0;
            Nodo actual = Raiz;

            while (actual != null)
            {
                comparaciones++;
                camino.Add(actual.ISBN);

                if (isbn == actual.ISBN) return true;
                else if (isbn < actual.ISBN) actual = actual.Izquierdo;
                else actual = actual.Derecho;
            }
            return false;
        }

        // --- 4. RECORRIDOS ---
        public List<int> InOrden() { var lista = new List<int>(); InOrdenRec(Raiz, lista); return lista; }
        private void InOrdenRec(Nodo nodo, List<int> lista) { if (nodo != null) { InOrdenRec(nodo.Izquierdo, lista); lista.Add(nodo.ISBN); InOrdenRec(nodo.Derecho, lista); } }

        public List<int> PreOrden() { var lista = new List<int>(); PreOrdenRec(Raiz, lista); return lista; }
        private void PreOrdenRec(Nodo nodo, List<int> lista) { if (nodo != null) { lista.Add(nodo.ISBN); PreOrdenRec(nodo.Izquierdo, lista); PreOrdenRec(nodo.Derecho, lista); } }

        public List<int> PostOrden() { var lista = new List<int>(); PostOrdenRec(Raiz, lista); return lista; }
        private void PostOrdenRec(Nodo nodo, List<int> lista) { if (nodo != null) { PostOrdenRec(nodo.Izquierdo, lista); PostOrdenRec(nodo.Derecho, lista); lista.Add(nodo.ISBN); } }

        // --- 5. ESTADÍSTICAS ---
        public int TotalNodos(Nodo nodo) { if (nodo == null) return 0; return 1 + TotalNodos(nodo.Izquierdo) + TotalNodos(nodo.Derecho); }
        public int Altura(Nodo nodo) { if (nodo == null) return 0; return 1 + Math.Max(Altura(nodo.Izquierdo), Altura(nodo.Derecho)); }

        public double PromedioNivel()
        {
            int totalNodos = TotalNodos(Raiz);
            if (totalNodos == 0) return 0;
            return (double)SumaNiveles(Raiz, 1) / totalNodos;
        }
        private int SumaNiveles(Nodo nodo, int nivelActual)
        {
            if (nodo == null) return 0;
            return nivelActual + SumaNiveles(nodo.Izquierdo, nivelActual + 1) + SumaNiveles(nodo.Derecho, nivelActual + 1);
        }

        // --- 6. DIBUJO (GDI+) ---
        public void Dibujar(Graphics g, int x, int y, int offsetX, List<int> resaltados = null)
        {
            DibujarRecursivo(g, Raiz, x, y, offsetX, resaltados ?? new List<int>());
        }

        private void DibujarRecursivo(Graphics g, Nodo nodo, int x, int y, int offsetX, List<int> resaltados)
        {
            if (nodo == null) return;

            // Dibujar líneas a los hijos primero
            if (nodo.Izquierdo != null)
            {
                g.DrawLine(Pens.Black, x, y, x - offsetX, y + 60);
                DibujarRecursivo(g, nodo.Izquierdo, x - offsetX, y + 60, offsetX / 2, resaltados);
            }
            if (nodo.Derecho != null)
            {
                g.DrawLine(Pens.Black, x, y, x + offsetX, y + 60);
                DibujarRecursivo(g, nodo.Derecho, x + offsetX, y + 60, offsetX / 2, resaltados);
            }

            // Dibujar el nodo (círculo)
            Color colorFondo = resaltados.Contains(nodo.ISBN) ? Color.LightGreen : Color.LightBlue;
            Brush brushFondo = new SolidBrush(colorFondo);

            g.FillEllipse(brushFondo, x - 15, y - 15, 30, 30);
            g.DrawEllipse(Pens.Black, x - 15, y - 15, 30, 30);

            // Dibujar el ISBN en el centro
            StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            g.DrawString(nodo.ISBN.ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Rectangle(x - 15, y - 15, 30, 30), sf);
        }
    }
}
