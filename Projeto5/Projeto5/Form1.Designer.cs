namespace Projeto5
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
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblMed = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblSit = new System.Windows.Forms.Label();
            this.lblSituação = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(49, 23);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(39, 13);
            this.lblNota1.TabIndex = 0;
            this.lblNota1.Text = "Nota 1";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(49, 53);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(39, 13);
            this.lblNota2.TabIndex = 1;
            this.lblNota2.Text = "Nota 2";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(49, 83);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(39, 13);
            this.lblNota3.TabIndex = 2;
            this.lblNota3.Text = "Nota 3";
            // 
            // lblMed
            // 
            this.lblMed.AutoSize = true;
            this.lblMed.Location = new System.Drawing.Point(49, 129);
            this.lblMed.Name = "lblMed";
            this.lblMed.Size = new System.Drawing.Size(36, 13);
            this.lblMed.TabIndex = 3;
            this.lblMed.Text = "Média";
            this.lblMed.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(118, 129);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(35, 13);
            this.lblMedia.TabIndex = 4;
            this.lblMedia.Text = "media";
            // 
            // lblSit
            // 
            this.lblSit.AutoSize = true;
            this.lblSit.Location = new System.Drawing.Point(49, 153);
            this.lblSit.Name = "lblSit";
            this.lblSit.Size = new System.Drawing.Size(49, 13);
            this.lblSit.TabIndex = 5;
            this.lblSit.Text = "Situação";
            // 
            // lblSituação
            // 
            this.lblSituação.AutoSize = true;
            this.lblSituação.Location = new System.Drawing.Point(118, 153);
            this.lblSituação.Name = "lblSituação";
            this.lblSituação.Size = new System.Drawing.Size(49, 13);
            this.lblSituação.TabIndex = 6;
            this.lblSituação.Text = "Situação";
            this.lblSituação.Click += new System.EventHandler(this.lblSituação_Click);
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(121, 23);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 20);
            this.txtNota1.TabIndex = 7;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(121, 50);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 20);
            this.txtNota2.TabIndex = 8;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(121, 80);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 20);
            this.txtNota3.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(52, 201);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(186, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.lblSituação);
            this.Controls.Add(this.lblSit);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblMed);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNota1);
            this.Name = "Form1";
            this.Text = "Calcular Média";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblMed;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblSit;
        private System.Windows.Forms.Label lblSituação;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Button btnCalcular;
    }
}

