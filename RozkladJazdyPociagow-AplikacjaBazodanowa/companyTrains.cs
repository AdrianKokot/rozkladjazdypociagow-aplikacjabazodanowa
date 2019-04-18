using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RozkladJazdyPociagow_AplikacjaBazodanowa
{
    public partial class companyTrains : UserControl
    {
        private bool companySearchValid = false;
        public companyTrains()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            companySearch.Text = "";
            companySearch.SelectedIndex = -1;
            error.SetError(companySearch, "");
            exit.Visible = false;
            stationDetailsResult1.Visible = false;
            stationDetailsResult1.Reset();
        }

        public void InitAutocomplete()
        {
            var autocomplete = new AutoCompleteStringCollection();
            List<string> companies = DataBase.companies.Select(x => x.CompanyName).ToList();
            companies.Sort();
            string[] companiesArr = companies.ToArray();
            autocomplete.AddRange(companiesArr);
            companySearch.AutoCompleteCustomSource = autocomplete;
            companySearch.Items.AddRange(companiesArr);
        }

        private void companySearchBack_Click(object sender, EventArgs e)
        {
            this.ActiveControl = companySearch;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (companySearchValid)
            {
                List<string> companysTrains = DataBase.FindCompanysTrains(companySearch.Text);
                if(companysTrains != null)
                {
                    stationDetailsResult1.FullfillLabels(companysTrains);
                    stationDetailsResult1.Visible = true;
                    stationDetailsResult1.BringToFront();
                    exit.Visible = true;
                    exit.BringToFront();
                } else
                {
                    MessageBox.Show("Przepraszamy, nie udało znaleźć się pociągów dla podanego przewoźnika");
                }
            } else
            {
                this.ActiveControl = companySearch;
            }
        }

        private void companySearch_Validating(object sender, CancelEventArgs e)
        {
            if(DataBase.companies.Exists(x => x.CompanyName.ToLower() == companySearch.Text.ToLower()))
            {
                companySearchValid = true;
                error.SetError(companySearch, "");
            } else
            {
                companySearchValid = false;
                error.SetError(companySearch, "Poday przewoźnik nie istnieje w naszej bazie danych");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            exit.Visible = false;
            stationDetailsResult1.Visible = false;
            stationDetailsResult1.Reset();
        }
    }
}
