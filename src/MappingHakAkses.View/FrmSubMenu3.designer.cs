﻿namespace MappingHakAkses.View
{
   partial class FrmSubMenu3
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
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.btn1 = new System.Windows.Forms.Button();
         this.btn2 = new System.Windows.Forms.Button();
         this.btn3 = new System.Windows.Forms.Button();
         this.btnExit = new System.Windows.Forms.Button();
         this.tableLayoutPanel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.ColumnCount = 1;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel1.Controls.Add(this.btn1, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.btn2, 0, 1);
         this.tableLayoutPanel1.Controls.Add(this.btn3, 0, 2);
         this.tableLayoutPanel1.Controls.Add(this.btnExit, 0, 3);
         this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 71);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 4;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 120);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // btn1
         // 
         this.btn1.AccessibleName = "";
         this.btn1.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.btn1.Location = new System.Drawing.Point(92, 3);
         this.btn1.Name = "btn1";
         this.btn1.Size = new System.Drawing.Size(75, 23);
         this.btn1.TabIndex = 0;
         this.btn1.Tag = "Button - 1";
         this.btn1.Text = "&Button - 1";
         this.btn1.UseVisualStyleBackColor = true;
         // 
         // btn2
         // 
         this.btn2.AccessibleName = "";
         this.btn2.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.btn2.Location = new System.Drawing.Point(92, 33);
         this.btn2.Name = "btn2";
         this.btn2.Size = new System.Drawing.Size(75, 23);
         this.btn2.TabIndex = 0;
         this.btn2.Tag = "Button - 2";
         this.btn2.Text = "B&utton - 2";
         this.btn2.UseVisualStyleBackColor = true;
         // 
         // btn3
         // 
         this.btn3.AccessibleName = "";
         this.btn3.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.btn3.Location = new System.Drawing.Point(92, 63);
         this.btn3.Name = "btn3";
         this.btn3.Size = new System.Drawing.Size(75, 23);
         this.btn3.TabIndex = 0;
         this.btn3.Tag = "Button - 3";
         this.btn3.Text = "Bu&tton - 3";
         this.btn3.UseVisualStyleBackColor = true;
         // 
         // btnExit
         // 
         this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnExit.Location = new System.Drawing.Point(92, 93);
         this.btnExit.Name = "btnExit";
         this.btnExit.Size = new System.Drawing.Size(75, 23);
         this.btnExit.TabIndex = 0;
         this.btnExit.Tag = "ignore";
         this.btnExit.Text = "&Exit";
         this.btnExit.UseVisualStyleBackColor = true;
         // 
         // FrmSubMenu3
         // 
         this.AccessibleName = "Menu - 3";
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(284, 262);
         this.Controls.Add(this.tableLayoutPanel1);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "FrmSubMenu3";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Sub Menu - 3";
         this.Load += new System.EventHandler(this.FrmSubMenu3_Load);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.Button btn1;
      private System.Windows.Forms.Button btn2;
      private System.Windows.Forms.Button btn3;
      private System.Windows.Forms.Button btnExit;
   }
}