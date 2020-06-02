namespace ApiWindows
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolPrincipal = new System.Windows.Forms.ToolStrip();
            this.TBtExit = new System.Windows.Forms.ToolStripButton();
            this.TbControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SToolStatus = new System.Windows.Forms.StatusStrip();
            this.TssThredInit = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainMenu.SuspendLayout();
            this.ToolPrincipal.SuspendLayout();
            this.TbControlPrincipal.SuspendLayout();
            this.SToolStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(962, 28);
            this.MainMenu.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // ToolPrincipal
            // 
            this.ToolPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TBtExit});
            this.ToolPrincipal.Location = new System.Drawing.Point(0, 28);
            this.ToolPrincipal.Name = "ToolPrincipal";
            this.ToolPrincipal.Size = new System.Drawing.Size(962, 27);
            this.ToolPrincipal.TabIndex = 2;
            // 
            // TBtExit
            // 
            this.TBtExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBtExit.Image = ((System.Drawing.Image)(resources.GetObject("TBtExit.Image")));
            this.TBtExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBtExit.Name = "TBtExit";
            this.TBtExit.Size = new System.Drawing.Size(29, 24);
            this.TBtExit.Text = "Exit";
            // 
            // TbControlPrincipal
            // 
            this.TbControlPrincipal.Controls.Add(this.tabPage1);
            this.TbControlPrincipal.Controls.Add(this.tabPage2);
            this.TbControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbControlPrincipal.Location = new System.Drawing.Point(0, 55);
            this.TbControlPrincipal.Name = "TbControlPrincipal";
            this.TbControlPrincipal.SelectedIndex = 0;
            this.TbControlPrincipal.Size = new System.Drawing.Size(962, 331);
            this.TbControlPrincipal.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(954, 302);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(751, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SToolStatus
            // 
            this.SToolStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SToolStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TssThredInit});
            this.SToolStatus.Location = new System.Drawing.Point(0, 364);
            this.SToolStatus.Name = "SToolStatus";
            this.SToolStatus.Size = new System.Drawing.Size(962, 22);
            this.SToolStatus.TabIndex = 4;
            // 
            // TssThredInit
            // 
            this.TssThredInit.Name = "TssThredInit";
            this.TssThredInit.Size = new System.Drawing.Size(0, 18);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 386);
            this.Controls.Add(this.SToolStatus);
            this.Controls.Add(this.TbControlPrincipal);
            this.Controls.Add(this.ToolPrincipal);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "FPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solucao Estudos API Windows";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FPrincipal_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ToolPrincipal.ResumeLayout(false);
            this.ToolPrincipal.PerformLayout();
            this.TbControlPrincipal.ResumeLayout(false);
            this.SToolStatus.ResumeLayout(false);
            this.SToolStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ToolPrincipal;
        private System.Windows.Forms.ToolStripButton TBtExit;
        private System.Windows.Forms.TabControl TbControlPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip SToolStatus;
        private System.Windows.Forms.ToolStripStatusLabel TssThredInit;
    }
}

