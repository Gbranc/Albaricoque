namespace Vista.Punto_De_Venta
{
    partial class Interfaz_Cobrar
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
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtNumMesa = new System.Windows.Forms.TextBox();
            this.txtIdVenta = new System.Windows.Forms.TextBox();
            this.lblIdVenta = new System.Windows.Forms.Label();
            this.lblNumMesa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbCuentaMesa1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnCobrarCuenta = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rbTarjeta = new System.Windows.Forms.RadioButton();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblST = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbCuentaMesa1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(72, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 21);
            this.label8.TabIndex = 43;
            this.label8.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(132, 23);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(230, 29);
            this.dtpFecha.TabIndex = 42;
            // 
            // txtNumMesa
            // 
            this.txtNumMesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumMesa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumMesa.Location = new System.Drawing.Point(132, 93);
            this.txtNumMesa.Name = "txtNumMesa";
            this.txtNumMesa.Size = new System.Drawing.Size(230, 29);
            this.txtNumMesa.TabIndex = 41;
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdVenta.Enabled = false;
            this.txtIdVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdVenta.Location = new System.Drawing.Point(132, 58);
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.Size = new System.Drawing.Size(230, 29);
            this.txtIdVenta.TabIndex = 40;
            // 
            // lblIdVenta
            // 
            this.lblIdVenta.AutoSize = true;
            this.lblIdVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdVenta.Location = new System.Drawing.Point(49, 61);
            this.lblIdVenta.Name = "lblIdVenta";
            this.lblIdVenta.Size = new System.Drawing.Size(80, 21);
            this.lblIdVenta.TabIndex = 38;
            this.lblIdVenta.Text = "ID Orden:";
            // 
            // lblNumMesa
            // 
            this.lblNumMesa.AutoSize = true;
            this.lblNumMesa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumMesa.Location = new System.Drawing.Point(45, 95);
            this.lblNumMesa.Name = "lblNumMesa";
            this.lblNumMesa.Size = new System.Drawing.Size(83, 21);
            this.lblNumMesa.TabIndex = 39;
            this.lblNumMesa.Text = "No. Mesa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 44;
            this.label1.Text = "Pedidos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(340, 261);
            this.dataGridView1.TabIndex = 45;
            // 
            // gbCuentaMesa1
            // 
            this.gbCuentaMesa1.BackColor = System.Drawing.Color.White;
            this.gbCuentaMesa1.Controls.Add(this.textBox3);
            this.gbCuentaMesa1.Controls.Add(this.label2);
            this.gbCuentaMesa1.Controls.Add(this.textBox1);
            this.gbCuentaMesa1.Controls.Add(this.button1);
            this.gbCuentaMesa1.Controls.Add(this.radioButton1);
            this.gbCuentaMesa1.Controls.Add(this.label12);
            this.gbCuentaMesa1.Controls.Add(this.btnCobrarCuenta);
            this.gbCuentaMesa1.Controls.Add(this.textBox2);
            this.gbCuentaMesa1.Controls.Add(this.label11);
            this.gbCuentaMesa1.Controls.Add(this.txtCambio);
            this.gbCuentaMesa1.Controls.Add(this.label10);
            this.gbCuentaMesa1.Controls.Add(this.label9);
            this.gbCuentaMesa1.Controls.Add(this.rbTarjeta);
            this.gbCuentaMesa1.Controls.Add(this.rbEfectivo);
            this.gbCuentaMesa1.Controls.Add(this.txtTotal);
            this.gbCuentaMesa1.Controls.Add(this.txtSubTotal);
            this.gbCuentaMesa1.Controls.Add(this.lblTotal);
            this.gbCuentaMesa1.Controls.Add(this.lblST);
            this.gbCuentaMesa1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCuentaMesa1.Location = new System.Drawing.Point(420, 26);
            this.gbCuentaMesa1.Name = "gbCuentaMesa1";
            this.gbCuentaMesa1.Size = new System.Drawing.Size(346, 412);
            this.gbCuentaMesa1.TabIndex = 46;
            this.gbCuentaMesa1.TabStop = false;
            this.gbCuentaMesa1.Text = "Factura";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(257, 195);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 25);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Dollar";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnCobrarCuenta
            // 
            this.btnCobrarCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCobrarCuenta.Location = new System.Drawing.Point(20, 358);
            this.btnCobrarCuenta.Name = "btnCobrarCuenta";
            this.btnCobrarCuenta.Size = new System.Drawing.Size(145, 48);
            this.btnCobrarCuenta.TabIndex = 13;
            this.btnCobrarCuenta.Text = "Cobrar Cuenta";
            this.btnCobrarCuenta.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(171, 307);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 29);
            this.textBox2.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(80, 315);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 21);
            this.label11.TabIndex = 10;
            this.label11.Text = "Cambio:";
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(171, 272);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(78, 29);
            this.txtCambio.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 21);
            this.label10.TabIndex = 8;
            this.label10.Text = "Cantidad Recibida:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(110, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "Metodo de pago:";
            // 
            // rbTarjeta
            // 
            this.rbTarjeta.AutoSize = true;
            this.rbTarjeta.Location = new System.Drawing.Point(148, 195);
            this.rbTarjeta.Name = "rbTarjeta";
            this.rbTarjeta.Size = new System.Drawing.Size(78, 25);
            this.rbTarjeta.TabIndex = 6;
            this.rbTarjeta.TabStop = true;
            this.rbTarjeta.Text = "Tarjeta";
            this.rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Location = new System.Drawing.Point(30, 195);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(87, 25);
            this.rbEfectivo.TabIndex = 5;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(171, 98);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(80, 29);
            this.txtTotal.TabIndex = 3;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(171, 63);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(80, 29);
            this.txtSubTotal.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(101, 135);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 21);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total:";
            // 
            // lblST
            // 
            this.lblST.AutoSize = true;
            this.lblST.Location = new System.Drawing.Point(80, 67);
            this.lblST.Name = "lblST";
            this.lblST.Size = new System.Drawing.Size(85, 21);
            this.lblST.TabIndex = 0;
            this.lblST.Text = "Sub-Total:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(101, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 21);
            this.label12.TabIndex = 16;
            this.label12.Text = "+IVA";
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(183, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 48);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(171, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 29);
            this.textBox1.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(171, 27);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(80, 29);
            this.textBox3.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "ID Factura:";
            // 
            // Interfaz_Cobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 452);
            this.Controls.Add(this.gbCuentaMesa1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtNumMesa);
            this.Controls.Add(this.txtIdVenta);
            this.Controls.Add(this.lblIdVenta);
            this.Controls.Add(this.lblNumMesa);
            this.Name = "Interfaz_Cobrar";
            this.Text = "Cobrar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbCuentaMesa1.ResumeLayout(false);
            this.gbCuentaMesa1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtNumMesa;
        private System.Windows.Forms.TextBox txtIdVenta;
        private System.Windows.Forms.Label lblIdVenta;
        private System.Windows.Forms.Label lblNumMesa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbCuentaMesa1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCobrarCuenta;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbTarjeta;
        private System.Windows.Forms.RadioButton rbEfectivo;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblST;
    }
}