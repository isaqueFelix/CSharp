namespace Artigos
{
    partial class Artigos
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEnviarFinal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnCadastrar.Location = new System.Drawing.Point(12, 12);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(127, 120);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar Artigo";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnConsultar.Location = new System.Drawing.Point(148, 12);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(127, 120);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar Status";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnEnviarFinal
            // 
            this.btnEnviarFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnEnviarFinal.Location = new System.Drawing.Point(281, 12);
            this.btnEnviarFinal.Name = "btnEnviarFinal";
            this.btnEnviarFinal.Size = new System.Drawing.Size(127, 120);
            this.btnEnviarFinal.TabIndex = 2;
            this.btnEnviarFinal.Text = "Enviar Artigo Final";
            this.btnEnviarFinal.UseVisualStyleBackColor = true;
            // 
            // Artigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 144);
            this.Controls.Add(this.btnEnviarFinal);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "Artigos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artigos";
            this.Load += new System.EventHandler(this.Artigos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEnviarFinal;
    }
}