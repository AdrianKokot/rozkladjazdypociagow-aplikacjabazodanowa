using System.Collections.Generic;
using System.Windows.Forms;
using RJP;

namespace RozkladJazdyPociagow_AplikacjaBazodanowa
{
    public partial class timetableSearchResult : UserControl
    {
        private List<List<Label>> labels;
        private List<PictureBox> backs;
        public timetableSearchResult()
        {
            InitializeComponent();
            labels = new List<List<Label>>()
            {
                new List<Label>()
                {
                    label1Train, label1Out, label1In
                },
                new List<Label>()
                {
                    label2Train, label2Out, label2In
                },
                new List<Label>()
                {
                    label3Train, label3Out, label3In
                },
                new List<Label>()
                {
                    label4Train, label4Out, label4In
                },
                new List<Label>()
                {
                    label5Train, label5Out, label5In
                }
            };
            backs = new List<PictureBox>()
            {
                label1Back,
                label2Back,
                label3Back,
                label4Back,
                label5Back
            };
        }

        public void FullfillLabels(TimetableResult timetable)
        {
            for(int i = 0; i<timetable.timetable.Count; i++)
            {
                labels[i][0].Text = DataBase.trains.Find(x => x.TrainID == timetable.timetable[i].TrainID).ToString();
                labels[i][1].Text = timetable.timetable[i].Hours.Find(x => x.StationID == timetable.startStationID).ToString();
                labels[i][2].Text = timetable.timetable[i].Hours.Find(x => x.StationID == timetable.endStationID).ToString();
                backs[i].Visible = true;
            }
        }

        public void Reset()
        {
            foreach (List<Label> labels2 in labels)
                foreach (Label label in labels2)
                    label.Text = "";
            foreach (PictureBox box in backs)
                box.Visible = false;
        }
    }
}
