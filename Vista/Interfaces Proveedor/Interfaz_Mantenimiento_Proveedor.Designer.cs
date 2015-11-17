namespace Vista.Interfaces_Proveedor
{
    partial class Interfaz_Mantenimiento_Proveedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtIdproveedor = new System.Windows.Forms.TextBox();
            this.txtFiltroProveedor = new System.Windows.Forms.TextBox();
            this.gbModificar = new System.Windows.Forms.GroupBox();
            this.lblTelM = new System.Windows.Forms.Label();
            this.lblDireccionM = new System.Windows.Forms.Label();
            this.lblNombreM = new System.Windows.Forms.Label();
            this.txtTelM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.txtDireccionM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancelarM = new System.Windows.Forms.Button();
            this.btnGuardarM = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gbRegistrar = new System.Windows.Forms.GroupBox();
            this.lblTelR = new System.Windows.Forms.Label();
            this.txtTelR = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDireccionR = new System.Windows.Forms.Label();
            this.txtNombreR = new System.Windows.Forms.TextBox();
            this.lblNombreR = new System.Windows.Forms.Label();
            this.txtDireccionR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelarR = new System.Windows.Forms.Button();
            this.btnGuardarR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.Seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbModificar.SuspendLayout();
            this.gbRegistrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdproveedor
            // 
            this.txtIdproveedor.Location = new System.Drawing.Point(319, 54);
            this.txtIdproveedor.Name = "txtIdproveedor";
            this.txtIdproveedor.Size = new System.Drawing.Size(158, 20);
            this.txtIdproveedor.TabIndex = 45;
            this.txtIdproveedor.Visible = false;
            // 
            // txtFiltroProveedor
            // 
            this.txtFiltroProveedor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroProveedor.Location = new System.Drawing.Point(89, 69);
            this.txtFiltroProveedor.Name = "txtFiltroProveedor";
            this.txtFiltroProveedor.Size = new System.Drawing.Size(138, 27);
            this.txtFiltroProveedor.TabIndex = 43;
            this.txtFiltroProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltroProveedor_KeyPress);
            this.txtFiltroProveedor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltroProveedor_KeyUp);
            // 
            // gbModificar
            // 
            this.gbModificar.Controls.Add(this.lblTelM);
            this.gbModificar.Controls.Add(this.lblDireccionM);
            this.gbModificar.Controls.Add(this.lblNombreM);
            this.gbModificar.Controls.Add(this.txtTelM);
            this.gbModificar.Controls.Add(this.label6);
            this.gbModificar.Controls.Add(this.txtNombreM);
            this.gbModificar.Controls.Add(this.txtDireccionM);
            this.gbModificar.Controls.Add(this.label8);
            this.gbModificar.Controls.Add(this.label9);
            this.gbModificar.Controls.Add(this.btnCancelarM);
            this.gbModificar.Controls.Add(this.btnGuardarM);
            this.gbModificar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbModificar.Location = new System.Drawing.Point(470, 88);
            this.gbModificar.Name = "gbModificar";
            this.gbModificar.Size = new System.Drawing.Size(256, 284);
            this.gbModificar.TabIndex = 44;
            this.gbModificar.TabStop = false;
            this.gbModificar.Text = "Proveedor";
            this.gbModificar.Visible = false;
            // 
            // lblTelM
            // 
            this.lblTelM.AutoSize = true;
            this.lblTelM.ForeColor = System.Drawing.Color.Maroon;
            this.lblTelM.Location = new System.Drawing.Point(169, 148);
            this.lblTelM.Name = "lblTelM";
            this.lblTelM.Size = new System.Drawing.Size(17, 21);
            this.lblTelM.TabIndex = 45;
            this.lblTelM.Text = "*";
            // 
            // lblDireccionM
            // 
            this.lblDireccionM.AutoSize = true;
            this.lblDireccionM.ForeColor = System.Drawing.Color.Maroon;
            this.lblDireccionM.Location = new System.Drawing.Point(196, 91);
            this.lblDireccionM.Name = "lblDireccionM";
            this.lblDireccionM.Size = new System.Drawing.Size(17, 21);
            this.lblDireccionM.TabIndex = 44;
            this.lblDireccionM.Text = "*";
            // 
            // lblNombreM
            // 
            this.lblNombreM.AutoSize = true;
            this.lblNombreM.ForeColor = System.Drawing.Color.Maroon;
            this.lblNombreM.Location = new System.Drawing.Point(219, 35);
            this.lblNombreM.Name = "lblNombreM";
            this.lblNombreM.Size = new System.Drawing.Size(17, 21);
            this.lblNombreM.TabIndex = 43;
            this.lblNombreM.Text = "*";
            // 
            // txtTelM
            // 
            this.txtTelM.Location = new System.Drawing.Point(17, 172);
            this.txtTelM.Multiline = true;
            this.txtTelM.Name = "txtTelM";
            this.txtTelM.Size = new System.Drawing.Size(223, 30);
            this.txtTelM.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 41;
            this.label6.Text = "Telefono:";
            // 
            // txtNombreM
            // 
            this.txtNombreM.Location = new System.Drawing.Point(15, 59);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(225, 29);
            this.txtNombreM.TabIndex = 40;
            this.txtNombreM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombreM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNombreM_KeyUp);
            // 
            // txtDireccionM
            // 
            this.txtDireccionM.Location = new System.Drawing.Point(17, 115);
            this.txtDireccionM.Multiline = true;
            this.txtDireccionM.Name = "txtDireccionM";
            this.txtDireccionM.Size = new System.Drawing.Size(223, 30);
            this.txtDireccionM.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(85, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 21);
            this.label8.TabIndex = 38;
            this.label8.Text = "Direccion:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 21);
            this.label9.TabIndex = 37;
            this.label9.Text = "Nombre de proveedor:";
            // 
            // btnCancelarM
            // 
            this.btnCancelarM.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarM.Location = new System.Drawing.Point(162, 234);
            this.btnCancelarM.Name = "btnCancelarM";
            this.btnCancelarM.Size = new System.Drawing.Size(88, 40);
            this.btnCancelarM.TabIndex = 27;
            this.btnCancelarM.Text = "Cancelar";
            this.btnCancelarM.UseVisualStyleBackColor = true;
            this.btnCancelarM.Click += new System.EventHandler(this.btnCancelarM_Click);
            // 
            // btnGuardarM
            // 
            this.btnGuardarM.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarM.Location = new System.Drawing.Point(6, 234);
            this.btnGuardarM.Name = "btnGuardarM";
            this.btnGuardarM.Size = new System.Drawing.Size(88, 40);
            this.btnGuardarM.TabIndex = 26;
            this.btnGuardarM.Text = "Guardar";
            this.btnGuardarM.UseVisualStyleBackColor = true;
            this.btnGuardarM.Click += new System.EventHandler(this.btnGuardarM_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(719, 45);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(158, 20);
            this.txtId.TabIndex = 42;
            this.txtId.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(415, 313);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(89, 40);
            this.btnSalir.TabIndex = 40;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(599, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "ID Categoria:";
            this.label3.Visible = false;
            // 
            // gbRegistrar
            // 
            this.gbRegistrar.Controls.Add(this.lblTelR);
            this.gbRegistrar.Controls.Add(this.txtTelR);
            this.gbRegistrar.Controls.Add(this.label7);
            this.gbRegistrar.Controls.Add(this.lblDireccionR);
            this.gbRegistrar.Controls.Add(this.txtNombreR);
            this.gbRegistrar.Controls.Add(this.lblNombreR);
            this.gbRegistrar.Controls.Add(this.txtDireccionR);
            this.gbRegistrar.Controls.Add(this.label4);
            this.gbRegistrar.Controls.Add(this.label2);
            this.gbRegistrar.Controls.Add(this.btnCancelarR);
            this.gbRegistrar.Controls.Add(this.btnGuardarR);
            this.gbRegistrar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistrar.Location = new System.Drawing.Point(660, 88);
            this.gbRegistrar.Name = "gbRegistrar";
            this.gbRegistrar.Size = new System.Drawing.Size(256, 284);
            this.gbRegistrar.TabIndex = 39;
            this.gbRegistrar.TabStop = false;
            this.gbRegistrar.Text = "Proveedor";
            this.gbRegistrar.Visible = false;
            // 
            // lblTelR
            // 
            this.lblTelR.AutoSize = true;
            this.lblTelR.ForeColor = System.Drawing.Color.Maroon;
            this.lblTelR.Location = new System.Drawing.Point(164, 148);
            this.lblTelR.Name = "lblTelR";
            this.lblTelR.Size = new System.Drawing.Size(17, 21);
            this.lblTelR.TabIndex = 37;
            this.lblTelR.Text = "*";
            // 
            // txtTelR
            // 
            this.txtTelR.Location = new System.Drawing.Point(17, 172);
            this.txtTelR.Multiline = true;
            this.txtTelR.Name = "txtTelR";
            this.txtTelR.Size = new System.Drawing.Size(223, 30);
            this.txtTelR.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(85, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.TabIndex = 35;
            this.label7.Text = "Telefono:";
            // 
            // lblDireccionR
            // 
            this.lblDireccionR.AutoSize = true;
            this.lblDireccionR.ForeColor = System.Drawing.Color.Maroon;
            this.lblDireccionR.Location = new System.Drawing.Point(191, 91);
            this.lblDireccionR.Name = "lblDireccionR";
            this.lblDireccionR.Size = new System.Drawing.Size(17, 21);
            this.lblDireccionR.TabIndex = 34;
            this.lblDireccionR.Text = "*";
            // 
            // txtNombreR
            // 
            this.txtNombreR.Location = new System.Drawing.Point(15, 59);
            this.txtNombreR.Name = "txtNombreR";
            this.txtNombreR.Size = new System.Drawing.Size(225, 29);
            this.txtNombreR.TabIndex = 31;
            this.txtNombreR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombreR
            // 
            this.lblNombreR.AutoSize = true;
            this.lblNombreR.ForeColor = System.Drawing.Color.Maroon;
            this.lblNombreR.Location = new System.Drawing.Point(214, 35);
            this.lblNombreR.Name = "lblNombreR";
            this.lblNombreR.Size = new System.Drawing.Size(17, 21);
            this.lblNombreR.TabIndex = 33;
            this.lblNombreR.Text = "*";
            // 
            // txtDireccionR
            // 
            this.txtDireccionR.Location = new System.Drawing.Point(17, 115);
            this.txtDireccionR.Multiline = true;
            this.txtDireccionR.Name = "txtDireccionR";
            this.txtDireccionR.Size = new System.Drawing.Size(223, 30);
            this.txtDireccionR.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "Direccion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre de proveedor:";
            // 
            // btnCancelarR
            // 
            this.btnCancelarR.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarR.Location = new System.Drawing.Point(162, 234);
            this.btnCancelarR.Name = "btnCancelarR";
            this.btnCancelarR.Size = new System.Drawing.Size(88, 40);
            this.btnCancelarR.TabIndex = 27;
            this.btnCancelarR.Text = "Cancelar";
            this.btnCancelarR.UseVisualStyleBackColor = true;
            this.btnCancelarR.Click += new System.EventHandler(this.btnCancelarR_Click);
            // 
            // btnGuardarR
            // 
            this.btnGuardarR.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarR.Location = new System.Drawing.Point(6, 234);
            this.btnGuardarR.Name = "btnGuardarR";
            this.btnGuardarR.Size = new System.Drawing.Size(88, 40);
            this.btnGuardarR.TabIndex = 26;
            this.btnGuardarR.Text = "Guardar";
            this.btnGuardarR.UseVisualStyleBackColor = true;
            this.btnGuardarR.Click += new System.EventHandler(this.btnGuardarR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-75, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nombre:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(274, 313);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 40);
            this.btnEliminar.TabIndex = 37;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(144, 313);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(95, 40);
            this.btnModificar.TabIndex = 36;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(12, 313);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(98, 40);
            this.btnRegistrar.TabIndex = 35;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.BackgroundColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccion});
            this.dgvProveedores.Location = new System.Drawing.Point(12, 102);
            this.dgvProveedores.Name = "dgvProveedores";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProveedores.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProveedores.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProveedores.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProveedores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProveedores.Size = new System.Drawing.Size(608, 205);
            this.dgvProveedores.TabIndex = 34;
            this.dgvProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellContentClick);
            this.dgvProveedores.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellContentDoubleClick);
            // 
            // Seleccion
            // 
            this.Seleccion.HeaderText = "SELECCION";
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Seleccion.Width = 80;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblTitulo.Location = new System.Drawing.Point(181, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(322, 30);
            this.lblTitulo.TabIndex = 33;
            this.lblTitulo.Text = "Mantenimiento de Proveedores";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 21);
            this.label5.TabIndex = 46;
            this.label5.Text = "Nombre:";
            // 
            // Interfaz_Mantenimiento_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(941, 423);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdproveedor);
            this.Controls.Add(this.txtFiltroProveedor);
            this.Controls.Add(this.gbModificar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbRegistrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Interfaz_Mantenimiento_Proveedor";
            this.Text = "Mantenimiento de Proveedores";
            this.Load += new System.EventHandler(this.Interfaz_Mantenimiento_Proveedor_Load);
            this.gbModificar.ResumeLayout(false);
            this.gbModificar.PerformLayout();
            this.gbRegistrar.ResumeLayout(false);
            this.gbRegistrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdproveedor;
        private System.Windows.Forms.TextBox txtFiltroProveedor;
        private System.Windows.Forms.GroupBox gbModificar;
        private System.Windows.Forms.Button btnCancelarM;
        private System.Windows.Forms.Button btnGuardarM;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbRegistrar;
        private System.Windows.Forms.Label lblDireccionR;
        private System.Windows.Forms.TextBox txtNombreR;
        private System.Windows.Forms.Label lblNombreR;
        private System.Windows.Forms.TextBox txtDireccionR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelarR;
        private System.Windows.Forms.Button btnGuardarR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTelR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.TextBox txtDireccionM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTelR;
        private System.Windows.Forms.Label lblTelM;
        private System.Windows.Forms.Label lblDireccionM;
        private System.Windows.Forms.Label lblNombreM;
        private System.Windows.Forms.Label label5;

    }
}