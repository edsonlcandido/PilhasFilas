namespace PilhasFilas
{
    partial class FormPilhasFilas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxInputPilhaEstatica = new System.Windows.Forms.TextBox();
            this.buttonPushPilhaEstatica = new System.Windows.Forms.Button();
            this.buttonPopPilhaEstatica = new System.Windows.Forms.Button();
            this.textBoxDataPilhaEstatica = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxPilhaDinamica = new System.Windows.Forms.TextBox();
            this.textBoxDataPilhaDinamica = new System.Windows.Forms.TextBox();
            this.buttonPushPilhaDinamica = new System.Windows.Forms.Button();
            this.buttonPopPilhaDinamica = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxInputPilhaEstatica
            // 
            this.textBoxInputPilhaEstatica.Location = new System.Drawing.Point(6, 22);
            this.textBoxInputPilhaEstatica.Name = "textBoxInputPilhaEstatica";
            this.textBoxInputPilhaEstatica.Size = new System.Drawing.Size(181, 23);
            this.textBoxInputPilhaEstatica.TabIndex = 1;
            // 
            // buttonPushPilhaEstatica
            // 
            this.buttonPushPilhaEstatica.Location = new System.Drawing.Point(6, 51);
            this.buttonPushPilhaEstatica.Name = "buttonPushPilhaEstatica";
            this.buttonPushPilhaEstatica.Size = new System.Drawing.Size(75, 23);
            this.buttonPushPilhaEstatica.TabIndex = 2;
            this.buttonPushPilhaEstatica.Text = "Adiciona";
            this.buttonPushPilhaEstatica.UseVisualStyleBackColor = true;
            this.buttonPushPilhaEstatica.Click += new System.EventHandler(this.buttonPushPilhaEstatica_Click);
            // 
            // buttonPopPilhaEstatica
            // 
            this.buttonPopPilhaEstatica.Location = new System.Drawing.Point(112, 51);
            this.buttonPopPilhaEstatica.Name = "buttonPopPilhaEstatica";
            this.buttonPopPilhaEstatica.Size = new System.Drawing.Size(75, 23);
            this.buttonPopPilhaEstatica.TabIndex = 3;
            this.buttonPopPilhaEstatica.Text = "Remove";
            this.buttonPopPilhaEstatica.UseVisualStyleBackColor = true;
            this.buttonPopPilhaEstatica.Click += new System.EventHandler(this.buttonPopPilhaEstatica_Click);
            // 
            // textBoxDataPilhaEstatica
            // 
            this.textBoxDataPilhaEstatica.Enabled = false;
            this.textBoxDataPilhaEstatica.Location = new System.Drawing.Point(6, 80);
            this.textBoxDataPilhaEstatica.Multiline = true;
            this.textBoxDataPilhaEstatica.Name = "textBoxDataPilhaEstatica";
            this.textBoxDataPilhaEstatica.Size = new System.Drawing.Size(181, 368);
            this.textBoxDataPilhaEstatica.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxInputPilhaEstatica);
            this.groupBox1.Controls.Add(this.textBoxDataPilhaEstatica);
            this.groupBox1.Controls.Add(this.buttonPushPilhaEstatica);
            this.groupBox1.Controls.Add(this.buttonPopPilhaEstatica);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 457);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilha Estática";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxPilhaDinamica);
            this.groupBox2.Controls.Add(this.textBoxDataPilhaDinamica);
            this.groupBox2.Controls.Add(this.buttonPushPilhaDinamica);
            this.groupBox2.Controls.Add(this.buttonPopPilhaDinamica);
            this.groupBox2.Location = new System.Drawing.Point(212, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 457);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pilha Dinamica";
            // 
            // textBoxPilhaDinamica
            // 
            this.textBoxPilhaDinamica.Location = new System.Drawing.Point(6, 22);
            this.textBoxPilhaDinamica.Name = "textBoxPilhaDinamica";
            this.textBoxPilhaDinamica.Size = new System.Drawing.Size(181, 23);
            this.textBoxPilhaDinamica.TabIndex = 1;
            // 
            // textBoxDataPilhaDinamica
            // 
            this.textBoxDataPilhaDinamica.Enabled = false;
            this.textBoxDataPilhaDinamica.Location = new System.Drawing.Point(6, 80);
            this.textBoxDataPilhaDinamica.Multiline = true;
            this.textBoxDataPilhaDinamica.Name = "textBoxDataPilhaDinamica";
            this.textBoxDataPilhaDinamica.Size = new System.Drawing.Size(181, 368);
            this.textBoxDataPilhaDinamica.TabIndex = 4;
            // 
            // buttonPushPilhaDinamica
            // 
            this.buttonPushPilhaDinamica.Location = new System.Drawing.Point(6, 51);
            this.buttonPushPilhaDinamica.Name = "buttonPushPilhaDinamica";
            this.buttonPushPilhaDinamica.Size = new System.Drawing.Size(75, 23);
            this.buttonPushPilhaDinamica.TabIndex = 2;
            this.buttonPushPilhaDinamica.Text = "Adiciona";
            this.buttonPushPilhaDinamica.UseVisualStyleBackColor = true;
            // 
            // buttonPopPilhaDinamica
            // 
            this.buttonPopPilhaDinamica.Location = new System.Drawing.Point(112, 51);
            this.buttonPopPilhaDinamica.Name = "buttonPopPilhaDinamica";
            this.buttonPopPilhaDinamica.Size = new System.Drawing.Size(75, 23);
            this.buttonPopPilhaDinamica.TabIndex = 3;
            this.buttonPopPilhaDinamica.Text = "Remove";
            this.buttonPopPilhaDinamica.UseVisualStyleBackColor = true;
            // 
            // FormPilhasFilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPilhasFilas";
            this.Text = "Pilhas e Filas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxInputPilhaEstatica;
        private System.Windows.Forms.Button buttonPushPilhaEstatica;
        private System.Windows.Forms.Button buttonPopPilhaEstatica;
        private System.Windows.Forms.TextBox textBoxDataPilhaEstatica;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxPilhaDinamica;
        private System.Windows.Forms.TextBox textBoxDataPilhaDinamica;
        private System.Windows.Forms.Button buttonPushPilhaDinamica;
        private System.Windows.Forms.Button buttonPopPilhaDinamica;
    }
}
