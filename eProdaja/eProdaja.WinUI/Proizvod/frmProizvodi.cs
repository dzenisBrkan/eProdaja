using eProdaja.Model;
using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace eProdaja.WinUI.Proizvod
{
    public partial class frmProizvodi : Form
    {
        private readonly APIService _vrsteProizvodaService = new APIService("VrsteProizvoda");
        private readonly APIService _jediniceMjereService = new APIService("JediniceMjere");
        private readonly APIService _proizvodiService = new APIService("Proizvodi");
        public frmProizvodi()
        {
            InitializeComponent();
        }

        private async void frmProizvodi_Load(object sender, EventArgs e)
        {
            await LoadVrsteProizvoda();
            await LoadJediniceMjere();
        }

        private async Task LoadVrsteProizvoda()
        {
            var resault = await _vrsteProizvodaService.Get<List<VrsteProizvodum>>(null);
            resault.Insert(0, new VrsteProizvodum());
            cmbVrstaProizvoda.DisplayMember = "Naziv";
            cmbVrstaProizvoda.ValueMember = "VrstaId";
            cmbVrstaProizvoda.DataSource = resault;
        }

        private async Task LoadJediniceMjere()
        {
            var resault = await _jediniceMjereService.Get<List<JediniceMjere>>(null);
            resault.Insert(0, new JediniceMjere());
            cmbJediniceMjere.DisplayMember = "Naziv";
            cmbJediniceMjere.ValueMember = "JedinicaMjereId";
            cmbJediniceMjere.DataSource = resault;
        }

        private async void cmbVrstaProizvoda_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbVrstaProizvoda.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadProizvodi(id);
            }
        }

        private async Task LoadProizvodi(int vrstaId)
        {
            ProizvodiSearchObject search = new ProizvodiSearchObject();
            search.IncludeList = new string[]
            {
                "JedinicaMjere",
                "Vrsta"
            };

            if (vrstaId != 0)
            {
                search.VrstaId = vrstaId;
            }
            var resault = await _proizvodiService.Get<List<Proizvodi>>(search);
            proizvodiGrid.DataSource = resault;
        }

        ProizvodiInsertRequest request = new ProizvodiInsertRequest();
        private async void Sacuvaj_Click(object sender, EventArgs e)
        {

            var vrstaProizvodaIdObj = cmbVrstaProizvoda.SelectedValue;
            if (int.TryParse(vrstaProizvodaIdObj.ToString(), out int vrstaId))
            {
                request.VrstaId = vrstaId;
            }

            var jedinicaMjereIdObj = cmbJediniceMjere.SelectedValue;
            if (int.TryParse(jedinicaMjereIdObj.ToString(), out int jedinicaId))
            {
                request.JedinicaMjereId = jedinicaId;
            }

            request.Sifra = txtSifra.Text;
            request.Naziv = txtNaziv.Text;
            //request.Cijena = Int32.Parse(txtCijena.Text);

            await _proizvodiService.Insert<Proizvodi>(request);
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            var resault = openFileDialog1.ShowDialog();

            if (resault == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);
                request.Slika = file;
                txtSlika.Text = fileName;
                Image image = Image.FromFile(fileName);
                pictureBox.Image = image; 
            }
        }
    }
}