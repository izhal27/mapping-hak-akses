namespace MappingHakAkses.View
{
   partial class FrmEntryOperator
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
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.chkBoxShowCharacters = new System.Windows.Forms.CheckBox();
         this.label11 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.cmbRole = new System.Windows.Forms.ComboBox();
         this.label5 = new System.Windows.Forms.Label();
         this.txtNama = new System.Windows.Forms.TextBox();
         this.txtAlamat = new System.Windows.Forms.TextBox();
         this.txtHp = new System.Windows.Forms.TextBox();
         this.txtLoginID = new System.Windows.Forms.TextBox();
         this.txtPassword = new System.Windows.Forms.TextBox();
         this.txtKonfPassword = new System.Windows.Forms.TextBox();
         this.groupBox1.SuspendLayout();
         this.tableLayoutPanel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.Location = new System.Drawing.Point(0, 289);
         this.panel1.Size = new System.Drawing.Size(394, 40);
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox1.Controls.Add(this.tableLayoutPanel1);
         this.groupBox1.Location = new System.Drawing.Point(12, 12);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(369, 271);
         this.groupBox1.TabIndex = 103;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "[ DATA ]";
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tableLayoutPanel1.ColumnCount = 2;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel1.Controls.Add(this.chkBoxShowCharacters, 1, 6);
         this.tableLayoutPanel1.Controls.Add(this.label11, 0, 4);
         this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
         this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
         this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
         this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
         this.tableLayoutPanel1.Controls.Add(this.cmbRole, 1, 7);
         this.tableLayoutPanel1.Controls.Add(this.label5, 0, 7);
         this.tableLayoutPanel1.Controls.Add(this.txtNama, 1, 0);
         this.tableLayoutPanel1.Controls.Add(this.txtAlamat, 1, 1);
         this.tableLayoutPanel1.Controls.Add(this.txtHp, 1, 2);
         this.tableLayoutPanel1.Controls.Add(this.txtLoginID, 1, 3);
         this.tableLayoutPanel1.Controls.Add(this.txtPassword, 1, 4);
         this.tableLayoutPanel1.Controls.Add(this.txtKonfPassword, 1, 5);
         this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 8;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(357, 240);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // chkBoxShowCharacters
         // 
         this.chkBoxShowCharacters.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.chkBoxShowCharacters.AutoSize = true;
         this.chkBoxShowCharacters.Location = new System.Drawing.Point(90, 186);
         this.chkBoxShowCharacters.Name = "chkBoxShowCharacters";
         this.chkBoxShowCharacters.Size = new System.Drawing.Size(106, 17);
         this.chkBoxShowCharacters.TabIndex = 6;
         this.chkBoxShowCharacters.Text = "Show characters";
         this.chkBoxShowCharacters.UseVisualStyleBackColor = true;
         this.chkBoxShowCharacters.CheckedChanged += new System.EventHandler(this.chkBoxShowCharacters_CheckedChanged);
         // 
         // label11
         // 
         this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label11.AutoSize = true;
         this.label11.Location = new System.Drawing.Point(3, 128);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(53, 13);
         this.label11.TabIndex = 0;
         this.label11.Text = "Password";
         // 
         // label1
         // 
         this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(3, 8);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(35, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Nama";
         // 
         // label2
         // 
         this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(3, 38);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(39, 13);
         this.label2.TabIndex = 0;
         this.label2.Text = "Alamat";
         // 
         // label7
         // 
         this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(3, 68);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(22, 13);
         this.label7.TabIndex = 0;
         this.label7.Text = "HP";
         // 
         // label3
         // 
         this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(3, 98);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(47, 13);
         this.label3.TabIndex = 0;
         this.label3.Text = "Login ID";
         // 
         // label4
         // 
         this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(3, 158);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(81, 13);
         this.label4.TabIndex = 0;
         this.label4.Text = "Konf. Password";
         // 
         // cmbRole
         // 
         this.cmbRole.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmbRole.FormattingEnabled = true;
         this.cmbRole.Location = new System.Drawing.Point(90, 214);
         this.cmbRole.Name = "cmbRole";
         this.cmbRole.Size = new System.Drawing.Size(164, 21);
         this.cmbRole.TabIndex = 7;
         // 
         // label5
         // 
         this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(3, 218);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(29, 13);
         this.label5.TabIndex = 0;
         this.label5.Text = "Role";
         // 
         // txtNama
         // 
         this.txtNama.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.txtNama.Location = new System.Drawing.Point(90, 5);
         this.txtNama.MaxLength = 100;
         this.txtNama.Name = "txtNama";
         this.txtNama.Size = new System.Drawing.Size(250, 20);
         this.txtNama.TabIndex = 0;
         this.txtNama.Tag = "nama";
         // 
         // txtAlamat
         // 
         this.txtAlamat.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.txtAlamat.Location = new System.Drawing.Point(90, 35);
         this.txtAlamat.MaxLength = 150;
         this.txtAlamat.Name = "txtAlamat";
         this.txtAlamat.Size = new System.Drawing.Size(250, 20);
         this.txtAlamat.TabIndex = 0;
         this.txtAlamat.Tag = "alamat";
         // 
         // txtHp
         // 
         this.txtHp.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.txtHp.Location = new System.Drawing.Point(90, 65);
         this.txtHp.MaxLength = 50;
         this.txtHp.Name = "txtHp";
         this.txtHp.Size = new System.Drawing.Size(250, 20);
         this.txtHp.TabIndex = 0;
         this.txtHp.Tag = "hp";
         // 
         // txtLoginID
         // 
         this.txtLoginID.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.txtLoginID.Location = new System.Drawing.Point(90, 95);
         this.txtLoginID.MaxLength = 50;
         this.txtLoginID.Name = "txtLoginID";
         this.txtLoginID.Size = new System.Drawing.Size(250, 20);
         this.txtLoginID.TabIndex = 0;
         this.txtLoginID.Tag = "login_id";
         // 
         // txtPassword
         // 
         this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.txtPassword.Location = new System.Drawing.Point(90, 125);
         this.txtPassword.MaxLength = 30;
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.PasswordChar = '●';
         this.txtPassword.Size = new System.Drawing.Size(250, 20);
         this.txtPassword.TabIndex = 0;
         this.txtPassword.Tag = "password";
         this.txtPassword.UseSystemPasswordChar = true;
         this.txtPassword.ImeModeChanged += new System.EventHandler(this.txtBox_ImeModeChanged);
         // 
         // txtKonfPassword
         // 
         this.txtKonfPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.txtKonfPassword.Location = new System.Drawing.Point(90, 155);
         this.txtKonfPassword.MaxLength = 30;
         this.txtKonfPassword.Name = "txtKonfPassword";
         this.txtKonfPassword.PasswordChar = '●';
         this.txtKonfPassword.Size = new System.Drawing.Size(250, 20);
         this.txtKonfPassword.TabIndex = 0;
         this.txtKonfPassword.Tag = "konf_password";
         this.txtKonfPassword.UseSystemPasswordChar = true;
         this.txtKonfPassword.ImeModeChanged += new System.EventHandler(this.txtBox_ImeModeChanged);
         // 
         // FrmEntryOperator
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(393, 341);
         this.Controls.Add(this.groupBox1);
         this.Name = "FrmEntryOperator";
         this.Text = "FrmEntryOperator";
         this.Load += new System.EventHandler(this.FrmEntryOperator_Load);
         this.Controls.SetChildIndex(this.panel1, 0);
         this.Controls.SetChildIndex(this.groupBox1, 0);
         this.groupBox1.ResumeLayout(false);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel1.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.CheckBox chkBoxShowCharacters;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.ComboBox cmbRole;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.TextBox txtNama;
      private System.Windows.Forms.TextBox txtAlamat;
      private System.Windows.Forms.TextBox txtHp;
      private System.Windows.Forms.TextBox txtLoginID;
      private System.Windows.Forms.TextBox txtPassword;
      private System.Windows.Forms.TextBox txtKonfPassword;
   }
}