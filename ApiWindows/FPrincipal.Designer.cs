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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPrincipal));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolPrincipal = new System.Windows.Forms.ToolStrip();
            this.TBtExit = new System.Windows.Forms.ToolStripButton();
            this.TbControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbIsChild = new System.Windows.Forms.Label();
            this.TxtIsChild = new System.Windows.Forms.TextBox();
            this.LbParentWindow = new System.Windows.Forms.Label();
            this.TxtParentWindow = new System.Windows.Forms.TextBox();
            this.LbClientToScreem = new System.Windows.Forms.Label();
            this.TxtClientToScreem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtScreemToClient = new System.Windows.Forms.TextBox();
            this.Window = new System.Windows.Forms.Label();
            this.TxtWindow = new System.Windows.Forms.TextBox();
            this.LbWindowPoint = new System.Windows.Forms.Label();
            this.TxtWindowPoint = new System.Windows.Forms.TextBox();
            this.TxtMousePosition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TxtGetWindow = new System.Windows.Forms.TextBox();
            this.LGetWindow = new System.Windows.Forms.Label();
            this.TxtRectangle = new System.Windows.Forms.TextBox();
            this.LbRectangle = new System.Windows.Forms.Label();
            this.LbContextoDC = new System.Windows.Forms.Label();
            this.TxtContextoDC = new System.Windows.Forms.TextBox();
            this.TxtLenght = new System.Windows.Forms.TextBox();
            this.LLength = new System.Windows.Forms.Label();
            this.LTextWindow = new System.Windows.Forms.Label();
            this.txtTextWindow = new System.Windows.Forms.TextBox();
            this.LbClassNama = new System.Windows.Forms.Label();
            this.TxtClassName = new System.Windows.Forms.TextBox();
            this.TxtControlFocus = new System.Windows.Forms.TextBox();
            this.LControlFocus = new System.Windows.Forms.Label();
            this.TListemKey = new System.Windows.Forms.Timer(this.components);
            this.MainMenu.SuspendLayout();
            this.ToolPrincipal.SuspendLayout();
            this.TbControlPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(782, 30);
            this.MainMenu.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ToolPrincipal
            // 
            this.ToolPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TBtExit});
            this.ToolPrincipal.Location = new System.Drawing.Point(0, 30);
            this.ToolPrincipal.Name = "ToolPrincipal";
            this.ToolPrincipal.Size = new System.Drawing.Size(782, 31);
            this.ToolPrincipal.TabIndex = 2;
            // 
            // TBtExit
            // 
            this.TBtExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBtExit.Image = ((System.Drawing.Image)(resources.GetObject("TBtExit.Image")));
            this.TBtExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBtExit.Name = "TBtExit";
            this.TBtExit.Size = new System.Drawing.Size(29, 28);
            this.TBtExit.Text = "Exit";
            // 
            // TbControlPrincipal
            // 
            this.TbControlPrincipal.Controls.Add(this.tabPage1);
            this.TbControlPrincipal.Controls.Add(this.tabPage2);
            this.TbControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbControlPrincipal.Location = new System.Drawing.Point(0, 61);
            this.TbControlPrincipal.Name = "TbControlPrincipal";
            this.TbControlPrincipal.SelectedIndex = 0;
            this.TbControlPrincipal.Size = new System.Drawing.Size(782, 256);
            this.TbControlPrincipal.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LControlFocus);
            this.tabPage1.Controls.Add(this.TxtControlFocus);
            this.tabPage1.Controls.Add(this.TxtClassName);
            this.tabPage1.Controls.Add(this.LbClassNama);
            this.tabPage1.Controls.Add(this.txtTextWindow);
            this.tabPage1.Controls.Add(this.LTextWindow);
            this.tabPage1.Controls.Add(this.LLength);
            this.tabPage1.Controls.Add(this.TxtLenght);
            this.tabPage1.Controls.Add(this.TxtContextoDC);
            this.tabPage1.Controls.Add(this.LbContextoDC);
            this.tabPage1.Controls.Add(this.LbRectangle);
            this.tabPage1.Controls.Add(this.TxtRectangle);
            this.tabPage1.Controls.Add(this.LGetWindow);
            this.tabPage1.Controls.Add(this.TxtGetWindow);
            this.tabPage1.Controls.Add(this.lbIsChild);
            this.tabPage1.Controls.Add(this.TxtIsChild);
            this.tabPage1.Controls.Add(this.LbParentWindow);
            this.tabPage1.Controls.Add(this.TxtParentWindow);
            this.tabPage1.Controls.Add(this.LbClientToScreem);
            this.tabPage1.Controls.Add(this.TxtClientToScreem);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.TxtScreemToClient);
            this.tabPage1.Controls.Add(this.Window);
            this.tabPage1.Controls.Add(this.TxtWindow);
            this.tabPage1.Controls.Add(this.LbWindowPoint);
            this.tabPage1.Controls.Add(this.TxtWindowPoint);
            this.tabPage1.Controls.Add(this.TxtMousePosition);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 227);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbIsChild
            // 
            this.lbIsChild.AutoSize = true;
            this.lbIsChild.Location = new System.Drawing.Point(118, 61);
            this.lbIsChild.Name = "lbIsChild";
            this.lbIsChild.Size = new System.Drawing.Size(53, 17);
            this.lbIsChild.TabIndex = 13;
            this.lbIsChild.Text = "Is Child";
            // 
            // TxtIsChild
            // 
            this.TxtIsChild.Location = new System.Drawing.Point(118, 84);
            this.TxtIsChild.Name = "TxtIsChild";
            this.TxtIsChild.Size = new System.Drawing.Size(100, 22);
            this.TxtIsChild.TabIndex = 12;
            // 
            // LbParentWindow
            // 
            this.LbParentWindow.AutoSize = true;
            this.LbParentWindow.Location = new System.Drawing.Point(8, 61);
            this.LbParentWindow.Name = "LbParentWindow";
            this.LbParentWindow.Size = new System.Drawing.Size(103, 17);
            this.LbParentWindow.TabIndex = 11;
            this.LbParentWindow.Text = "Parent Window";
            // 
            // TxtParentWindow
            // 
            this.TxtParentWindow.Location = new System.Drawing.Point(9, 84);
            this.TxtParentWindow.Name = "TxtParentWindow";
            this.TxtParentWindow.Size = new System.Drawing.Size(100, 22);
            this.TxtParentWindow.TabIndex = 10;
            // 
            // LbClientToScreem
            // 
            this.LbClientToScreem.AutoSize = true;
            this.LbClientToScreem.Location = new System.Drawing.Point(481, 13);
            this.LbClientToScreem.Name = "LbClientToScreem";
            this.LbClientToScreem.Size = new System.Drawing.Size(116, 17);
            this.LbClientToScreem.TabIndex = 9;
            this.LbClientToScreem.Text = "Client To Screem";
            // 
            // TxtClientToScreem
            // 
            this.TxtClientToScreem.Location = new System.Drawing.Point(483, 33);
            this.TxtClientToScreem.Name = "TxtClientToScreem";
            this.TxtClientToScreem.Size = new System.Drawing.Size(116, 22);
            this.TxtClientToScreem.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Screem?";
            // 
            // TxtScreemToClient
            // 
            this.TxtScreemToClient.Location = new System.Drawing.Point(307, 33);
            this.TxtScreemToClient.Name = "TxtScreemToClient";
            this.TxtScreemToClient.Size = new System.Drawing.Size(64, 22);
            this.TxtScreemToClient.TabIndex = 6;
            // 
            // Window
            // 
            this.Window.AutoSize = true;
            this.Window.Location = new System.Drawing.Point(374, 13);
            this.Window.Name = "Window";
            this.Window.Size = new System.Drawing.Size(81, 17);
            this.Window.TabIndex = 5;
            this.Window.Text = "Window Pai";
            // 
            // TxtWindow
            // 
            this.TxtWindow.Location = new System.Drawing.Point(377, 33);
            this.TxtWindow.Name = "TxtWindow";
            this.TxtWindow.Size = new System.Drawing.Size(100, 22);
            this.TxtWindow.TabIndex = 4;
            // 
            // LbWindowPoint
            // 
            this.LbWindowPoint.AutoSize = true;
            this.LbWindowPoint.Location = new System.Drawing.Point(192, 13);
            this.LbWindowPoint.Name = "LbWindowPoint";
            this.LbWindowPoint.Size = new System.Drawing.Size(93, 17);
            this.LbWindowPoint.TabIndex = 3;
            this.LbWindowPoint.Text = "Window Point";
            // 
            // TxtWindowPoint
            // 
            this.TxtWindowPoint.Location = new System.Drawing.Point(191, 33);
            this.TxtWindowPoint.Name = "TxtWindowPoint";
            this.TxtWindowPoint.Size = new System.Drawing.Size(110, 22);
            this.TxtWindowPoint.TabIndex = 2;
            // 
            // TxtMousePosition
            // 
            this.TxtMousePosition.Location = new System.Drawing.Point(6, 33);
            this.TxtMousePosition.Name = "TxtMousePosition";
            this.TxtMousePosition.Size = new System.Drawing.Size(179, 22);
            this.TxtMousePosition.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mouse Position:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(612, 267);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 295);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(782, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TxtGetWindow
            // 
            this.TxtGetWindow.Location = new System.Drawing.Point(225, 84);
            this.TxtGetWindow.Name = "TxtGetWindow";
            this.TxtGetWindow.Size = new System.Drawing.Size(100, 22);
            this.TxtGetWindow.TabIndex = 14;
            // 
            // LGetWindow
            // 
            this.LGetWindow.AutoSize = true;
            this.LGetWindow.Location = new System.Drawing.Point(225, 61);
            this.LGetWindow.Name = "LGetWindow";
            this.LGetWindow.Size = new System.Drawing.Size(80, 17);
            this.LGetWindow.TabIndex = 15;
            this.LGetWindow.Text = "GetWindow";
            // 
            // TxtRectangle
            // 
            this.TxtRectangle.Location = new System.Drawing.Point(332, 84);
            this.TxtRectangle.Name = "TxtRectangle";
            this.TxtRectangle.Size = new System.Drawing.Size(100, 22);
            this.TxtRectangle.TabIndex = 16;
            // 
            // LbRectangle
            // 
            this.LbRectangle.AutoSize = true;
            this.LbRectangle.Location = new System.Drawing.Point(332, 61);
            this.LbRectangle.Name = "LbRectangle";
            this.LbRectangle.Size = new System.Drawing.Size(72, 17);
            this.LbRectangle.TabIndex = 17;
            this.LbRectangle.Text = "Rectangle";
            // 
            // LbContextoDC
            // 
            this.LbContextoDC.AutoSize = true;
            this.LbContextoDC.Location = new System.Drawing.Point(439, 61);
            this.LbContextoDC.Name = "LbContextoDC";
            this.LbContextoDC.Size = new System.Drawing.Size(86, 17);
            this.LbContextoDC.TabIndex = 18;
            this.LbContextoDC.Text = "Contexto DC";
            // 
            // TxtContextoDC
            // 
            this.TxtContextoDC.Location = new System.Drawing.Point(439, 83);
            this.TxtContextoDC.Name = "TxtContextoDC";
            this.TxtContextoDC.Size = new System.Drawing.Size(100, 22);
            this.TxtContextoDC.TabIndex = 19;
            // 
            // TxtLenght
            // 
            this.TxtLenght.Location = new System.Drawing.Point(546, 83);
            this.TxtLenght.Name = "TxtLenght";
            this.TxtLenght.Size = new System.Drawing.Size(53, 22);
            this.TxtLenght.TabIndex = 20;
            // 
            // LLength
            // 
            this.LLength.AutoSize = true;
            this.LLength.Location = new System.Drawing.Point(546, 61);
            this.LLength.Name = "LLength";
            this.LLength.Size = new System.Drawing.Size(52, 17);
            this.LLength.TabIndex = 21;
            this.LLength.Text = "Lenght";
            // 
            // LTextWindow
            // 
            this.LTextWindow.AutoSize = true;
            this.LTextWindow.Location = new System.Drawing.Point(11, 113);
            this.LTextWindow.Name = "LTextWindow";
            this.LTextWindow.Size = new System.Drawing.Size(84, 17);
            this.LTextWindow.TabIndex = 22;
            this.LTextWindow.Text = "TextWindow";
            // 
            // txtTextWindow
            // 
            this.txtTextWindow.Location = new System.Drawing.Point(14, 134);
            this.txtTextWindow.Name = "txtTextWindow";
            this.txtTextWindow.Size = new System.Drawing.Size(100, 22);
            this.txtTextWindow.TabIndex = 23;
            // 
            // LbClassNama
            // 
            this.LbClassNama.AutoSize = true;
            this.LbClassNama.Location = new System.Drawing.Point(121, 112);
            this.LbClassNama.Name = "LbClassNama";
            this.LbClassNama.Size = new System.Drawing.Size(79, 17);
            this.LbClassNama.TabIndex = 24;
            this.LbClassNama.Text = "ClassName";
            // 
            // TxtClassName
            // 
            this.TxtClassName.Location = new System.Drawing.Point(124, 133);
            this.TxtClassName.Name = "TxtClassName";
            this.TxtClassName.Size = new System.Drawing.Size(100, 22);
            this.TxtClassName.TabIndex = 25;
            // 
            // TxtControlFocus
            // 
            this.TxtControlFocus.Location = new System.Drawing.Point(231, 134);
            this.TxtControlFocus.Name = "TxtControlFocus";
            this.TxtControlFocus.Size = new System.Drawing.Size(232, 22);
            this.TxtControlFocus.TabIndex = 26;
            // 
            // LControlFocus
            // 
            this.LControlFocus.AutoSize = true;
            this.LControlFocus.Location = new System.Drawing.Point(228, 113);
            this.LControlFocus.Name = "LControlFocus";
            this.LControlFocus.Size = new System.Drawing.Size(91, 17);
            this.LControlFocus.TabIndex = 27;
            this.LControlFocus.Text = "ControlFocus";
            // 
            // TListemKey
            // 
            this.TListemKey.Enabled = true;
            this.TListemKey.Interval = 10;
            this.TListemKey.Tick += new System.EventHandler(this.TListemKey_Tick);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 317);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TbControlPrincipal);
            this.Controls.Add(this.ToolPrincipal);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "FPrincipal";
            this.Text = "Solucao Estudos API Windows";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FPrincipal_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FPrincipal_KeyUp);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ToolPrincipal.ResumeLayout(false);
            this.ToolPrincipal.PerformLayout();
            this.TbControlPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.TextBox TxtMousePosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox TxtWindowPoint;
        private System.Windows.Forms.Label LbWindowPoint;
        private System.Windows.Forms.Label Window;
        private System.Windows.Forms.TextBox TxtWindow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtScreemToClient;
        private System.Windows.Forms.Label LbClientToScreem;
        private System.Windows.Forms.TextBox TxtClientToScreem;
        private System.Windows.Forms.TextBox TxtParentWindow;
        private System.Windows.Forms.Label LbParentWindow;
        private System.Windows.Forms.Label lbIsChild;
        private System.Windows.Forms.TextBox TxtIsChild;
        private System.Windows.Forms.Label LGetWindow;
        private System.Windows.Forms.TextBox TxtGetWindow;
        private System.Windows.Forms.Label LbRectangle;
        private System.Windows.Forms.TextBox TxtRectangle;
        private System.Windows.Forms.TextBox TxtContextoDC;
        private System.Windows.Forms.Label LbContextoDC;
        private System.Windows.Forms.Label LLength;
        private System.Windows.Forms.TextBox TxtLenght;
        private System.Windows.Forms.TextBox txtTextWindow;
        private System.Windows.Forms.Label LTextWindow;
        private System.Windows.Forms.TextBox TxtClassName;
        private System.Windows.Forms.Label LbClassNama;
        private System.Windows.Forms.Label LControlFocus;
        private System.Windows.Forms.TextBox TxtControlFocus;
        private System.Windows.Forms.Timer TListemKey;
    }
}

