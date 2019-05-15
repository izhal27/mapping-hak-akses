namespace MappingHakAkses.View
{
   partial class FrmBaseEntry
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
         this.btnOperasi = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         this.panel1 = new System.Windows.Forms.Panel();
         this.tlpButtons.SuspendLayout();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // tlpButtons
         // 
         this.tlpButtons.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
         this.tlpButtons.BackColor = System.Drawing.SystemColors.Control;
         this.tlpButtons.ColumnCount = 2;
         this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tlpButtons.Controls.Add(this.btnOperasi, 0, 0);
         this.tlpButtons.Controls.Add(this.btnCancel, 1, 0);
         this.tlpButtons.Location = new System.Drawing.Point(42, 3);
         this.tlpButtons.Name = "tlpButtons";
         this.tlpButtons.RowCount = 1;
         this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tlpButtons.Size = new System.Drawing.Size(200, 35);
         this.tlpButtons.TabIndex = 101;
         // 
         // btnOperasi
         // 
         this.btnOperasi.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.btnOperasi.Location = new System.Drawing.Point(22, 6);
         this.btnOperasi.Name = "btnOperasi";
         this.btnOperasi.Size = new System.Drawing.Size(75, 23);
         this.btnOperasi.TabIndex = 99;
         this.btnOperasi.Tag = "ignore";
         this.btnOperasi.Text = "Operasi";
         this.btnOperasi.UseVisualStyleBackColor = true;
         // 
         // btnCancel
         // 
         this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.btnCancel.Location = new System.Drawing.Point(103, 6);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 23);
         this.btnCancel.TabIndex = 100;
         this.btnCancel.Tag = "ignore";
         this.btnCancel.Text = "&Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // panel1
         // 
         this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.panel1.Controls.Add(this.tlpButtons);
         this.panel1.Location = new System.Drawing.Point(0, 210);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(285, 40);
         this.panel1.TabIndex = 102;
         // 
         // FrmBaseEntry
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(284, 262);
         this.Controls.Add(this.panel1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.KeyPreview = true;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "FrmBaseEntry";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Tag = "ignore";
         this.Text = "FrmBaseEntry";
         this.Load += new System.EventHandler(this.FrmBaseEntry_Load);
         this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBaseOperasi_KeyDown);
         this.tlpButtons.ResumeLayout(false);
         this.panel1.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      protected System.Windows.Forms.TableLayoutPanel tlpButtons;
      protected System.Windows.Forms.Button btnOperasi;
      protected System.Windows.Forms.Button btnCancel;
      protected System.Windows.Forms.Panel panel1;
   }
}