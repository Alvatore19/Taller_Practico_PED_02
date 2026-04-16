namespace Taller_Practico_PED_02
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControles = new System.Windows.Forms.Panel();
            this.lblTituloRecorridos = new System.Windows.Forms.Label();
            this.listBoxRecorrido = new System.Windows.Forms.ListBox();
            this.btnPostOrden = new System.Windows.Forms.Button();
            this.btnPreOrden = new System.Windows.Forms.Button();
            this.btnInOrden = new System.Windows.Forms.Button();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblNodos = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.pictureBoxArbol = new System.Windows.Forms.PictureBox();
            this.panelControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArbol)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControles
            // 
            this.panelControles.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelControles.Controls.Add(this.lblTituloRecorridos);
            this.panelControles.Controls.Add(this.listBoxRecorrido);
            this.panelControles.Controls.Add(this.btnPostOrden);
            this.panelControles.Controls.Add(this.btnPreOrden);
            this.panelControles.Controls.Add(this.btnInOrden);
            this.panelControles.Controls.Add(this.lblPromedio);
            this.panelControles.Controls.Add(this.lblAltura);
            this.panelControles.Controls.Add(this.lblNodos);
            this.panelControles.Controls.Add(this.lblInfo);
            this.panelControles.Controls.Add(this.btnBuscar);
            this.panelControles.Controls.Add(this.btnEliminar);
            this.panelControles.Controls.Add(this.btnInsertar);
            this.panelControles.Controls.Add(this.txtISBN);
            this.panelControles.Controls.Add(this.lblISBN);
            this.panelControles.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControles.Location = new System.Drawing.Point(0, 0);
            this.panelControles.Name = "panelControles";
            this.panelControles.Size = new System.Drawing.Size(250, 681);
            this.panelControles.TabIndex = 0;
            // 
            // lblTituloRecorridos
            // 
            this.lblTituloRecorridos.AutoSize = true;
            this.lblTituloRecorridos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRecorridos.Location = new System.Drawing.Point(12, 330);
            this.lblTituloRecorridos.Name = "lblTituloRecorridos";
            this.lblTituloRecorridos.Size = new System.Drawing.Size(76, 17);
            this.lblTituloRecorridos.TabIndex = 13;
            this.lblTituloRecorridos.Text = "Recorridos";
            // 
            // listBoxRecorrido
            // 
            this.listBoxRecorrido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRecorrido.FormattingEnabled = true;
            this.listBoxRecorrido.ItemHeight = 15;
            this.listBoxRecorrido.Location = new System.Drawing.Point(15, 455);
            this.listBoxRecorrido.Name = "listBoxRecorrido";
            this.listBoxRecorrido.Size = new System.Drawing.Size(217, 199);
            this.listBoxRecorrido.TabIndex = 12;
            // 
            // btnPostOrden
            // 
            this.btnPostOrden.Location = new System.Drawing.Point(15, 417);
            this.btnPostOrden.Name = "btnPostOrden";
            this.btnPostOrden.Size = new System.Drawing.Size(217, 30);
            this.btnPostOrden.TabIndex = 11;
            this.btnPostOrden.Text = "Post-Orden";
            this.btnPostOrden.UseVisualStyleBackColor = true;
            this.btnPostOrden.Click += new System.EventHandler(this.btnPostOrden_Click);
            // 
            // btnPreOrden
            // 
            this.btnPreOrden.Location = new System.Drawing.Point(15, 386);
            this.btnPreOrden.Name = "btnPreOrden";
            this.btnPreOrden.Size = new System.Drawing.Size(217, 30);
            this.btnPreOrden.TabIndex = 10;
            this.btnPreOrden.Text = "Pre-Orden";
            this.btnPreOrden.UseVisualStyleBackColor = true;
            this.btnPreOrden.Click += new System.EventHandler(this.btnPreOrden_Click);
            // 
            // btnInOrden
            // 
            this.btnInOrden.Location = new System.Drawing.Point(15, 355);
            this.btnInOrden.Name = "btnInOrden";
            this.btnInOrden.Size = new System.Drawing.Size(217, 30);
            this.btnInOrden.TabIndex = 9;
            this.btnInOrden.Text = "In-Orden";
            this.btnInOrden.UseVisualStyleBackColor = true;
            this.btnInOrden.Click += new System.EventHandler(this.btnInOrden_Click);
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(12, 275);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(107, 15);
            this.lblPromedio.TabIndex = 8;
            this.lblPromedio.Text = "Promedio Nivel: 0";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(12, 250);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(52, 15);
            this.lblAltura.TabIndex = 7;
            this.lblAltura.Text = "Altura: 0";
            // 
            // lblNodos
            // 
            this.lblNodos.AutoSize = true;
            this.lblNodos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNodos.Location = new System.Drawing.Point(12, 225);
            this.lblNodos.Name = "lblNodos";
            this.lblNodos.Size = new System.Drawing.Size(83, 15);
            this.lblNodos.TabIndex = 6;
            this.lblNodos.Text = "Total Nodos: 0";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Teal;
            this.lblInfo.Location = new System.Drawing.Point(12, 185);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(127, 15);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Esperando acciones...";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(15, 140);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(217, 30);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar ISBN";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(128, 100);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(104, 30);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(15, 100);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(104, 30);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(15, 55);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(217, 29);
            this.txtISBN.TabIndex = 1;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(12, 30);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(95, 17);
            this.lblISBN.TabIndex = 0;
            this.lblISBN.Text = "Número ISBN:";
            // 
            // pictureBoxArbol
            // 
            this.pictureBoxArbol.BackColor = System.Drawing.Color.White;
            this.pictureBoxArbol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxArbol.Location = new System.Drawing.Point(250, 0);
            this.pictureBoxArbol.Name = "pictureBoxArbol";
            this.pictureBoxArbol.Size = new System.Drawing.Size(834, 681);
            this.pictureBoxArbol.TabIndex = 1;
            this.pictureBoxArbol.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 681);
            this.Controls.Add(this.pictureBoxArbol);
            this.Controls.Add(this.panelControles);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Inventario - Árbol Binario de Búsqueda";
            this.panelControles.ResumeLayout(false);
            this.panelControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArbol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControles;
        private System.Windows.Forms.PictureBox pictureBoxArbol;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblNodos;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Button btnInOrden;
        private System.Windows.Forms.Button btnPostOrden;
        private System.Windows.Forms.Button btnPreOrden;
        private System.Windows.Forms.ListBox listBoxRecorrido;
        private System.Windows.Forms.Label lblTituloRecorridos;
    }
}