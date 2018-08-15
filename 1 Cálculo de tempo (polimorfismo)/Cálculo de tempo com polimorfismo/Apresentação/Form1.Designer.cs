namespace Cálculo_de_tempo_com_polimorfismo
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txbDistancia = new System.Windows.Forms.TextBox();
            this.txbVelocidade = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResposta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe a distância em Km";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Informe a velocidade em Km";
            // 
            // txbDistancia
            // 
            this.txbDistancia.Location = new System.Drawing.Point(45, 54);
            this.txbDistancia.Name = "txbDistancia";
            this.txbDistancia.Size = new System.Drawing.Size(138, 20);
            this.txbDistancia.TabIndex = 2;
            // 
            // txbVelocidade
            // 
            this.txbVelocidade.Location = new System.Drawing.Point(45, 102);
            this.txbVelocidade.Name = "txbVelocidade";
            this.txbVelocidade.Size = new System.Drawing.Size(138, 20);
            this.txbVelocidade.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(61, 138);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(97, 28);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(27, 191);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(55, 13);
            this.lblResposta.TabIndex = 5;
            this.lblResposta.Text = "Resposta ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "made by Priscilla Rizzardo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(237, 299);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbVelocidade);
            this.Controls.Add(this.txbDistancia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cálculo de Tempo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbDistancia;
        private System.Windows.Forms.TextBox txbVelocidade;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Label label3;
    }
}

