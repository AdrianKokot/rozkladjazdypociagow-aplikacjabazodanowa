using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using RJP;

namespace RJP_EdytorBazyDanych
{
    public partial class trainEdit : UserControl
    {
        private bool trainValid = false;
        public trainEdit()
        {
            InitializeComponent();
        }

        public void InitAutocomplete()
        {
            var autoComplete = new AutoCompleteStringCollection();
            List<string> trains = DataBase.trains.Select(x => x.TrainName).ToList();
            trains.Sort();
            autoComplete.AddRange(trains.ToArray());
            trainSelect.AutoCompleteCustomSource = autoComplete;
            trainSelect.Items.AddRange(trains.ToArray());
        }

        public void Reset()
        {
            trainError.SetError(trainSelect, "");
            newTrainError.SetError(newTrainName, "");
            trainValid = false;
            newTrainName.Text = "";
            trainSelect.Text = "";
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (trainValid && newTrainName.Text != "")
            {
                newTrainError.SetError(newTrainName, "");
                if (DataBase.ChangeTrainName(trainSelect.Text, newTrainName.Text))
                {
                    MessageBox.Show("Zmiana została zaakceptowana");
                    InitAutocomplete();
                }
            }
            else
            {
                newTrainError.SetError(newTrainName, "Nazwa nie może być pusta");
            }
        }

        private void TrainSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DataBase.trains.Exists(x => x.TrainName.ToLower() == trainSelect.Text.ToLower()))
            {
                trainValid = true;
                newTrainName.Text = trainSelect.Text;
                trainError.SetError(trainSelect, "");
            }
            else
            {
                trainError.SetError(trainSelect, "Podany pociąg nie istnieje");
                trainValid = false;
            }
        }
    }
}
