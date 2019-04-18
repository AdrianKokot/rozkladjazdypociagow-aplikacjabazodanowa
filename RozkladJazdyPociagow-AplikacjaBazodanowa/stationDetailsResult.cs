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
    public partial class stationDetailsResult : UserControl
    {
        private List<Label> labels;
        private List<PictureBox> boxes;

        public stationDetailsResult()
        {
            InitializeComponent();
            labels = new List<Label>()
            {
                label1Train,
                label2Train,
                label3Train,
                label4Train,
                label5Train,
                label6Train,
                label7Train,
                label8Train,
                label9Train,
                label10Train,
                label11Train,
                label12Train,
                label13Train,
                label14Train,
                label15Train,
                label16Train,
                label17Train,
                label18Train,
                label19Train,
                label20Train
            };
            boxes = new List<PictureBox>()
            {
                label1Back,
                label2Back,
                label3Back,
                label4Back,
                label5Back,
                label6Back,
                label7Back,
                label8Back,
                label9Back,
                label10Back,
                label11Back,
                label12Back,
                label13Back,
                label14Back,
                label15Back,
                label16Back,
                label17Back,
                label18Back,
                label19Back,
                label20Back
            };
        }

        public void FullfillLabels(List<string> trains)
        {
            if (trains.Count <= 8)
                this.AutoScroll = false;
            else
                this.AutoScroll = true;
            for(int i = 0; i<trains.Count; i++)
            {
                labels[i].Text = trains[i];
                boxes[i].Visible = true;
            }
        }

        public void Reset()
        {
            foreach (Label label in labels)
                label.Text = "";
            foreach (PictureBox box in boxes)
                box.Visible = false;
        }
    }
}
