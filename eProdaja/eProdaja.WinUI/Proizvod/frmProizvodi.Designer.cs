namespace eProdaja.WinUI.Proizvod
{
    partial class frmProizvodi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Dodaj = new System.Windows.Forms.Button();
            this.Sacuvaj = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.cmbVrstaProizvoda = new System.Windows.Forms.ComboBox();
            this.cmbJediniceMjere = new System.Windows.Forms.ComboBox();
            this.proizvodiGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vrsta Proizvoda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Šifra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Naziv";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cijena";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Slika";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Jed. mjere";
            // 
            // Dodaj
            // 
            this.Dodaj.Location = new System.Drawing.Point(518, 195);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(78, 35);
            this.Dodaj.TabIndex = 6;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = true;
            // 
            // Sacuvaj
            // 
            this.Sacuvaj.Location = new System.Drawing.Point(1055, 268);
            this.Sacuvaj.Name = "Sacuvaj";
            this.Sacuvaj.Size = new System.Drawing.Size(122, 49);
            this.Sacuvaj.TabIndex = 7;
            this.Sacuvaj.Text = "Sacuvaj";
            this.Sacuvaj.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(1009, 37);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(168, 182);
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(188, 84);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(321, 26);
            this.txtSifra.TabIndex = 9;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(188, 121);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(321, 26);
            this.txtNaziv.TabIndex = 10;
            // 
            // txtSlika
            // 
            this.txtSlika.Location = new System.Drawing.Point(188, 199);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(321, 26);
            this.txtSlika.TabIndex = 11;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(188, 158);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(106, 26);
            this.txtCijena.TabIndex = 12;
            // 
            // cmbVrstaProizvoda
            // 
            this.cmbVrstaProizvoda.FormattingEnabled = true;
            this.cmbVrstaProizvoda.Location = new System.Drawing.Point(188, 43);
            this.cmbVrstaProizvoda.Name = "cmbVrstaProizvoda";
            this.cmbVrstaProizvoda.Size = new System.Drawing.Size(321, 28);
            this.cmbVrstaProizvoda.TabIndex = 13;
            this.cmbVrstaProizvoda.SelectedIndexChanged += new System.EventHandler(this.cmbVrstaProizvoda_SelectedIndexChanged);
            // 
            // cmbJediniceMjere
            // 
            this.cmbJediniceMjere.FormattingEnabled = true;
            this.cmbJediniceMjere.Location = new System.Drawing.Point(388, 157);
            this.cmbJediniceMjere.Name = "cmbJediniceMjere";
            this.cmbJediniceMjere.Size = new System.Drawing.Size(121, 28);
            this.cmbJediniceMjere.TabIndex = 14;
            // 
            // proizvodiGrid
            // 
            this.proizvodiGrid.ColumnHeadersHeight = 34;
            this.proizvodiGrid.Location = new System.Drawing.Point(30, 341);
            this.proizvodiGrid.Name = "proizvodiGrid";
            this.proizvodiGrid.RowHeadersWidth = 62;
            this.proizvodiGrid.Size = new System.Drawing.Size(1175, 254);
            this.proizvodiGrid.TabIndex = 0;
            // 
            // frmProizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 625);
            this.Controls.Add(this.proizvodiGrid);
            this.Controls.Add(this.cmbJediniceMjere);
            this.Controls.Add(this.cmbVrstaProizvoda);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.Sacuvaj);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmProizvodi";
            this.Text = "frmProizvodi";
            this.Load += new System.EventHandler(this.frmProizvodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.Button Sacuvaj;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.ComboBox cmbVrstaProizvoda;
        private System.Windows.Forms.ComboBox cmbJediniceMjere;
        private System.Windows.Forms.DataGridView proizvodiGrid;
    }
}