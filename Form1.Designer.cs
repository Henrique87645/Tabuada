namespace Tabuada
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtnumInicial = new System.Windows.Forms.TextBox();
            this.txtnumFinal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLIMPAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnumInicial
            // 
            this.txtnumInicial.Location = new System.Drawing.Point(29, 65);
            this.txtnumInicial.Margin = new System.Windows.Forms.Padding(4);
            this.txtnumInicial.Name = "txtnumInicial";
            this.txtnumInicial.Size = new System.Drawing.Size(132, 22);
            this.txtnumInicial.TabIndex = 0;
            // 
            // txtnumFinal
            // 
            this.txtnumFinal.Location = new System.Drawing.Point(185, 65);
            this.txtnumFinal.Margin = new System.Windows.Forms.Padding(4);
            this.txtnumFinal.Name = "txtnumFinal";
            this.txtnumFinal.Size = new System.Drawing.Size(132, 22);
            this.txtnumFinal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número Inicial ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número Final";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(360, 60);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 28);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.ItemHeight = 16;
            this.lstResultados.Location = new System.Drawing.Point(32, 137);
            this.lstResultados.Margin = new System.Windows.Forms.Padding(4);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(307, 436);
            this.lstResultados.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado";
            // 
            // btnLIMPAR
            // 
            this.btnLIMPAR.Location = new System.Drawing.Point(360, 545);
            this.btnLIMPAR.Margin = new System.Windows.Forms.Padding(4);
            this.btnLIMPAR.Name = "btnLIMPAR";
            this.btnLIMPAR.Size = new System.Drawing.Size(100, 28);
            this.btnLIMPAR.TabIndex = 7;
            this.btnLIMPAR.Text = "Limpar";
            this.btnLIMPAR.UseVisualStyleBackColor = true;
            this.btnLIMPAR.Click += new System.EventHandler(this.btnLIMPAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 608);
            this.Controls.Add(this.btnLIMPAR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnumFinal);
            this.Controls.Add(this.txtnumInicial);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnumInicial;
        private System.Windows.Forms.TextBox txtnumFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLIMPAR;
    }
}

