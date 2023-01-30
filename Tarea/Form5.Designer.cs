namespace Tarea
{
    partial class Form5
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
            this.lblPregunta = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnAdivinar = new System.Windows.Forms.Button();
            this.lblAd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(80, 45);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(550, 31);
            this.lblPregunta.TabIndex = 0;
            this.lblPregunta.Text = "Estoy pensando en un numero del 1 al 10";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(220, 127);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(254, 31);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdivinar
            // 
            this.btnAdivinar.Location = new System.Drawing.Point(280, 208);
            this.btnAdivinar.Name = "btnAdivinar";
            this.btnAdivinar.Size = new System.Drawing.Size(142, 53);
            this.btnAdivinar.TabIndex = 2;
            this.btnAdivinar.Text = "Adivinar";
            this.btnAdivinar.UseVisualStyleBackColor = true;
            this.btnAdivinar.Click += new System.EventHandler(this.btnAdivinar_Click);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAd.Location = new System.Drawing.Point(12, 292);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(242, 20);
            this.lblAd.TabIndex = 3;
            this.lblAd.Text = "Adivinaste al intento numero ";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 321);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.btnAdivinar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblPregunta);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adivinar el numero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnAdivinar;
        private System.Windows.Forms.Label lblAd;
    }
}