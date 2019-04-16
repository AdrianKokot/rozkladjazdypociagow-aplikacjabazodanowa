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
    public partial class search : UserControl
    {
        private bool firstCityValid = false;
        private bool secondCityValid = false;

        public search()
        {
            InitializeComponent();
            timetableSearchResult1.Visible = false;
            exit.Visible = false;
        }

        public void InitAutoComplete()
        {
            var autoComplete = new AutoCompleteStringCollection();
            List<string> stations = DataBase.stations.Select(x => x.StationName).ToList();
            autoComplete.AddRange(stations.ToArray());
            firstCity.AutoCompleteCustomSource = autoComplete;
            secondCity.AutoCompleteCustomSource = autoComplete;
        }

        private bool ValidateCity(TextBox city, ErrorProvider error)
        {
            if (DataBase.stations.Exists(x => x.StationName.ToLower() == city.Text.ToLower()))
            {
                error.SetError(city, "");
                return true;
            }
            else
            {
                error.SetError(city, "Podana stacja nie istnieje w naszej bazie");
                return false;
            }
        }

        private void changeCities_Click(object sender, EventArgs e)
        {
            string firstVal = firstCity.Text;
            firstCity.Text = secondCity.Text;
            secondCity.Text = firstVal;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (!firstCityValid)
            {
                this.ActiveControl = firstCity;
            }
            else if (!secondCityValid)
            {
                this.ActiveControl = secondCity;
            }
            else
            {
                TimetableResult timetable = DataBase.FindRoute(firstCity.Text, secondCity.Text, new StationTime(dateTime.Value.Hour, dateTime.Value.Minute), dateDate.Value.Day % 7);
                if (timetable != null)
                {
                    timetableSearchResult1.FullfillLabels(timetable);
                    timetableSearchResult1.Visible = true;
                    timetableSearchResult1.BringToFront();
                    exit.Visible = true;
                    exit.BringToFront();
                }
                else
                {
                    MessageBox.Show("Przepraszamy ale nie udalo się znaleźć pociągu dla podanego połączenia");
                }
            }
        }

        private void firstCity_Validating(object sender, CancelEventArgs e)
        {
            firstCityValid = ValidateCity(firstCity, firstCityError);
        }

        private void secondCity_Validating(object sender, CancelEventArgs e)
        {
            secondCityValid = ValidateCity(secondCity, secondCityError);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            timetableSearchResult1.Visible = false;
            exit.Visible = false;
            timetableSearchResult1.Reset();
        }

        private void firstCityBoxBack_Click(object sender, EventArgs e)
        {
            this.ActiveControl = firstCity;
        }

        private void secondCityBoxBack_Click(object sender, EventArgs e)
        {
            this.ActiveControl = secondCity;
        }
    }
}
