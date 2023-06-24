namespace Sistema_Emisión_de_Boletas
{
    partial class Infusión
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
            this.govInfusión = new System.Windows.Forms.GroupBox();
            this.CEBFrutosDelBosque = new System.Windows.Forms.CheckBox();
            this.CEBAnís = new System.Windows.Forms.CheckBox();
            this.CEBManzanilla = new System.Windows.Forms.CheckBox();
            this.CEBTé = new System.Windows.Forms.CheckBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.govInfusión.SuspendLayout();
            this.SuspendLayout();
            // 
            // govInfusión
            // 
            this.govInfusión.Controls.Add(this.CEBFrutosDelBosque);
            this.govInfusión.Controls.Add(this.CEBAnís);
            this.govInfusión.Controls.Add(this.CEBManzanilla);
            this.govInfusión.Controls.Add(this.CEBTé);
            this.govInfusión.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.govInfusión.Location = new System.Drawing.Point(83, 23);
            this.govInfusión.Margin = new System.Windows.Forms.Padding(4);
            this.govInfusión.Name = "govInfusión";
            this.govInfusión.Padding = new System.Windows.Forms.Padding(4);
            this.govInfusión.Size = new System.Drawing.Size(200, 177);
            this.govInfusión.TabIndex = 20;
            this.govInfusión.TabStop = false;
            this.govInfusión.Text = "Infusión";
            // 
            // CEBFrutosDelBosque
            // 
            this.CEBFrutosDelBosque.AutoSize = true;
            this.CEBFrutosDelBosque.Location = new System.Drawing.Point(38, 134);
            this.CEBFrutosDelBosque.Margin = new System.Windows.Forms.Padding(4);
            this.CEBFrutosDelBosque.Name = "CEBFrutosDelBosque";
            this.CEBFrutosDelBosque.Size = new System.Drawing.Size(152, 20);
            this.CEBFrutosDelBosque.TabIndex = 3;
            this.CEBFrutosDelBosque.Text = "Frutos del Bosque";
            this.CEBFrutosDelBosque.UseVisualStyleBackColor = true;
            // 
            // CEBAnís
            // 
            this.CEBAnís.AutoSize = true;
            this.CEBAnís.Location = new System.Drawing.Point(38, 105);
            this.CEBAnís.Margin = new System.Windows.Forms.Padding(4);
            this.CEBAnís.Name = "CEBAnís";
            this.CEBAnís.Size = new System.Drawing.Size(56, 20);
            this.CEBAnís.TabIndex = 2;
            this.CEBAnís.Text = "Anís";
            this.CEBAnís.UseVisualStyleBackColor = true;
            // 
            // CEBManzanilla
            // 
            this.CEBManzanilla.AutoSize = true;
            this.CEBManzanilla.Location = new System.Drawing.Point(38, 75);
            this.CEBManzanilla.Margin = new System.Windows.Forms.Padding(4);
            this.CEBManzanilla.Name = "CEBManzanilla";
            this.CEBManzanilla.Size = new System.Drawing.Size(100, 20);
            this.CEBManzanilla.TabIndex = 1;
            this.CEBManzanilla.Text = "Manzanilla";
            this.CEBManzanilla.UseVisualStyleBackColor = true;
            // 
            // CEBTé
            // 
            this.CEBTé.AutoSize = true;
            this.CEBTé.Location = new System.Drawing.Point(38, 46);
            this.CEBTé.Margin = new System.Windows.Forms.Padding(4);
            this.CEBTé.Name = "CEBTé";
            this.CEBTé.Size = new System.Drawing.Size(45, 20);
            this.CEBTé.TabIndex = 0;
            this.CEBTé.Text = "Té";
            this.CEBTé.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(146, 229);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 21;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Infusión
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 291);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.govInfusión);
            this.Name = "Infusión";
            this.Text = "Infusión";
            this.govInfusión.ResumeLayout(false);
            this.govInfusión.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox govInfusión;
        private System.Windows.Forms.CheckBox CEBFrutosDelBosque;
        private System.Windows.Forms.CheckBox CEBAnís;
        private System.Windows.Forms.CheckBox CEBManzanilla;
        private System.Windows.Forms.CheckBox CEBTé;
        private System.Windows.Forms.Button btnVolver;
    }
}