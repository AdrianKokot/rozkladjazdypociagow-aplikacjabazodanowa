using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using RJP;

namespace RJP_EdytorBazyDanych
{
    public partial class addTimetable : UserControl
    {
        List<Station> addStationsList = new List<Station>();
        List<StationTime> addStationTimeList = new List<StationTime>();
        bool trainValid = false;
        public addTimetable()
        {
            InitializeComponent();
        }

        public void InitAutocomplete()
        {
            AutoCompleteStringCollection trainAutocomplete = new AutoCompleteStringCollection();
            List<string> trains = DataBase.trains.Select(x => x.ToString()).ToList();
            trains.Sort();
            trainAutocomplete.AddRange(trains.ToArray());
            trainSelect.AutoCompleteCustomSource = trainAutocomplete;
            trainSelect.Items.Clear();
            trainSelect.Items.AddRange(trains.ToArray());
            

            AutoCompleteStringCollection stationAutocomplete = new AutoCompleteStringCollection();
            List<string> stations = DataBase.stations.Select(x => x.StationName).ToList();
            stations.Sort();
            stationAutocomplete.AddRange(stations.ToArray());
            stationSelect.AutoCompleteCustomSource = stationAutocomplete;
            stationSelect.Items.Clear();
            stationSelect.Items.AddRange(stations.ToArray());
        }

        public void Reset()
        {
            trainValid = false;
            addStationsList.Clear();
            addStationTimeList.Clear();
            stationsList.Text = "";
            stationSelect.Text = "";
            stationSelect.SelectedIndex = -1;
            trainSelect.Text = "";
            trainSelect.SelectedIndex = -1;
            trainError.SetError(trainSelect, "");
            stationError.SetError(stationsList, "");
            stationError.SetError(stationSelect, "");
        }

        private void AddStation_Click(object sender, EventArgs e)
        {
            Station station = DataBase.stations.Find(x => x.StationName.ToLower() == stationSelect.Text.ToLower());
            StationTime stationTime = new StationTime(dateTime.Value.Hour, dateTime.Value.Minute);
            if(station != null)
            {
                stationTime.StationID = station.StationID;
                addStationsList.Add(station);
                addStationTimeList.Add(stationTime);
                stationError.SetError(stationsList, "");
                stationError.SetError(stationSelect, "");
                stationsList.Text += (stationsList.Text.Length > 0 ? ", " : "") + station.StationName + " - " + dateTime.Value.Hour + ":" + (dateTime.Value.Minute < 10 ? "0" + dateTime.Value.Minute.ToString() : dateTime.Value.Minute.ToString());
            } else
            {
                this.ActiveControl = stationSelect;
                stationError.SetError(stationSelect, "Podana stacja nie istnieje");
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (trainValid && stationsList.Text.Length > 0)
            {
                if (DataBase.AddTimetable(trainSelect.Text, addStationsList, addStationTimeList, new List<int>() { 1, 2, 3, 4, 5, 6, 0 }))
                    MessageBox.Show("Dodano pomyślnie");
                else
                    MessageBox.Show("Operacja nie powiodła się");
            } else
            {
                if (stationsList.Text.Length == 0)
                    stationError.SetError(stationsList, "Proszę podać listę stacji");
                else
                {
                    trainError.SetError(trainSelect, "Podany pociąg nie istnieje");
                    this.ActiveControl = trainSelect;
                }
            }
        }

        private void TrainSelect_TabIndexChanged(object sender, EventArgs e)
        {
            if(DataBase.trains.Exists(x => x.ToString().ToLower() == trainSelect.Text.ToLower()))
            {
                trainValid = true;
                trainError.SetError(trainSelect, "");
            } else
            {
                trainValid = false;
                trainError.SetError(trainSelect, "Podany pociąg nie istnieje");
            }
        }
    }
}
