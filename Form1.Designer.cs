namespace WindowsFormsApp1
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.BotaoProsseguir1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotaoProsseguir1
            // 
            this.BotaoProsseguir1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BotaoProsseguir1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BotaoProsseguir1.Location = new System.Drawing.Point(532, 534);
            this.BotaoProsseguir1.Name = "BotaoProsseguir1";
            this.BotaoProsseguir1.Size = new System.Drawing.Size(284, 100);
            this.BotaoProsseguir1.TabIndex = 0;
            this.BotaoProsseguir1.Text = "Prosseguir";
            this.BotaoProsseguir1.UseVisualStyleBackColor = true;
            this.BotaoProsseguir1.Click += new System.EventHandler(this.BotaoProsseguir1_Click);
            // 
            // TelaInicial
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1320, 696);
            this.Controls.Add(this.BotaoProsseguir1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaInicial";
            this.Text = "Tela Inical";
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BotaoProsseguir1;
    }
}

