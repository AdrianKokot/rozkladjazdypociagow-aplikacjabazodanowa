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
            btns = new List<Button>()
            {
                btnSearchPanel,
                btnTrainPanel,
                btnStationPanel
            };
            black = new List<Bitmap>
            {
                global::RozkladJazdyPociagow_AplikacjaBazodanowa.Properties.Resources.searchBlack,
                global::RozkladJazdyPociagow_AplikacjaBazodanowa.Properties.Resources.routeBlack,
                global::RozkladJazdyPociagow_AplikacjaBazodanowa.Properties.Resources.trainBlack
            };
            white = new List<Bitmap>
            {
                global::RozkladJazdyPociagow_AplikacjaBazodanowa.Properties.Resources.searchWhite,
                global::RozkladJazdyPociagow_AplikacjaBazodanowa.Properties.Resources.routeWhite,
                global::RozkladJazdyPociagow_AplikacjaBazodanowa.Properties.Resources.trainWhite
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
            resetBtnsColors();
            btnSearchPanel.BackColor = Color.FromArgb(33, 94, 231);
            btnSearchPanel.ForeColor = Color.White;
            btnSearchPanel.Image = white[0];
        }

        private void btnTrainPanel_Click(object sender, EventArgs e)
        {
            resetBtnsColors();
            btnTrainPanel.BackColor = Color.FromArgb(246, 56, 137);
            btnTrainPanel.ForeColor = Color.White;
            btnTrainPanel.Image = white[1];
            trainRoute1.BringToFront();
        }

        private void btnStationPanel_Click(object sender, EventArgs e)
        {
            resetBtnsColors();
            btnStationPanel.BackColor = Color.FromArgb(246, 162, 38);
            btnStationPanel.ForeColor = Color.White;
            btnStationPanel.Image = white[2];
        }

        private void resetBtnsColors()
        {
            for(int i = 0; i<btns.Count; i++)
            {
                btns[i].BackColor = Color.White;
                btns[i].ForeColor = Color.Black;
                btns[i].Image = black[i];
            }
        }
    }
}
