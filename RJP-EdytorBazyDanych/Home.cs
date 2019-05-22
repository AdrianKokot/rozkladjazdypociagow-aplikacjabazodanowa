using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RJP;

namespace RJP_EdytorBazyDanych
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
            stationEdit1.InitAutocomplete();
            trainEdit1.InitAutocomplete();
            btns = new List<Button>()
            {
                btnEditStations,
                btnEditTrain,
                btnAddTimetable
            };
            black = new List<Bitmap>
            {
                global::RJP_EdytorBazyDanych.Properties.Resources.routeBlack,
                global::RJP_EdytorBazyDanych.Properties.Resources.trainBlack,
                global::RJP_EdytorBazyDanych.Properties.Resources.bookmarkBlack
            };
            white = new List<Bitmap>
            {
                global::RJP_EdytorBazyDanych.Properties.Resources.routeWhite,
                global::RJP_EdytorBazyDanych.Properties.Resources.trainWhite,
                global::RJP_EdytorBazyDanych.Properties.Resources.bookmarkWhite
            };
            searchBtn();
        }

        private void searchBtn()
        {
            stationEdit1.BringToFront();
            resetBtnsColorsAndPanels();
            btnEditStations.BackColor = Color.FromArgb(33, 94, 231);
            btnEditStations.ForeColor = Color.White;
            btnEditStations.Image = white[0];
        }

        private void resetBtnsColorsAndPanels()
        {
            for (int i = 0; i < btns.Count; i++)
            {
                btns[i].BackColor = Color.White;
                btns[i].ForeColor = Color.Black;
                btns[i].Image = black[i];
            }
            stationEdit1.Reset();
            trainEdit1.Reset();
        }

        private void BtnEditStations_Click(object sender, EventArgs e)
        {
            searchBtn();
        }

        private void BtnEditTrain_Click(object sender, EventArgs e)
        {
            resetBtnsColorsAndPanels();
            btnEditTrain.BackColor = Color.FromArgb(246, 56, 137);
            btnEditTrain.ForeColor = Color.White;
            btnEditTrain.Image = white[1];
            trainEdit1.BringToFront();
        }

        private void BtnAddTimetable_Click(object sender, EventArgs e)
        {
            resetBtnsColorsAndPanels();
            btnAddTimetable.BackColor = Color.FromArgb(246, 162, 38);
            btnAddTimetable.ForeColor = Color.White;
            btnAddTimetable.Image = white[2];
            //stationDetails1.BringToFront();
        }
    }
}
