namespace LabelTranslationEx
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
            this.label1 = new System.Windows.Forms.Label();
            this.chbLingagens = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione a Linguagem";
            // 
            // chbLingagens
            // 
            this.chbLingagens.FormattingEnabled = true;
            this.chbLingagens.Items.AddRange(new object[] {
            "pt_BR",
            "en_US",
            "Others"});
            this.chbLingagens.Location = new System.Drawing.Point(167, 6);
            this.chbLingagens.Name = "chbLingagens";
            this.chbLingagens.Size = new System.Drawing.Size(121, 21);
            this.chbLingagens.TabIndex = 1;
            this.chbLingagens.SelectedIndexChanged += new System.EventHandler(this.chbLingagens_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 41);
            this.Controls.Add(this.chbLingagens);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Título";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox chbLingagens;
    }
}

