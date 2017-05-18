namespace Artigos
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnRevisao = new System.Windows.Forms.Button();
            this.btnArtigos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "login.png");
            // 
            // btnRevisao
            // 
            this.btnRevisao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRevisao.Enabled = false;
            this.btnRevisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevisao.Image = global::Artigos.Properties.Resources.iconUser;
            this.btnRevisao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRevisao.Location = new System.Drawing.Point(240, 41);
            this.btnRevisao.Name = "btnRevisao";
            this.btnRevisao.Size = new System.Drawing.Size(93, 81);
            this.btnRevisao.TabIndex = 2;
            this.btnRevisao.Text = "Revisão";
            this.btnRevisao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRevisao.UseVisualStyleBackColor = true;
            // 
            // btnArtigos
            // 
            this.btnArtigos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArtigos.Enabled = false;
            this.btnArtigos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtigos.Image = ((System.Drawing.Image)(resources.GetObject("btnArtigos.Image")));
            this.btnArtigos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnArtigos.Location = new System.Drawing.Point(141, 41);
            this.btnArtigos.Name = "btnArtigos";
            this.btnArtigos.Size = new System.Drawing.Size(93, 81);
            this.btnArtigos.TabIndex = 1;
            this.btnArtigos.Text = "Artigos";
            this.btnArtigos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnArtigos.UseVisualStyleBackColor = true;
            this.btnArtigos.Click += new System.EventHandler(this.btnArtigos_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Artigos.Properties.Resources.iconUser;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(42, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "Usuários";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 467);
            this.Controls.Add(this.btnRevisao);
            this.Controls.Add(this.btnArtigos);
            this.Controls.Add(this.button1);
            this.Name = "Dashboard";
            this.Text = "Cadastrar artigos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnArtigos;
        private System.Windows.Forms.Button btnRevisao;
    }
}

