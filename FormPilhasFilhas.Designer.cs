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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxFilaEstatica = new System.Windows.Forms.TextBox();
            this.textBoxDataFilaEstatica = new System.Windows.Forms.TextBox();
            this.buttonEnqueueFilaEstatica = new System.Windows.Forms.Button();
            this.buttonDequeueFilaEstatica = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxFilaDinamica = new System.Windows.Forms.TextBox();
            this.textBoxDataFilaDinamica = new System.Windows.Forms.TextBox();
            this.buttonEnqueueFilaDinamica = new System.Windows.Forms.Button();
            this.buttonDequeueFilaDinamica = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.buttonPushPilhaDinamica.Click += new System.EventHandler(this.buttonPushPilhaDinamica_Click);
            // 
            // buttonPopPilhaDinamica
            // 
            this.buttonPopPilhaDinamica.Location = new System.Drawing.Point(112, 51);
            this.buttonPopPilhaDinamica.Name = "buttonPopPilhaDinamica";
            this.buttonPopPilhaDinamica.Size = new System.Drawing.Size(75, 23);
            this.buttonPopPilhaDinamica.TabIndex = 3;
            this.buttonPopPilhaDinamica.Text = "Remove";
            this.buttonPopPilhaDinamica.UseVisualStyleBackColor = true;
            this.buttonPopPilhaDinamica.Click += new System.EventHandler(this.buttonPopPilhaDinamica_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxFilaEstatica);
            this.groupBox3.Controls.Add(this.textBoxDataFilaEstatica);
            this.groupBox3.Controls.Add(this.buttonEnqueueFilaEstatica);
            this.groupBox3.Controls.Add(this.buttonDequeueFilaEstatica);
            this.groupBox3.Location = new System.Drawing.Point(412, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(194, 457);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fila Estática";
            // 
            // textBoxFilaEstatica
            // 
            this.textBoxFilaEstatica.Location = new System.Drawing.Point(6, 22);
            this.textBoxFilaEstatica.Name = "textBoxFilaEstatica";
            this.textBoxFilaEstatica.Size = new System.Drawing.Size(181, 23);
            this.textBoxFilaEstatica.TabIndex = 1;
            // 
            // textBoxDataFilaEstatica
            // 
            this.textBoxDataFilaEstatica.Enabled = false;
            this.textBoxDataFilaEstatica.Location = new System.Drawing.Point(6, 80);
            this.textBoxDataFilaEstatica.Multiline = true;
            this.textBoxDataFilaEstatica.Name = "textBoxDataFilaEstatica";
            this.textBoxDataFilaEstatica.Size = new System.Drawing.Size(181, 368);
            this.textBoxDataFilaEstatica.TabIndex = 4;
            // 
            // buttonEnqueueFilaEstatica
            // 
            this.buttonEnqueueFilaEstatica.Location = new System.Drawing.Point(6, 51);
            this.buttonEnqueueFilaEstatica.Name = "buttonEnqueueFilaEstatica";
            this.buttonEnqueueFilaEstatica.Size = new System.Drawing.Size(75, 23);
            this.buttonEnqueueFilaEstatica.TabIndex = 2;
            this.buttonEnqueueFilaEstatica.Text = "Adiciona";
            this.buttonEnqueueFilaEstatica.UseVisualStyleBackColor = true;
            this.buttonEnqueueFilaEstatica.Click += new System.EventHandler(this.buttonEnqueueFilaEstatica_Click);
            // 
            // buttonDequeueFilaEstatica
            // 
            this.buttonDequeueFilaEstatica.Location = new System.Drawing.Point(112, 51);
            this.buttonDequeueFilaEstatica.Name = "buttonDequeueFilaEstatica";
            this.buttonDequeueFilaEstatica.Size = new System.Drawing.Size(75, 23);
            this.buttonDequeueFilaEstatica.TabIndex = 3;
            this.buttonDequeueFilaEstatica.Text = "Remove";
            this.buttonDequeueFilaEstatica.UseVisualStyleBackColor = true;
            this.buttonDequeueFilaEstatica.Click += new System.EventHandler(this.buttonDequeueFilaEstatica_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxFilaDinamica);
            this.groupBox4.Controls.Add(this.textBoxDataFilaDinamica);
            this.groupBox4.Controls.Add(this.buttonEnqueueFilaDinamica);
            this.groupBox4.Controls.Add(this.buttonDequeueFilaDinamica);
            this.groupBox4.Location = new System.Drawing.Point(612, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(194, 457);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fila Dinamica";
            // 
            // textBoxFilaDinamica
            // 
            this.textBoxFilaDinamica.Location = new System.Drawing.Point(6, 22);
            this.textBoxFilaDinamica.Name = "textBoxFilaDinamica";
            this.textBoxFilaDinamica.Size = new System.Drawing.Size(181, 23);
            this.textBoxFilaDinamica.TabIndex = 1;
            // 
            // textBoxDataFilaDinamica
            // 
            this.textBoxDataFilaDinamica.Enabled = false;
            this.textBoxDataFilaDinamica.Location = new System.Drawing.Point(6, 80);
            this.textBoxDataFilaDinamica.Multiline = true;
            this.textBoxDataFilaDinamica.Name = "textBoxDataFilaDinamica";
            this.textBoxDataFilaDinamica.Size = new System.Drawing.Size(181, 368);
            this.textBoxDataFilaDinamica.TabIndex = 4;
            // 
            // buttonEnqueueFilaDinamica
            // 
            this.buttonEnqueueFilaDinamica.Location = new System.Drawing.Point(6, 51);
            this.buttonEnqueueFilaDinamica.Name = "buttonEnqueueFilaDinamica";
            this.buttonEnqueueFilaDinamica.Size = new System.Drawing.Size(75, 23);
            this.buttonEnqueueFilaDinamica.TabIndex = 2;
            this.buttonEnqueueFilaDinamica.Text = "Adiciona";
            this.buttonEnqueueFilaDinamica.UseVisualStyleBackColor = true;
            // 
            // buttonDequeueFilaDinamica
            // 
            this.buttonDequeueFilaDinamica.Location = new System.Drawing.Point(112, 51);
            this.buttonDequeueFilaDinamica.Name = "buttonDequeueFilaDinamica";
            this.buttonDequeueFilaDinamica.Size = new System.Drawing.Size(75, 23);
            this.buttonDequeueFilaDinamica.TabIndex = 3;
            this.buttonDequeueFilaDinamica.Text = "Remove";
            this.buttonDequeueFilaDinamica.UseVisualStyleBackColor = true;
            // 
            // FormPilhasFilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 479);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPilhasFilas";
            this.Text = "Pilhas e Filas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxFilaEstatica;
        private System.Windows.Forms.TextBox textBoxDataFilaEstatica;
        private System.Windows.Forms.Button buttonEnqueueFilaEstatica;
        private System.Windows.Forms.Button buttonDequeueFilaEstatica;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxFilaDinamica;
        private System.Windows.Forms.TextBox textBoxDataFilaDinamica;
        private System.Windows.Forms.Button buttonEnqueueFilaDinamica;
        private System.Windows.Forms.Button buttonDequeueFilaDinamica;
    }
}
