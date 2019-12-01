namespace spotifyMark1
{
    partial class mainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainScreen));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCanciones = new System.Windows.Forms.ToolStripButton();
            this.btnAlbumes = new System.Windows.Forms.ToolStripButton();
            this.btnArtistas = new System.Windows.Forms.ToolStripButton();
            this.btnGeneros = new System.Windows.Forms.ToolStripButton();
            this.btnUsuarios = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCanciones,
            this.btnAlbumes,
            this.btnArtistas,
            this.btnGeneros,
            this.btnUsuarios});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCanciones
            // 
            this.btnCanciones.Image = ((System.Drawing.Image)(resources.GetObject("btnCanciones.Image")));
            this.btnCanciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCanciones.Name = "btnCanciones";
            this.btnCanciones.Size = new System.Drawing.Size(82, 22);
            this.btnCanciones.Text = "Canciones";
            this.btnCanciones.Click += new System.EventHandler(this.btnCanciones_Click_1);
            // 
            // btnAlbumes
            // 
            this.btnAlbumes.Image = ((System.Drawing.Image)(resources.GetObject("btnAlbumes.Image")));
            this.btnAlbumes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlbumes.Name = "btnAlbumes";
            this.btnAlbumes.Size = new System.Drawing.Size(74, 22);
            this.btnAlbumes.Text = "Álbumes";
            this.btnAlbumes.Click += new System.EventHandler(this.btnAlbumes_Click);
            // 
            // btnArtistas
            // 
            this.btnArtistas.Image = ((System.Drawing.Image)(resources.GetObject("btnArtistas.Image")));
            this.btnArtistas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnArtistas.Name = "btnArtistas";
            this.btnArtistas.Size = new System.Drawing.Size(66, 22);
            this.btnArtistas.Text = "Artistas";
            this.btnArtistas.Click += new System.EventHandler(this.btnArtistas_Click);
            // 
            // btnGeneros
            // 
            this.btnGeneros.Image = ((System.Drawing.Image)(resources.GetObject("btnGeneros.Image")));
            this.btnGeneros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGeneros.Name = "btnGeneros";
            this.btnGeneros.Size = new System.Drawing.Size(70, 22);
            this.btnGeneros.Text = "Géneros";
            this.btnGeneros.Click += new System.EventHandler(this.btnGeneros_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(72, 22);
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // mainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "mainScreen";
            this.Text = "mainScreen";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAlbumes;
        private System.Windows.Forms.ToolStripButton btnArtistas;
        private System.Windows.Forms.ToolStripButton btnGeneros;
        private System.Windows.Forms.ToolStripButton btnUsuarios;
        private System.Windows.Forms.ToolStripButton btnCanciones;
    }
}