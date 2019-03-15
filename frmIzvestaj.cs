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
    public partial class frmIzvestaj : Form
    {
        public frmIzvestaj()
        {
            InitializeComponent();
        }

        private void frmIzvestaj_Load(object sender, EventArgs e)
        {
            // Izvor podataka za prikaz je lista svih profesora
            // koja se ucitava iz baze pomocu metode Profesor.ucitajProfesore
            ProfesorBindingSource.DataSource = new Profesor().ucitajProfesora();
            this.reportViewer1.RefreshReport();
        }

    }
}
