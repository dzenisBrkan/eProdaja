using eProdaja.Model;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eProdaja.WinUI.Korisnik
{
    public partial class frmKorisnici : Form
    {
        private readonly APIService _apiService = new APIService("Korisnik");
        public frmKorisnici()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new KorisniciSearchRequest()
            {
                Ime = txtPretraga.Text
            };

            var resault = await _apiService.Get<IList<Korisnici>>(search);
            dgvKorisnici.AutoGenerateColumns = false;
            dgvKorisnici.DataSource = resault;
        }

        private void btnPrikazi_DragEnter(object sender, DragEventArgs e)
        {}
    }
}
