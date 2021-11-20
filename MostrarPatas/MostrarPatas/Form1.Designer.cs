namespace MostrarPatas
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
            this.cboAnimais = new System.Windows.Forms.ComboBox();
            this.bntPatas = new System.Windows.Forms.Button();
            this.pctAnimais = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctAnimais)).BeginInit();
            this.SuspendLayout();
            // 
            // cboAnimais
            // 
            this.cboAnimais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnimais.FormattingEnabled = true;
            this.cboAnimais.Location = new System.Drawing.Point(61, 69);
            this.cboAnimais.Name = "cboAnimais";
            this.cboAnimais.Size = new System.Drawing.Size(158, 21);
            this.cboAnimais.TabIndex = 0;
            this.cboAnimais.SelectedIndexChanged += new System.EventHandler(this.cboAnimais_SelectedIndexChanged);
            // 
            // bntPatas
            // 
            this.bntPatas.Location = new System.Drawing.Point(61, 109);
            this.bntPatas.Name = "bntPatas";
            this.bntPatas.Size = new System.Drawing.Size(158, 23);
            this.bntPatas.TabIndex = 1;
            this.bntPatas.Text = "Mostrar Patas";
            this.bntPatas.UseVisualStyleBackColor = true;
            this.bntPatas.Click += new System.EventHandler(this.bntPatas_Click);
            // 
            // pctAnimais
            // 
            this.pctAnimais.Location = new System.Drawing.Point(47, 150);
            this.pctAnimais.Name = "pctAnimais";
            this.pctAnimais.Size = new System.Drawing.Size(188, 163);
            this.pctAnimais.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAnimais.TabIndex = 2;
            this.pctAnimais.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 340);
            this.Controls.Add(this.pctAnimais);
            this.Controls.Add(this.bntPatas);
            this.Controls.Add(this.cboAnimais);
            this.Name = "Form1";
            this.Text = "Animais";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctAnimais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAnimais;
        private System.Windows.Forms.Button bntPatas;
        private System.Windows.Forms.PictureBox pctAnimais;
    }
}

