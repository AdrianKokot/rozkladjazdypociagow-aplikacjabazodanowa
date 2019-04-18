using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RozkladJazdyPociagow_AplikacjaBazodanowa
{
    public partial class Home : Form
    {
        private List<Button> btns;
        private List<Bitmap> black;
        private List<Bitmap> white;
        public Home()
        {
            InitializeComponent();
            DataBase.ImportAll();
            search1.InitAutoComplete();
            trainRoute1.InitAutoTrainAutocomplete();
            stationDetails1.InitAutoComplete();
            companyTrains1.InitAutocomplete();
            btns = new List<Button>()
            {
                btnSearchPanel,
                btnTrainPanel,
                btnStationPanel,
                btnCompanyPanel
            };
            black = new List<Bitmap>
            {
                global::RozkladJazdyPociagow_AplikacjaBazodanowa.Properties.Resources.searchBlack,
                global::RozkladJazdyPociagow_AplikacjaBazodanowa.Properties.Resources.routeBlack,
                global::RozkladJazdyPociagow_AplikacjaBazodanowa.Properties.Resources.trainBlack,
                global::RozkladJazdyPociagow_AplikacjaBazodanowa.Properties.Resources.staffBlack
            };
            white = new List<Bitmap>
            {
                global::RozkladJazdyPociagow_AplikacjaBazodanowa.Properties.Resources.searchWhite,
                global::RozkladJazdyPociagow_AplikacjaBazodanowa.Properties.Resources.routeWhite,
                global::RozkladJazdyPociagow_AplikacjaBazodanowa.Properties.Resources.trainWhite,
                global::RozkladJazdyPociagow_AplikacjaBazodanowa.Properties.Resources.staffWhite
            };
            searchBtn();
        }

        private void btnSearchPanel_Click(object sender, EventArgs e)
        {
            searchBtn();
        }

        private void searchBtn()
        {
            search1.BringToFront();
            resetBtnsColorsAndPanels();
            btnSearchPanel.BackColor = Color.FromArgb(33, 94, 231);
            btnSearchPanel.ForeColor = Color.White;
            btnSearchPanel.Image = white[0];
        }

        private void btnTrainPanel_Click(object sender, EventArgs e)
        {
            resetBtnsColorsAndPanels();
            btnTrainPanel.BackColor = Color.FromArgb(246, 56, 137);
            btnTrainPanel.ForeColor = Color.White;
            btnTrainPanel.Image = white[1];
            trainRoute1.BringToFront();
        }

        private void btnStationPanel_Click(object sender, EventArgs e)
        {
            resetBtnsColorsAndPanels();
            btnStationPanel.BackColor = Color.FromArgb(246, 162, 38);
            btnStationPanel.ForeColor = Color.White;
            btnStationPanel.Image = white[2];
            stationDetails1.BringToFront();
        }

        private void resetBtnsColorsAndPanels()
        {
            for(int i = 0; i<btns.Count; i++)
            {
                btns[i].BackColor = Color.White;
                btns[i].ForeColor = Color.Black;
                btns[i].Image = black[i];
            }
            search1.Reset();
            trainRoute1.Reset();
            stationDetails1.Reset();
            companyTrains1.Reset();
        }

        private void btnCompanyPanel_Click(object sender, EventArgs e)
        {
            resetBtnsColorsAndPanels();
            btnCompanyPanel.BackColor = Color.FromArgb(33, 94, 231);
            btnCompanyPanel.ForeColor = Color.White;
            btnCompanyPanel.Image = white[3];
            companyTrains1.BringToFront();
        }
    }
}
