
namespace Elevador
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
            this.terreo = new System.Windows.Forms.Button();
            this.andar1 = new System.Windows.Forms.Button();
            this.andar2 = new System.Windows.Forms.Button();
            this.andar3 = new System.Windows.Forms.Button();
            this.andar4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.txtboxAndar = new System.Windows.Forms.TextBox();
            this.txtboxSituacao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // terreo
            // 
            this.terreo.Location = new System.Drawing.Point(130, 231);
            this.terreo.Name = "terreo";
            this.terreo.Size = new System.Drawing.Size(76, 60);
            this.terreo.TabIndex = 0;
            this.terreo.Text = "Terreo";
            this.terreo.UseVisualStyleBackColor = true;
            this.terreo.Click += new System.EventHandler(this.terreo_Click);
            // 
            // andar1
            // 
            this.andar1.Location = new System.Drawing.Point(32, 148);
            this.andar1.Name = "andar1";
            this.andar1.Size = new System.Drawing.Size(76, 60);
            this.andar1.TabIndex = 0;
            this.andar1.Text = "Andar 1";
            this.andar1.UseVisualStyleBackColor = true;
            this.andar1.Click += new System.EventHandler(this.andar1_Click);
            // 
            // andar2
            // 
            this.andar2.Location = new System.Drawing.Point(228, 148);
            this.andar2.Name = "andar2";
            this.andar2.Size = new System.Drawing.Size(76, 60);
            this.andar2.TabIndex = 0;
            this.andar2.Text = "Andar 2";
            this.andar2.UseVisualStyleBackColor = true;
            this.andar2.Click += new System.EventHandler(this.andar2_Click);
            // 
            // andar3
            // 
            this.andar3.Location = new System.Drawing.Point(32, 31);
            this.andar3.Name = "andar3";
            this.andar3.Size = new System.Drawing.Size(76, 60);
            this.andar3.TabIndex = 0;
            this.andar3.Text = "Andar 3";
            this.andar3.UseVisualStyleBackColor = true;
            this.andar3.Click += new System.EventHandler(this.andar3_Click);
            // 
            // andar4
            // 
            this.andar4.Location = new System.Drawing.Point(228, 31);
            this.andar4.Name = "andar4";
            this.andar4.Size = new System.Drawing.Size(76, 60);
            this.andar4.TabIndex = 0;
            this.andar4.Text = "Andar 4";
            this.andar4.UseVisualStyleBackColor = true;
            this.andar4.Click += new System.EventHandler(this.andar4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(508, 231);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(76, 60);
            this.button6.TabIndex = 0;
            this.button6.Text = "button1";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(560, 148);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(76, 60);
            this.button7.TabIndex = 0;
            this.button7.Text = "button1";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(613, 231);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(76, 60);
            this.button8.TabIndex = 0;
            this.button8.Text = "button1";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(712, 231);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(76, 60);
            this.button9.TabIndex = 0;
            this.button9.Text = "button1";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(663, 148);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(76, 60);
            this.button10.TabIndex = 0;
            this.button10.Text = "button1";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // txtboxAndar
            // 
            this.txtboxAndar.Location = new System.Drawing.Point(541, 12);
            this.txtboxAndar.Name = "txtboxAndar";
            this.txtboxAndar.ReadOnly = true;
            this.txtboxAndar.Size = new System.Drawing.Size(198, 20);
            this.txtboxAndar.TabIndex = 1;
            // 
            // txtboxSituacao
            // 
            this.txtboxSituacao.Location = new System.Drawing.Point(541, 61);
            this.txtboxSituacao.Name = "txtboxSituacao";
            this.txtboxSituacao.ReadOnly = true;
            this.txtboxSituacao.Size = new System.Drawing.Size(198, 20);
            this.txtboxSituacao.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtboxSituacao);
            this.Controls.Add(this.txtboxAndar);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.andar4);
            this.Controls.Add(this.andar3);
            this.Controls.Add(this.andar2);
            this.Controls.Add(this.andar1);
            this.Controls.Add(this.terreo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button terreo;
        private System.Windows.Forms.Button andar1;
        private System.Windows.Forms.Button andar2;
        private System.Windows.Forms.Button andar3;
        private System.Windows.Forms.Button andar4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox txtboxAndar;
        private System.Windows.Forms.TextBox txtboxSituacao;
    }
}

