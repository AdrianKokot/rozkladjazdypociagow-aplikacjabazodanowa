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
    public partial class trainRoute : UserControl
    {
        private bool trainSearchValid = false;
        private bool stationSearchValid = false;
        private List<string> routes;
        public trainRoute()
        {
            InitializeComponent();
        }

        public void InitAutoTrainAutocomplete ()
        {
            var autoComplete = new AutoCompleteStringCollection();
            List<string> trains = DataBase.trains.Select(x => x.TrainName).ToList();
            autoComplete.AddRange(trains.ToArray());
            trainSearch.AutoCompleteCustomSource = autoComplete;
            trainSearch.Items.AddRange(trains.ToArray());
        }

        private void AutocompleteStationSearch()
        {
            var autoComplete = new AutoCompleteStringCollection();
            Train train = DataBase.trains.Find(y => y.TrainName.ToLower() == trainSearch.Text.ToLower());
            List<TrainPath> pathsIDs = DataBase.trainPaths.FindAll(x => train.PathIDs.Contains(x.PathID));
            routes = pathsIDs.Select(x => DataBase.stations.Find(z => z.StationID == x.Stations.First()).StationName + " - " + DataBase.stations.Find(z => z.StationID == x.Stations.Last()).StationName).Distinct().ToList();
            autoComplete.AddRange(routes.ToArray());
            stationSearch.AutoCompleteCustomSource = autoComplete;
            stationSearch.Items.Clear();
            stationSearch.Items.AddRange(routes.ToArray());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!trainSearchValid)
            {
                this.ActiveControl = trainSearch;
            }
            else if (!stationSearchValid)
            {
                this.ActiveControl = stationSearch;
            }
            else
            {
                Timetable timetable = DataBase.FindTrainDetails(trainSearch.Text, stationSearch.Text);
                if (timetable != null)
                {
                    trainRouteResult1.FullfillLabels(timetable);
                    trainRouteResult1.Visible = true;
                    trainRouteResult1.BringToFront();
                    exit.Visible = true;
                    exit.BringToFront();
                    exit.Visible = true;
                    exit.BringToFront();
                }
                else
                {
                    MessageBox.Show("Przepraszamy ale nie udalo się znaleźć pociągu lub trasy");
                }
                
            }
        }

        private void trainSearchBack_Click(object sender, EventArgs e)
        {
            this.ActiveControl = trainSearch;
        }

        private void trainSearch_Validating(object sender, CancelEventArgs e)
        {
            if (DataBase.trains.Exists(x => x.TrainName.ToLower() == trainSearch.Text.ToLower()))
            {
                trainSearchValid = true;
                errorTrain.SetError(trainSearch, "");
                AutocompleteStationSearch();
            }
            else
            {
                trainSearchValid = false;
                errorTrain.SetError(trainSearch, "Podany pociąg nie istnieje w naszej bazie");
            }
        }

        private void stationSearch_Validating(object sender, CancelEventArgs e)
        {
            if(trainSearchValid)
            if (routes.Exists(x => x.ToLower()  == stationSearch.Text.ToLower()))
            {
                stationSearchValid = true;
                errorStation.SetError(stationSearch, "");
            }
            else
            {
                trainSearchValid = false;
                errorStation.SetError(stationSearch, "Podana trasa nie istnieje w naszej bazie");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            exit.Visible = false;
            trainRouteResult1.Visible = false;
            trainRouteResult1.Reset();
        }

        private void trainSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            stationSearch.SelectedIndex = -1;
        }
    }
}
