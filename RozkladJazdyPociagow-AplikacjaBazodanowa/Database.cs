using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RJP
{
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
        public List<int> FacilitiesIDs { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, \"{1}\"", DataBase.companies.Find(x => x.CompanyID == this.CompanyID).ToString(), TrainName);
        }
    }

    public class Facilities
    {
        public int FacilityID { get; set; }
        public string FacilityName { get; set; }
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

    static class DataBase
    {
        private static string StationsFile = @"DB\stations.txt";
        private static string TrainsFile = @"DB\trains.txt";
        private static string TrainpathsFile = @"DB\trainpaths.txt";
        private static string TimetablesFile = @"DB\timetables.txt";
        private static string CompaniesFile = @"DB\companies.txt";
        private static string FacilitiesFile = @"DB\facilities.txt";


        public static List<Station> stations;
        public static List<Train> trains;
        public static List<TrainPath> trainPaths;
        public static List<Timetable> timetable;
        public static List<Company> companies;
        public static List<Facilities> facilities;

        static private void ImportStations()
        {
            var jsonData = File.ReadAllText(StationsFile, Encoding.UTF8);
            stations = JsonConvert.DeserializeObject<List<Station>>(jsonData);
        }

        static private void ImportTrains()
        {
            var jsonData = File.ReadAllText(TrainsFile, Encoding.UTF8);
            trains = JsonConvert.DeserializeObject<List<Train>>(jsonData);
        }

        static private void ImportTrainPaths()
        {
            var jsonData = File.ReadAllText(TrainpathsFile, Encoding.UTF8);
            trainPaths = JsonConvert.DeserializeObject<List<TrainPath>>(jsonData);
        }

        static private void ImportTimetables()
        {
            var jsonData = File.ReadAllText(TimetablesFile, Encoding.UTF8);
            timetable = JsonConvert.DeserializeObject<List<Timetable>>(jsonData);
        }

        static private void ImportCompanies()
        {
            var jsonData = File.ReadAllText(CompaniesFile, Encoding.UTF8);
            companies = JsonConvert.DeserializeObject<List<Company>>(jsonData);
        }

        static private void ImportFacilities()
        {
            var jsonData = File.ReadAllText(FacilitiesFile, Encoding.UTF8);
            facilities = JsonConvert.DeserializeObject<List<Facilities>>(jsonData);
        }

        static public void ImportAll()
        {
            ImportStations();
            ImportTrains();
            ImportTrainPaths();
            ImportTimetables();
            ImportCompanies();
            ImportFacilities();
        }

        static public TimetableResult FindRoute(string from, string to, StationTime time, int day)
        {
            from = from.ToLower();
            to = to.ToLower();
            Station startStation = stations.Find(x => x.StationName.ToLower() == from);
            Station endStation = stations.Find(x => x.StationName.ToLower() == to);
            if (startStation != null && endStation != null)
            {
                TimetableResult result = new TimetableResult(startStation.StationID, endStation.StationID);
                List<TrainPath> paths = trainPaths.FindAll(x => x.Stations.Contains(startStation.StationID) && x.Stations.Contains(endStation.StationID) && x.Stations.IndexOf(startStation.StationID) < x.Stations.IndexOf(endStation.StationID));
                if (paths.Count > 0)
                {
                    List<Timetable> schedule = timetable.FindAll(x => paths.Exists(z => z.PathID == x.PathID) && x.Hours.Exists(z => z.hour >= time.hour && z.StationID == startStation.StationID) && x.Days.Contains(day));
                    if (schedule.Count > 0)
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
            if (train != null)
            {
                List<TrainPath> paths = trainPaths.FindAll(x => train.PathIDs.Contains(x.PathID));
                if (paths.Count > 0)
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
                    if (startStationID > 0 && endStationID > 0)
                    {
                        TrainPath path = paths.Find(x => x.Stations[0] == startStationID && x.Stations[x.Stations.Count - 1] == endStationID);
                        if (path != null)
                        {
                            Timetable result = timetable.Find(x => x.TrainID == train.TrainID && x.PathID == path.PathID);
                            if (result != null)
                                return result;
                        }
                    }
                }
            }
            return null;
        }

        static public List<string> FindStationDetails(string stationName)
        {
            Station station = stations.Find(x => x.StationName.ToLower() == stationName.ToLower());
            if (station != null)
            {
                List<TrainPath> paths = trainPaths.FindAll(x => x.Stations.Contains(station.StationID));
                if (paths.Count > 0)
                {
                    List<Train> trainsResult = trains.FindAll(x => x.PathIDs.Exists(z => paths.Exists(y => y.PathID == z)));
                    if (trainsResult.Count > 0)
                    {
                        List<string> result = trainsResult.Select(x => x.ToString()).ToList();
                        result.Sort();
                        return result;
                    }
                }
            }
            return null;
        }

        static public List<string> FindCompanysTrains(string companyName)
        {
            Company company = companies.Find(x => x.CompanyName.ToLower() == companyName.ToLower());
            if (company != null)
            {
                List<Train> companysTrains = trains.FindAll(x => x.CompanyID == company.CompanyID);
                if (companysTrains.Count > 0)
                {
                    List<string> result = companysTrains.Select(x => x.TrainName).ToList();
                    result.Sort();
                    return result;
                }
            }
            return null;
        }

        static public List<string> FindTrainsFacilities(string trainName)
        {
            Train train = trains.Find(x => x.ToString().ToLower() == trainName.ToLower());
            if (train != null)
            {
                List<Facilities> trainsFacilities = facilities.FindAll(x => train.FacilitiesIDs.Contains(x.FacilityID));
                if (trainsFacilities.Count > 0)
                {
                    List<string> result = trainsFacilities.Select(x => x.FacilityName).ToList();
                    result.Sort();
                    return result;
                }
            }
            return null;
        }

        static public bool ChangeStationName(string oldName, string newName)
        {
            Station station = stations.Find(x => x.StationName.ToLower() == oldName.ToLower());
            if (station != null)
            {
                station.StationName = newName;
                var output = JsonConvert.SerializeObject(stations);
                File.WriteAllText(StationsFile, output);
                return true;
            }
            return false;
        }

        static public bool ChangeTrainName(string oldName, string newName)
        {
            Train train = trains.Find(x => x.TrainName.ToLower() == oldName.ToLower());
            if(train != null)
            {
                train.TrainName = newName;
                var output = JsonConvert.SerializeObject(trains);
                File.WriteAllText(TrainsFile, output);
                return true;
            }
            return false;
        }

        static public bool AddTrain(string name)
        {
            return true;
        }
    }
}
