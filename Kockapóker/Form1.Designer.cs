namespace Kockapóker
{
    partial class Form1
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
            this.tabla_dgv = new System.Windows.Forms.DataGridView();
            this.kategoriak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jatekos1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jatekos2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jatekos_l = new System.Windows.Forms.Label();
            this.kor_l = new System.Windows.Forms.Label();
            this.dobas1_l = new System.Windows.Forms.Label();
            this.dobas2_l = new System.Windows.Forms.Label();
            this.dobas3_l = new System.Windows.Forms.Label();
            this.dobas4_l = new System.Windows.Forms.Label();
            this.dobas5_l = new System.Windows.Forms.Label();
            this.dobas_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabla_dgv
            // 
            this.tabla_dgv.AllowUserToAddRows = false;
            this.tabla_dgv.AllowUserToDeleteRows = false;
            this.tabla_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kategoriak,
            this.Jatekos1,
            this.Jatekos2});
            this.tabla_dgv.Location = new System.Drawing.Point(443, 12);
            this.tabla_dgv.Name = "tabla_dgv";
            this.tabla_dgv.ReadOnly = true;
            this.tabla_dgv.Size = new System.Drawing.Size(345, 375);
            this.tabla_dgv.TabIndex = 0;
            this.tabla_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_dgv_CellClick);
            // 
            // kategoriak
            // 
            this.kategoriak.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kategoriak.HeaderText = "";
            this.kategoriak.Name = "kategoriak";
            this.kategoriak.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Jatekos1
            // 
            this.Jatekos1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Jatekos1.HeaderText = "Játékos 1";
            this.Jatekos1.Name = "Jatekos1";
            this.Jatekos1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Jatekos2
            // 
            this.Jatekos2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Jatekos2.HeaderText = "Játékos 2";
            this.Jatekos2.Name = "Jatekos2";
            this.Jatekos2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Jatekos_l
            // 
            this.Jatekos_l.AutoSize = true;
            this.Jatekos_l.Location = new System.Drawing.Point(199, 12);
            this.Jatekos_l.Name = "Jatekos_l";
            this.Jatekos_l.Size = new System.Drawing.Size(35, 13);
            this.Jatekos_l.TabIndex = 1;
            this.Jatekos_l.Text = "label1";
            // 
            // kor_l
            // 
            this.kor_l.AutoSize = true;
            this.kor_l.Location = new System.Drawing.Point(126, 12);
            this.kor_l.Name = "kor_l";
            this.kor_l.Size = new System.Drawing.Size(35, 13);
            this.kor_l.TabIndex = 2;
            this.kor_l.Text = "label1";
            // 
            // dobas1_l
            // 
            this.dobas1_l.AutoSize = true;
            this.dobas1_l.Location = new System.Drawing.Point(52, 99);
            this.dobas1_l.Name = "dobas1_l";
            this.dobas1_l.Size = new System.Drawing.Size(13, 13);
            this.dobas1_l.TabIndex = 3;
            this.dobas1_l.Text = "0";
            // 
            // dobas2_l
            // 
            this.dobas2_l.AutoSize = true;
            this.dobas2_l.Location = new System.Drawing.Point(120, 99);
            this.dobas2_l.Name = "dobas2_l";
            this.dobas2_l.Size = new System.Drawing.Size(13, 13);
            this.dobas2_l.TabIndex = 4;
            this.dobas2_l.Text = "0";
            // 
            // dobas3_l
            // 
            this.dobas3_l.AutoSize = true;
            this.dobas3_l.Location = new System.Drawing.Point(193, 99);
            this.dobas3_l.Name = "dobas3_l";
            this.dobas3_l.Size = new System.Drawing.Size(13, 13);
            this.dobas3_l.TabIndex = 5;
            this.dobas3_l.Text = "0";
            // 
            // dobas4_l
            // 
            this.dobas4_l.AutoSize = true;
            this.dobas4_l.Location = new System.Drawing.Point(261, 99);
            this.dobas4_l.Name = "dobas4_l";
            this.dobas4_l.Size = new System.Drawing.Size(13, 13);
            this.dobas4_l.TabIndex = 6;
            this.dobas4_l.Text = "0";
            // 
            // dobas5_l
            // 
            this.dobas5_l.AutoSize = true;
            this.dobas5_l.Location = new System.Drawing.Point(337, 99);
            this.dobas5_l.Name = "dobas5_l";
            this.dobas5_l.Size = new System.Drawing.Size(13, 13);
            this.dobas5_l.TabIndex = 7;
            this.dobas5_l.Text = "0";
            // 
            // dobas_btn
            // 
            this.dobas_btn.Location = new System.Drawing.Point(132, 171);
            this.dobas_btn.Name = "dobas_btn";
            this.dobas_btn.Size = new System.Drawing.Size(123, 23);
            this.dobas_btn.TabIndex = 8;
            this.dobas_btn.Text = "Dobás";
            this.dobas_btn.UseVisualStyleBackColor = true;
            this.dobas_btn.Click += new System.EventHandler(this.dobas_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dobas_btn);
            this.Controls.Add(this.dobas5_l);
            this.Controls.Add(this.dobas4_l);
            this.Controls.Add(this.dobas3_l);
            this.Controls.Add(this.dobas2_l);
            this.Controls.Add(this.dobas1_l);
            this.Controls.Add(this.kor_l);
            this.Controls.Add(this.Jatekos_l);
            this.Controls.Add(this.tabla_dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabla_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jatekos1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jatekos2;
        private System.Windows.Forms.Label Jatekos_l;
        private System.Windows.Forms.Label kor_l;
        private System.Windows.Forms.Label dobas1_l;
        private System.Windows.Forms.Label dobas2_l;
        private System.Windows.Forms.Label dobas3_l;
        private System.Windows.Forms.Label dobas4_l;
        private System.Windows.Forms.Label dobas5_l;
        private System.Windows.Forms.Button dobas_btn;
    }
}

