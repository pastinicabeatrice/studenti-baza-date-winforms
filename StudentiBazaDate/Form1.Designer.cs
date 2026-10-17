namespace StudentiBazaDate
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.btnInsereaza = new System.Windows.Forms.Button();
            this.btnActualizeaza = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            this.SuspendLayout();
            this.btnAfiseaza.Location = new System.Drawing.Point(39, 39);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(75, 23);
            this.btnAfiseaza.TabIndex = 0;
            this.btnAfiseaza.Text = "Afiseaza";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            this.btnInsereaza.Location = new System.Drawing.Point(173, 39);
            this.btnInsereaza.Name = "btnInsereaza";
            this.btnInsereaza.Size = new System.Drawing.Size(75, 23);
            this.btnInsereaza.TabIndex = 1;
            this.btnInsereaza.Text = "Insereaza";
            this.btnInsereaza.UseVisualStyleBackColor = true;
            this.btnInsereaza.Click += new System.EventHandler(this.btnInsereaza_Click);
            this.btnActualizeaza.Location = new System.Drawing.Point(317, 39);
            this.btnActualizeaza.Name = "btnActualizeaza";
            this.btnActualizeaza.Size = new System.Drawing.Size(75, 23);
            this.btnActualizeaza.TabIndex = 2;
            this.btnActualizeaza.Text = "Actualizeaza";
            this.btnActualizeaza.UseVisualStyleBackColor = true;
            this.btnActualizeaza.Click += new System.EventHandler(this.btnActualizeaza_Click);
            this.btnSterge.Location = new System.Drawing.Point(456, 39);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(75, 23);
            this.btnSterge.TabIndex = 3;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Location = new System.Drawing.Point(39, 103);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.RowHeadersWidth = 51;
            this.dgvStudenti.RowTemplate.Height = 24;
            this.dgvStudenti.Size = new System.Drawing.Size(492, 277);
            this.dgvStudenti.TabIndex = 4;
            this.dgvStudenti.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStudenti_RowHeaderMouseClick);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.dgvStudenti);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnActualizeaza);
            this.Controls.Add(this.btnInsereaza);
            this.Controls.Add(this.btnAfiseaza);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.Button btnInsereaza;
        private System.Windows.Forms.Button btnActualizeaza;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.DataGridView dgvStudenti;
    }
}

