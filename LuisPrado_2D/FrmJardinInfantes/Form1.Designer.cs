﻿namespace FrmJardinInfantes
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaNoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónPadresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sueldoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sueldoNoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudaciónPorAulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudaciónTotalDeJardinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responsableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reporteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDocenteToolStripMenuItem,
            this.altaNoDocenteToolStripMenuItem,
            this.altaAlumnoToolStripMenuItem,
            this.altaAulaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónPadresToolStripMenuItem,
            this.sueldoDocenteToolStripMenuItem,
            this.sueldoNoDocenteToolStripMenuItem,
            this.recaudaciónPorAulaToolStripMenuItem,
            this.recaudaciónTotalDeJardinToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // altaDocenteToolStripMenuItem
            // 
            this.altaDocenteToolStripMenuItem.Name = "altaDocenteToolStripMenuItem";
            this.altaDocenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaDocenteToolStripMenuItem.Text = "Alta Docente";
            this.altaDocenteToolStripMenuItem.Click += new System.EventHandler(this.altaDocenteToolStripMenuItem_Click);
            // 
            // altaNoDocenteToolStripMenuItem
            // 
            this.altaNoDocenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.responsableToolStripMenuItem,
            this.personalToolStripMenuItem});
            this.altaNoDocenteToolStripMenuItem.Name = "altaNoDocenteToolStripMenuItem";
            this.altaNoDocenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaNoDocenteToolStripMenuItem.Text = "Alta No Docente";
            // 
            // altaAlumnoToolStripMenuItem
            // 
            this.altaAlumnoToolStripMenuItem.Name = "altaAlumnoToolStripMenuItem";
            this.altaAlumnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaAlumnoToolStripMenuItem.Text = "Alta Alumno";
            this.altaAlumnoToolStripMenuItem.Click += new System.EventHandler(this.altaAlumnoToolStripMenuItem_Click);
            // 
            // altaAulaToolStripMenuItem
            // 
            this.altaAulaToolStripMenuItem.Name = "altaAulaToolStripMenuItem";
            this.altaAulaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaAulaToolStripMenuItem.Text = "Alta Aula";
            this.altaAulaToolStripMenuItem.Click += new System.EventHandler(this.altaAulaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // informaciónPadresToolStripMenuItem
            // 
            this.informaciónPadresToolStripMenuItem.Name = "informaciónPadresToolStripMenuItem";
            this.informaciónPadresToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.informaciónPadresToolStripMenuItem.Text = "Información Padres";
            // 
            // sueldoDocenteToolStripMenuItem
            // 
            this.sueldoDocenteToolStripMenuItem.Name = "sueldoDocenteToolStripMenuItem";
            this.sueldoDocenteToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.sueldoDocenteToolStripMenuItem.Text = "Sueldo Docente";
            // 
            // sueldoNoDocenteToolStripMenuItem
            // 
            this.sueldoNoDocenteToolStripMenuItem.Name = "sueldoNoDocenteToolStripMenuItem";
            this.sueldoNoDocenteToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.sueldoNoDocenteToolStripMenuItem.Text = "Sueldo No Docente";
            // 
            // recaudaciónPorAulaToolStripMenuItem
            // 
            this.recaudaciónPorAulaToolStripMenuItem.Name = "recaudaciónPorAulaToolStripMenuItem";
            this.recaudaciónPorAulaToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.recaudaciónPorAulaToolStripMenuItem.Text = "Recaudación por Aula";
            // 
            // recaudaciónTotalDeJardinToolStripMenuItem
            // 
            this.recaudaciónTotalDeJardinToolStripMenuItem.Name = "recaudaciónTotalDeJardinToolStripMenuItem";
            this.recaudaciónTotalDeJardinToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.recaudaciónTotalDeJardinToolStripMenuItem.Text = "Recaudación Total de Jardin";
            // 
            // responsableToolStripMenuItem
            // 
            this.responsableToolStripMenuItem.Name = "responsableToolStripMenuItem";
            this.responsableToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.responsableToolStripMenuItem.Text = "Responsable";
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personalToolStripMenuItem.Text = "Personal";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaNoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaAulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónPadresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldoNoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recaudaciónPorAulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recaudaciónTotalDeJardinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responsableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
    }
}
