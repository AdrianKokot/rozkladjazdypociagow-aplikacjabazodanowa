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
        public Home()
        {
            InitializeComponent();
            //searchPanel.BringToFront();
            DataBase.ImportAll();
            search1.InitAutoComplete();
            search1.BringToFront();
        }

        private void btnSearchPanel_Click(object sender, EventArgs e)
        {
            search1.BringToFront();
        }

        private void btnTrainPanel_Click(object sender, EventArgs e)
        {
            timetableSearchResult1.BringToFront();
        }
    }
}
