
namespace Capa_Vista
{
    partial class Busqueda_Smart
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
            this.tbcBusqueda = new System.Windows.Forms.TabControl();
            this.tbpCreacion = new System.Windows.Forms.TabPage();
            this.tbpConsultas = new System.Windows.Forms.TabPage();
            this.tbpEditar = new System.Windows.Forms.TabPage();
            this.tbpBE = new System.Windows.Forms.TabPage();
            this.tbcBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcBusqueda
            // 
            this.tbcBusqueda.Controls.Add(this.tbpCreacion);
            this.tbcBusqueda.Controls.Add(this.tbpConsultas);
            this.tbcBusqueda.Controls.Add(this.tbpEditar);
            this.tbcBusqueda.Controls.Add(this.tbpBE);
            this.tbcBusqueda.Location = new System.Drawing.Point(12, 12);
            this.tbcBusqueda.Name = "tbcBusqueda";
            this.tbcBusqueda.SelectedIndex = 0;
            this.tbcBusqueda.Size = new System.Drawing.Size(776, 426);
            this.tbcBusqueda.TabIndex = 1;
            // 
            // tbpCreacion
            // 
            this.tbpCreacion.Location = new System.Drawing.Point(4, 22);
            this.tbpCreacion.Name = "tbpCreacion";
            this.tbpCreacion.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCreacion.Size = new System.Drawing.Size(768, 400);
            this.tbpCreacion.TabIndex = 0;
            this.tbpCreacion.Text = "Creación";
            this.tbpCreacion.UseVisualStyleBackColor = true;
            // 
            // tbpConsultas
            // 
            this.tbpConsultas.Location = new System.Drawing.Point(4, 22);
            this.tbpConsultas.Name = "tbpConsultas";
            this.tbpConsultas.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConsultas.Size = new System.Drawing.Size(768, 400);
            this.tbpConsultas.TabIndex = 1;
            this.tbpConsultas.Text = "Consultas";
            this.tbpConsultas.UseVisualStyleBackColor = true;
            // 
            // tbpEditar
            // 
            this.tbpEditar.Location = new System.Drawing.Point(4, 22);
            this.tbpEditar.Name = "tbpEditar";
            this.tbpEditar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEditar.Size = new System.Drawing.Size(768, 400);
            this.tbpEditar.TabIndex = 2;
            this.tbpEditar.Text = "Editar";
            this.tbpEditar.UseVisualStyleBackColor = true;
            // 
            // tbpBE
            // 
            this.tbpBE.Location = new System.Drawing.Point(4, 22);
            this.tbpBE.Name = "tbpBE";
            this.tbpBE.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBE.Size = new System.Drawing.Size(768, 400);
            this.tbpBE.TabIndex = 3;
            this.tbpBE.Text = "Buscar/Eliminar";
            this.tbpBE.UseVisualStyleBackColor = true;
            // 
            // Busqueda_Smart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcBusqueda);
            this.Name = "Busqueda_Smart";
            this.Text = "Busqueda_Smart";
            this.tbcBusqueda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tbcBusqueda;
        private System.Windows.Forms.TabPage tbpCreacion;
        private System.Windows.Forms.TabPage tbpConsultas;
        private System.Windows.Forms.TabPage tbpEditar;
        private System.Windows.Forms.TabPage tbpBE;
    }
}