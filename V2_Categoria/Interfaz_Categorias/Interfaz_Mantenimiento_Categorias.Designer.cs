namespace Vista.Interfaz_Categorias
{
    partial class Interfaz_Mantenimiento_Categorias
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.Seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbRegistrar = new System.Windows.Forms.GroupBox();
            this.lblDescripcionR = new System.Windows.Forms.Label();
            this.txtNombreR = new System.Windows.Forms.TextBox();
            this.lblNombreR = new System.Windows.Forms.Label();
            this.txtDescripcionR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelarR = new System.Windows.Forms.Button();
            this.btnGuardarR = new System.Windows.Forms.Button();
            this.gbModificar = new System.Windows.Forms.GroupBox();
            this.lblDescripcionM = new System.Windows.Forms.Label();
            this.txtDescripcionM = new System.Windows.Forms.TextBox();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.lblNombreM = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelarM = new System.Windows.Forms.Button();
            this.btnGuardarM = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtFiltroCategoria = new System.Windows.Forms.TextBox();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.gbRegistrar.SuspendLayout();
            this.gbModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(278, 312);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 40);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(148, 312);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(95, 40);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(16, 312);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(98, 40);
            this.btnRegistrar.TabIndex = 19;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.BackgroundColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccion});
            this.dgvCategorias.Location = new System.Drawing.Point(16, 101);
            this.dgvCategorias.Name = "dgvCategorias";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategorias.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCategorias.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCategorias.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategorias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCategorias.Size = new System.Drawing.Size(608, 205);
            this.dgvCategorias.TabIndex = 18;
            this.dgvCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellContentClick);
            this.dgvCategorias.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellContentDoubleClick);
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
            this.lblTitulo.Location = new System.Drawing.Point(185, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(304, 30);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "Mantenimiento de Categorias";
            // 
            // gbRegistrar
            // 
            this.gbRegistrar.Controls.Add(this.lblDescripcionR);
            this.gbRegistrar.Controls.Add(this.txtNombreR);
            this.gbRegistrar.Controls.Add(this.lblNombreR);
            this.gbRegistrar.Controls.Add(this.txtDescripcionR);
            this.gbRegistrar.Controls.Add(this.label4);
            this.gbRegistrar.Controls.Add(this.label2);
            this.gbRegistrar.Controls.Add(this.btnCancelarR);
            this.gbRegistrar.Controls.Add(this.btnGuardarR);
            this.gbRegistrar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistrar.Location = new System.Drawing.Point(664, 87);
            this.gbRegistrar.Name = "gbRegistrar";
            this.gbRegistrar.Size = new System.Drawing.Size(256, 284);
            this.gbRegistrar.TabIndex = 25;
            this.gbRegistrar.TabStop = false;
            this.gbRegistrar.Text = "Categoria";
            this.gbRegistrar.Visible = false;
            // 
            // lblDescripcionR
            // 
            this.lblDescripcionR.AutoSize = true;
            this.lblDescripcionR.ForeColor = System.Drawing.Color.Maroon;
            this.lblDescripcionR.Location = new System.Drawing.Point(191, 91);
            this.lblDescripcionR.Name = "lblDescripcionR";
            this.lblDescripcionR.Size = new System.Drawing.Size(17, 21);
            this.lblDescripcionR.TabIndex = 34;
            this.lblDescripcionR.Text = "*";
            // 
            // txtNombreR
            // 
            this.txtNombreR.Location = new System.Drawing.Point(15, 59);
            this.txtNombreR.Name = "txtNombreR";
            this.txtNombreR.Size = new System.Drawing.Size(225, 29);
            this.txtNombreR.TabIndex = 31;
            this.txtNombreR.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // txtDescripcionR
            // 
            this.txtDescripcionR.Location = new System.Drawing.Point(17, 115);
            this.txtDescripcionR.Multiline = true;
            this.txtDescripcionR.Name = "txtDescripcionR";
            this.txtDescripcionR.Size = new System.Drawing.Size(223, 105);
            this.txtDescripcionR.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre de Categoria:";
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
            this.btnCancelarR.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnGuardarR.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gbModificar
            // 
            this.gbModificar.Controls.Add(this.lblDescripcionM);
            this.gbModificar.Controls.Add(this.txtDescripcionM);
            this.gbModificar.Controls.Add(this.txtNombreM);
            this.gbModificar.Controls.Add(this.lblNombreM);
            this.gbModificar.Controls.Add(this.label5);
            this.gbModificar.Controls.Add(this.txtNombreCategoria);
            this.gbModificar.Controls.Add(this.label6);
            this.gbModificar.Controls.Add(this.btnCancelarM);
            this.gbModificar.Controls.Add(this.btnGuardarM);
            this.gbModificar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbModificar.Location = new System.Drawing.Point(664, 87);
            this.gbModificar.Name = "gbModificar";
            this.gbModificar.Size = new System.Drawing.Size(256, 284);
            this.gbModificar.TabIndex = 31;
            this.gbModificar.TabStop = false;
            this.gbModificar.Text = "Categoria";
            this.gbModificar.Visible = false;
            // 
            // lblDescripcionM
            // 
            this.lblDescripcionM.AutoSize = true;
            this.lblDescripcionM.ForeColor = System.Drawing.Color.Maroon;
            this.lblDescripcionM.Location = new System.Drawing.Point(191, 91);
            this.lblDescripcionM.Name = "lblDescripcionM";
            this.lblDescripcionM.Size = new System.Drawing.Size(17, 21);
            this.lblDescripcionM.TabIndex = 32;
            this.lblDescripcionM.Text = "*";
            // 
            // txtDescripcionM
            // 
            this.txtDescripcionM.Location = new System.Drawing.Point(17, 115);
            this.txtDescripcionM.Multiline = true;
            this.txtDescripcionM.Name = "txtDescripcionM";
            this.txtDescripcionM.Size = new System.Drawing.Size(223, 105);
            this.txtDescripcionM.TabIndex = 30;
            // 
            // txtNombreM
            // 
            this.txtNombreM.Location = new System.Drawing.Point(15, 59);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(225, 29);
            this.txtNombreM.TabIndex = 28;
            this.txtNombreM.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombreM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombreM
            // 
            this.lblNombreM.AutoSize = true;
            this.lblNombreM.ForeColor = System.Drawing.Color.Maroon;
            this.lblNombreM.Location = new System.Drawing.Point(214, 35);
            this.lblNombreM.Name = "lblNombreM";
            this.lblNombreM.Size = new System.Drawing.Size(17, 21);
            this.lblNombreM.TabIndex = 31;
            this.lblNombreM.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "Descripcion:";
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Location = new System.Drawing.Point(15, 59);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(225, 29);
            this.txtNombreCategoria.TabIndex = 28;
            this.txtNombreCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCategoria_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 21);
            this.label6.TabIndex = 27;
            this.label6.Text = "Nombre de Categoria:";
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
            this.btnCancelarM.Click += new System.EventHandler(this.btnCancelar2_Click);
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
            this.btnGuardarM.Click += new System.EventHandler(this.btnGuardar2_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(723, 44);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(158, 20);
            this.txtId.TabIndex = 30;
            this.txtId.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(719, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 29;
            this.label3.Text = "ID Categoria:";
            this.label3.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(419, 312);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(89, 40);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtFiltroCategoria
            // 
            this.txtFiltroCategoria.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroCategoria.Location = new System.Drawing.Point(80, 64);
            this.txtFiltroCategoria.Name = "txtFiltroCategoria";
            this.txtFiltroCategoria.Size = new System.Drawing.Size(138, 27);
            this.txtFiltroCategoria.TabIndex = 31;
            this.txtFiltroCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltroCategoria_KeyPress);
            this.txtFiltroCategoria.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltroCategoria_KeyUp);
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Location = new System.Drawing.Point(323, 53);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(158, 20);
            this.txtIdCategoria.TabIndex = 32;
            this.txtIdCategoria.Visible = false;
            // 
            // Interfaz_Mantenimiento_Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(941, 361);
            this.Controls.Add(this.txtIdCategoria);
            this.Controls.Add(this.txtFiltroCategoria);
            this.Controls.Add(this.gbModificar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbRegistrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.Name = "Interfaz_Mantenimiento_Categorias";
            this.Text = "Mantenimiento de Categorias";
            this.Load += new System.EventHandler(this.Interfaz_Mantenimiento_Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.gbRegistrar.ResumeLayout(false);
            this.gbRegistrar.PerformLayout();
            this.gbModificar.ResumeLayout(false);
            this.gbModificar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbRegistrar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelarR;
        private System.Windows.Forms.Button btnGuardarR;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtDescripcionR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFiltroCategoria;
        private System.Windows.Forms.GroupBox gbModificar;
        private System.Windows.Forms.TextBox txtDescripcionM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelarM;
        private System.Windows.Forms.Button btnGuardarM;
        private System.Windows.Forms.TextBox txtIdCategoria;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccion;
        private System.Windows.Forms.Label lblDescripcionM;
        private System.Windows.Forms.Label lblNombreM;
        private System.Windows.Forms.TextBox txtNombreR;
        private System.Windows.Forms.Label lblDescripcionR;
        private System.Windows.Forms.Label lblNombreR;
    }
}