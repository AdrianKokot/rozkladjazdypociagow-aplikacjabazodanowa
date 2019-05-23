using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RJP;

namespace RJP_EdytorBazyDanych
{
    public partial class stationEdit : UserControl
    {
        private bool stationValid = false;
        public stationEdit()
        {
            InitializeComponent();
        }
        public void InitAutocomplete()
        {
            var autoComplete = new AutoCompleteStringCollection();
            List<string> stations = DataBase.stations.Select(x => x.StationName).ToList();
            stations.Sort();
            autoComplete.AddRange(stations.ToArray());
            stationSelect.AutoCompleteCustomSource = autoComplete;
            stationSelect.Items.Clear();
            stationSelect.Items.AddRange(stations.ToArray());
        }

        public void Reset()
        {
            stationError.SetError(stationSelect, "");
            newStationError.SetError(newStationName, "");
            stationValid = false;
            newStationName.Text = "";
            stationSelect.Text = "";
            newStationError.SetError(newStationName, "");
            stationError.SetError(stationSelect, "");
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if(stationValid && newStationName.Text != "")
            {
                newStationError.SetError(newStationName, "");
                if(DataBase.ChangeStationName(stationSelect.Text, newStationName.Text))
                {
                    MessageBox.Show("Zmiana została zaakceptowana");
                }
            } else
            {
                if (!stationValid)
                {
                    stationError.SetError(stationSelect, "Podana stacja nie istnieje");
                    this.ActiveControl = stationSelect;
                } else
                {
                    newStationError.SetError(newStationName, "Nazwa nie może być pusta");
                    this.ActiveControl = newStationName;
                }
                    
            }
        }

        private void StationSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DataBase.stations.Exists(x => x.StationName.ToLower() == stationSelect.Text.ToLower())){
                stationValid = true;
                newStationName.Text = stationSelect.Text;
                stationError.SetError(stationSelect, "");
            } else
            {
                stationError.SetError(stationSelect, "Podana stacja nie istnieje");
                stationValid = false;
            }
        }
    }
}
