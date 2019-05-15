namespace MappingHakAkses.View
{
   partial class FrmEntryHakAkses
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
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.txtKode = new System.Windows.Forms.TextBox();
         this.txtNama = new System.Windows.Forms.TextBox();
         this.txtKeterangan = new System.Windows.Forms.TextBox();
         this.groupBox1.SuspendLayout();
         this.tableLayoutPanel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.Location = new System.Drawing.Point(0, 182);
         this.panel1.Size = new System.Drawing.Size(379, 40);
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox1.Controls.Add(this.tableLayoutPanel1);
         this.groupBox1.Location = new System.Drawing.Point(12, 12);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(354, 165);
         this.groupBox1.TabIndex = 102;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "[ DATA ]";
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tableLayoutPanel1.ColumnCount = 2;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
         this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
         this.tableLayoutPanel1.Controls.Add(this.txtKode, 1, 0);
         this.tableLayoutPanel1.Controls.Add(this.txtNama, 1, 1);
         this.tableLayoutPanel1.Controls.Add(this.txtKeterangan, 1, 2);
         this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 3;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(342, 140);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(3, 8);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(32, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Kode";
         // 
         // label2
         // 
         this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(3, 93);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(62, 13);
         this.label2.TabIndex = 0;
         this.label2.Text = "Keterangan";
         // 
         // label3
         // 
         this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(3, 38);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(35, 13);
         this.label3.TabIndex = 0;
         this.label3.Text = "Nama";
         // 
         // txtKode
         // 
         this.txtKode.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.txtKode.Location = new System.Drawing.Point(71, 5);
         this.txtKode.MaxLength = 20;
         this.txtKode.Name = "txtKode";
         this.txtKode.Size = new System.Drawing.Size(250, 20);
         this.txtKode.TabIndex = 0;
         this.txtKode.Tag = "kode";
         // 
         // txtNama
         // 
         this.txtNama.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.txtNama.Location = new System.Drawing.Point(71, 35);
         this.txtNama.MaxLength = 100;
         this.txtNama.Name = "txtNama";
         this.txtNama.Size = new System.Drawing.Size(250, 20);
         this.txtNama.TabIndex = 1;
         this.txtNama.Tag = "nama";
         // 
         // txtKeterangan
         // 
         this.txtKeterangan.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.txtKeterangan.Location = new System.Drawing.Point(71, 65);
         this.txtKeterangan.MaxLength = 150;
         this.txtKeterangan.Multiline = true;
         this.txtKeterangan.Name = "txtKeterangan";
         this.txtKeterangan.Size = new System.Drawing.Size(250, 70);
         this.txtKeterangan.TabIndex = 2;
         this.txtKeterangan.Tag = "keterangan";
         // 
         // FrmEntryHakAkses
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(378, 234);
         this.Controls.Add(this.groupBox1);
         this.Name = "FrmEntryHakAkses";
         this.Text = "Enty Role";
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
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox txtKode;
      private System.Windows.Forms.TextBox txtNama;
      private System.Windows.Forms.TextBox txtKeterangan;
   }
}