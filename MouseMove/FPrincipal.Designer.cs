namespace MouseMove
{
    partial class FPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPrincipal));
            this.BExecute = new System.Windows.Forms.Button();
            this.TQtdeVezes = new System.Windows.Forms.TextBox();
            this.LQuantidadeVezes = new System.Windows.Forms.Label();
            this.SStatus = new System.Windows.Forms.StatusStrip();
            this.SStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SStatusTecla = new System.Windows.Forms.ToolStripStatusLabel();
            this.BExit = new System.Windows.Forms.Button();
            this.SStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // BExecute
            // 
            this.BExecute.Location = new System.Drawing.Point(448, 13);
            this.BExecute.Name = "BExecute";
            this.BExecute.Size = new System.Drawing.Size(150, 85);
            this.BExecute.TabIndex = 0;
            this.BExecute.Text = "&Execute";
            this.BExecute.UseVisualStyleBackColor = true;
            this.BExecute.Click += new System.EventHandler(this.BExecute_Click);
            // 
            // TQtdeVezes
            // 
            this.TQtdeVezes.Location = new System.Drawing.Point(12, 35);
            this.TQtdeVezes.Name = "TQtdeVezes";
            this.TQtdeVezes.Size = new System.Drawing.Size(83, 22);
            this.TQtdeVezes.TabIndex = 1;
            this.TQtdeVezes.Text = "1";
            this.TQtdeVezes.TextChanged += new System.EventHandler(this.TQtdeVezes_TextChanged);
            // 
            // LQuantidadeVezes
            // 
            this.LQuantidadeVezes.AutoSize = true;
            this.LQuantidadeVezes.Location = new System.Drawing.Point(13, 13);
            this.LQuantidadeVezes.Name = "LQuantidadeVezes";
            this.LQuantidadeVezes.Size = new System.Drawing.Size(82, 17);
            this.LQuantidadeVezes.TabIndex = 2;
            this.LQuantidadeVezes.Text = "Qtde Vezes";
            // 
            // SStatus
            // 
            this.SStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SStatusLabel,
            this.SStatusTecla});
            this.SStatus.Location = new System.Drawing.Point(0, 205);
            this.SStatus.Name = "SStatus";
            this.SStatus.Size = new System.Drawing.Size(620, 26);
            this.SStatus.TabIndex = 5;
            this.SStatus.Text = "SStatus";
            // 
            // SStatusLabel
            // 
            this.SStatusLabel.Name = "SStatusLabel";
            this.SStatusLabel.Size = new System.Drawing.Size(105, 20);
            this.SStatusLabel.Text = "Status: Parado.";
            // 
            // SStatusTecla
            // 
            this.SStatusTecla.Name = "SStatusTecla";
            this.SStatusTecla.Size = new System.Drawing.Size(0, 20);
            // 
            // BExit
            // 
            this.BExit.Location = new System.Drawing.Point(448, 105);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(150, 94);
            this.BExit.TabIndex = 4;
            this.BExit.Text = "&Exit";
            this.BExit.UseVisualStyleBackColor = true;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 231);
            this.Controls.Add(this.SStatus);
            this.Controls.Add(this.BExit);
            this.Controls.Add(this.LQuantidadeVezes);
            this.Controls.Add(this.TQtdeVezes);
            this.Controls.Add(this.BExecute);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mouse Move 1.0";
            this.SStatus.ResumeLayout(false);
            this.SStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BExecute;
        private System.Windows.Forms.TextBox TQtdeVezes;
        private System.Windows.Forms.Label LQuantidadeVezes;
        private System.Windows.Forms.StatusStrip SStatus;
        private System.Windows.Forms.ToolStripStatusLabel SStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel SStatusTecla;
        private System.Windows.Forms.Button BExit;
    }
}

