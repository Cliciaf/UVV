namespace Agenda_telefonica
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
            this.lblagentatelefonica = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbnome = new System.Windows.Forms.TextBox();
            this.txbsobrenome = new System.Windows.Forms.TextBox();
            this.txbddd = new System.Windows.Forms.TextBox();
            this.txbnumero = new System.Windows.Forms.TextBox();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblagentatelefonica
            // 
            this.lblagentatelefonica.AutoSize = true;
            this.lblagentatelefonica.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblagentatelefonica.Location = new System.Drawing.Point(95, 35);
            this.lblagentatelefonica.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblagentatelefonica.Name = "lblagentatelefonica";
            this.lblagentatelefonica.Size = new System.Drawing.Size(240, 31);
            this.lblagentatelefonica.TabIndex = 0;
            this.lblagentatelefonica.Text = "Agenda Telefonica";
            this.lblagentatelefonica.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sobrenome:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefone:";
            // 
            // txbnome
            // 
            this.txbnome.Location = new System.Drawing.Point(160, 105);
            this.txbnome.Multiline = true;
            this.txbnome.Name = "txbnome";
            this.txbnome.Size = new System.Drawing.Size(217, 22);
            this.txbnome.TabIndex = 4;
            // 
            // txbsobrenome
            // 
            this.txbsobrenome.Location = new System.Drawing.Point(160, 144);
            this.txbsobrenome.Multiline = true;
            this.txbsobrenome.Name = "txbsobrenome";
            this.txbsobrenome.Size = new System.Drawing.Size(217, 22);
            this.txbsobrenome.TabIndex = 5;
            // 
            // txbddd
            // 
            this.txbddd.Location = new System.Drawing.Point(160, 185);
            this.txbddd.Multiline = true;
            this.txbddd.Name = "txbddd";
            this.txbddd.Size = new System.Drawing.Size(57, 22);
            this.txbddd.TabIndex = 6;
            // 
            // txbnumero
            // 
            this.txbnumero.Location = new System.Drawing.Point(247, 185);
            this.txbnumero.Multiline = true;
            this.txbnumero.Name = "txbnumero";
            this.txbnumero.Size = new System.Drawing.Size(130, 22);
            this.txbnumero.TabIndex = 7;
            // 
            // btnadicionar
            // 
            this.btnadicionar.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadicionar.Location = new System.Drawing.Point(247, 232);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(131, 30);
            this.btnadicionar.TabIndex = 8;
            this.btnadicionar.Text = "adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 350);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.txbnumero);
            this.Controls.Add(this.txbddd);
            this.Controls.Add(this.txbsobrenome);
            this.Controls.Add(this.txbnome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblagentatelefonica);
            this.Font = new System.Drawing.Font("Monospac821 BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblagentatelefonica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbnome;
        private System.Windows.Forms.TextBox txbsobrenome;
        private System.Windows.Forms.TextBox txbddd;
        private System.Windows.Forms.TextBox txbnumero;
        private System.Windows.Forms.Button btnadicionar;
    }
}

