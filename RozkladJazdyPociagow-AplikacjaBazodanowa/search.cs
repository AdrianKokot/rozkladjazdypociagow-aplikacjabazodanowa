using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RozkladJazdyPociagow_AplikacjaBazodanowa
{
    public partial class search : UserControl
    {
        private bool firstCityValid = false;
        private bool secondCityValid = false;
        TimetableResult timetable = null;

        public search()
        {
            InitializeComponent();
            timetableSearchResult1.Visible = false;
            exit.Visible = false;
            btnRaport.Visible = false;
        }

        public void Reset()
        {
            firstCity.Text = "";
            secondCity.Text = "";
            firstCityValid = false;
            secondCityValid = false;
            firstCityError.SetError(firstCity, "");
            secondCityError.SetError(secondCity, "");
            timetableSearchResult1.Visible = false;
            timetableSearchResult1.Reset();
            exit.Visible = false;
            btnRaport.Visible = false;
            dateDate.Value = DateTime.Now;
            dateTime.Value = DateTime.Now;
            timetable = null;
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
            if(!firstCityValid&&!secondCityValid)
            {
                if (!secondCityValid)
                {
                    this.ActiveControl = secondCity;
                    secondCityError.SetError(secondCity, "Podana stacja nie istnieje w naszej bazie");
                }
                if (!firstCityValid)
                {
                    this.ActiveControl = firstCity;
                    firstCityError.SetError(firstCity, "Podana stacja nie istnieje w naszej bazie");
                }
            }
            else
            {
                timetable = DataBase.FindRoute(firstCity.Text, secondCity.Text, new StationTime(dateTime.Value.Hour, dateTime.Value.Minute), dateDate.Value.Day % 7);
                if (timetable != null)
                {
                    timetableSearchResult1.FullfillLabels(timetable);
                    timetableSearchResult1.Visible = true;
                    timetableSearchResult1.BringToFront();
                    exit.Visible = true;
                    btnRaport.Visible = true;
                    exit.BringToFront();
                    btnRaport.BringToFront();
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
            btnRaport.Visible = false;
            timetableSearchResult1.Reset();
            timetable = null;
        }

        private void firstCityBoxBack_Click(object sender, EventArgs e)
        {
            this.ActiveControl = firstCity;
        }

        private void secondCityBoxBack_Click(object sender, EventArgs e)
        {
            this.ActiveControl = secondCity;
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            this.ActiveControl = dateTime;
        }

        private void DateDateBack_Click(object sender, EventArgs e)
        {
            this.ActiveControl = dateDate;
        }

        private void BtnRaport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Zapisz raport jako";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Plik tekstowy (*.txt)|*.txt";
            saveFileDialog1.CheckPathExists = true;

            string fileName = @"";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName += saveFileDialog1.FileName;
                try
                {
                    if (File.Exists(fileName))
                        File.Delete(fileName);

                    using (StreamWriter sw = File.CreateText(fileName))
                    {
                        sw.WriteLine("Raport utworzony " + DateTime.Now.ToShortDateString() + " o godzinie " + DateTime.Now.ToShortTimeString() + "\n");
                        sw.WriteLine("Rozkład na dzień " + dateDate.Value.ToShortDateString() + " od godziny " + dateTime.Value.Hour + ":00\n");
                        sw.WriteLine("----- Stacja początkowa --- ---- --- Stacja końcowa -----");
                        sw.WriteLine("\t" + DataBase.stations.Find(x => x.StationID == timetable.startStationID).StationName + "\t\t\t" + DataBase.stations.Find(x => x.StationID == timetable.endStationID).StationName);
                        sw.WriteLine("\n----- Nazwa pociągu ---------- Odjazd ------- Przyjazd --");
                        for (int i = 0; i < timetable.timetable.Count; i++)
                            sw.WriteLine("\t" + DataBase.trains.Find(x => x.TrainID == timetable.timetable[i].TrainID).ToString() + (DataBase.trains.Find(x => x.TrainID == timetable.timetable[i].TrainID).ToString().Length < 15 ? "\t\t" : "\t") + timetable.timetable[i].Hours.Find(x => x.StationID == timetable.startStationID).ToString() + "\t\t" + timetable.timetable[i].Hours.Find(x => x.StationID == timetable.endStationID).ToString());
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                MessageBox.Show("Wystąpił błąd");
            }
            
        }
    }
}
