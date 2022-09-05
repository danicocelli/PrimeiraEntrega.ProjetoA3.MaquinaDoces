
namespace PrimeiraEntrega.ProjetoA3.MaquinaDoces
{
    partial class FrmMaquinaDoces
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
            this.btnUmReal = new System.Windows.Forms.Button();
            this.btnDoisReais = new System.Windows.Forms.Button();
            this.btnCincoReais = new System.Windows.Forms.Button();
            this.lblRetorno = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDoceC = new System.Windows.Forms.Button();
            this.btnDoceB = new System.Windows.Forms.Button();
            this.btnDoceA = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUmReal
            // 
            this.btnUmReal.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUmReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUmReal.ForeColor = System.Drawing.Color.White;
            this.btnUmReal.Location = new System.Drawing.Point(12, 262);
            this.btnUmReal.Name = "btnUmReal";
            this.btnUmReal.Size = new System.Drawing.Size(248, 83);
            this.btnUmReal.TabIndex = 0;
            this.btnUmReal.Text = "R$1,00";
            this.btnUmReal.UseVisualStyleBackColor = false;
            this.btnUmReal.Click += new System.EventHandler(this.btnUmReal_Click);
            // 
            // btnDoisReais
            // 
            this.btnDoisReais.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDoisReais.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoisReais.ForeColor = System.Drawing.Color.White;
            this.btnDoisReais.Location = new System.Drawing.Point(263, 262);
            this.btnDoisReais.Name = "btnDoisReais";
            this.btnDoisReais.Size = new System.Drawing.Size(248, 83);
            this.btnDoisReais.TabIndex = 1;
            this.btnDoisReais.Text = "R$2,00";
            this.btnDoisReais.UseVisualStyleBackColor = false;
            this.btnDoisReais.Click += new System.EventHandler(this.btnDoisReais_Click);
            // 
            // btnCincoReais
            // 
            this.btnCincoReais.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCincoReais.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCincoReais.ForeColor = System.Drawing.Color.White;
            this.btnCincoReais.Location = new System.Drawing.Point(517, 262);
            this.btnCincoReais.Name = "btnCincoReais";
            this.btnCincoReais.Size = new System.Drawing.Size(248, 83);
            this.btnCincoReais.TabIndex = 2;
            this.btnCincoReais.Text = "R$5,00";
            this.btnCincoReais.UseVisualStyleBackColor = false;
            this.btnCincoReais.Click += new System.EventHandler(this.btnCincoReais_Click);
            // 
            // lblRetorno
            // 
            this.lblRetorno.AutoSize = true;
            this.lblRetorno.BackColor = System.Drawing.Color.Black;
            this.lblRetorno.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetorno.ForeColor = System.Drawing.Color.Lime;
            this.lblRetorno.Location = new System.Drawing.Point(118, 169);
            this.lblRetorno.Name = "lblRetorno";
            this.lblRetorno.Size = new System.Drawing.Size(17, 20);
            this.lblRetorno.TabIndex = 3;
            this.lblRetorno.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(23, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Seu Saldo: R$";
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.ForeColor = System.Drawing.Color.White;
            this.btnComprar.Location = new System.Drawing.Point(391, 351);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(374, 78);
            this.btnComprar.TabIndex = 8;
            this.btnComprar.Text = "CONCLUIR COMPRA";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Maroon;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(12, 351);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(374, 78);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDoceC
            // 
            this.btnDoceC.BackColor = System.Drawing.Color.DimGray;
            this.btnDoceC.Enabled = false;
            this.btnDoceC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoceC.Location = new System.Drawing.Point(517, 219);
            this.btnDoceC.Name = "btnDoceC";
            this.btnDoceC.Size = new System.Drawing.Size(248, 37);
            this.btnDoceC.TabIndex = 12;
            this.btnDoceC.Text = "CHOCOLATE";
            this.btnDoceC.UseVisualStyleBackColor = false;
            this.btnDoceC.Click += new System.EventHandler(this.btnDoceC_Click);
            // 
            // btnDoceB
            // 
            this.btnDoceB.BackColor = System.Drawing.Color.DimGray;
            this.btnDoceB.Enabled = false;
            this.btnDoceB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoceB.Location = new System.Drawing.Point(263, 219);
            this.btnDoceB.Name = "btnDoceB";
            this.btnDoceB.Size = new System.Drawing.Size(248, 37);
            this.btnDoceB.TabIndex = 11;
            this.btnDoceB.Text = "CHICLETE";
            this.btnDoceB.UseVisualStyleBackColor = false;
            this.btnDoceB.Click += new System.EventHandler(this.btnDoceB_Click);
            // 
            // btnDoceA
            // 
            this.btnDoceA.BackColor = System.Drawing.Color.DimGray;
            this.btnDoceA.Enabled = false;
            this.btnDoceA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoceA.ForeColor = System.Drawing.Color.Black;
            this.btnDoceA.Location = new System.Drawing.Point(12, 219);
            this.btnDoceA.Name = "btnDoceA";
            this.btnDoceA.Size = new System.Drawing.Size(248, 37);
            this.btnDoceA.TabIndex = 10;
            this.btnDoceA.Text = "BALA";
            this.btnDoceA.UseVisualStyleBackColor = false;
            this.btnDoceA.Click += new System.EventHandler(this.btnDoceA_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Lime;
            this.textBox2.Location = new System.Drawing.Point(12, 24);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(753, 118);
            this.textBox2.TabIndex = 0;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Olá, bem-vindo(a) a Máquina de Doces. Insira o valor do produto que deseja.\r\n\r\nBa" +
    "la.............................R$6.00\r\nChiclete......................R$7.00\r\nCho" +
    "colate...................R$8,00";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(12, 157);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(252, 41);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            // 
            // FrmMaquinaDoces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(783, 443);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblRetorno);
            this.Controls.Add(this.btnDoceC);
            this.Controls.Add(this.btnDoceB);
            this.Controls.Add(this.btnDoceA);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCincoReais);
            this.Controls.Add(this.btnDoisReais);
            this.Controls.Add(this.btnUmReal);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMaquinaDoces";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Máquina de Doces";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUmReal;
        private System.Windows.Forms.Button btnDoisReais;
        private System.Windows.Forms.Button btnCincoReais;
        private System.Windows.Forms.Label lblRetorno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDoceC;
        private System.Windows.Forms.Button btnDoceB;
        private System.Windows.Forms.Button btnDoceA;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

