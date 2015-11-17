namespace Vista.Interfaces_Usuario
{
    partial class Interfaz_Eliminar_Usuario
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbNombreBuscar = new System.Windows.Forms.ComboBox();
            this.lblRegistrarUsuario = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Seleccione o  ingrese el usuario que desea Eliminar:";
            // 
            // cbNombreBuscar
            // 
            this.cbNombreBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbNombreBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNombreBuscar.FormattingEnabled = true;
            this.cbNombreBuscar.Items.AddRange(new object[] {
            ""});
            this.cbNombreBuscar.Location = new System.Drawing.Point(39, 98);
            this.cbNombreBuscar.Name = "cbNombreBuscar";
            this.cbNombreBuscar.Size = new System.Drawing.Size(276, 21);
            this.cbNombreBuscar.TabIndex = 40;
            // 
            // lblRegistrarUsuario
            // 
            this.lblRegistrarUsuario.AutoSize = true;
            this.lblRegistrarUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarUsuario.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblRegistrarUsuario.Location = new System.Drawing.Point(107, 27);
            this.lblRegistrarUsuario.Name = "lblRegistrarUsuario";
            this.lblRegistrarUsuario.Size = new System.Drawing.Size(137, 21);
            this.lblRegistrarUsuario.TabIndex = 39;
            this.lblRegistrarUsuario.Text = "Eliminar Usuario";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(39, 145);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 35);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(213, 145);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 35);
            this.btnEliminar.TabIndex = 43;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Interfaz_Eliminar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(371, 208);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbNombreBuscar);
            this.Controls.Add(this.lblRegistrarUsuario);
            this.Name = "Interfaz_Eliminar_Usuario";
            this.Text = "Eliminar Usuario";
            this.Load += new System.EventHandler(this.Interfaz_Eliminar_Usuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNombreBuscar;
        private System.Windows.Forms.Label lblRegistrarUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
    }
}