
namespace CapaVista
{
    partial class MDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.módulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPuestos = new System.Windows.Forms.ToolStripMenuItem();
            this.desarrolloDeCarreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioContraseñaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.enlacesContabilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nominasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGenerarNóminas = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCierreDeNominas = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVerCierresDeNomina = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.toolStripMenuItem1,
            this.mantenimientosToolStripMenuItem,
            this.cambioContraseñaToolStripMenuItem1,
            this.bitacoraToolStripMenuItem1,
            this.enlacesContabilidadToolStripMenuItem,
            this.nominasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1003, 33);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "MenuStrip";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
            this.inicioToolStripMenuItem.Text = "Abrir";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 29);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEmpleados,
            this.módulosToolStripMenuItem,
            this.tsmPuestos,
            this.desarrolloDeCarreraToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.mantenimientosToolStripMenuItem.Text = "Catalogo";
            // 
            // tsmEmpleados
            // 
            this.tsmEmpleados.Name = "tsmEmpleados";
            this.tsmEmpleados.Size = new System.Drawing.Size(215, 30);
            this.tsmEmpleados.Text = "Bodegas";
            this.tsmEmpleados.Click += new System.EventHandler(this.tsmEmpleados_Click);
            // 
            // módulosToolStripMenuItem
            // 
            this.módulosToolStripMenuItem.Name = "módulosToolStripMenuItem";
            this.módulosToolStripMenuItem.Size = new System.Drawing.Size(215, 30);
            this.módulosToolStripMenuItem.Text = "Productos";
            this.módulosToolStripMenuItem.Click += new System.EventHandler(this.módulosToolStripMenuItem_Click);
            // 
            // tsmPuestos
            // 
            this.tsmPuestos.Name = "tsmPuestos";
            this.tsmPuestos.Size = new System.Drawing.Size(215, 30);
            this.tsmPuestos.Text = "Tipo de Pago";
            this.tsmPuestos.Click += new System.EventHandler(this.aplicacionesToolStripMenuItem_Click);
            // 
            // desarrolloDeCarreraToolStripMenuItem
            // 
            this.desarrolloDeCarreraToolStripMenuItem.Name = "desarrolloDeCarreraToolStripMenuItem";
            this.desarrolloDeCarreraToolStripMenuItem.Size = new System.Drawing.Size(215, 30);
            this.desarrolloDeCarreraToolStripMenuItem.Text = "Clientes";
            this.desarrolloDeCarreraToolStripMenuItem.Click += new System.EventHandler(this.desarrolloDeCarreraToolStripMenuItem_Click);
            // 
            // cambioContraseñaToolStripMenuItem1
            // 
            this.cambioContraseñaToolStripMenuItem1.Name = "cambioContraseñaToolStripMenuItem1";
            this.cambioContraseñaToolStripMenuItem1.Size = new System.Drawing.Size(14, 29);
            // 
            // bitacoraToolStripMenuItem1
            // 
            this.bitacoraToolStripMenuItem1.Name = "bitacoraToolStripMenuItem1";
            this.bitacoraToolStripMenuItem1.Size = new System.Drawing.Size(108, 29);
            this.bitacoraToolStripMenuItem1.Text = "Procesos";
            this.bitacoraToolStripMenuItem1.Click += new System.EventHandler(this.bitacoraToolStripMenuItem1_Click);
            // 
            // enlacesContabilidadToolStripMenuItem
            // 
            this.enlacesContabilidadToolStripMenuItem.Name = "enlacesContabilidadToolStripMenuItem";
            this.enlacesContabilidadToolStripMenuItem.Size = new System.Drawing.Size(101, 29);
            this.enlacesContabilidadToolStripMenuItem.Text = "Informes";
            this.enlacesContabilidadToolStripMenuItem.Click += new System.EventHandler(this.enlacesContabilidadToolStripMenuItem_Click);
            // 
            // nominasToolStripMenuItem
            // 
            this.nominasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGenerarNóminas,
            this.btnCierreDeNominas,
            this.btnVerCierresDeNomina});
            this.nominasToolStripMenuItem.Name = "nominasToolStripMenuItem";
            this.nominasToolStripMenuItem.Size = new System.Drawing.Size(142, 29);
            this.nominasToolStripMenuItem.Text = "Herramientas";
            this.nominasToolStripMenuItem.Click += new System.EventHandler(this.nominasToolStripMenuItem_Click);
            // 
            // btnGenerarNóminas
            // 
            this.btnGenerarNóminas.Name = "btnGenerarNóminas";
            this.btnGenerarNóminas.Size = new System.Drawing.Size(296, 30);
            this.btnGenerarNóminas.Text = "Nóminas";
            this.btnGenerarNóminas.Click += new System.EventHandler(this.btnGenerarNóminas_Click);
            // 
            // btnCierreDeNominas
            // 
            this.btnCierreDeNominas.Name = "btnCierreDeNominas";
            this.btnCierreDeNominas.Size = new System.Drawing.Size(296, 30);
            this.btnCierreDeNominas.Text = "Cierre de Nóminas";
            this.btnCierreDeNominas.Click += new System.EventHandler(this.btnCierreDeNominas_Click);
            // 
            // btnVerCierresDeNomina
            // 
            this.btnVerCierresDeNomina.Name = "btnVerCierresDeNomina";
            this.btnVerCierresDeNomina.Size = new System.Drawing.Size(296, 30);
            this.btnVerCierresDeNomina.Text = "Ver Cierres de Nómina";
            this.btnVerCierresDeNomina.Click += new System.EventHandler(this.btnVerCierresDeNomina_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(916, 0);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(85, 22);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.Visible = false;
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1003, 526);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MDI";
            this.Text = " MDI Daniel Navas 0901-18-15032";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmEmpleados;
        private System.Windows.Forms.ToolStripMenuItem tsmPuestos;
        private System.Windows.Forms.ToolStripMenuItem módulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioContraseñaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bitacoraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem desarrolloDeCarreraToolStripMenuItem;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ToolStripMenuItem enlacesContabilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nominasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnGenerarNóminas;
        private System.Windows.Forms.ToolStripMenuItem btnCierreDeNominas;
        private System.Windows.Forms.ToolStripMenuItem btnVerCierresDeNomina;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
    }
}