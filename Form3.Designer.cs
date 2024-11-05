namespace ProjetoSistema
{
    partial class PortalADM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortalADM));
            this.CampoUsuario = new System.Windows.Forms.TextBox();
            this.CampoSenha = new System.Windows.Forms.TextBox();
            this.BotaoEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CampoUsuario
            // 
            this.CampoUsuario.Location = new System.Drawing.Point(423, 358);
            this.CampoUsuario.Name = "CampoUsuario";
            this.CampoUsuario.Size = new System.Drawing.Size(477, 20);
            this.CampoUsuario.TabIndex = 0;
            this.CampoUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CampoSenha
            // 
            this.CampoSenha.Location = new System.Drawing.Point(423, 442);
            this.CampoSenha.Name = "CampoSenha";
            this.CampoSenha.Size = new System.Drawing.Size(477, 20);
            this.CampoSenha.TabIndex = 1;
            // 
            // BotaoEntrar
            // 
            this.BotaoEntrar.Location = new System.Drawing.Point(556, 488);
            this.BotaoEntrar.Name = "BotaoEntrar";
            this.BotaoEntrar.Size = new System.Drawing.Size(211, 46);
            this.BotaoEntrar.TabIndex = 2;
            this.BotaoEntrar.Text = "Entrar";
            this.BotaoEntrar.UseVisualStyleBackColor = true;
            this.BotaoEntrar.Click += new System.EventHandler(this.BotaoEntrar_Click);
            // 
            // PortalADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1324, 735);
            this.Controls.Add(this.BotaoEntrar);
            this.Controls.Add(this.CampoSenha);
            this.Controls.Add(this.CampoUsuario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PortalADM";
            this.Text = "Portal do Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CampoUsuario;
        private System.Windows.Forms.TextBox CampoSenha;
        private System.Windows.Forms.Button BotaoEntrar;
    }
}