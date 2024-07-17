using eProdaja.Model;
using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eProdaja.WinUI.Korisnik
{
    public partial class frmKorisniciDetalji : Form
    {
        private readonly APIService _apiService = new APIService("Korisnik");
        public APIService _UlogeService { get; set; } = new APIService("Uloge");

        private int? _id = null;
        public frmKorisniciDetalji(int? korisnikId = null)
        {
            InitializeComponent();
            _id = korisnikId;
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var roleList = clbUloge.CheckedItems.Cast<Uloge>().ToList();
            var roleIdList = roleList.Select(x => x.UlogaId).ToList();

            if (this.ValidateChildren())
            {
                var request = new KorisniciInsertRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Email = txtEmail.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Telefon = txtTelefon.Text,
                    Password = txtPassword.Text,
                    PasswordPotvrda = txtPotvrda.Text,
                    Status = chbStatus.Checked,
                    Uloge = roleIdList,
                };

                if (_id.HasValue)
                {
                    //kada se ide update korisnika mora se unijeti i password
                    await _apiService.Update<Korisnici>(_id, request);
                }
                else
                {
                    await _apiService.Insert<Korisnici>(request);
                }
                MessageBox.Show("Dodavanje korisnika uspejsno");
            }
        }

        private async void frmKorisniciDetalji_Load(object sender, EventArgs e)
        {
            if(_id.HasValue)
            {
                var korisnik = await _apiService.GetById<Korisnici>(_id);

                txtIme.Text = korisnik.Ime;
                txtPrezime.Text = korisnik.Prezime;
                txtEmail.Text = korisnik.Email;
                txtTelefon.Text = korisnik.Telefon;
                txtKorisnickoIme.Text = korisnik.KorisnickoIme;
                chbStatus.Checked = korisnik.Status.GetValueOrDefault(false);

                await LoadRoles();
            }
        }

        private async Task LoadRoles()
        {
            var roles = await _UlogeService.Get<List<Uloge>>(null);
            clbUloge.DataSource = roles;
            clbUloge.DisplayMember = "Naziv";
        }

        private void txtIme_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                errorProvider.SetError(txtIme, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                errorProvider.SetError(txtPrezime, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
            }
        }

        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void txtTelefon_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                errorProvider.SetError(txtTelefon, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtTelefon, null);
            }
        }

        private void txtKorisnickoIme_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text) && txtKorisnickoIme.Text.Length < 3)
            {
                errorProvider.SetError(txtKorisnickoIme, "Obavezno polje ili unesite vise od 3 slova");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtKorisnickoIme, null);
            }
        }
    }
}