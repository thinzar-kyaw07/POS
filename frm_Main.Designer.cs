
namespace POS
{
    partial class frm_Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMasterData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProfitLoss = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSale = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuMasterData,
            this.mnuProcess});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogin,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(54, 29);
            this.mnuFile.Text = "File";
            // 
            // mnuLogin
            // 
            this.mnuLogin.Name = "mnuLogin";
            this.mnuLogin.Size = new System.Drawing.Size(158, 34);
            this.mnuLogin.Text = "Login";
            this.mnuLogin.Click += new System.EventHandler(this.mnuLogin_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(158, 34);
            this.mnuExit.Text = "Exit";
            // 
            // mnuMasterData
            // 
            this.mnuMasterData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItem,
            this.mnuSupplier,
            this.mnuUser});
            this.mnuMasterData.Name = "mnuMasterData";
            this.mnuMasterData.Size = new System.Drawing.Size(119, 29);
            this.mnuMasterData.Text = "MasterData";
            // 
            // mnuItem
            // 
            this.mnuItem.Name = "mnuItem";
            this.mnuItem.Size = new System.Drawing.Size(270, 34);
            this.mnuItem.Text = "Item";
            this.mnuItem.Click += new System.EventHandler(this.mnuItem_Click);
            // 
            // mnuSupplier
            // 
            this.mnuSupplier.Name = "mnuSupplier";
            this.mnuSupplier.Size = new System.Drawing.Size(270, 34);
            this.mnuSupplier.Text = "Supplier";
            this.mnuSupplier.Click += new System.EventHandler(this.mnuSupplier_Click);
            // 
            // mnuUser
            // 
            this.mnuUser.Name = "mnuUser";
            this.mnuUser.Size = new System.Drawing.Size(270, 34);
            this.mnuUser.Text = "User";
            this.mnuUser.Click += new System.EventHandler(this.mnuUser_Click);
            // 
            // mnuProcess
            // 
            this.mnuProcess.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProfitLoss,
            this.mnuSale,
            this.mnuPro});
            this.mnuProcess.Name = "mnuProcess";
            this.mnuProcess.Size = new System.Drawing.Size(88, 29);
            this.mnuProcess.Text = "Process";
            // 
            // mnuProfitLoss
            // 
            this.mnuProfitLoss.Name = "mnuProfitLoss";
            this.mnuProfitLoss.Size = new System.Drawing.Size(270, 34);
            this.mnuProfitLoss.Text = "Purchase";
            this.mnuProfitLoss.Click += new System.EventHandler(this.mnuProfitLoss_Click);
            // 
            // mnuSale
            // 
            this.mnuSale.Name = "mnuSale";
            this.mnuSale.Size = new System.Drawing.Size(270, 34);
            this.mnuSale.Text = "Sale";
            this.mnuSale.Click += new System.EventHandler(this.mnuSale_Click);
            // 
            // mnuPro
            // 
            this.mnuPro.Name = "mnuPro";
            this.mnuPro.Size = new System.Drawing.Size(270, 34);
            this.mnuPro.Text = "ProfitAndLoss";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Main";
            this.Text = "Point of Sale System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuLogin;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuMasterData;
        private System.Windows.Forms.ToolStripMenuItem mnuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSupplier;
        private System.Windows.Forms.ToolStripMenuItem mnuUser;
        private System.Windows.Forms.ToolStripMenuItem mnuProcess;
        private System.Windows.Forms.ToolStripMenuItem mnuProfitLoss;
        private System.Windows.Forms.ToolStripMenuItem mnuSale;
        private System.Windows.Forms.ToolStripMenuItem mnuPro;
    }
}

