namespace ProjetoSistema
{
    partial class PortalAcesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortalAcesso));
            this.PortalAdministrador = new System.Windows.Forms.Button();
            this.PortalUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PortalAdministrador
            // 
            this.PortalAdministrador.Location = new System.Drawing.Point(269, 430);
            this.PortalAdministrador.Name = "PortalAdministrador";
            this.PortalAdministrador.Size = new System.Drawing.Size(327, 61);
            this.PortalAdministrador.TabIndex = 0;
            this.PortalAdministrador.Text = "Portal do Administrador";
            this.PortalAdministrador.UseVisualStyleBackColor = true;
            this.PortalAdministrador.Click += new System.EventHandler(this.PortalAdministrador_Click);
            // 
            // PortalUsuario
            // 
            this.PortalUsuario.Location = new System.Drawing.Point(709, 430);
            this.PortalUsuario.Name = "PortalUsuario";
            this.PortalUsuario.Size = new System.Drawing.Size(328, 61);
            this.PortalUsuario.TabIndex = 1;
            this.PortalUsuario.Text = "Portal do Usuário";
            this.PortalUsuario.UseVisualStyleBackColor = true;
            this.PortalUsuario.Click += new System.EventHandler(this.PortalUsuario_Click);
            // 
            // PortalAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1317, 700);
            this.Controls.Add(this.PortalUsuario);
            this.Controls.Add(this.PortalAdministrador);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PortalAcesso";
            this.Text = "Portal de Acesso";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PortalAdministrador;
        private System.Windows.Forms.Button PortalUsuario;
    }
}