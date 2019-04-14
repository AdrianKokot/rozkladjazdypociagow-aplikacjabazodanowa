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
        public search()
        {
            InitializeComponent();
        }

        public void InitAutoComplete()
        {
            var autoComplete = new AutoCompleteStringCollection();
            List<string> stations = DataBase.stations.Select(x => x.StationName).ToList();
            autoComplete.AddRange(stations.ToArray());
            firstCity.AutoCompleteCustomSource = autoComplete;
            secondCity.AutoCompleteCustomSource = autoComplete;
        }

        private void changeCities_Click(object sender, EventArgs e)
        {
            string firstVal = firstCity.Text;
            firstCity.Text = secondCity.Text;
            secondCity.Text = firstVal;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            output.Text = "";
            TimetableResult timetable = DataBase.FindRoute(firstCity.Text, secondCity.Text, new StationTime(dateTime.Value.Hour, dateTime.Value.Minute), dateDate.Value.Day % 7);
            if(timetable.msg == "OK")
            {
                foreach (Timetable timetbl in timetable.timetable)
                {
                    output.Text += timetbl.ToString(timetable.startStationID, timetable.endStationID) + "\n";
                }
            } else
            {
                output.Text = "Przepraszamy ale nie udalo się znaleźć pociągu dla podanego połączenia";
            }
            
        }
    }
}
