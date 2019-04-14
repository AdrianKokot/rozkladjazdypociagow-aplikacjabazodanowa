using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RozkladJazdyPociagow_AplikacjaBazodanowa
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }
    }

    class Station
    {
        public int StationID { get; set; }
        public string StationName { get; set; }
    }

    class Train
    {
        public int TrainID { get; set; }
        public int CompanyID { get; set; }
        public string TrainName { get; set; }
        public List<int> PathIDs { get; set; }
    }

    class TrainPath
    {
        public int PathID { get; set; }
        public List<int> Stations { get; set; }
    }

    class StationTime
    {
        public int StationID { get; set; }
        public int hour { get; set; }
        public int min { get; set; }

        public StationTime(int h, int m)
        {
            hour = h;
            min = m;
            StationID = -1;
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}", hour, min < 10 ? "0" + min : min.ToString());
        }
    }

    class Timetable
    {
        public int TrainID { get; set; }
        public int PathID { get; set; }
        public List<int> Days { get; set; }
        public List<StationTime> Hours { get; set; }

        public string ToString(int startStationID, int endStationID)
        {
            string days = "[";
            foreach (int day in Days)
            {
                days += day.ToString() + ", ";
            }
            days += "], Hours: [";
            foreach (StationTime hour in Hours)
            {
                if(hour.StationID == startStationID || hour.StationID == endStationID)
                    days += hour.ToString() + ", ";
            }
            days += "]";
            return string.Format("TrainID: {0}, PathID: {1}, Days: " + days, TrainID, PathID);
        }
    }

    class TimetableResult
    {
        public List<Timetable> timetable { get; set; }
        public int startStationID { get; set; }
        public int endStationID { get; set; }
        public string msg { get; set; }

        public TimetableResult(int start = -1, int end = -1)
        {
            startStationID = start;
            endStationID = end;
            timetable = null;
            msg = "E";
        }
    }

    class Company
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string ShortCompanyName { get; set; }

        public override string ToString()
        {
            return string.Format("\"{0}\" {1}", ShortCompanyName, CompanyName);
        }
    }

    static class DataBase
    {
        public static List<Station> stations;
        public static List<Train> trains;
        public static List<TrainPath> trainPaths;
        public static List<Timetable> timetable;
        public static List<Company> companies;

        static private void ImportStations()
        {
            var jsonData = File.ReadAllText(@"..\..\..\DB\stations.txt", Encoding.UTF8);
            stations = JsonConvert.DeserializeObject<List<Station>>(jsonData);
        }

        static private void ImportTrains()
        {
            var jsonData = File.ReadAllText(@"..\..\..\DB\trains.txt", Encoding.UTF8);
            trains = JsonConvert.DeserializeObject<List<Train>>(jsonData);
        }

        static private void ImportTrainPaths()
        {
            var jsonData = File.ReadAllText(@"..\..\..\DB\trainpaths.txt", Encoding.UTF8);
            trainPaths = JsonConvert.DeserializeObject<List<TrainPath>>(jsonData);
        }

        static private void ImportTimetables()
        {
            var jsonData = File.ReadAllText(@"..\..\..\DB\timetables.txt", Encoding.UTF8);
            timetable = JsonConvert.DeserializeObject<List<Timetable>>(jsonData);
        }

        static private void ImportCompanies()
        {
            var jsonData = File.ReadAllText(@"..\..\..\DB\companies.txt", Encoding.UTF8);
            companies = JsonConvert.DeserializeObject<List<Company>>(jsonData);
        }

        static public void ImportAll()
        {
            ImportStations();
            ImportTrains();
            ImportTrainPaths();
            ImportTimetables();
            ImportCompanies();
        }

        static public TimetableResult FindRoute(string from, string to, StationTime time, int day)
        {
            from = from.ToLower();
            to = to.ToLower();
            Station startStation = stations.Find(x => x.StationName.ToLower() == from);                
            Station endStation = stations.Find(x => x.StationName.ToLower() == to);
            if(startStation == null || endStation == null)
            {
                return new TimetableResult();
            } else
            {
                TimetableResult result = new TimetableResult(startStation.StationID, endStation.StationID);
                List<TrainPath> paths = trainPaths.FindAll(x => x.Stations.Contains(startStation.StationID) && x.Stations.Contains(endStation.StationID) && x.Stations.IndexOf(startStation.StationID) < x.Stations.IndexOf(endStation.StationID));
                if(paths.Count < 1)
                {
                    return new TimetableResult();
                } else
                {

                    MessageBox.Show(paths.Count.ToString());
                    List<Timetable> schedule = timetable.FindAll(x => paths.Exists(z => z.PathID == x.PathID) && x.Hours.Exists(z => z.hour >= time.hour && z.StationID == startStation.StationID) && x.Days.Contains(day));
                    if(schedule.Count < 1)
                    {
                        return new TimetableResult();
                    } else
                    {
                        MessageBox.Show(schedule.Count.ToString());
                        result.msg = "OK";
                        result.timetable = schedule;
                        return result;
                    }
                    
                }
            }               
        }

    }


}
