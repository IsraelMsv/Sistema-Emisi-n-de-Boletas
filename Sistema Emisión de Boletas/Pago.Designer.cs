namespace Sistema_Emisión_de_Boletas
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
            this.govMediodePago = new System.Windows.Forms.GroupBox();
            this.ravEfectivo = new System.Windows.Forms.RadioButton();
            this.ravBilleteraDigital = new System.Windows.Forms.RadioButton();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.txtResultadoF = new System.Windows.Forms.TextBox();
            this.govMediodePago.SuspendLayout();
            this.SuspendLayout();
            // 
            // govMediodePago
            // 
            this.govMediodePago.Controls.Add(this.ravEfectivo);
            this.govMediodePago.Controls.Add(this.ravBilleteraDigital);
            this.govMediodePago.Location = new System.Drawing.Point(172, 37);
            this.govMediodePago.Margin = new System.Windows.Forms.Padding(4);
            this.govMediodePago.Name = "govMediodePago";
            this.govMediodePago.Padding = new System.Windows.Forms.Padding(4);
            this.govMediodePago.Size = new System.Drawing.Size(227, 123);
            this.govMediodePago.TabIndex = 13;
            this.govMediodePago.TabStop = false;
            this.govMediodePago.Text = "Medios de Pagos";
            // 
            // ravEfectivo
            // 
            this.ravEfectivo.AutoSize = true;
            this.ravEfectivo.Location = new System.Drawing.Point(42, 85);
            this.ravEfectivo.Margin = new System.Windows.Forms.Padding(4);
            this.ravEfectivo.Name = "ravEfectivo";
            this.ravEfectivo.Size = new System.Drawing.Size(64, 17);
            this.ravEfectivo.TabIndex = 6;
            this.ravEfectivo.TabStop = true;
            this.ravEfectivo.Text = "Efectivo";
            this.ravEfectivo.UseVisualStyleBackColor = true;
            // 
            // ravBilleteraDigital
            // 
            this.ravBilleteraDigital.AutoSize = true;
            this.ravBilleteraDigital.Location = new System.Drawing.Point(42, 46);
            this.ravBilleteraDigital.Margin = new System.Windows.Forms.Padding(4);
            this.ravBilleteraDigital.Name = "ravBilleteraDigital";
            this.ravBilleteraDigital.Size = new System.Drawing.Size(94, 17);
            this.ravBilleteraDigital.TabIndex = 5;
            this.ravBilleteraDigital.TabStop = true;
            this.ravBilleteraDigital.Text = "Billetera Digital";
            this.ravBilleteraDigital.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(455, 601);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCobrar
            // 
            this.btnCobrar.Location = new System.Drawing.Point(59, 601);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(75, 23);
            this.btnCobrar.TabIndex = 15;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // txtResultadoF
            // 
            this.txtResultadoF.Location = new System.Drawing.Point(111, 205);
            this.txtResultadoF.Multiline = true;
            this.txtResultadoF.Name = "txtResultadoF";
            this.txtResultadoF.Size = new System.Drawing.Size(366, 362);
            this.txtResultadoF.TabIndex = 17;
            // 
            // Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 652);
            this.Controls.Add(this.txtResultadoF);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.govMediodePago);
            this.Name = "Pago";
            this.Text = "Pago";
            this.Load += new System.EventHandler(this.Pago_Load);
            this.govMediodePago.ResumeLayout(false);
            this.govMediodePago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox govMediodePago;
        private System.Windows.Forms.RadioButton ravEfectivo;
        private System.Windows.Forms.RadioButton ravBilleteraDigital;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.TextBox txtResultadoF;
    }
}