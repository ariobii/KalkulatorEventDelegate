namespace TugasKalkulatorLagi
{
    partial class frmHitung
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
            this.lblOperasi = new System.Windows.Forms.Label();
            this.lblNilaiA = new System.Windows.Forms.Label();
            this.lblNilaiB = new System.Windows.Forms.Label();
            this.txtNilaiA = new System.Windows.Forms.TextBox();
            this.txtNilaiB = new System.Windows.Forms.TextBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.cmbOperasi = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.Controls.Add(this.lblOperasi, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNilaiA, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblNilaiB, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNilaiA, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNilaiB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnProses, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbOperasi, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(194, 121);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblOperasi
            // 
            this.lblOperasi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOperasi.AutoSize = true;
            this.lblOperasi.Location = new System.Drawing.Point(3, 0);
            this.lblOperasi.Name = "lblOperasi";
            this.lblOperasi.Size = new System.Drawing.Size(58, 25);
            this.lblOperasi.TabIndex = 0;
            this.lblOperasi.Text = "Operasi";
            this.lblOperasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNilaiA
            // 
            this.lblNilaiA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNilaiA.AutoSize = true;
            this.lblNilaiA.Location = new System.Drawing.Point(3, 25);
            this.lblNilaiA.Name = "lblNilaiA";
            this.lblNilaiA.Size = new System.Drawing.Size(58, 25);
            this.lblNilaiA.TabIndex = 0;
            this.lblNilaiA.Text = "Nilai A";
            this.lblNilaiA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNilaiB
            // 
            this.lblNilaiB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNilaiB.AutoSize = true;
            this.lblNilaiB.Location = new System.Drawing.Point(3, 50);
            this.lblNilaiB.Name = "lblNilaiB";
            this.lblNilaiB.Size = new System.Drawing.Size(58, 25);
            this.lblNilaiB.TabIndex = 0;
            this.lblNilaiB.Text = "Nilai B";
            this.lblNilaiB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNilaiA
            // 
            this.txtNilaiA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNilaiA.Location = new System.Drawing.Point(67, 28);
            this.txtNilaiA.Name = "txtNilaiA";
            this.txtNilaiA.Size = new System.Drawing.Size(124, 20);
            this.txtNilaiA.TabIndex = 2;
            // 
            // txtNilaiB
            // 
            this.txtNilaiB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNilaiB.Location = new System.Drawing.Point(67, 53);
            this.txtNilaiB.Name = "txtNilaiB";
            this.txtNilaiB.Size = new System.Drawing.Size(124, 20);
            this.txtNilaiB.TabIndex = 2;
            // 
            // btnProses
            // 
            this.btnProses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProses.Location = new System.Drawing.Point(116, 95);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(75, 23);
            this.btnProses.TabIndex = 3;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // cmbOperasi
            // 
            this.cmbOperasi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbOperasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperasi.FormattingEnabled = true;
            this.cmbOperasi.Location = new System.Drawing.Point(67, 3);
            this.cmbOperasi.Name = "cmbOperasi";
            this.cmbOperasi.Size = new System.Drawing.Size(124, 21);
            this.cmbOperasi.TabIndex = 4;
            // 
            // frmHitung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 121);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmHitung";
            this.Text = "Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblOperasi;
        private System.Windows.Forms.Label lblNilaiA;
        private System.Windows.Forms.Label lblNilaiB;
        private System.Windows.Forms.TextBox txtNilaiA;
        private System.Windows.Forms.TextBox txtNilaiB;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.ComboBox cmbOperasi;
    }
}