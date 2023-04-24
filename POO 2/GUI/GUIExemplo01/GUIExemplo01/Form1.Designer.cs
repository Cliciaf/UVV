namespace GUIExemplo01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblcontagemdecliques = new System.Windows.Forms.Label();
            this.lblcliques = new System.Windows.Forms.Label();
            this.buttonclique = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcontagemdecliques
            // 
            resources.ApplyResources(this.lblcontagemdecliques, "lblcontagemdecliques");
            this.lblcontagemdecliques.Name = "lblcontagemdecliques";
            this.lblcontagemdecliques.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblcliques
            // 
            resources.ApplyResources(this.lblcliques, "lblcliques");
            this.lblcliques.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblcliques.Name = "lblcliques";
            // 
            // buttonclique
            // 
            resources.ApplyResources(this.buttonclique, "buttonclique");
            this.buttonclique.Name = "buttonclique";
            this.buttonclique.UseVisualStyleBackColor = false;
            this.buttonclique.Click += new System.EventHandler(this.buttonclique_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonclique);
            this.Controls.Add(this.lblcliques);
            this.Controls.Add(this.lblcontagemdecliques);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcontagemdecliques;
        private System.Windows.Forms.Label lblcliques;
        private System.Windows.Forms.Button buttonclique;
        private System.Windows.Forms.Button button1;
    }
}

