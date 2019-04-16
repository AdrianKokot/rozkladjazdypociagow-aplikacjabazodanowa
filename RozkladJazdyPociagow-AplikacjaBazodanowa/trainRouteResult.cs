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
    public partial class trainRouteResult : UserControl
    {
        private List<List<Label>> labels;
        private List<PictureBox> backs;
        public trainRouteResult()
        {
            InitializeComponent();
            labels = new List<List<Label>>()
            {
                new List<Label>()
                {
                    label1Train, label1Out
                },
                new List<Label>()
                {
                    label2Train, label2Out
                },
                new List<Label>()
                {
                    label3Train, label3Out
                },
                new List<Label>()
                {
                    label4Train, label4Out
                },
                new List<Label>()
                {
                    label5Train, label5Out
                },
                new List<Label>()
                {
                    label6Train, label6Out
                },
                new List<Label>()
                {
                    label7Train, label7Out
                }
            };
            backs = new List<PictureBox>()
            {
                label1Back,
                label2Back,
                label3Back,
                label4Back,
                label5Back,
                label6Back,
                label7Back
            };
        }

        public void FullfillLabels(Timetable timetable)
        {
            for (int i = 0; i < timetable.Hours.Count; i++)
            {
                labels[i][0].Text = DataBase.stations.Find(x => x.StationID == timetable.Hours[i].StationID).StationName.ToString();
                labels[i][1].Text = timetable.Hours[i].ToString();
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
