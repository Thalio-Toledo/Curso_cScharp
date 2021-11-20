namespace helloWord
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
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.BtnMensagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(125, 57);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(35, 13);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome";
            this.LblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(186, 54);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(100, 20);
            this.TxtNome.TabIndex = 1;
            // 
            // BtnMensagem
            // 
            this.BtnMensagem.Location = new System.Drawing.Point(186, 92);
            this.BtnMensagem.Name = "BtnMensagem";
            this.BtnMensagem.Size = new System.Drawing.Size(75, 23);
            this.BtnMensagem.TabIndex = 2;
            this.BtnMensagem.Text = "Mensagem";
            this.BtnMensagem.UseVisualStyleBackColor = true;
            this.BtnMensagem.Click += new System.EventHandler(this.BtnMensagem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 427);
            this.Controls.Add(this.BtnMensagem);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblNome);
            this.Name = "Form1";
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Button BtnMensagem;
    }
}

