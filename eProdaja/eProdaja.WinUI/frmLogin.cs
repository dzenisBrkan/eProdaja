﻿using eProdaja.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eProdaja.WinUI
{
    public partial class frmLogin : Form
    {
        private readonly APIService _apiService = new APIService("Korisnik");

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            APIService.Username = txtUsername.Text;
            APIService.Password = txtPassword.Text;

            try
            {
                var resault = await _apiService.Get<List<Korisnici>>();

                mdiIndex frm = new mdiIndex();
                frm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Pogresan username ili password");
                throw;
            }
        }
    }
}
