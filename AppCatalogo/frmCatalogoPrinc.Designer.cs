﻿namespace AppCatalogo
{
    partial class frmCatalogoPrinc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            this.entrar = new System.Windows.Forms.Button();
            this.tituloinicio = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labeltitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(144, 414);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(100, 96);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellContentClick);
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(711, 427);
            this.dgvCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.Size = new System.Drawing.Size(110, 96);
            this.dgvCategoria.TabIndex = 1;
            // 
            // dgvMarca
            // 
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarca.Location = new System.Drawing.Point(441, 399);
            this.dgvMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.Size = new System.Drawing.Size(159, 111);
            this.dgvMarca.TabIndex = 2;
            // 
            // entrar
            // 
            this.entrar.Location = new System.Drawing.Point(482, 276);
            this.entrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(118, 51);
            this.entrar.TabIndex = 4;
            this.entrar.Text = "Entrar";
            this.entrar.UseVisualStyleBackColor = true;
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // tituloinicio
            // 
            this.tituloinicio.AccessibleDescription = "";
            this.tituloinicio.AutoSize = true;
            this.tituloinicio.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloinicio.Location = new System.Drawing.Point(264, 133);
            this.tituloinicio.Name = "tituloinicio";
            this.tituloinicio.Size = new System.Drawing.Size(0, 35);
            this.tituloinicio.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1066, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // labeltitulo
            // 
            this.labeltitulo.AutoSize = true;
            this.labeltitulo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labeltitulo.Font = new System.Drawing.Font("Sitka Display", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitulo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labeltitulo.Location = new System.Drawing.Point(250, 156);
            this.labeltitulo.Name = "labeltitulo";
            this.labeltitulo.Size = new System.Drawing.Size(496, 50);
            this.labeltitulo.TabIndex = 7;
            this.labeltitulo.Text = "Gestion de Articulos de Comercios";
            // 
            // frmCatalogoPrinc
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1066, 523);
            this.Controls.Add(this.labeltitulo);
            this.Controls.Add(this.tituloinicio);
            this.Controls.Add(this.entrar);
            this.Controls.Add(this.dgvMarca);
            this.Controls.Add(this.dgvCategoria);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCatalogoPrinc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCatalogoPrinc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.DataGridView dgvMarca;
        private System.Windows.Forms.Button entrar;
        private System.Windows.Forms.Label tituloinicio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label labeltitulo;
    }
}

