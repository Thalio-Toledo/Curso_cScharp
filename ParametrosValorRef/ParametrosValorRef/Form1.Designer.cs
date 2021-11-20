namespace ParametrosValorRef
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
            this.lblVarA = new System.Windows.Forms.Label();
            this.lblVarB = new System.Windows.Forms.Label();
            this.lblResA = new System.Windows.Forms.Label();
            this.lblResB = new System.Windows.Forms.Label();
            this.txtVarA = new System.Windows.Forms.TextBox();
            this.txtVarB = new System.Windows.Forms.TextBox();
            this.txtResA = new System.Windows.Forms.TextBox();
            this.txtResB = new System.Windows.Forms.TextBox();
            this.btnValor = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVarA
            // 
            this.lblVarA.AutoSize = true;
            this.lblVarA.Location = new System.Drawing.Point(13, 33);
            this.lblVarA.Name = "lblVarA";
            this.lblVarA.Size = new System.Drawing.Size(55, 13);
            this.lblVarA.TabIndex = 0;
            this.lblVarA.Text = "Variável A";
            // 
            // lblVarB
            // 
            this.lblVarB.AutoSize = true;
            this.lblVarB.Location = new System.Drawing.Point(13, 62);
            this.lblVarB.Name = "lblVarB";
            this.lblVarB.Size = new System.Drawing.Size(55, 13);
            this.lblVarB.TabIndex = 1;
            this.lblVarB.Text = "Variável B";
            // 
            // lblResA
            // 
            this.lblResA.AutoSize = true;
            this.lblResA.Location = new System.Drawing.Point(13, 187);
            this.lblResA.Name = "lblResA";
            this.lblResA.Size = new System.Drawing.Size(55, 13);
            this.lblResA.TabIndex = 2;
            this.lblResA.Text = "Variável A";
            // 
            // lblResB
            // 
            this.lblResB.AutoSize = true;
            this.lblResB.Location = new System.Drawing.Point(12, 222);
            this.lblResB.Name = "lblResB";
            this.lblResB.Size = new System.Drawing.Size(55, 13);
            this.lblResB.TabIndex = 3;
            this.lblResB.Text = "Variável B";
            // 
            // txtVarA
            // 
            this.txtVarA.Location = new System.Drawing.Point(109, 33);
            this.txtVarA.Name = "txtVarA";
            this.txtVarA.Size = new System.Drawing.Size(100, 20);
            this.txtVarA.TabIndex = 4;
            // 
            // txtVarB
            // 
            this.txtVarB.Location = new System.Drawing.Point(109, 59);
            this.txtVarB.Name = "txtVarB";
            this.txtVarB.Size = new System.Drawing.Size(100, 20);
            this.txtVarB.TabIndex = 5;
            // 
            // txtResA
            // 
            this.txtResA.Location = new System.Drawing.Point(109, 185);
            this.txtResA.Name = "txtResA";
            this.txtResA.Size = new System.Drawing.Size(100, 20);
            this.txtResA.TabIndex = 6;
            // 
            // txtResB
            // 
            this.txtResB.Location = new System.Drawing.Point(109, 215);
            this.txtResB.Name = "txtResB";
            this.txtResB.Size = new System.Drawing.Size(100, 20);
            this.txtResB.TabIndex = 7;
            // 
            // btnValor
            // 
            this.btnValor.Location = new System.Drawing.Point(40, 114);
            this.btnValor.Name = "btnValor";
            this.btnValor.Size = new System.Drawing.Size(75, 23);
            this.btnValor.TabIndex = 8;
            this.btnValor.Text = "Por Valor";
            this.btnValor.UseVisualStyleBackColor = true;
            this.btnValor.Click += new System.EventHandler(this.btnValor_Click);
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(134, 114);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(106, 23);
            this.btnRef.TabIndex = 9;
            this.btnRef.Text = "Por Referência";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.btnValor);
            this.Controls.Add(this.txtResB);
            this.Controls.Add(this.txtResA);
            this.Controls.Add(this.txtVarB);
            this.Controls.Add(this.txtVarA);
            this.Controls.Add(this.lblResB);
            this.Controls.Add(this.lblResA);
            this.Controls.Add(this.lblVarB);
            this.Controls.Add(this.lblVarA);
            this.Name = "Form1";
            this.Text = "Valor / Referência";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVarA;
        private System.Windows.Forms.Label lblVarB;
        private System.Windows.Forms.Label lblResA;
        private System.Windows.Forms.Label lblResB;
        private System.Windows.Forms.TextBox txtVarA;
        private System.Windows.Forms.TextBox txtVarB;
        private System.Windows.Forms.TextBox txtResA;
        private System.Windows.Forms.TextBox txtResB;
        private System.Windows.Forms.Button btnValor;
        private System.Windows.Forms.Button btnRef;
    }
}

