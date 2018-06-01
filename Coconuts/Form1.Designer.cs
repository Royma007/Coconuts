namespace Coconuts
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cdmSubir = new System.Windows.Forms.Button();
            this.cdmVisualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(107, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 318);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cdmSubir
            // 
            this.cdmSubir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cdmSubir.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.cdmSubir.FlatAppearance.BorderSize = 3;
            this.cdmSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdmSubir.Location = new System.Drawing.Point(107, 464);
            this.cdmSubir.Name = "cdmSubir";
            this.cdmSubir.Size = new System.Drawing.Size(76, 48);
            this.cdmSubir.TabIndex = 1;
            this.cdmSubir.Text = "Subir Foto";
            this.cdmSubir.UseVisualStyleBackColor = false;
            // 
            // cdmVisualizar
            // 
            this.cdmVisualizar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cdmVisualizar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.cdmVisualizar.FlatAppearance.BorderSize = 3;
            this.cdmVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdmVisualizar.Location = new System.Drawing.Point(290, 464);
            this.cdmVisualizar.Name = "cdmVisualizar";
            this.cdmVisualizar.Size = new System.Drawing.Size(76, 48);
            this.cdmVisualizar.TabIndex = 2;
            this.cdmVisualizar.Text = "Ver mis Fotos";
            this.cdmVisualizar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ballpark", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 49);
            this.label2.TabIndex = 3;
            this.label2.Text = "Coconuts";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cdmVisualizar);
            this.Controls.Add(this.cdmSubir);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cdmSubir;
        private System.Windows.Forms.Button cdmVisualizar;
        private System.Windows.Forms.Label label2;
    }
}

