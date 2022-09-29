
namespace PrimeiraEntrega.ProjetoA3.MaquinaDoces
{
    partial class FrmMenu
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
            this.btnDoce = new System.Windows.Forms.Button();
            this.btnElevador = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDoce
            // 
            this.btnDoce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoce.Location = new System.Drawing.Point(12, 120);
            this.btnDoce.Name = "btnDoce";
            this.btnDoce.Size = new System.Drawing.Size(419, 62);
            this.btnDoce.TabIndex = 0;
            this.btnDoce.Text = "MÁQUINA DE DOCES";
            this.btnDoce.UseVisualStyleBackColor = true;
            this.btnDoce.Click += new System.EventHandler(this.btnDoce_Click);
            // 
            // btnElevador
            // 
            this.btnElevador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElevador.Location = new System.Drawing.Point(12, 188);
            this.btnElevador.Name = "btnElevador";
            this.btnElevador.Size = new System.Drawing.Size(419, 62);
            this.btnElevador.TabIndex = 1;
            this.btnElevador.Text = "ELEVADOR";
            this.btnElevador.UseVisualStyleBackColor = true;
            this.btnElevador.Click += new System.EventHandler(this.btnElevador_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(419, 62);
            this.button3.TabIndex = 2;
            this.button3.Text = "TERCEIRA ENTREGA";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "PROJETO A3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "TEORIA DA COMPUTAÇÃO E COMPILADORES ";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 328);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnElevador);
            this.Controls.Add(this.btnDoce);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROJETO A3 - MENU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoce;
        private System.Windows.Forms.Button btnElevador;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}