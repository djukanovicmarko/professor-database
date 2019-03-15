namespace Domaci5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtZvanje = new System.Windows.Forms.TextBox();
            this.txtKatedra = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnPromeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.dgProfesori = new System.Windows.Forms.DataGridView();
            this.mniStripXml = new System.Windows.Forms.MenuStrip();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniXMLUvezi = new System.Windows.Forms.ToolStripMenuItem();
            this.mniXMLIzvezi = new System.Windows.Forms.ToolStripMenuItem();
            this.izvestajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesori)).BeginInit();
            this.mniStripXml.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zvanje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Katedra:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(126, 60);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(225, 20);
            this.txtIme.TabIndex = 4;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(126, 94);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(225, 20);
            this.txtPrezime.TabIndex = 5;
            // 
            // txtZvanje
            // 
            this.txtZvanje.Location = new System.Drawing.Point(126, 128);
            this.txtZvanje.Name = "txtZvanje";
            this.txtZvanje.Size = new System.Drawing.Size(225, 20);
            this.txtZvanje.TabIndex = 6;
            // 
            // txtKatedra
            // 
            this.txtKatedra.Location = new System.Drawing.Point(126, 162);
            this.txtKatedra.Name = "txtKatedra";
            this.txtKatedra.Size = new System.Drawing.Size(225, 20);
            this.txtKatedra.TabIndex = 7;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(35, 205);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnPromeni
            // 
            this.btnPromeni.Location = new System.Drawing.Point(151, 205);
            this.btnPromeni.Name = "btnPromeni";
            this.btnPromeni.Size = new System.Drawing.Size(75, 23);
            this.btnPromeni.TabIndex = 9;
            this.btnPromeni.Text = "Azuriraj";
            this.btnPromeni.UseVisualStyleBackColor = true;
            this.btnPromeni.Click += new System.EventHandler(this.btnPromeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(265, 205);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 10;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(375, 205);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdi.TabIndex = 11;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(481, 205);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 12;
            this.btnOdustani.Text = "Ponisti";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // dgProfesori
            // 
            this.dgProfesori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProfesori.Location = new System.Drawing.Point(12, 245);
            this.dgProfesori.Name = "dgProfesori";
            this.dgProfesori.Size = new System.Drawing.Size(609, 150);
            this.dgProfesori.TabIndex = 13;
            this.dgProfesori.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStudenti_CellClick);
            // 
            // mniStripXml
            // 
            this.mniStripXml.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem,
            this.izvestajiToolStripMenuItem});
            this.mniStripXml.Location = new System.Drawing.Point(0, 0);
            this.mniStripXml.Name = "mniStripXml";
            this.mniStripXml.Size = new System.Drawing.Size(633, 24);
            this.mniStripXml.TabIndex = 15;
            this.mniStripXml.Text = "mniStripXML";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniXMLUvezi,
            this.mniXMLIzvezi});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // mniXMLUvezi
            // 
            this.mniXMLUvezi.Name = "mniXMLUvezi";
            this.mniXMLUvezi.Size = new System.Drawing.Size(152, 22);
            this.mniXMLUvezi.Text = "Uvezi";
            this.mniXMLUvezi.Click += new System.EventHandler(this.mniXMLUvezi_Click);
            // 
            // mniXMLIzvezi
            // 
            this.mniXMLIzvezi.Name = "mniXMLIzvezi";
            this.mniXMLIzvezi.Size = new System.Drawing.Size(152, 22);
            this.mniXMLIzvezi.Text = "Izvezi";
            this.mniXMLIzvezi.Click += new System.EventHandler(this.mniXMLIzvezi_Click);
            // 
            // izvestajiToolStripMenuItem
            // 
            this.izvestajiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profesoriToolStripMenuItem});
            this.izvestajiToolStripMenuItem.Name = "izvestajiToolStripMenuItem";
            this.izvestajiToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.izvestajiToolStripMenuItem.Text = "Izvestaji";
            // 
            // profesoriToolStripMenuItem
            // 
            this.profesoriToolStripMenuItem.Name = "profesoriToolStripMenuItem";
            this.profesoriToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.profesoriToolStripMenuItem.Text = "Profesori";
            this.profesoriToolStripMenuItem.Click += new System.EventHandler(this.mniIzvestajiProfesori_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 442);
            this.Controls.Add(this.dgProfesori);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnPromeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtKatedra);
            this.Controls.Add(this.txtZvanje);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mniStripXml);
            this.MainMenuStrip = this.mniStripXml;
            this.Name = "Form1";
            this.Text = "Profesori";
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesori)).EndInit();
            this.mniStripXml.ResumeLayout(false);
            this.mniStripXml.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtZvanje;
        private System.Windows.Forms.TextBox txtKatedra;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnPromeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.DataGridView dgProfesori;
        private System.Windows.Forms.MenuStrip mniStripXml;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniXMLUvezi;
        private System.Windows.Forms.ToolStripMenuItem mniXMLIzvezi;
        private System.Windows.Forms.ToolStripMenuItem izvestajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoriToolStripMenuItem;
    }
}

