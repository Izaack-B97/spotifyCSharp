namespace spotifyMark1.Vistas
{
    partial class AgregaEditaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregaEditaUsuario));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.botGuardar = new System.Windows.Forms.ToolStripButton();
            this.botCancelar = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botGuardar,
            this.botCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(208, 25);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // botGuardar
            // 
            this.botGuardar.Image = ((System.Drawing.Image)(resources.GetObject("botGuardar.Image")));
            this.botGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botGuardar.Name = "botGuardar";
            this.botGuardar.Size = new System.Drawing.Size(69, 22);
            this.botGuardar.Text = "Guardar";
            this.botGuardar.Click += new System.EventHandler(this.botGuardar_Click);
            // 
            // botCancelar
            // 
            this.botCancelar.Image = ((System.Drawing.Image)(resources.GetObject("botCancelar.Image")));
            this.botCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botCancelar.Name = "botCancelar";
            this.botCancelar.Size = new System.Drawing.Size(73, 22);
            this.botCancelar.Text = "Cancelar";
            this.botCancelar.Click += new System.EventHandler(this.botCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "IDUsuario:";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(86, 101);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(62, 17);
            this.chkActivo.TabIndex = 32;
            this.chkActivo.Text = "Activo?";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 31;
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.Location = new System.Drawing.Point(86, 49);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.ReadOnly = true;
            this.txtIDUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtIDUsuario.TabIndex = 30;
            // 
            // AgregaEditaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 185);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIDUsuario);
            this.Name = "AgregaEditaUsuario";
            this.Text = "AgregaEditaUsuario";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton botGuardar;
        private System.Windows.Forms.ToolStripButton botCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIDUsuario;
    }
}