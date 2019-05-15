namespace MappingHakAkses.View
{
   partial class FrmHakAkses
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
         this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
         this.btnTambah = new System.Windows.Forms.Button();
         this.btnUbah = new System.Windows.Forms.Button();
         this.btnHapus = new System.Windows.Forms.Button();
         this.btnTutup = new System.Windows.Forms.Button();
         this.grpBoxAction = new System.Windows.Forms.GroupBox();
         this.treeViewAction = new System.Windows.Forms.TreeView();
         this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
         this.btnUpdate = new System.Windows.Forms.Button();
         this.chkbPilihSemua = new System.Windows.Forms.CheckBox();
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.label1 = new System.Windows.Forms.Label();
         this.cmbMenu = new System.Windows.Forms.ComboBox();
         this.grpBoxRole = new System.Windows.Forms.GroupBox();
         this.dgvRole = new System.Windows.Forms.DataGridView();
         this.tlpButtons.SuspendLayout();
         this.grpBoxAction.SuspendLayout();
         this.tableLayoutPanel2.SuspendLayout();
         this.tableLayoutPanel1.SuspendLayout();
         this.grpBoxRole.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).BeginInit();
         this.SuspendLayout();
         // 
         // tlpButtons
         // 
         this.tlpButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tlpButtons.ColumnCount = 4;
         this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.tlpButtons.Controls.Add(this.btnTambah, 0, 0);
         this.tlpButtons.Controls.Add(this.btnUbah, 1, 0);
         this.tlpButtons.Controls.Add(this.btnHapus, 2, 0);
         this.tlpButtons.Controls.Add(this.btnTutup, 3, 0);
         this.tlpButtons.Location = new System.Drawing.Point(12, 452);
         this.tlpButtons.Name = "tlpButtons";
         this.tlpButtons.RowCount = 1;
         this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tlpButtons.Size = new System.Drawing.Size(876, 35);
         this.tlpButtons.TabIndex = 4;
         // 
         // btnTambah
         // 
         this.btnTambah.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.btnTambah.Location = new System.Drawing.Point(3, 6);
         this.btnTambah.Name = "btnTambah";
         this.btnTambah.Size = new System.Drawing.Size(75, 23);
         this.btnTambah.TabIndex = 1;
         this.btnTambah.Tag = "Tambah";
         this.btnTambah.Text = "&Tambah";
         this.btnTambah.UseVisualStyleBackColor = true;
         this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
         // 
         // btnUbah
         // 
         this.btnUbah.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.btnUbah.Location = new System.Drawing.Point(84, 6);
         this.btnUbah.Name = "btnUbah";
         this.btnUbah.Size = new System.Drawing.Size(75, 23);
         this.btnUbah.TabIndex = 2;
         this.btnUbah.Tag = "Ubah";
         this.btnUbah.Text = "&Ubah";
         this.btnUbah.UseVisualStyleBackColor = true;
         this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
         // 
         // btnHapus
         // 
         this.btnHapus.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.btnHapus.Location = new System.Drawing.Point(165, 6);
         this.btnHapus.Name = "btnHapus";
         this.btnHapus.Size = new System.Drawing.Size(75, 23);
         this.btnHapus.TabIndex = 3;
         this.btnHapus.Tag = "Hapus";
         this.btnHapus.Text = "&Hapus";
         this.btnHapus.UseVisualStyleBackColor = true;
         this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
         // 
         // btnTutup
         // 
         this.btnTutup.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.btnTutup.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnTutup.Location = new System.Drawing.Point(798, 6);
         this.btnTutup.Name = "btnTutup";
         this.btnTutup.Size = new System.Drawing.Size(75, 23);
         this.btnTutup.TabIndex = 10;
         this.btnTutup.Tag = "ignore";
         this.btnTutup.Text = "Tutu&p";
         this.btnTutup.UseVisualStyleBackColor = true;
         // 
         // grpBoxAction
         // 
         this.grpBoxAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.grpBoxAction.Controls.Add(this.treeViewAction);
         this.grpBoxAction.Controls.Add(this.tableLayoutPanel2);
         this.grpBoxAction.Controls.Add(this.tableLayoutPanel1);
         this.grpBoxAction.Location = new System.Drawing.Point(464, 12);
         this.grpBoxAction.Name = "grpBoxAction";
         this.grpBoxAction.Size = new System.Drawing.Size(424, 434);
         this.grpBoxAction.TabIndex = 5;
         this.grpBoxAction.TabStop = false;
         this.grpBoxAction.Text = "Action";
         // 
         // treeViewAction
         // 
         this.treeViewAction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.treeViewAction.CheckBoxes = true;
         this.treeViewAction.Location = new System.Drawing.Point(6, 60);
         this.treeViewAction.Name = "treeViewAction";
         this.treeViewAction.Size = new System.Drawing.Size(412, 327);
         this.treeViewAction.TabIndex = 1;
         // 
         // tableLayoutPanel2
         // 
         this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tableLayoutPanel2.ColumnCount = 2;
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel2.Controls.Add(this.btnUpdate, 1, 0);
         this.tableLayoutPanel2.Controls.Add(this.chkbPilihSemua, 0, 0);
         this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 393);
         this.tableLayoutPanel2.Name = "tableLayoutPanel2";
         this.tableLayoutPanel2.RowCount = 1;
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel2.Size = new System.Drawing.Size(412, 35);
         this.tableLayoutPanel2.TabIndex = 0;
         // 
         // btnUpdate
         // 
         this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.btnUpdate.Location = new System.Drawing.Point(90, 6);
         this.btnUpdate.Name = "btnUpdate";
         this.btnUpdate.Size = new System.Drawing.Size(75, 23);
         this.btnUpdate.TabIndex = 0;
         this.btnUpdate.Tag = "Update";
         this.btnUpdate.Text = "Update";
         this.btnUpdate.UseVisualStyleBackColor = true;
         this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
         // 
         // chkbPilihSemua
         // 
         this.chkbPilihSemua.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.chkbPilihSemua.AutoSize = true;
         this.chkbPilihSemua.Location = new System.Drawing.Point(3, 9);
         this.chkbPilihSemua.Name = "chkbPilihSemua";
         this.chkbPilihSemua.Size = new System.Drawing.Size(81, 17);
         this.chkbPilihSemua.TabIndex = 1;
         this.chkbPilihSemua.Text = "Pilih Semua";
         this.chkbPilihSemua.UseVisualStyleBackColor = true;
         this.chkbPilihSemua.CheckedChanged += new System.EventHandler(this.chkbPilihSemua_CheckedChanged);
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tableLayoutPanel1.ColumnCount = 2;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.cmbMenu, 1, 0);
         this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 1;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(412, 35);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(3, 11);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(34, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Menu";
         // 
         // cmbMenu
         // 
         this.cmbMenu.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.cmbMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmbMenu.FormattingEnabled = true;
         this.cmbMenu.Location = new System.Drawing.Point(43, 7);
         this.cmbMenu.Name = "cmbMenu";
         this.cmbMenu.Size = new System.Drawing.Size(150, 21);
         this.cmbMenu.TabIndex = 1;
         // 
         // grpBoxRole
         // 
         this.grpBoxRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.grpBoxRole.Controls.Add(this.dgvRole);
         this.grpBoxRole.Location = new System.Drawing.Point(12, 12);
         this.grpBoxRole.Name = "grpBoxRole";
         this.grpBoxRole.Size = new System.Drawing.Size(446, 434);
         this.grpBoxRole.TabIndex = 6;
         this.grpBoxRole.TabStop = false;
         this.grpBoxRole.Text = "Role";
         // 
         // dgvRole
         // 
         this.dgvRole.AllowUserToAddRows = false;
         this.dgvRole.AllowUserToResizeRows = false;
         this.dgvRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.dgvRole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.dgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvRole.Location = new System.Drawing.Point(6, 19);
         this.dgvRole.MultiSelect = false;
         this.dgvRole.Name = "dgvRole";
         this.dgvRole.ReadOnly = true;
         this.dgvRole.RowHeadersVisible = false;
         this.dgvRole.Size = new System.Drawing.Size(434, 409);
         this.dgvRole.TabIndex = 5;
         // 
         // FrmHakAkses
         // 
         this.AccessibleName = "Master";
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(900, 499);
         this.Controls.Add(this.grpBoxAction);
         this.Controls.Add(this.grpBoxRole);
         this.Controls.Add(this.tlpButtons);
         this.Name = "FrmHakAkses";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Tag = "";
         this.Text = "Hak Akses";
         this.Load += new System.EventHandler(this.FrmHakAkses_Load);
         this.tlpButtons.ResumeLayout(false);
         this.grpBoxAction.ResumeLayout(false);
         this.tableLayoutPanel2.ResumeLayout(false);
         this.tableLayoutPanel2.PerformLayout();
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel1.PerformLayout();
         this.grpBoxRole.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      protected System.Windows.Forms.TableLayoutPanel tlpButtons;
      protected System.Windows.Forms.Button btnTambah;
      protected System.Windows.Forms.Button btnUbah;
      protected System.Windows.Forms.Button btnHapus;
      protected System.Windows.Forms.Button btnTutup;
      private System.Windows.Forms.GroupBox grpBoxAction;
      private System.Windows.Forms.TreeView treeViewAction;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
      private System.Windows.Forms.Button btnUpdate;
      private System.Windows.Forms.CheckBox chkbPilihSemua;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.ComboBox cmbMenu;
      private System.Windows.Forms.GroupBox grpBoxRole;
      private System.Windows.Forms.DataGridView dgvRole;
   }
}