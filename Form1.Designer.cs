namespace Impar_ou_Par_1
{
    partial class FrmPrincipal
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblInstrucao1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVerif = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTitulo.Location = new System.Drawing.Point(300, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(123, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Impar ou Par";
            // 
            // lblInstrucao1
            // 
            this.lblInstrucao1.AutoSize = true;
            this.lblInstrucao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblInstrucao1.Location = new System.Drawing.Point(99, 84);
            this.lblInstrucao1.Name = "lblInstrucao1";
            this.lblInstrucao1.Size = new System.Drawing.Size(119, 17);
            this.lblInstrucao1.TabIndex = 1;
            this.lblInstrucao1.Text = "Digite um número";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblResult.Location = new System.Drawing.Point(6, 31);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(72, 17);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Resultado";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Location = new System.Drawing.Point(22, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 83);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnVerif
            // 
            this.btnVerif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnVerif.Location = new System.Drawing.Point(270, 232);
            this.btnVerif.Name = "btnVerif";
            this.btnVerif.Size = new System.Drawing.Size(124, 41);
            this.btnVerif.TabIndex = 4;
            this.btnVerif.Text = "Verificar";
            this.btnVerif.UseVisualStyleBackColor = true;
            this.btnVerif.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClean.Location = new System.Drawing.Point(140, 232);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(124, 41);
            this.btnClean.TabIndex = 6;
            this.btnClean.Text = "Limpar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.Location = new System.Drawing.Point(22, 397);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 41);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Sair";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(224, 83);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(170, 20);
            this.txtNumber.TabIndex = 8;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnVerif);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblInstrucao1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmPrincipal";
            this.Text = "Impar ou Par";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInstrucao1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVerif;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtNumber;
    }
}

