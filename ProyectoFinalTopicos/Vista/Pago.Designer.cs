namespace Vista
{
    partial class Pago
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
            this.cbxTarjeta = new System.Windows.Forms.CheckBox();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.btnTransaccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxTarjeta
            // 
            this.cbxTarjeta.AutoSize = true;
            this.cbxTarjeta.Location = new System.Drawing.Point(12, 41);
            this.cbxTarjeta.Name = "cbxTarjeta";
            this.cbxTarjeta.Size = new System.Drawing.Size(104, 17);
            this.cbxTarjeta.TabIndex = 0;
            this.cbxTarjeta.Text = "Pago con tarjeta";
            this.cbxTarjeta.UseVisualStyleBackColor = true;
            this.cbxTarjeta.Click += new System.EventHandler(this.cbxTarjeta_Click);
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Location = new System.Drawing.Point(255, 41);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(100, 20);
            this.txtEfectivo.TabIndex = 1;
            this.txtEfectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEfectivo_KeyPress);
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(149, 104);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(100, 20);
            this.txtCambio.TabIndex = 2;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(149, 41);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.ReadOnly = true;
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Monto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cambio: ";
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Location = new System.Drawing.Point(252, 13);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(52, 13);
            this.lblMetodo.TabIndex = 6;
            this.lblMetodo.Text = "Efectivo: ";
            // 
            // btnTransaccion
            // 
            this.btnTransaccion.Location = new System.Drawing.Point(255, 76);
            this.btnTransaccion.Name = "btnTransaccion";
            this.btnTransaccion.Size = new System.Drawing.Size(100, 48);
            this.btnTransaccion.TabIndex = 7;
            this.btnTransaccion.Text = "Transferir";
            this.btnTransaccion.UseVisualStyleBackColor = true;
            this.btnTransaccion.Click += new System.EventHandler(this.btnTransaccion_Click);
            // 
            // Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 143);
            this.Controls.Add(this.btnTransaccion);
            this.Controls.Add(this.lblMetodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.txtEfectivo);
            this.Controls.Add(this.cbxTarjeta);
            this.Name = "Pago";
            this.Text = "Pago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxTarjeta;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.Button btnTransaccion;
        public System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtCambio;
    }
}