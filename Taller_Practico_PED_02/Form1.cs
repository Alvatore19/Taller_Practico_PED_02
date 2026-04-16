using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_Practico_PED_02
{
    public partial class Form1 : Form
    {
        private ArbolBinario arbol;
        private List<int> nodosResaltados;

        public Form1()
        {
            InitializeComponent();
            arbol = new ArbolBinario();
            nodosResaltados = new List<int>();
            pictureBoxArbol.Paint += PictureBoxArbol_Paint;
        }

        private void ActualizarEstadisticas()
        {
            lblNodos.Text = $"Total Nodos: {arbol.TotalNodos(arbol.Raiz)}";
            lblAltura.Text = $"Altura: {arbol.Altura(arbol.Raiz)}";
            lblPromedio.Text = $"Promedio Nivel: {arbol.PromedioNivel():F2}";
            nodosResaltados.Clear();
            pictureBoxArbol.Invalidate(); // Refrescar dibujo
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtISBN.Text, out int isbn))
            {
                if (!arbol.Insertar(isbn))
                {
                    MessageBox.Show("ISBN ya registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                ActualizarEstadisticas();
                txtISBN.Clear();
                txtISBN.Focus();
            }
            else MessageBox.Show("Ingrese un número válido.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtISBN.Text, out int isbn))
            {
                if (!arbol.Eliminar(isbn))
                {
                    MessageBox.Show("ISBN no encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ActualizarEstadisticas();
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtISBN.Text, out int isbn))
            {
                bool encontrado = arbol.Buscar(isbn, out List<int> camino, out int comparaciones);
                lblInfo.Text = $"Comparaciones: {comparaciones}. {(encontrado ? "¡Encontrado!" : "No encontrado")}";

                // Animar el camino de búsqueda
                nodosResaltados.Clear();
                foreach (int nodoEnCamino in camino)
                {
                    nodosResaltados.Add(nodoEnCamino);
                    pictureBoxArbol.Invalidate();
                    await Task.Delay(400); // Pausa de 400ms para ver cómo se colorea
                }
            }
        }

        // --- ANIMACIÓN DE RECORRIDOS ---
        private async Task AnimarRecorrido(List<int> recorrido)
        {
            listBoxRecorrido.Items.Clear();
            nodosResaltados.Clear();

            foreach (int isbn in recorrido)
            {
                listBoxRecorrido.Items.Add(isbn);
                nodosResaltados.Add(isbn);
                pictureBoxArbol.Invalidate();
                await Task.Delay(500); // Animación medio segundo por nodo
            }
        }

        private async void btnInOrden_Click(object sender, EventArgs e) { await AnimarRecorrido(arbol.InOrden()); }
        private async void btnPreOrden_Click(object sender, EventArgs e) { await AnimarRecorrido(arbol.PreOrden()); }
        private async void btnPostOrden_Click(object sender, EventArgs e) { await AnimarRecorrido(arbol.PostOrden()); }

        // --- EVENTO GDI+ DIBUJO ---
        private void PictureBoxArbol_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // Bordes suaves

            // Dibujar el árbol centrado. Se asume un PictureBox ancho.
            if (arbol.Raiz != null)
            {
                int startX = pictureBoxArbol.Width / 2;
                int startY = 30;
                int offsetInicial = pictureBoxArbol.Width / 4;
                arbol.Dibujar(e.Graphics, startX, startY, offsetInicial, nodosResaltados);
            }
        }
    }
}
