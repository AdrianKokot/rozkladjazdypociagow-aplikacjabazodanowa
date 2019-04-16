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

    public class Station
    {
        public int StationID { get; set; }
        public string StationName { get; set; }
    }

    public class Train
    {
        public int TrainID { get; set; }
        public int CompanyID { get; set; }
        public string TrainName { get; set; }
        public List<int> PathIDs { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, \"{1}\"", DataBase.companies.Find(x => x.CompanyID == this.CompanyID).ToString(), TrainName);
        }
    }

    public class TrainPath
    {
        public int PathID { get; set; }
        public List<int> Stations { get; set; }
    }

    public class StationTime : IComparable<StationTime>
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

        public int CompareTo(StationTime other)
        {
            //0 = równe
            //1 = this > other
            //-1 = this < other
            if (this != null && other != null)
                if (this.hour == other.hour)
                {
                    if (this.min > other.min)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    if (this.hour > other.hour)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
            else
                return 0;
        }
    }

    public class Timetable : IComparable<Timetable>
    {
        public int TrainID { get; set; }
        public int PathID { get; set; }
        public List<int> Days { get; set; }
        public List<StationTime> Hours { get; set; }

        public int CompareTo(Timetable other)
        {
            return this.Hours[0].CompareTo(other.Hours[0]);
        }
    }

    public class TimetableResult
    {
        public List<Timetable> timetable { get; set; }
        public int startStationID { get; set; }
        public int endStationID { get; set; }

        public TimetableResult(int start = -1, int end = -1)
        {
            startStationID = start;
            endStationID = end;
            timetable = null;
        }
    }

    public class Company
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string ShortCompanyName { get; set; }

        public override string ToString()
        {
            return ShortCompanyName;
        }
    }

    public class TrainDetails
    {
        public int TrainID { get; set; }
        public int startStationID { get; set; }
        public int endStationID { get; set; }
        public TrainPath path { get; set; }
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
            if(startStation != null && endStation != null)
            {
                TimetableResult result = new TimetableResult(startStation.StationID, endStation.StationID);
                List<TrainPath> paths = trainPaths.FindAll(x => x.Stations.Contains(startStation.StationID) && x.Stations.Contains(endStation.StationID) && x.Stations.IndexOf(startStation.StationID) < x.Stations.IndexOf(endStation.StationID));
                if(paths.Count > 0)
                {
                    List<Timetable> schedule = timetable.FindAll(x => paths.Exists(z => z.PathID == x.PathID) && x.Hours.Exists(z => z.hour >= time.hour && z.StationID == startStation.StationID) && x.Days.Contains(day));
                    if(schedule.Count > 0)
                    {
                        schedule.Sort();
                        result.timetable = schedule;
                        return result;
                    }
                }
            }
            return null;
        }

        static public Timetable FindTrainDetails(string trainName, string routeName)
        {
            Train train = trains.Find(x => x.TrainName.ToLower() == trainName.ToLower());
            if(train != null)
            {
                List<TrainPath> paths = trainPaths.FindAll(x => train.PathIDs.Contains(x.PathID));
                if(paths.Count > 0)
                {
                    string startStation, endStation;
                    try
                    {
                        startStation = routeName.Split('-')[0].Trim();
                        endStation = routeName.Split('-')[1].Trim();
                    }
                    catch (Exception e)
                    {
                        return null;
                    }
                    int startStationID = stations.Find(x => x.StationName.ToLower() == startStation.ToLower()).StationID;
                    int endStationID = stations.Find(x => x.StationName.ToLower() == endStation.ToLower()).StationID;
                    if(startStationID > 0 && endStationID > 0)
                    {
                        TrainPath path = paths.Find(x => x.Stations[0] == startStationID && x.Stations[x.Stations.Count - 1] == endStationID);
                        if(path != null)
                        {
                            Timetable result = timetable.Find(x => x.TrainID == train.TrainID && x.PathID == path.PathID);
                            if(result != null)
                                return result;
                        }
                    }
                }
            }
            return null;
        }
    }
}
