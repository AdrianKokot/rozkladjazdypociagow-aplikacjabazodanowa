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
    public partial class trainsFacilities : UserControl
    {
        private bool trainSearchValid = false;
        public trainsFacilities()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            trainSearch.Text = "";
            trainSearch.SelectedIndex = -1;
            exit.Visible = false;
            stationDetailsResult1.Visible = false;
            stationDetailsResult1.Reset();
        }

        public void InitAutocomplete()
        {
            var autocomplete = new AutoCompleteStringCollection();
            List<string> trains = DataBase.trains.Select(x => x.ToString()).ToList();
            trains.Sort();
            string[] trainsArr = trains.ToArray();
            autocomplete.AddRange(trainsArr);
            trainSearch.AutoCompleteCustomSource = autocomplete;
            trainSearch.Items.AddRange(trainsArr);
        }

        private void TrainSearchBack_Click(object sender, EventArgs e)
        {
            this.ActiveControl = trainSearch;
        }

        private void TrainSearch_Validating(object sender, CancelEventArgs e)
        {
            if(DataBase.trains.Exists(x => x.ToString().ToLower() == trainSearch.Text.ToLower()))
            {
                trainSearchValid = true;
                trainSearchError.SetError(trainSearch, "");
            } else
            {
                trainSearchValid = false;
                trainSearchError.SetError(trainSearch, "Podany pociąg nie istnieje w naszej bazie danych");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            exit.Visible = false;
            stationDetailsResult1.Visible = false;
            stationDetailsResult1.Reset();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (trainSearchValid)
            {
                List<string> result = DataBase.FindTrainsFacilities(trainSearch.Text);
                if(result != null)
                {
                    stationDetailsResult1.FullfillLabels(result);
                    exit.Visible = true;
                    stationDetailsResult1.Visible = true;
                    stationDetailsResult1.BringToFront();
                } else
                {
                    MessageBox.Show("Niestety nie udało się znaleźć informacji na temat podanego pociągu");
                }
            } else
            {
                this.ActiveControl = trainSearch;
            }
        }
    }
}
