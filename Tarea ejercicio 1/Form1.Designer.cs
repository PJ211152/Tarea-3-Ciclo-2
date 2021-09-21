namespace Tarea_ejercicio_1
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
            this.rdb_Ingresar = new System.Windows.Forms.RadioButton();
            this.rbt_Consulta = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rdb_Ingresar
            // 
            this.rdb_Ingresar.AutoSize = true;
            this.rdb_Ingresar.Location = new System.Drawing.Point(562, 71);
            this.rdb_Ingresar.Name = "rdb_Ingresar";
            this.rdb_Ingresar.Size = new System.Drawing.Size(103, 17);
            this.rdb_Ingresar.TabIndex = 0;
            this.rdb_Ingresar.TabStop = true;
            this.rdb_Ingresar.Text = "Ingresar Clientes";
            this.rdb_Ingresar.UseVisualStyleBackColor = true;
            // 
            // rbt_Consulta
            // 
            this.rbt_Consulta.AutoSize = true;
            this.rbt_Consulta.Location = new System.Drawing.Point(562, 114);
            this.rbt_Consulta.Name = "rbt_Consulta";
            this.rbt_Consulta.Size = new System.Drawing.Size(109, 17);
            this.rbt_Consulta.TabIndex = 1;
            this.rbt_Consulta.TabStop = true;
            this.rbt_Consulta.Text = "Consultar Clientes";
            this.rbt_Consulta.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 361);
            this.Controls.Add(this.rbt_Consulta);
            this.Controls.Add(this.rdb_Ingresar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb_Ingresar;
        private System.Windows.Forms.RadioButton rbt_Consulta;
    }
}

