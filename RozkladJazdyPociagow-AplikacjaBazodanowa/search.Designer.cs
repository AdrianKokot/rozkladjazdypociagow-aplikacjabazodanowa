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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(search));
            this.firstCity = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dateDate = new System.Windows.Forms.DateTimePicker();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstCityError = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.secondCity = new System.Windows.Forms.TextBox();
            this.secondCityError = new System.Windows.Forms.ErrorProvider(this.components);
            this.exit = new System.Windows.Forms.Button();
            this.timetableSearchResult1 = new RozkladJazdyPociagow_AplikacjaBazodanowa.timetableSearchResult();
            this.secondCityBoxBack = new System.Windows.Forms.PictureBox();
            this.firstCityBoxBack = new System.Windows.Forms.PictureBox();
            this.changeCities = new System.Windows.Forms.Button();
            this.dateDateBack = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.firstCityError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCityError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCityBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstCityBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDateBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // firstCity
            // 
            this.firstCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.firstCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.firstCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstCity.ForeColor = System.Drawing.Color.Black;
            this.firstCity.Location = new System.Drawing.Point(105, 176);
            this.firstCity.Margin = new System.Windows.Forms.Padding(0);
            this.firstCity.Name = "firstCity";
            this.firstCity.Size = new System.Drawing.Size(316, 25);
            this.firstCity.TabIndex = 0;
            this.firstCity.Validating += new System.ComponentModel.CancelEventHandler(this.firstCity_Validating);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(193)))), ((int)(((byte)(61)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(66, 458);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(218, 43);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Wyszukaj";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dateDate
            // 
            this.dateDate.Checked = false;
            this.dateDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateDate.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.dateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDate.Location = new System.Drawing.Point(105, 377);
            this.dateDate.Margin = new System.Windows.Forms.Padding(0);
            this.dateDate.Name = "dateDate";
            this.dateDate.Size = new System.Drawing.Size(135, 32);
            this.dateDate.TabIndex = 2;
            // 
            // dateTime
            // 
            this.dateTime.CalendarFont = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.dateTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTime.CustomFormat = " HH : mm";
            this.dateTime.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime.Location = new System.Drawing.Point(292, 377);
            this.dateTime.Margin = new System.Windows.Forms.Padding(0);
            this.dateTime.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.dateTime.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dateTime.Name = "dateTime";
            this.dateTime.ShowUpDown = true;
            this.dateTime.Size = new System.Drawing.Size(90, 32);
            this.dateTime.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(66, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Stacja początkowa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(66, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Stacja końcowa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(66, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data i godzina odjazdu";
            // 
            // firstCityError
            // 
            this.firstCityError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.firstCityError.ContainerControl = this;
            this.firstCityError.Icon = ((System.Drawing.Icon)(resources.GetObject("firstCityError.Icon")));
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Google Sans", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(63, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(424, 50);
            this.label4.TabIndex = 10;
            this.label4.Text = "Wyszukaj połączenia";
            // 
            // secondCity
            // 
            this.secondCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.secondCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.secondCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondCity.ForeColor = System.Drawing.Color.Black;
            this.secondCity.Location = new System.Drawing.Point(105, 281);
            this.secondCity.Margin = new System.Windows.Forms.Padding(0);
            this.secondCity.Name = "secondCity";
            this.secondCity.Size = new System.Drawing.Size(316, 25);
            this.secondCity.TabIndex = 1;
            this.secondCity.Validating += new System.ComponentModel.CancelEventHandler(this.secondCity_Validating);
            // 
            // secondCityError
            // 
            this.secondCityError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.secondCityError.ContainerControl = this;
            this.secondCityError.Icon = ((System.Drawing.Icon)(resources.GetObject("secondCityError.Icon")));
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(193)))), ((int)(((byte)(61)))));
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(66, 458);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(270, 43);
            this.exit.TabIndex = 5;
            this.exit.Text = "Ponowne wyszukiwanie";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // timetableSearchResult1
            // 
            this.timetableSearchResult1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.timetableSearchResult1.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.timetableSearchResult1.Location = new System.Drawing.Point(0, 0);
            this.timetableSearchResult1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.timetableSearchResult1.Name = "timetableSearchResult1";
            this.timetableSearchResult1.Size = new System.Drawing.Size(708, 540);
            this.timetableSearchResult1.TabIndex = 17;
            // 
            // secondCityBoxBack
            // 
            this.secondCityBoxBack.BackColor = System.Drawing.Color.White;
            this.secondCityBoxBack.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.secondCityBoxBack.Image = global::RozkladJazdyPociagow_AplikacjaBazodanowa.Properties.Resources.pin;
            this.secondCityBoxBack.Location = new System.Drawing.Point(66, 272);
            this.secondCityBoxBack.Margin = new System.Windows.Forms.Padding(0);
            this.secondCityBoxBack.Name = "secondCityBoxBack";
            this.secondCityBoxBack.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.secondCityBoxBack.Size = new System.Drawing.Size(355, 43);
            this.secondCityBoxBack.TabIndex = 13;
            this.secondCityBoxBack.TabStop = false;
            this.secondCityBoxBack.Click += new System.EventHandler(this.secondCityBoxBack_Click);
            // 
            // firstCityBoxBack
            // 
            this.firstCityBoxBack.BackColor = System.Drawing.Color.White;
            this.firstCityBoxBack.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstCityBoxBack.Image = global::RozkladJazdyPociagow_AplikacjaBazodanowa.Properties.Resources.pin;
            this.firstCityBoxBack.Location = new System.Drawing.Point(66, 167);
            this.firstCityBoxBack.Margin = new System.Windows.Forms.Padding(0);
            this.firstCityBoxBack.Name = "firstCityBoxBack";
            this.firstCityBoxBack.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.firstCityBoxBack.Size = new System.Drawing.Size(355, 43);
            this.firstCityBoxBack.TabIndex = 11;
            this.firstCityBoxBack.TabStop = false;
            this.firstCityBoxBack.Click += new System.EventHandler(this.firstCityBoxBack_Click);
            // 
            // changeCities
            // 
            this.changeCities.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeCities.FlatAppearance.BorderSize = 0;
            this.changeCities.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.changeCities.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.changeCities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeCities.Image = global::RozkladJazdyPociagow_AplikacjaBazodanowa.Properties.Resources.change;
            this.changeCities.Location = new System.Drawing.Point(435, 219);
            this.changeCities.Margin = new System.Windows.Forms.Padding(0);
            this.changeCities.Name = "changeCities";
            this.changeCities.Size = new System.Drawing.Size(43, 43);
            this.changeCities.TabIndex = 10;
            this.changeCities.UseVisualStyleBackColor = true;
            this.changeCities.Click += new System.EventHandler(this.changeCities_Click);
            // 
            // dateDateBack
            // 
            this.dateDateBack.BackColor = System.Drawing.Color.White;
            this.dateDateBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateDateBack.Image = global::RozkladJazdyPociagow_AplikacjaBazodanowa.Properties.Resources.calendar;
            this.dateDateBack.Location = new System.Drawing.Point(66, 372);
            this.dateDateBack.Margin = new System.Windows.Forms.Padding(0);
            this.dateDateBack.Name = "dateDateBack";
            this.dateDateBack.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.dateDateBack.Size = new System.Drawing.Size(174, 43);
            this.dateDateBack.TabIndex = 18;
            this.dateDateBack.TabStop = false;
            this.dateDateBack.Click += new System.EventHandler(this.DateDateBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(105, 377);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 1);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(105, 408);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(135, 1);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(105, 377);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1, 32);
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Location = new System.Drawing.Point(239, 377);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1, 32);
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::RozkladJazdyPociagow_AplikacjaBazodanowa.Properties.Resources.clock;
            this.pictureBox6.Location = new System.Drawing.Point(253, 372);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.pictureBox6.Size = new System.Drawing.Size(129, 43);
            this.pictureBox6.TabIndex = 23;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.PictureBox6_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(292, 408);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 1);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Location = new System.Drawing.Point(292, 377);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(90, 1);
            this.pictureBox7.TabIndex = 25;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Location = new System.Drawing.Point(381, 377);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(1, 32);
            this.pictureBox8.TabIndex = 26;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.White;
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Location = new System.Drawing.Point(292, 377);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(1, 32);
            this.pictureBox9.TabIndex = 27;
            this.pictureBox9.TabStop = false;
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateDate);
            this.Controls.Add(this.dateDateBack);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.secondCity);
            this.Controls.Add(this.secondCityBoxBack);
            this.Controls.Add(this.firstCity);
            this.Controls.Add(this.firstCityBoxBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.changeCities);
            this.Controls.Add(this.timetableSearchResult1);
            this.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "search";
            this.Size = new System.Drawing.Size(708, 540);
            ((System.ComponentModel.ISupportInitialize)(this.firstCityError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCityError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCityBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstCityBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDateBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstCity;
        private System.Windows.Forms.Button changeCities;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateDate;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider firstCityError;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox firstCityBoxBack;
        private System.Windows.Forms.TextBox secondCity;
        private System.Windows.Forms.PictureBox secondCityBoxBack;
        private System.Windows.Forms.ErrorProvider secondCityError;
        private System.Windows.Forms.Button exit;
        private timetableSearchResult timetableSearchResult1;
        private System.Windows.Forms.PictureBox dateDateBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
