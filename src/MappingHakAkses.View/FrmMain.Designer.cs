namespace MappingHakAkses.View
{
   partial class FrmMain
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
         this.menuStripMain = new System.Windows.Forms.MenuStrip();
         this.operasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.tsMenuOperator = new System.Windows.Forms.ToolStripMenuItem();
         this.tsMenuHakAkses = new System.Windows.Forms.ToolStripMenuItem();
         this.menu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.tsMenuSubMenu1_1 = new System.Windows.Forms.ToolStripMenuItem();
         this.tsMenuSubMenu1_2 = new System.Windows.Forms.ToolStripMenuItem();
         this.tsMenuSubMenu1_3 = new System.Windows.Forms.ToolStripMenuItem();
         this.tsMenuIgnore3 = new System.Windows.Forms.ToolStripMenuItem();
         this.menu2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.tsMenuIgnore4 = new System.Windows.Forms.ToolStripMenuItem();
         this.tsMenuIgnore5 = new System.Windows.Forms.ToolStripMenuItem();
         this.tsMenuSubMenu2_1 = new System.Windows.Forms.ToolStripMenuItem();
         this.tsMenuSubMenu2_2 = new System.Windows.Forms.ToolStripMenuItem();
         this.tsMenuSubMenu2_3 = new System.Windows.Forms.ToolStripMenuItem();
         this.menu3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.tsMenuSubMenu3_1 = new System.Windows.Forms.ToolStripMenuItem();
         this.tsMenuSubMenu3_2 = new System.Windows.Forms.ToolStripMenuItem();
         this.tsMenuSubMenu3_3 = new System.Windows.Forms.ToolStripMenuItem();
         this.tsMenuIgnore1 = new System.Windows.Forms.ToolStripMenuItem();
         this.tsMenuIgnore2 = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripMain = new System.Windows.Forms.ToolStrip();
         this.tsBtnSubMenu1_1 = new System.Windows.Forms.ToolStripButton();
         this.tsBtnSubMenu2_1 = new System.Windows.Forms.ToolStripButton();
         this.tsBtnSubMenu3_1 = new System.Windows.Forms.ToolStripButton();
         this.tsBtnLogout = new System.Windows.Forms.ToolStripButton();
         this.tsMenuSubMenu4 = new System.Windows.Forms.ToolStripMenuItem();
         this.tsMenuSubMenu4_1 = new System.Windows.Forms.ToolStripMenuItem();
         this.tsMenuSubMenu4_2 = new System.Windows.Forms.ToolStripMenuItem();
         this.tsMenuSubMenu4_3 = new System.Windows.Forms.ToolStripMenuItem();
         this.menuStripMain.SuspendLayout();
         this.toolStripMain.SuspendLayout();
         this.SuspendLayout();
         // 
         // menuStripMain
         // 
         this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operasiToolStripMenuItem,
            this.masterToolStripMenuItem,
            this.menu1ToolStripMenuItem,
            this.menu2ToolStripMenuItem,
            this.menu3ToolStripMenuItem,
            this.tsMenuIgnore1});
         this.menuStripMain.Location = new System.Drawing.Point(0, 0);
         this.menuStripMain.Name = "menuStripMain";
         this.menuStripMain.Size = new System.Drawing.Size(584, 24);
         this.menuStripMain.TabIndex = 0;
         this.menuStripMain.Text = "menuStrip1";
         // 
         // operasiToolStripMenuItem
         // 
         this.operasiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
         this.operasiToolStripMenuItem.Name = "operasiToolStripMenuItem";
         this.operasiToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
         this.operasiToolStripMenuItem.Tag = "ignore";
         this.operasiToolStripMenuItem.Text = "&Operasi";
         // 
         // logOutToolStripMenuItem
         // 
         this.logOutToolStripMenuItem.AccessibleName = "menu";
         this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
         this.logOutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
         this.logOutToolStripMenuItem.Tag = "ignore";
         this.logOutToolStripMenuItem.Text = "&Logout";
         this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
         // 
         // masterToolStripMenuItem
         // 
         this.masterToolStripMenuItem.AccessibleDescription = "Master";
         this.masterToolStripMenuItem.AccessibleName = "menu";
         this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuOperator,
            this.tsMenuHakAkses});
         this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
         this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
         this.masterToolStripMenuItem.Tag = "Master";
         this.masterToolStripMenuItem.Text = "&Master";
         // 
         // tsMenuOperator
         // 
         this.tsMenuOperator.AccessibleDescription = "Master";
         this.tsMenuOperator.AccessibleName = "menuForm";
         this.tsMenuOperator.Name = "tsMenuOperator";
         this.tsMenuOperator.Size = new System.Drawing.Size(128, 22);
         this.tsMenuOperator.Tag = "FrmOperator";
         this.tsMenuOperator.Text = "&Operator";
         this.tsMenuOperator.Click += new System.EventHandler(this.tsMenuOperator_Click);
         // 
         // tsMenuHakAkses
         // 
         this.tsMenuHakAkses.AccessibleDescription = "Master";
         this.tsMenuHakAkses.AccessibleName = "menuForm";
         this.tsMenuHakAkses.Name = "tsMenuHakAkses";
         this.tsMenuHakAkses.Size = new System.Drawing.Size(128, 22);
         this.tsMenuHakAkses.Tag = "FrmHakAkses";
         this.tsMenuHakAkses.Text = "&Hak Akses";
         this.tsMenuHakAkses.Click += new System.EventHandler(this.tsMenuHakAkses_Click);
         // 
         // menu1ToolStripMenuItem
         // 
         this.menu1ToolStripMenuItem.AccessibleDescription = "Menu - 1";
         this.menu1ToolStripMenuItem.AccessibleName = "menu";
         this.menu1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuSubMenu1_1,
            this.tsMenuSubMenu1_2,
            this.tsMenuSubMenu1_3,
            this.tsMenuIgnore3});
         this.menu1ToolStripMenuItem.Name = "menu1ToolStripMenuItem";
         this.menu1ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
         this.menu1ToolStripMenuItem.Tag = "Menu - 1";
         this.menu1ToolStripMenuItem.Text = "&Menu - 1";
         // 
         // tsMenuSubMenu1_1
         // 
         this.tsMenuSubMenu1_1.AccessibleDescription = "Menu - 1";
         this.tsMenuSubMenu1_1.AccessibleName = "menuForm";
         this.tsMenuSubMenu1_1.Name = "tsMenuSubMenu1_1";
         this.tsMenuSubMenu1_1.Size = new System.Drawing.Size(154, 22);
         this.tsMenuSubMenu1_1.Tag = "FrmSubMenu1";
         this.tsMenuSubMenu1_1.Text = "Sub Menu - 1.1";
         this.tsMenuSubMenu1_1.Click += new System.EventHandler(this.tsMenuSubMenu1_1_Click);
         // 
         // tsMenuSubMenu1_2
         // 
         this.tsMenuSubMenu1_2.AccessibleDescription = "Menu - 1";
         this.tsMenuSubMenu1_2.AccessibleName = "menu";
         this.tsMenuSubMenu1_2.Name = "tsMenuSubMenu1_2";
         this.tsMenuSubMenu1_2.Size = new System.Drawing.Size(154, 22);
         this.tsMenuSubMenu1_2.Tag = "Sub Menu - 1.2";
         this.tsMenuSubMenu1_2.Text = "Sub Menu - 1.2";
         // 
         // tsMenuSubMenu1_3
         // 
         this.tsMenuSubMenu1_3.AccessibleDescription = "Menu - 1";
         this.tsMenuSubMenu1_3.AccessibleName = "menu";
         this.tsMenuSubMenu1_3.Name = "tsMenuSubMenu1_3";
         this.tsMenuSubMenu1_3.Size = new System.Drawing.Size(154, 22);
         this.tsMenuSubMenu1_3.Tag = "Sub Menu - 1.3";
         this.tsMenuSubMenu1_3.Text = "Sub Menu - 1.3";
         // 
         // tsMenuIgnore3
         // 
         this.tsMenuIgnore3.AccessibleDescription = "";
         this.tsMenuIgnore3.AccessibleName = "menu";
         this.tsMenuIgnore3.Name = "tsMenuIgnore3";
         this.tsMenuIgnore3.Size = new System.Drawing.Size(154, 22);
         this.tsMenuIgnore3.Tag = "ignore";
         this.tsMenuIgnore3.Text = "Ignore - 3";
         // 
         // menu2ToolStripMenuItem
         // 
         this.menu2ToolStripMenuItem.AccessibleDescription = "Menu - 2";
         this.menu2ToolStripMenuItem.AccessibleName = "menu";
         this.menu2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuIgnore4,
            this.tsMenuSubMenu2_1,
            this.tsMenuSubMenu2_2,
            this.tsMenuSubMenu2_3});
         this.menu2ToolStripMenuItem.Name = "menu2ToolStripMenuItem";
         this.menu2ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
         this.menu2ToolStripMenuItem.Tag = "Menu - 2";
         this.menu2ToolStripMenuItem.Text = "M&enu - 2";
         // 
         // tsMenuIgnore4
         // 
         this.tsMenuIgnore4.AccessibleDescription = "";
         this.tsMenuIgnore4.AccessibleName = "menu";
         this.tsMenuIgnore4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuIgnore5});
         this.tsMenuIgnore4.Name = "tsMenuIgnore4";
         this.tsMenuIgnore4.Size = new System.Drawing.Size(154, 22);
         this.tsMenuIgnore4.Tag = "ignore";
         this.tsMenuIgnore4.Text = "Ignore - 4";
         // 
         // tsMenuIgnore5
         // 
         this.tsMenuIgnore5.AccessibleName = "menu";
         this.tsMenuIgnore5.Name = "tsMenuIgnore5";
         this.tsMenuIgnore5.Size = new System.Drawing.Size(125, 22);
         this.tsMenuIgnore5.Tag = "ignore";
         this.tsMenuIgnore5.Text = "Ignore - 5";
         // 
         // tsMenuSubMenu2_1
         // 
         this.tsMenuSubMenu2_1.AccessibleDescription = "Menu - 2";
         this.tsMenuSubMenu2_1.AccessibleName = "menuForm";
         this.tsMenuSubMenu2_1.Name = "tsMenuSubMenu2_1";
         this.tsMenuSubMenu2_1.Size = new System.Drawing.Size(154, 22);
         this.tsMenuSubMenu2_1.Tag = "FrmSubMenu2";
         this.tsMenuSubMenu2_1.Text = "Sub Menu - 2.1";
         this.tsMenuSubMenu2_1.Click += new System.EventHandler(this.tsMenuSubMenu2_1_Click);
         // 
         // tsMenuSubMenu2_2
         // 
         this.tsMenuSubMenu2_2.AccessibleDescription = "Menu - 2";
         this.tsMenuSubMenu2_2.AccessibleName = "menu";
         this.tsMenuSubMenu2_2.Name = "tsMenuSubMenu2_2";
         this.tsMenuSubMenu2_2.Size = new System.Drawing.Size(154, 22);
         this.tsMenuSubMenu2_2.Tag = "Sub Menu - 2.2";
         this.tsMenuSubMenu2_2.Text = "Sub Menu - 2.2";
         // 
         // tsMenuSubMenu2_3
         // 
         this.tsMenuSubMenu2_3.AccessibleDescription = "Menu - 2";
         this.tsMenuSubMenu2_3.AccessibleName = "menu";
         this.tsMenuSubMenu2_3.Name = "tsMenuSubMenu2_3";
         this.tsMenuSubMenu2_3.Size = new System.Drawing.Size(154, 22);
         this.tsMenuSubMenu2_3.Tag = "Sub Menu - 2.3";
         this.tsMenuSubMenu2_3.Text = "Sub Menu - 2.3";
         // 
         // menu3ToolStripMenuItem
         // 
         this.menu3ToolStripMenuItem.AccessibleDescription = "Menu - 3";
         this.menu3ToolStripMenuItem.AccessibleName = "menu";
         this.menu3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuSubMenu3_1,
            this.tsMenuSubMenu3_2,
            this.tsMenuSubMenu3_3,
            this.tsMenuSubMenu4});
         this.menu3ToolStripMenuItem.Name = "menu3ToolStripMenuItem";
         this.menu3ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
         this.menu3ToolStripMenuItem.Tag = "Menu - 3";
         this.menu3ToolStripMenuItem.Text = "Me&nu - 3";
         // 
         // tsMenuSubMenu3_1
         // 
         this.tsMenuSubMenu3_1.AccessibleDescription = "Menu - 3";
         this.tsMenuSubMenu3_1.AccessibleName = "menuForm";
         this.tsMenuSubMenu3_1.Name = "tsMenuSubMenu3_1";
         this.tsMenuSubMenu3_1.Size = new System.Drawing.Size(154, 22);
         this.tsMenuSubMenu3_1.Tag = "FrmSubMenu3";
         this.tsMenuSubMenu3_1.Text = "Sub Menu - 3.1";
         this.tsMenuSubMenu3_1.Click += new System.EventHandler(this.tsMenuSubMenu3_1_Click);
         // 
         // tsMenuSubMenu3_2
         // 
         this.tsMenuSubMenu3_2.AccessibleDescription = "Menu - 3";
         this.tsMenuSubMenu3_2.AccessibleName = "menu";
         this.tsMenuSubMenu3_2.Name = "tsMenuSubMenu3_2";
         this.tsMenuSubMenu3_2.Size = new System.Drawing.Size(154, 22);
         this.tsMenuSubMenu3_2.Tag = "Sub Menu - 3.2";
         this.tsMenuSubMenu3_2.Text = "Sub Menu - 3.2";
         // 
         // tsMenuSubMenu3_3
         // 
         this.tsMenuSubMenu3_3.AccessibleDescription = "Menu - 3";
         this.tsMenuSubMenu3_3.AccessibleName = "menu";
         this.tsMenuSubMenu3_3.Name = "tsMenuSubMenu3_3";
         this.tsMenuSubMenu3_3.Size = new System.Drawing.Size(154, 22);
         this.tsMenuSubMenu3_3.Tag = "Sub Menu - 3.3";
         this.tsMenuSubMenu3_3.Text = "Sub Menu - 3.3";
         // 
         // tsMenuIgnore1
         // 
         this.tsMenuIgnore1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuIgnore2});
         this.tsMenuIgnore1.Name = "tsMenuIgnore1";
         this.tsMenuIgnore1.Size = new System.Drawing.Size(70, 20);
         this.tsMenuIgnore1.Tag = "ignore";
         this.tsMenuIgnore1.Text = "Ignore - 1";
         // 
         // tsMenuIgnore2
         // 
         this.tsMenuIgnore2.AccessibleName = "";
         this.tsMenuIgnore2.Name = "tsMenuIgnore2";
         this.tsMenuIgnore2.Size = new System.Drawing.Size(125, 22);
         this.tsMenuIgnore2.Tag = "ignore";
         this.tsMenuIgnore2.Text = "Ignore - 2";
         // 
         // toolStripMain
         // 
         this.toolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
         this.toolStripMain.ImageScalingSize = new System.Drawing.Size(32, 32);
         this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnSubMenu1_1,
            this.tsBtnSubMenu2_1,
            this.tsBtnSubMenu3_1,
            this.tsBtnLogout});
         this.toolStripMain.Location = new System.Drawing.Point(0, 24);
         this.toolStripMain.Name = "toolStripMain";
         this.toolStripMain.Size = new System.Drawing.Size(584, 58);
         this.toolStripMain.TabIndex = 1;
         this.toolStripMain.Text = "toolStrip1";
         // 
         // tsBtnSubMenu1_1
         // 
         this.tsBtnSubMenu1_1.AccessibleDescription = "Menu - 1";
         this.tsBtnSubMenu1_1.AccessibleName = "menuForm";
         this.tsBtnSubMenu1_1.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSubMenu1_1.Image")));
         this.tsBtnSubMenu1_1.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.tsBtnSubMenu1_1.Name = "tsBtnSubMenu1_1";
         this.tsBtnSubMenu1_1.Padding = new System.Windows.Forms.Padding(2);
         this.tsBtnSubMenu1_1.Size = new System.Drawing.Size(95, 55);
         this.tsBtnSubMenu1_1.Tag = "FrmSubMenu1";
         this.tsBtnSubMenu1_1.Text = "Sub Menu - 1.1";
         this.tsBtnSubMenu1_1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
         this.tsBtnSubMenu1_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
         this.tsBtnSubMenu1_1.ToolTipText = "Sub Menu - 1.1";
         this.tsBtnSubMenu1_1.Click += new System.EventHandler(this.tsMenuSubMenu1_1_Click);
         // 
         // tsBtnSubMenu2_1
         // 
         this.tsBtnSubMenu2_1.AccessibleDescription = "Menu - 2";
         this.tsBtnSubMenu2_1.AccessibleName = "menuForm";
         this.tsBtnSubMenu2_1.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSubMenu2_1.Image")));
         this.tsBtnSubMenu2_1.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.tsBtnSubMenu2_1.Name = "tsBtnSubMenu2_1";
         this.tsBtnSubMenu2_1.Size = new System.Drawing.Size(91, 55);
         this.tsBtnSubMenu2_1.Tag = "FrmSubMenu2";
         this.tsBtnSubMenu2_1.Text = "Sub Menu - 2.1";
         this.tsBtnSubMenu2_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
         this.tsBtnSubMenu2_1.ToolTipText = "Sub Menu - 2.1";
         this.tsBtnSubMenu2_1.Click += new System.EventHandler(this.tsMenuSubMenu2_1_Click);
         // 
         // tsBtnSubMenu3_1
         // 
         this.tsBtnSubMenu3_1.AccessibleDescription = "Menu - 3";
         this.tsBtnSubMenu3_1.AccessibleName = "menuForm";
         this.tsBtnSubMenu3_1.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSubMenu3_1.Image")));
         this.tsBtnSubMenu3_1.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.tsBtnSubMenu3_1.Name = "tsBtnSubMenu3_1";
         this.tsBtnSubMenu3_1.Size = new System.Drawing.Size(91, 55);
         this.tsBtnSubMenu3_1.Tag = "FrmSubMenu3";
         this.tsBtnSubMenu3_1.Text = "Sub Menu - 3.1";
         this.tsBtnSubMenu3_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
         this.tsBtnSubMenu3_1.ToolTipText = "Sub Menu - 3.1";
         this.tsBtnSubMenu3_1.Click += new System.EventHandler(this.tsMenuSubMenu3_1_Click);
         // 
         // tsBtnLogout
         // 
         this.tsBtnLogout.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnLogout.Image")));
         this.tsBtnLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.tsBtnLogout.Name = "tsBtnLogout";
         this.tsBtnLogout.Size = new System.Drawing.Size(49, 55);
         this.tsBtnLogout.Tag = "ignore";
         this.tsBtnLogout.Text = "Logout";
         this.tsBtnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
         this.tsBtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
         this.tsBtnLogout.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
         // 
         // tsMenuSubMenu4
         // 
         this.tsMenuSubMenu4.AccessibleDescription = "Menu - 3";
         this.tsMenuSubMenu4.AccessibleName = "menu";
         this.tsMenuSubMenu4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuSubMenu4_1,
            this.tsMenuSubMenu4_2,
            this.tsMenuSubMenu4_3});
         this.tsMenuSubMenu4.Name = "tsMenuSubMenu4";
         this.tsMenuSubMenu4.Size = new System.Drawing.Size(154, 22);
         this.tsMenuSubMenu4.Tag = "Menu - 4";
         this.tsMenuSubMenu4.Text = "Menu - 4";
         // 
         // tsMenuSubMenu4_1
         // 
         this.tsMenuSubMenu4_1.AccessibleDescription = "Menu - 3";
         this.tsMenuSubMenu4_1.AccessibleName = "menuForm";
         this.tsMenuSubMenu4_1.Name = "tsMenuSubMenu4_1";
         this.tsMenuSubMenu4_1.Size = new System.Drawing.Size(154, 22);
         this.tsMenuSubMenu4_1.Tag = "FrmSubMenu4";
         this.tsMenuSubMenu4_1.Text = "Sub Menu - 4.1";
         this.tsMenuSubMenu4_1.Click += new System.EventHandler(this.tsMenuSubMenu4_1_Click);
         // 
         // tsMenuSubMenu4_2
         // 
         this.tsMenuSubMenu4_2.AccessibleDescription = "Menu - 3";
         this.tsMenuSubMenu4_2.AccessibleName = "menu";
         this.tsMenuSubMenu4_2.Name = "tsMenuSubMenu4_2";
         this.tsMenuSubMenu4_2.Size = new System.Drawing.Size(154, 22);
         this.tsMenuSubMenu4_2.Tag = "Sub Menu - 4.2";
         this.tsMenuSubMenu4_2.Text = "Sub Menu - 4.2";
         // 
         // tsMenuSubMenu4_3
         // 
         this.tsMenuSubMenu4_3.AccessibleDescription = "Menu - 3";
         this.tsMenuSubMenu4_3.AccessibleName = "menu";
         this.tsMenuSubMenu4_3.Name = "tsMenuSubMenu4_3";
         this.tsMenuSubMenu4_3.Size = new System.Drawing.Size(154, 22);
         this.tsMenuSubMenu4_3.Tag = "Sub Menu - 4.3";
         this.tsMenuSubMenu4_3.Text = "Sub Menu - 4.3";
         // 
         // FrmMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(584, 362);
         this.Controls.Add(this.toolStripMain);
         this.Controls.Add(this.menuStripMain);
         this.MainMenuStrip = this.menuStripMain;
         this.Name = "FrmMain";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Tag = "ignore";
         this.Text = "Main Form";
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
         this.menuStripMain.ResumeLayout(false);
         this.menuStripMain.PerformLayout();
         this.toolStripMain.ResumeLayout(false);
         this.toolStripMain.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip menuStripMain;
      private System.Windows.Forms.ToolStrip toolStripMain;
      private System.Windows.Forms.ToolStripButton tsBtnSubMenu1_1;
      private System.Windows.Forms.ToolStripButton tsBtnSubMenu2_1;
      private System.Windows.Forms.ToolStripButton tsBtnSubMenu3_1;
      private System.Windows.Forms.ToolStripButton tsBtnLogout;
      private System.Windows.Forms.ToolStripMenuItem operasiToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem menu1ToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem tsMenuSubMenu1_1;
      private System.Windows.Forms.ToolStripMenuItem tsMenuSubMenu1_2;
      private System.Windows.Forms.ToolStripMenuItem tsMenuSubMenu1_3;
      private System.Windows.Forms.ToolStripMenuItem tsMenuIgnore3;
      private System.Windows.Forms.ToolStripMenuItem menu2ToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem tsMenuSubMenu2_1;
      private System.Windows.Forms.ToolStripMenuItem tsMenuSubMenu2_2;
      private System.Windows.Forms.ToolStripMenuItem tsMenuSubMenu2_3;
      private System.Windows.Forms.ToolStripMenuItem menu3ToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem tsMenuSubMenu3_1;
      private System.Windows.Forms.ToolStripMenuItem tsMenuSubMenu3_2;
      private System.Windows.Forms.ToolStripMenuItem tsMenuSubMenu3_3;
      private System.Windows.Forms.ToolStripMenuItem tsMenuIgnore1;
      private System.Windows.Forms.ToolStripMenuItem tsMenuIgnore2;
      private System.Windows.Forms.ToolStripMenuItem tsMenuIgnore4;
      private System.Windows.Forms.ToolStripMenuItem tsMenuIgnore5;
      private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem tsMenuOperator;
      private System.Windows.Forms.ToolStripMenuItem tsMenuHakAkses;
      private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem tsMenuSubMenu4;
      private System.Windows.Forms.ToolStripMenuItem tsMenuSubMenu4_1;
      private System.Windows.Forms.ToolStripMenuItem tsMenuSubMenu4_2;
      private System.Windows.Forms.ToolStripMenuItem tsMenuSubMenu4_3;
   }
}

