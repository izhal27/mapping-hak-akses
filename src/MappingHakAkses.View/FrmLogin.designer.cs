namespace MappingHakAkses.View
{
   partial class FrmLogin
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
         this.btnLogin = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.chkBoxShowCharacters = new System.Windows.Forms.CheckBox();
         this.txtLoginID = new System.Windows.Forms.TextBox();
         this.txtPassword = new System.Windows.Forms.TextBox();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.groupBox1.SuspendLayout();
         this.tableLayoutPanel2.SuspendLayout();
         this.tableLayoutPanel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
         this.label1.Location = new System.Drawing.Point(3, 5);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(61, 19);
         this.label1.TabIndex = 1;
         this.label1.Text = "Login ID";
         // 
         // label2
         // 
         this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
         this.label2.Location = new System.Drawing.Point(3, 35);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(67, 19);
         this.label2.TabIndex = 2;
         this.label2.Text = "Password";
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::MappingHakAkses.View.Properties.Resources._lock;
         this.pictureBox1.Location = new System.Drawing.Point(12, 12);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(155, 155);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox1.Controls.Add(this.tableLayoutPanel2);
         this.groupBox1.Controls.Add(this.tableLayoutPanel1);
         this.groupBox1.Location = new System.Drawing.Point(173, 12);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(296, 155);
         this.groupBox1.TabIndex = 7;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "[ DATA ]";
         // 
         // tableLayoutPanel2
         // 
         this.tableLayoutPanel2.ColumnCount = 2;
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
         this.tableLayoutPanel2.Controls.Add(this.btnLogin, 0, 0);
         this.tableLayoutPanel2.Controls.Add(this.btnCancel, 1, 0);
         this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 117);
         this.tableLayoutPanel2.Name = "tableLayoutPanel2";
         this.tableLayoutPanel2.RowCount = 1;
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel2.Size = new System.Drawing.Size(282, 30);
         this.tableLayoutPanel2.TabIndex = 8;
         // 
         // btnLogin
         // 
         this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.btnLogin.Location = new System.Drawing.Point(123, 3);
         this.btnLogin.Name = "btnLogin";
         this.btnLogin.Size = new System.Drawing.Size(75, 23);
         this.btnLogin.TabIndex = 2;
         this.btnLogin.Text = "&Login";
         this.btnLogin.UseVisualStyleBackColor = true;
         this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
         // 
         // btnCancel
         // 
         this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnCancel.Location = new System.Drawing.Point(204, 3);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 23);
         this.btnCancel.TabIndex = 10;
         this.btnCancel.Text = "&Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.ColumnCount = 2;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.Controls.Add(this.chkBoxShowCharacters, 1, 2);
         this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
         this.tableLayoutPanel1.Controls.Add(this.txtLoginID, 1, 0);
         this.tableLayoutPanel1.Controls.Add(this.txtPassword, 1, 1);
         this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 21);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 3;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(282, 90);
         this.tableLayoutPanel1.TabIndex = 8;
         // 
         // chkBoxShowCharacters
         // 
         this.chkBoxShowCharacters.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.chkBoxShowCharacters.AutoSize = true;
         this.chkBoxShowCharacters.Location = new System.Drawing.Point(76, 66);
         this.chkBoxShowCharacters.Name = "chkBoxShowCharacters";
         this.chkBoxShowCharacters.Size = new System.Drawing.Size(106, 17);
         this.chkBoxShowCharacters.TabIndex = 8;
         this.chkBoxShowCharacters.Text = "Show characters";
         this.chkBoxShowCharacters.UseVisualStyleBackColor = true;
         this.chkBoxShowCharacters.CheckedChanged += new System.EventHandler(this.chkBoxShowCharacters_CheckedChanged);
         // 
         // txtLoginID
         // 
         this.txtLoginID.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.txtLoginID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtLoginID.Location = new System.Drawing.Point(76, 3);
         this.txtLoginID.Name = "txtLoginID";
         this.txtLoginID.Size = new System.Drawing.Size(200, 23);
         this.txtLoginID.TabIndex = 0;
         this.txtLoginID.Tag = "login_id";
         // 
         // txtPassword
         // 
         this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtPassword.Location = new System.Drawing.Point(76, 33);
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.PasswordChar = '●';
         this.txtPassword.Size = new System.Drawing.Size(200, 23);
         this.txtPassword.TabIndex = 1;
         this.txtPassword.Tag = "password";
         this.txtPassword.UseSystemPasswordChar = true;
         this.txtPassword.ImeModeChanged += new System.EventHandler(this.txtPassword_ImeModeChanged);
         // 
         // FrmLogin
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.Control;
         this.ClientSize = new System.Drawing.Size(480, 179);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.pictureBox1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.KeyPreview = true;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "FrmLogin";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Tag = "ignore";
         this.Text = "Login";
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogin_FormClosed);
         this.Load += new System.EventHandler(this.FrmLogin_Load);
         this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyDown);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.groupBox1.ResumeLayout(false);
         this.tableLayoutPanel2.ResumeLayout(false);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel1.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
      private System.Windows.Forms.Button btnLogin;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.TextBox txtLoginID;
      private System.Windows.Forms.TextBox txtPassword;
      private System.Windows.Forms.CheckBox chkBoxShowCharacters;
   }
}