using eProdaja.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            var resault = await _proizvodiService.Get<List<Proizvodi>>(new ProizvodiSearchObject()
            {
                VrstaId = vrstaId
            });

            proizvodiGrid.DataSource = resault;
        }
    }
}