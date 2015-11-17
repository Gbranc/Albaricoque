namespace Vista.Interfaces_Proveedor
{
    partial class Interfaz_Modificar_Proveedor
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
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefonoUsuario = new System.Windows.Forms.Label();
            this.lblDireccionUsuario = new System.Windows.Forms.Label();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Seleccione o  ingrese el proveedor que desea modificar:";
            // 
            // cbNombreBuscar
            // 
            this.cbNombreBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbNombreBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNombreBuscar.FormattingEnabled = true;
            this.cbNombreBuscar.Items.AddRange(new object[] {
            ""});
            this.cbNombreBuscar.Location = new System.Drawing.Point(75, 69);
            this.cbNombreBuscar.Name = "cbNombreBuscar";
            this.cbNombreBuscar.Size = new System.Drawing.Size(276, 21);
            this.cbNombreBuscar.TabIndex = 44;
            this.cbNombreBuscar.SelectedIndexChanged += new System.EventHandler(this.cbNombreBuscar_SelectedIndexChanged);
            // 
            // lblRegistrarUsuario
            // 
            this.lblRegistrarUsuario.AutoSize = true;
            this.lblRegistrarUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarUsuario.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblRegistrarUsuario.Location = new System.Drawing.Point(137, 9);
            this.lblRegistrarUsuario.Name = "lblRegistrarUsuario";
            this.lblRegistrarUsuario.Size = new System.Drawing.Size(167, 21);
            this.lblRegistrarUsuario.TabIndex = 43;
            this.lblRegistrarUsuario.Text = "Modificar Proveedor";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(110, 246);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(223, 20);
            this.txtTelefono.TabIndex = 42;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(110, 173);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(223, 67);
            this.txtDireccion.TabIndex = 41;
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Location = new System.Drawing.Point(110, 121);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(223, 20);
            this.txtIdProveedor.TabIndex = 40;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 147);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(223, 20);
            this.txtNombre.TabIndex = 39;
            // 
            // lblTelefonoUsuario
            // 
            this.lblTelefonoUsuario.AutoSize = true;
            this.lblTelefonoUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoUsuario.Location = new System.Drawing.Point(46, 249);
            this.lblTelefonoUsuario.Name = "lblTelefonoUsuario";
            this.lblTelefonoUsuario.Size = new System.Drawing.Size(55, 13);
            this.lblTelefonoUsuario.TabIndex = 49;
            this.lblTelefonoUsuario.Text = "Telefono:";
            // 
            // lblDireccionUsuario
            // 
            this.lblDireccionUsuario.AutoSize = true;
            this.lblDireccionUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionUsuario.Location = new System.Drawing.Point(46, 176);
            this.lblDireccionUsuario.Name = "lblDireccionUsuario";
            this.lblDireccionUsuario.Size = new System.Drawing.Size(58, 13);
            this.lblDireccionUsuario.TabIndex = 48;
            this.lblDireccionUsuario.Text = "Direccion:";
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUsuario.Location = new System.Drawing.Point(13, 124);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(92, 13);
            this.lblIdUsuario.TabIndex = 47;
            this.lblIdUsuario.Text = "ID de Proveedor:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(54, 150);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(51, 13);
            this.lblNombreUsuario.TabIndex = 46;
            this.lblNombreUsuario.Text = "Nombre:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(161, 276);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(102, 35);
            this.btnLimpiar.TabIndex = 52;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(54, 276);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 35);
            this.btnCancelar.TabIndex = 51;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(269, 276);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 35);
            this.btnGuardar.TabIndex = 50;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Interfaz_Modificar_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(418, 323);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblTelefonoUsuario);
            this.Controls.Add(this.lblDireccionUsuario);
            this.Controls.Add(this.lblIdUsuario);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbNombreBuscar);
            this.Controls.Add(this.lblRegistrarUsuario);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtIdProveedor);
            this.Controls.Add(this.txtNombre);
            this.Name = "Interfaz_Modificar_Proveedor";
            this.Text = "Modificar Proveedor";
            this.Load += new System.EventHandler(this.Interfaz_Modificar_Proveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNombreBuscar;
        private System.Windows.Forms.Label lblRegistrarUsuario;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefonoUsuario;
        private System.Windows.Forms.Label lblDireccionUsuario;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}