namespace Sistema_Emisión_de_Boletas
{
    partial class Seleccion
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.govBebidas = new System.Windows.Forms.GroupBox();
            this.CEBCAFE = new System.Windows.Forms.CheckBox();
            this.CEBInfusión = new System.Windows.Forms.CheckBox();
            this.CEBAgua = new System.Windows.Forms.CheckBox();
            this.CEBGaseosas = new System.Windows.Forms.CheckBox();
            this.govPlatillo = new System.Windows.Forms.GroupBox();
            this.CEBAlaCarta = new System.Windows.Forms.CheckBox();
            this.CEBMenúEstudiantil = new System.Windows.Forms.CheckBox();
            this.govSandwiches = new System.Windows.Forms.GroupBox();
            this.CEBHamburguesa = new System.Windows.Forms.CheckBox();
            this.CEBPanMixto = new System.Windows.Forms.CheckBox();
            this.CEBPanConPolloCr = new System.Windows.Forms.CheckBox();
            this.CEBPanConPolloCi = new System.Windows.Forms.CheckBox();
            this.txtSelección = new System.Windows.Forms.TextBox();
            this.govBebidas.SuspendLayout();
            this.govPlatillo.SuspendLayout();
            this.govSandwiches.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mesón del Estudiante";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(453, 607);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(57, 607);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 13;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.nComprar_Click);
            // 
            // govBebidas
            // 
            this.govBebidas.Controls.Add(this.CEBCAFE);
            this.govBebidas.Controls.Add(this.CEBInfusión);
            this.govBebidas.Controls.Add(this.CEBAgua);
            this.govBebidas.Controls.Add(this.CEBGaseosas);
            this.govBebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.govBebidas.Location = new System.Drawing.Point(57, 116);
            this.govBebidas.Margin = new System.Windows.Forms.Padding(4);
            this.govBebidas.Name = "govBebidas";
            this.govBebidas.Padding = new System.Windows.Forms.Padding(4);
            this.govBebidas.Size = new System.Drawing.Size(188, 177);
            this.govBebidas.TabIndex = 11;
            this.govBebidas.TabStop = false;
            this.govBebidas.Text = "Bebidas";
            // 
            // CEBCAFE
            // 
            this.CEBCAFE.AutoSize = true;
            this.CEBCAFE.Location = new System.Drawing.Point(38, 134);
            this.CEBCAFE.Margin = new System.Windows.Forms.Padding(4);
            this.CEBCAFE.Name = "CEBCAFE";
            this.CEBCAFE.Size = new System.Drawing.Size(58, 20);
            this.CEBCAFE.TabIndex = 3;
            this.CEBCAFE.Text = "Café";
            this.CEBCAFE.UseVisualStyleBackColor = true;
            // 
            // CEBInfusión
            // 
            this.CEBInfusión.AutoSize = true;
            this.CEBInfusión.Location = new System.Drawing.Point(38, 105);
            this.CEBInfusión.Margin = new System.Windows.Forms.Padding(4);
            this.CEBInfusión.Name = "CEBInfusión";
            this.CEBInfusión.Size = new System.Drawing.Size(79, 20);
            this.CEBInfusión.TabIndex = 2;
            this.CEBInfusión.Text = "Infusión";
            this.CEBInfusión.UseVisualStyleBackColor = true;
            // 
            // CEBAgua
            // 
            this.CEBAgua.AutoSize = true;
            this.CEBAgua.Location = new System.Drawing.Point(38, 75);
            this.CEBAgua.Margin = new System.Windows.Forms.Padding(4);
            this.CEBAgua.Name = "CEBAgua";
            this.CEBAgua.Size = new System.Drawing.Size(62, 20);
            this.CEBAgua.TabIndex = 1;
            this.CEBAgua.Text = "Agua";
            this.CEBAgua.UseVisualStyleBackColor = true;
            // 
            // CEBGaseosas
            // 
            this.CEBGaseosas.AutoSize = true;
            this.CEBGaseosas.Location = new System.Drawing.Point(38, 46);
            this.CEBGaseosas.Margin = new System.Windows.Forms.Padding(4);
            this.CEBGaseosas.Name = "CEBGaseosas";
            this.CEBGaseosas.Size = new System.Drawing.Size(97, 20);
            this.CEBGaseosas.TabIndex = 0;
            this.CEBGaseosas.Text = "Gaseosas";
            this.CEBGaseosas.UseVisualStyleBackColor = true;
            // 
            // govPlatillo
            // 
            this.govPlatillo.Controls.Add(this.CEBAlaCarta);
            this.govPlatillo.Controls.Add(this.CEBMenúEstudiantil);
            this.govPlatillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.govPlatillo.Location = new System.Drawing.Point(57, 374);
            this.govPlatillo.Margin = new System.Windows.Forms.Padding(4);
            this.govPlatillo.Name = "govPlatillo";
            this.govPlatillo.Padding = new System.Windows.Forms.Padding(4);
            this.govPlatillo.Size = new System.Drawing.Size(188, 126);
            this.govPlatillo.TabIndex = 16;
            this.govPlatillo.TabStop = false;
            this.govPlatillo.Text = "Platillo";
            // 
            // CEBAlaCarta
            // 
            this.CEBAlaCarta.AutoSize = true;
            this.CEBAlaCarta.Location = new System.Drawing.Point(38, 76);
            this.CEBAlaCarta.Margin = new System.Windows.Forms.Padding(4);
            this.CEBAlaCarta.Name = "CEBAlaCarta";
            this.CEBAlaCarta.Size = new System.Drawing.Size(92, 20);
            this.CEBAlaCarta.TabIndex = 1;
            this.CEBAlaCarta.Text = "A la carta";
            this.CEBAlaCarta.UseVisualStyleBackColor = true;
            // 
            // CEBMenúEstudiantil
            // 
            this.CEBMenúEstudiantil.AutoSize = true;
            this.CEBMenúEstudiantil.Location = new System.Drawing.Point(38, 47);
            this.CEBMenúEstudiantil.Margin = new System.Windows.Forms.Padding(4);
            this.CEBMenúEstudiantil.Name = "CEBMenúEstudiantil";
            this.CEBMenúEstudiantil.Size = new System.Drawing.Size(139, 20);
            this.CEBMenúEstudiantil.TabIndex = 0;
            this.CEBMenúEstudiantil.Text = "Menú Estudiantil";
            this.CEBMenúEstudiantil.UseVisualStyleBackColor = true;
            // 
            // govSandwiches
            // 
            this.govSandwiches.Controls.Add(this.CEBHamburguesa);
            this.govSandwiches.Controls.Add(this.CEBPanMixto);
            this.govSandwiches.Controls.Add(this.CEBPanConPolloCr);
            this.govSandwiches.Controls.Add(this.CEBPanConPolloCi);
            this.govSandwiches.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.govSandwiches.Location = new System.Drawing.Point(354, 116);
            this.govSandwiches.Margin = new System.Windows.Forms.Padding(4);
            this.govSandwiches.Name = "govSandwiches";
            this.govSandwiches.Padding = new System.Windows.Forms.Padding(4);
            this.govSandwiches.Size = new System.Drawing.Size(227, 177);
            this.govSandwiches.TabIndex = 17;
            this.govSandwiches.TabStop = false;
            this.govSandwiches.Text = "sandwiches";
            // 
            // CEBHamburguesa
            // 
            this.CEBHamburguesa.AutoSize = true;
            this.CEBHamburguesa.Location = new System.Drawing.Point(25, 134);
            this.CEBHamburguesa.Margin = new System.Windows.Forms.Padding(4);
            this.CEBHamburguesa.Name = "CEBHamburguesa";
            this.CEBHamburguesa.Size = new System.Drawing.Size(123, 20);
            this.CEBHamburguesa.TabIndex = 3;
            this.CEBHamburguesa.Text = "Hamburguesa";
            this.CEBHamburguesa.UseVisualStyleBackColor = true;
            // 
            // CEBPanMixto
            // 
            this.CEBPanMixto.AutoSize = true;
            this.CEBPanMixto.Location = new System.Drawing.Point(25, 106);
            this.CEBPanMixto.Margin = new System.Windows.Forms.Padding(4);
            this.CEBPanMixto.Name = "CEBPanMixto";
            this.CEBPanMixto.Size = new System.Drawing.Size(93, 20);
            this.CEBPanMixto.TabIndex = 2;
            this.CEBPanMixto.Text = "Pan Mixto";
            this.CEBPanMixto.UseVisualStyleBackColor = true;
            // 
            // CEBPanConPolloCr
            // 
            this.CEBPanConPolloCr.AutoSize = true;
            this.CEBPanConPolloCr.Location = new System.Drawing.Point(25, 77);
            this.CEBPanConPolloCr.Margin = new System.Windows.Forms.Padding(4);
            this.CEBPanConPolloCr.Name = "CEBPanConPolloCr";
            this.CEBPanConPolloCr.Size = new System.Drawing.Size(195, 20);
            this.CEBPanConPolloCr.TabIndex = 1;
            this.CEBPanConPolloCr.Text = "Pan con Pollo (crousant)";
            this.CEBPanConPolloCr.UseVisualStyleBackColor = true;
            // 
            // CEBPanConPolloCi
            // 
            this.CEBPanConPolloCi.AutoSize = true;
            this.CEBPanConPolloCi.Location = new System.Drawing.Point(25, 47);
            this.CEBPanConPolloCi.Margin = new System.Windows.Forms.Padding(4);
            this.CEBPanConPolloCi.Name = "CEBPanConPolloCi";
            this.CEBPanConPolloCi.Size = new System.Drawing.Size(194, 20);
            this.CEBPanConPolloCi.TabIndex = 0;
            this.CEBPanConPolloCi.Text = "Pan con Pollo (Ciabatta)";
            this.CEBPanConPolloCi.UseVisualStyleBackColor = true;
            // 
            // txtSelección
            // 
            this.txtSelección.Location = new System.Drawing.Point(354, 350);
            this.txtSelección.Multiline = true;
            this.txtSelección.Name = "txtSelección";
            this.txtSelección.Size = new System.Drawing.Size(227, 187);
            this.txtSelección.TabIndex = 18;
            // 
            // Seleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 642);
            this.Controls.Add(this.txtSelección);
            this.Controls.Add(this.govSandwiches);
            this.Controls.Add(this.govPlatillo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.govBebidas);
            this.Name = "Seleccion";
            this.Text = "Selección";
            this.Load += new System.EventHandler(this.Ventana2_Load);
            this.govBebidas.ResumeLayout(false);
            this.govBebidas.PerformLayout();
            this.govPlatillo.ResumeLayout(false);
            this.govPlatillo.PerformLayout();
            this.govSandwiches.ResumeLayout(false);
            this.govSandwiches.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.GroupBox govBebidas;
        private System.Windows.Forms.CheckBox CEBCAFE;
        private System.Windows.Forms.CheckBox CEBInfusión;
        private System.Windows.Forms.CheckBox CEBAgua;
        private System.Windows.Forms.CheckBox CEBGaseosas;
        private System.Windows.Forms.GroupBox govPlatillo;
        private System.Windows.Forms.CheckBox CEBAlaCarta;
        private System.Windows.Forms.CheckBox CEBMenúEstudiantil;
        private System.Windows.Forms.GroupBox govSandwiches;
        private System.Windows.Forms.CheckBox CEBHamburguesa;
        private System.Windows.Forms.CheckBox CEBPanMixto;
        private System.Windows.Forms.CheckBox CEBPanConPolloCr;
        private System.Windows.Forms.CheckBox CEBPanConPolloCi;
        private System.Windows.Forms.TextBox txtSelección;
    }
}