namespace StudentiBazaDate
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMatricol = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbFacultate = new System.Windows.Forms.TextBox();
            this.tbMedie = new System.Windows.Forms.TextBox();
            this.btnInsereaza = new System.Windows.Forms.Button();
            this.btnActualizeaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricol";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nume";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Facultate";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Medie";
            this.tbMatricol.Location = new System.Drawing.Point(103, 28);
            this.tbMatricol.Name = "tbMatricol";
            this.tbMatricol.Size = new System.Drawing.Size(100, 22);
            this.tbMatricol.TabIndex = 4;
            this.tbNume.Location = new System.Drawing.Point(103, 77);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(100, 22);
            this.tbNume.TabIndex = 5;
            this.tbFacultate.Location = new System.Drawing.Point(103, 121);
            this.tbFacultate.Name = "tbFacultate";
            this.tbFacultate.Size = new System.Drawing.Size(100, 22);
            this.tbFacultate.TabIndex = 6;
            this.tbMedie.Location = new System.Drawing.Point(103, 173);
            this.tbMedie.Name = "tbMedie";
            this.tbMedie.Size = new System.Drawing.Size(100, 22);
            this.tbMedie.TabIndex = 7;
            this.btnInsereaza.Location = new System.Drawing.Point(16, 223);
            this.btnInsereaza.Name = "btnInsereaza";
            this.btnInsereaza.Size = new System.Drawing.Size(187, 30);
            this.btnInsereaza.TabIndex = 8;
            this.btnInsereaza.Text = "Insereaza";
            this.btnInsereaza.UseVisualStyleBackColor = true;
            this.btnInsereaza.Click += new System.EventHandler(this.btnInsereaza_Click);
            this.btnActualizeaza.Location = new System.Drawing.Point(16, 268);
            this.btnActualizeaza.Name = "btnActualizeaza";
            this.btnActualizeaza.Size = new System.Drawing.Size(187, 25);
            this.btnActualizeaza.TabIndex = 9;
            this.btnActualizeaza.Text = "Actualizeaza";
            this.btnActualizeaza.UseVisualStyleBackColor = true;
            this.btnActualizeaza.Click += new System.EventHandler(this.btnActualizeaza_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 350);
            this.Controls.Add(this.btnActualizeaza);
            this.Controls.Add(this.btnInsereaza);
            this.Controls.Add(this.tbMedie);
            this.Controls.Add(this.tbFacultate);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.tbMatricol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMatricol;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbFacultate;
        private System.Windows.Forms.TextBox tbMedie;
        private System.Windows.Forms.Button btnInsereaza;
        private System.Windows.Forms.Button btnActualizeaza;
    }
}