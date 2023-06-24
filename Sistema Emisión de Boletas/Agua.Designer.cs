namespace Sistema_Emisión_de_Boletas
{
    partial class Agua
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.govAgua = new System.Windows.Forms.GroupBox();
            this.CEBEvian = new System.Windows.Forms.CheckBox();
            this.CEBSanMateo = new System.Windows.Forms.CheckBox();
            this.CEBSanLuis = new System.Windows.Forms.CheckBox();
            this.CEBCielo = new System.Windows.Forms.CheckBox();
            this.govAgua.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(152, 234);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 18;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // govAgua
            // 
            this.govAgua.Controls.Add(this.CEBEvian);
            this.govAgua.Controls.Add(this.CEBSanMateo);
            this.govAgua.Controls.Add(this.CEBSanLuis);
            this.govAgua.Controls.Add(this.CEBCielo);
            this.govAgua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.govAgua.Location = new System.Drawing.Point(96, 30);
            this.govAgua.Margin = new System.Windows.Forms.Padding(4);
            this.govAgua.Name = "govAgua";
            this.govAgua.Padding = new System.Windows.Forms.Padding(4);
            this.govAgua.Size = new System.Drawing.Size(188, 177);
            this.govAgua.TabIndex = 19;
            this.govAgua.TabStop = false;
            this.govAgua.Text = "Agua";
            // 
            // CEBEvian
            // 
            this.CEBEvian.AutoSize = true;
            this.CEBEvian.Location = new System.Drawing.Point(38, 134);
            this.CEBEvian.Margin = new System.Windows.Forms.Padding(4);
            this.CEBEvian.Name = "CEBEvian";
            this.CEBEvian.Size = new System.Drawing.Size(65, 20);
            this.CEBEvian.TabIndex = 3;
            this.CEBEvian.Text = "Evian";
            this.CEBEvian.UseVisualStyleBackColor = true;
            // 
            // CEBSanMateo
            // 
            this.CEBSanMateo.AutoSize = true;
            this.CEBSanMateo.Location = new System.Drawing.Point(38, 105);
            this.CEBSanMateo.Margin = new System.Windows.Forms.Padding(4);
            this.CEBSanMateo.Name = "CEBSanMateo";
            this.CEBSanMateo.Size = new System.Drawing.Size(100, 20);
            this.CEBSanMateo.TabIndex = 2;
            this.CEBSanMateo.Text = "San Mateo";
            this.CEBSanMateo.UseVisualStyleBackColor = true;
            // 
            // CEBSanLuis
            // 
            this.CEBSanLuis.AutoSize = true;
            this.CEBSanLuis.Location = new System.Drawing.Point(38, 75);
            this.CEBSanLuis.Margin = new System.Windows.Forms.Padding(4);
            this.CEBSanLuis.Name = "CEBSanLuis";
            this.CEBSanLuis.Size = new System.Drawing.Size(85, 20);
            this.CEBSanLuis.TabIndex = 1;
            this.CEBSanLuis.Text = "San Luis";
            this.CEBSanLuis.UseVisualStyleBackColor = true;
            // 
            // CEBCielo
            // 
            this.CEBCielo.AutoSize = true;
            this.CEBCielo.Location = new System.Drawing.Point(38, 46);
            this.CEBCielo.Margin = new System.Windows.Forms.Padding(4);
            this.CEBCielo.Name = "CEBCielo";
            this.CEBCielo.Size = new System.Drawing.Size(62, 20);
            this.CEBCielo.TabIndex = 0;
            this.CEBCielo.Text = "Cielo";
            this.CEBCielo.UseVisualStyleBackColor = true;
            // 
            // Agua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 288);
            this.Controls.Add(this.govAgua);
            this.Controls.Add(this.btnVolver);
            this.Name = "Agua";
            this.Text = "Agua";
            this.govAgua.ResumeLayout(false);
            this.govAgua.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox govAgua;
        private System.Windows.Forms.CheckBox CEBEvian;
        private System.Windows.Forms.CheckBox CEBSanMateo;
        private System.Windows.Forms.CheckBox CEBSanLuis;
        private System.Windows.Forms.CheckBox CEBCielo;
    }
}