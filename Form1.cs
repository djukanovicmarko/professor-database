using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Domaci5
{
    public partial class Form1 : Form
    {
       // Lista u kojoj ce se nalaziti podaci o profesorima
        List<Profesor> profesoriList = new List<Profesor>();
        // Promenljiva koja cuva informaciju koja akcija je odabrana
        string akcija = "";
        // Promenljiva koja cuva indeks selektovanog reda
        int indeksSelektovanog = -1;


        // Konstruktor forme
        public Form1()
        {
            /* Inicijalizacija svih komponenti koje se nalaze na formi 
             (dugmici, labele, ...)*/
            InitializeComponent();

            /* Podesavanja DataGridView kontrole
             Nije dozvoljeno korisniku da dodaje redove direktno u kontroli
             vec samo kroz tekstualna polja*/
            dgProfesori.AllowUserToAddRows = false;
            // Nije dozvoljeno korisniku da brise redove sa podacima
            dgProfesori.AllowUserToDeleteRows = false;
            // Korisnik ne moze da menja sadrzaj u poljima, vec samo da ih cita
            dgProfesori.ReadOnly = true;
            /* Ne zelimo da kontrola sama generise imena kolona, 
             vec cemo to uraditi kroz kod*/
            dgProfesori.AutoGenerateColumns = false;

            /* Dodajemo kolone u DataGridView kontrolu.
             Naziv kolone je "ID". 
             Tekst u zaglavlju je "ID", kolona nece biti vidljiva*/
            dgProfesori.Columns.Add("ID", "ID");
            dgProfesori.Columns["ID"].Visible = false;
            /* Naziv kolone je "imeProfesora". 
             Tekst prikazan u zaglavlju je "Ime"*/
            dgProfesori.Columns.Add("imeProfesora", "Ime");
            /* Naziv kolone je "prezimeProfesora". 
             Tekst prikazan u zaglavlju je "Prezime"*/
            dgProfesori.Columns.Add("prezimeProfesora", "Prezime");
            /* Naziv kolone je "Zvanje". 
             Tekst prikazan u zaglavlju je "Zvanje"*/
            dgProfesori.Columns.Add("Zvanje", "Zvanje");
            /* Naziv kolone je "Katedra". 
            Tekst prikazan u zaglavlju je "Katedra"*/
            dgProfesori.Columns.Add("Katedra", "Katedra");
            /* Pozivamo pomocne metode koje ce kreirati odgovarajuci 
             izgled komponenti na formi: tekstualnih polja i dugmica.*/
            txtDisabled();
            btnChangeEnabled();
            btnSubmitDisabled();

            /* Ucitavaju se svi profesori koji se vec nalaze u bazi i 
             prikazuju se u okviru DataGridView kontrole.*/ 
            prikaziProfesoreDGV();
        }

        // Pomocna metoda koja onemogucava upis u tekstualna polja
        private void txtDisabled()
        {
            txtIme.Enabled = false;
            txtPrezime.Enabled = false;
            txtZvanje.Enabled = false;
            txtKatedra.Enabled = false;
        }

        // Pomocna metoda koja omogucava upis u tekstualna polja
        private void txtEnabled()
        {
            txtIme.Enabled = true;
            txtPrezime.Enabled = true;
            txtZvanje.Enabled = true;
            txtKatedra.Enabled = true;
        }

        // Pomocna metoda koja onemogucava rad sa dugmicima dodaj, promeni i obrisi
        private void btnChangeDisabled()
        {
            btnDodaj.Enabled = false;
            btnPromeni.Enabled = false;
            btnObrisi.Enabled = false;
        }

        // Pomocna metoda koja omogucava rad sa dugmicima dodaj, promeni i obrisi
        private void btnChangeEnabled()
        {
            btnDodaj.Enabled = true;
            btnPromeni.Enabled = true;
            btnObrisi.Enabled = true;
        }

        // Pomocna metoda koja onemogucava rad sa dugmicima potvrdi i odustani
        private void btnSubmitDisabled()
        {
            btnPotvrdi.Enabled = false;
            btnOdustani.Enabled = false;
        }

        // Pomocna metoda koja omogucava rad sa dugmicima potvrdi i odustani
        private void btnSubmitEnabled()
        {
            btnPotvrdi.Enabled = true;
            btnOdustani.Enabled = true;
        }

        // Pomocna metoda koja ponistava unos u tekstualnim poljima
        private void ponistiUnosTxt()
        {
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtZvanje.Text = "";
            txtKatedra.Text = "";
        }

        /* Metoda koja prikazuje podatke o odabranom profesoru (selektovanom redu) 
         u tekstualnim poljima*/
        private void prikaziProfesoraTxt()
        {
            int idSelektovanog = (int)dgProfesori.SelectedRows[0].Cells["ID"].Value;
            Profesor selektovaniProfesor =
                profesoriList.Where(x => x.ID == idSelektovanog).FirstOrDefault();
            if (selektovaniProfesor != null)
            {
                txtIme.Text = selektovaniProfesor.Ime;
                txtPrezime.Text = selektovaniProfesor.Prezime;
                txtZvanje.Text = selektovaniProfesor.Zvanje;
                txtKatedra.Text = selektovaniProfesor.Katedra;
            }
        }

        // Metoda koja prikazuje podatke o svim profesorima u DataGridView kontroli 
        private void prikaziProfesoreDGV()
        {
            // Ucitavaju se podaci o svim profesorima iz baze podataka
            profesoriList = new Profesor().ucitajProfesora();
            // Brisu se svi profesori koji su prikazani u DataGridView kontroli
            dgProfesori.Rows.Clear();
            /* Prikazuju se podaci u DataGridView kontroli tako sto se dodaju
             novi redovi, a zatim se u odgovarajuce celije upisuju vrednosti*/
            for (int i = 0; i < profesoriList.Count; i++)
            {
                dgProfesori.Rows.Add();
                dgProfesori.Rows[i].Cells["ID"].Value =
                    profesoriList[i].ID;
                dgProfesori.Rows[i].Cells["imeProfesora"].Value =
                    profesoriList[i].Ime;
                dgProfesori.Rows[i].Cells["prezimeProfesora"].Value =
                    profesoriList[i].Prezime;
                dgProfesori.Rows[i].Cells["Zvanje"].Value =
                    profesoriList[i].Zvanje;
                dgProfesori.Rows[i].Cells["Katedra"].Value =
                    profesoriList[i].Katedra;
            }
            // Ponistava se unos u tekstualnim poljima
            ponistiUnosTxt();
            /* DataGridView podrazumevano selektuje prvi red prvu kolonu
             sto za nas nije zeljeno ponasanje*/
            dgProfesori.CurrentCell = null;
            /* Ukoliko ima podataka o studentima u bazi selektuj red i 
             prikazi podatke o tom studentu u tekstulanim poljima*/
            if (profesoriList.Count > 0)
            {
                if (indeksSelektovanog != -1)
                    dgProfesori.Rows[indeksSelektovanog].Selected = true;
                else
                    dgProfesori.Rows[0].Selected = true;
                prikaziProfesoraTxt();
            }
        }

        // Obrada dogadjaja klika na dugme Dodaj
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            // Ponistava se unos u tekstualnim poljima
            ponistiUnosTxt();
            // Omogucava se unos u tekstualna polja
            txtEnabled();
            /* Omogucava se klik na dugmice potvrdi i odustani, 
             kako bi se zavrsilo dodavanje novog profesora*/
            btnSubmitEnabled();
            /* Onemogucava se klik na dugmice dodaj, promeni i obrisi
             dok se ne zavrsi trenutno dodavanje*/
            btnChangeDisabled();
            // Promenljiva akcija dobija vrednost "dodaj"
            akcija = "Dodaj";
        }

        // Obrada dogadjaja klika na dugme Obrisi
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            /* Provera da li je neki red selektovan za brisanje
             Ukoliko nije, korisnik se obavestava porukom*/
            if (dgProfesori.SelectedRows.Count > 0)
            {
                // Poruka korisniku kojom se od njega trazi da potvrdi brisanje
                if (MessageBox.Show("Da li zelite da obrisete odabranog profesora?",
                "Potvrda brisanja", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Odredjuje se ID profesora kojeg je potrebno obrisati
                    int idSelektovanog = (int)dgProfesori.SelectedRows[0].Cells["ID"].Value;
                    // Na osnovu ID-a iz liste uzimamo odgovarajuceg studenta
                    Profesor selektovaniProfesor = profesoriList.Where(x => x.ID == 
                        idSelektovanog).FirstOrDefault();
                    /* Brisanje profesora pomocu metode obrisiStudenta koja se 
                     nalazi u klasi Student*/
                    if (selektovaniProfesor != null)
                    {
                        selektovaniProfesor.obrisiProfesora();
                    }
                    // Nakon brisanja, prikazuje se prvi red u DataGridView kontroli
                    indeksSelektovanog = -1;
                    // Prikaz preostalih profesora u DataGridView kontroli
                    prikaziProfesoreDGV();
                }
            }
            else
            {
                MessageBox.Show("Nema podataka ili ni jedan red nije odabran!");
            }
        }

        // Obrada dogadjaja klika na dugme Promeni
        private void btnPromeni_Click(object sender, EventArgs e)
        {
            /* Provera da li je neki red selektovan za promenu
             Ukoliko nije, korisnik se obavestava porukom*/
            if (dgProfesori.SelectedRows.Count > 0)
            {
                // Omogucava se unos u tekstualna polja
                txtEnabled();
                /* Omogucava se klik na dugmice potvrdi i odustani, 
                 kako bi se zavrsila promena profesora*/
                btnSubmitEnabled();
                /* Onemogucava se klik na dugmice dodaj, promeni i obrisi
                 dok se ne zavrsi trenutna promena*/
                btnChangeDisabled();
                // Promenljiva akcija dobija vrednost "promeni"
                akcija = "Promeni";
            }
            else
            {
                MessageBox.Show("Nema podataka ili ni jedan red nije odabran!");
            }
        }

        // Obrada dogadjaja klika na dugme Potvrdi
        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            try
            {
                /* Ukoliko je akcija bila "promeni", vrsi se promena 
                 podataka o profesoru*/
                if (akcija == "Promeni")
                {
                    // Odredjuje se ID profesora kojeg je potrebno promeniti
                    int idSelektovanog = (int)dgProfesori.SelectedRows[0].Cells["ID"].Value;
                    // Na osnovu ID-a iz liste uzimamo odgovarajuceg profesora
                    Profesor selektovaniProfesor = profesoriList.Where(x => x.ID == 
                        idSelektovanog).FirstOrDefault();
                    // Menjaju se vrednosti za ime, prezime i indeks
                    if (selektovaniProfesor != null)
                    {
                        selektovaniProfesor.Ime = txtIme.Text;
                        selektovaniProfesor.Prezime = txtPrezime.Text;
                        selektovaniProfesor.Zvanje = txtZvanje.Text;
                        selektovaniProfesor.Katedra = txtKatedra.Text;
                        /* Izmena podataka o profesoru pomocu metode azurirajProfesora 
                         koja se nalazi u klasi Profesor.*/ 
                        selektovaniProfesor.azurirajProfesora();
                        // Nakon izmene ostaje selektovan isti red
                        idSelektovanog = dgProfesori.SelectedRows[0].Index;
                    }
                }
                /* Ukoliko je akcija bila "dodaj", vrsi se dodavanje 
                 novog profesora*/
                else if (akcija == "Dodaj")
                {
                    // Kreira se nova instanca klase Profesor
                    Profesor prof = new Profesor();
                    // Postavljaju se vrednosti za ime, prezime, zvanje i katedra
                    prof.Ime = txtIme.Text;
                    prof.Prezime = txtPrezime.Text;
                    prof.Zvanje = txtZvanje.Text;
                    prof.Katedra = txtKatedra.Text;
                    /* Dodavanje podataka o profesoru pomocu metode dodajProfesora
                     koja se nalazi u klasi Profesor*/
                    prof.dodajProfesora();
                    // Nakon dodavanja, selektovan je poslednji red
                    indeksSelektovanog = dgProfesori.Rows.Count;
                }
                // Onemogucava se dalja promena sadrzaja u tekstualnim poljima
                txtDisabled();
                /* Onemogucava se klik na dugmice potvrdi i odustani, 
                 sve dok se ponovo ne klikne na dodaj ili promeni*/
                btnSubmitDisabled();
                // Omogucava se klik na dugmice dodaj, promeni i obrisi
                btnChangeEnabled();
                // Promenljiva akcija dobija vrednost ""
                akcija = "";
                // Prikaz profesore u DataGridView kontroli
                prikaziProfesoreDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Obrada dogadjaja klika na dugme Odustani
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            // Onemogucava se dalja promena sadrzaja u tekstualnim poljima
            txtDisabled();
            /* Onemogucava se klik na dugmice potvrdi i odustani, 
             sve dok se ponovo ne klikne na dodaj ili promeni*/
            btnSubmitDisabled();
            // Omogucava se klik na dugmice dodaj, promeni i obrisi
            btnChangeEnabled();
        }

        // Obrada dogadjaja klika na celiju u okviru DataGridView kontrole
        private void dgStudenti_CellClick(object sender,
            DataGridViewCellEventArgs e)
        {
            // Ukoliko postoji red na koji je kliknuto
            if (dgProfesori.CurrentRow != null)
            {
                // Selektuje se odabrani red
                dgProfesori.Rows[dgProfesori.CurrentRow.Index].Selected = true;
                /* Vrsi se prikaz podataka iz selektovanog reda 
                 u tekstualnim poljima*/
                prikaziProfesoraTxt();
            }
        }

        private void mniIzvestajiProfesori_Click(object sender, EventArgs e)
        {
            // Otvara se forma u kojoj ce biti prikazani izvestaji
            frmIzvestaj izvestajFrm = new frmIzvestaj();
            izvestajFrm.Show();
        }


        // Obrada dogadjaja klika na stavku u meniju Uvezi
        private void mniXMLUvezi_Click(object sender, EventArgs e)
        {
            // Otvara se dijalog koji omogucava odabir fajla sa racunara
            OpenFileDialog oDlg = new OpenFileDialog();
            // Pocetni direktorijum je C:\\
            oDlg.InitialDirectory = "C:\\";
            // Moguce je odabrati samo xml fajlove
            oDlg.Filter = "xml Files (*.xml)|*.xml";
            // Ukoliko je odabran fajl
            if (DialogResult.OK == oDlg.ShowDialog())
            {
                /* Pozivamo metodu uveziXML iz klase ProfesoriXML
                 koja uvlaci podatke iz XML-a i cuva ih u bazi*/
                ProfesoriXML.uveziXML(oDlg.FileName);
            }
            /* Prikazuju se svi profesori u DataGridView kontroli
             (koji su vec bili u bazi i koji su dodati iz XML-a)*/
            prikaziProfesoreDGV();
        }

        // Obrada dogadjaja klika na stavku u meniju Izvezi
        private void mniXMLIzvezi_Click(object sender, EventArgs e)
        {
            // Otvara se dijalog koji omogucava cuvanje fajla na racunaru
            SaveFileDialog sDlg = new SaveFileDialog();
            // Pocetni direktorijum je C:\\
            sDlg.InitialDirectory = "C:\\";
            // Moguce je cuvati samo xml fajlove
            sDlg.Filter = "xml Files (*.xml)|*.xml";
            // Ukoliko je odabran fajl
            if (DialogResult.OK == sDlg.ShowDialog())
            {
                /* Pozivamo metodu izveziXML iz klase ProfesoriXML
                 koja kreira XML fajl i cuva ga na racunaru*/
                ProfesoriXML.izveziXML(sDlg.FileName, profesoriList);
            }
        }


       

        
    }

        
}
