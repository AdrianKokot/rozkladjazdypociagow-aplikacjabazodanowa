namespace RozkladJazdyPociagow_AplikacjaBazodanowa
{
    partial class search
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstCity = new System.Windows.Forms.TextBox();
            this.secondCity = new System.Windows.Forms.TextBox();
            this.changeCities = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // firstCity
            // 
            this.firstCity.Location = new System.Drawing.Point(18, 21);
            this.firstCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstCity.Name = "firstCity";
            this.firstCity.Size = new System.Drawing.Size(148, 27);
            this.firstCity.TabIndex = 0;
            // 
            // secondCity
            // 
            this.secondCity.Location = new System.Drawing.Point(255, 30);
            this.secondCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.secondCity.Name = "secondCity";
            this.secondCity.Size = new System.Drawing.Size(148, 27);
            this.secondCity.TabIndex = 1;
            // 
            // changeCities
            // 
            this.changeCities.Location = new System.Drawing.Point(334, 135);
            this.changeCities.Name = "changeCities";
            this.changeCities.Size = new System.Drawing.Size(24, 23);
            this.changeCities.TabIndex = 2;
            this.changeCities.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(338, 236);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(163, 35);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Wyszukaj";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(60, 190);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(106, 27);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.changeCities);
            this.Controls.Add(this.secondCity);
            this.Controls.Add(this.firstCity);
            this.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "search";
            this.Size = new System.Drawing.Size(575, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstCity;
        private System.Windows.Forms.TextBox secondCity;
        private System.Windows.Forms.Button changeCities;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
