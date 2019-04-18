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
    public partial class stationDetails : UserControl
    {
        private bool stationSearchValid = false;
        public stationDetails()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            stationSearchValid = false;
            stationDetailsResult1.Visible = false;
            exit.Visible = false;
            stationDetailsResult1.Reset();
            stationSearchError.SetError(stationSearch, "");
            stationSearch.SelectedIndex = -1;
            stationSearch.Text = "";
        }

        public void InitAutoComplete()
        {
            var autocomplete = new AutoCompleteStringCollection();
            List<string> stations = DataBase.stations.Select(x => x.StationName).ToList();
            stations.Sort();
            string[] stationsArray = stations.ToArray();
            autocomplete.AddRange(stationsArray);
            stationSearch.AutoCompleteCustomSource = autocomplete;
            stationSearch.Items.AddRange(stationsArray);
        }

        private void stationSearchBack_Click(object sender, EventArgs e)
        {
            this.ActiveControl = stationSearch;
        }

        private void stationSearch_Validating(object sender, CancelEventArgs e)
        {
            if(DataBase.stations.Exists(x => x.StationName.ToLower() == stationSearch.Text.ToLower()))
            {
                stationSearchValid = true;
                stationSearchError.SetError(stationSearch, "");
            } else
            {
                stationSearchValid = false;
                stationSearchError.SetError(stationSearch, "Podana stacja nie istnieje w naszej bazie danych");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (stationSearchValid)
            {
                List<string> stationDetails = DataBase.FindStationDetails(stationSearch.Text);
                if(stationDetails != null)
                {
                    stationDetailsResult1.FullfillLabels(stationDetails);
                    stationDetailsResult1.Visible = true;
                    stationDetailsResult1.BringToFront();
                    exit.Visible = true;
                    exit.BringToFront();
                } else
                {
                    MessageBox.Show("Niestety nie udało się znaleźć pociągów na podanej stacji");
                }
            } else
            {
                this.ActiveControl = stationSearch;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            stationDetailsResult1.Visible = false;
            exit.Visible = false;
            stationDetailsResult1.Reset();
        }
    }
}
