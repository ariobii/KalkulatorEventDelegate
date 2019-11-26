namespace TugasKalkulatorLagi
{
    partial class frmHasil
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
            this.grpHasil = new System.Windows.Forms.GroupBox();
            this.lstHasil = new System.Windows.Forms.ListBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpHasil.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.grpHasil, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnHitung, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(354, 286);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grpHasil
            // 
            this.grpHasil.Controls.Add(this.lstHasil);
            this.grpHasil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpHasil.Location = new System.Drawing.Point(3, 3);
            this.grpHasil.Name = "grpHasil";
            this.grpHasil.Size = new System.Drawing.Size(348, 250);
            this.grpHasil.TabIndex = 0;
            this.grpHasil.TabStop = false;
            this.grpHasil.Text = "[Hasil]";
            // 
            // lstHasil
            // 
            this.lstHasil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstHasil.FormattingEnabled = true;
            this.lstHasil.Location = new System.Drawing.Point(3, 16);
            this.lstHasil.Name = "lstHasil";
            this.lstHasil.Size = new System.Drawing.Size(342, 231);
            this.lstHasil.TabIndex = 0;
            // 
            // btnHitung
            // 
            this.btnHitung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHitung.Location = new System.Drawing.Point(3, 259);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(348, 24);
            this.btnHitung.TabIndex = 1;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // frmHasil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 286);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmHasil";
            this.Text = "Hasil Perhitungan";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpHasil.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpHasil;
        private System.Windows.Forms.ListBox lstHasil;
        private System.Windows.Forms.Button btnHitung;
    }
}

