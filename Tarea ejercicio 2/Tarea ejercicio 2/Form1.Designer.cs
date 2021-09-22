namespace Tarea_ejercicio_2
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
            this.rbt_Ingresar = new System.Windows.Forms.RadioButton();
            this.txb_carnet = new System.Windows.Forms.TextBox();
            this.txb_materia = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.lbl_carnet = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_materia = new System.Windows.Forms.Label();
            this.rbt_consultar = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbt_Ingresar
            // 
            this.rbt_Ingresar.AutoSize = true;
            this.rbt_Ingresar.Location = new System.Drawing.Point(631, 64);
            this.rbt_Ingresar.Name = "rbt_Ingresar";
            this.rbt_Ingresar.Size = new System.Drawing.Size(116, 17);
            this.rbt_Ingresar.TabIndex = 0;
            this.rbt_Ingresar.TabStop = true;
            this.rbt_Ingresar.Text = "Ingresar Estudiante";
            this.rbt_Ingresar.UseVisualStyleBackColor = true;
            // 
            // txb_carnet
            // 
            this.txb_carnet.Location = new System.Drawing.Point(180, 65);
            this.txb_carnet.Name = "txb_carnet";
            this.txb_carnet.Size = new System.Drawing.Size(100, 20);
            this.txb_carnet.TabIndex = 1;
            // 
            // txb_materia
            // 
            this.txb_materia.Location = new System.Drawing.Point(180, 173);
            this.txb_materia.Name = "txb_materia";
            this.txb_materia.Size = new System.Drawing.Size(100, 20);
            this.txb_materia.TabIndex = 2;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(180, 137);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(100, 20);
            this.txt_apellido.TabIndex = 3;
            // 
            // txb_nombre
            // 
            this.txb_nombre.Location = new System.Drawing.Point(180, 102);
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.Size = new System.Drawing.Size(100, 20);
            this.txb_nombre.TabIndex = 4;
            // 
            // lbl_carnet
            // 
            this.lbl_carnet.AutoSize = true;
            this.lbl_carnet.Location = new System.Drawing.Point(122, 68);
            this.lbl_carnet.Name = "lbl_carnet";
            this.lbl_carnet.Size = new System.Drawing.Size(38, 13);
            this.lbl_carnet.TabIndex = 5;
            this.lbl_carnet.Text = "Carnet";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(122, 105);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 6;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(122, 140);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_apellido.TabIndex = 7;
            this.lbl_apellido.Text = "Apellido";
            // 
            // lbl_materia
            // 
            this.lbl_materia.AutoSize = true;
            this.lbl_materia.Location = new System.Drawing.Point(122, 176);
            this.lbl_materia.Name = "lbl_materia";
            this.lbl_materia.Size = new System.Drawing.Size(42, 13);
            this.lbl_materia.TabIndex = 8;
            this.lbl_materia.Text = "Materia";
            // 
            // rbt_consultar
            // 
            this.rbt_consultar.AutoSize = true;
            this.rbt_consultar.Location = new System.Drawing.Point(631, 101);
            this.rbt_consultar.Name = "rbt_consultar";
            this.rbt_consultar.Size = new System.Drawing.Size(127, 17);
            this.rbt_consultar.TabIndex = 9;
            this.rbt_consultar.TabStop = true;
            this.rbt_consultar.Text = "Consultar Estudiantes";
            this.rbt_consultar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 339);
            this.Controls.Add(this.rbt_consultar);
            this.Controls.Add(this.lbl_materia);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_carnet);
            this.Controls.Add(this.txb_nombre);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txb_materia);
            this.Controls.Add(this.txb_carnet);
            this.Controls.Add(this.rbt_Ingresar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbt_Ingresar;
        private System.Windows.Forms.TextBox txb_carnet;
        private System.Windows.Forms.TextBox txb_materia;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txb_nombre;
        private System.Windows.Forms.Label lbl_carnet;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_materia;
        private System.Windows.Forms.RadioButton rbt_consultar;
    }
}

