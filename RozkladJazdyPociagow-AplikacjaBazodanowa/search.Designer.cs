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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.secondCityBoxBack = new System.Windows.Forms.PictureBox();
            this.firstCityBoxBack = new System.Windows.Forms.PictureBox();
            this.changeCities = new System.Windows.Forms.Button();
            this.timetableSearchResult1 = new RozkladJazdyPociagow_AplikacjaBazodanowa.timetableSearchResult();
            ((System.ComponentModel.ISupportInitialize)(this.firstCityError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCityError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCityBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstCityBoxBack)).BeginInit();
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
            this.dateDate.Location = new System.Drawing.Point(88, 377);
            this.dateDate.Margin = new System.Windows.Forms.Padding(0);
            this.dateDate.Name = "dateDate";
            this.dateDate.Size = new System.Drawing.Size(135, 32);
            this.dateDate.TabIndex = 2;
            // 
            // dateTime
            // 
            this.dateTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTime.CustomFormat = " HH:mm";
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime.Location = new System.Drawing.Point(256, 377);
            this.dateTime.Margin = new System.Windows.Forms.Padding(0);
            this.dateTime.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.dateTime.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dateTime.Name = "dateTime";
            this.dateTime.ShowUpDown = true;
            this.dateTime.Size = new System.Drawing.Size(80, 32);
            this.dateTime.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(66, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
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
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Stacja końcowa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(66, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 25);
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
            this.label4.Size = new System.Drawing.Size(419, 50);
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
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(232, 382);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 382);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // secondCityBoxBack
            // 
            this.secondCityBoxBack.BackColor = System.Drawing.Color.White;
            this.secondCityBoxBack.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.secondCityBoxBack.Image = ((System.Drawing.Image)(resources.GetObject("secondCityBoxBack.Image")));
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
            this.firstCityBoxBack.Image = ((System.Drawing.Image)(resources.GetObject("firstCityBoxBack.Image")));
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
            this.changeCities.Image = ((System.Drawing.Image)(resources.GetObject("changeCities.Image")));
            this.changeCities.Location = new System.Drawing.Point(435, 219);
            this.changeCities.Margin = new System.Windows.Forms.Padding(0);
            this.changeCities.Name = "changeCities";
            this.changeCities.Size = new System.Drawing.Size(43, 43);
            this.changeCities.TabIndex = 10;
            this.changeCities.UseVisualStyleBackColor = true;
            this.changeCities.Click += new System.EventHandler(this.changeCities_Click);
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
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateDate);
            this.Controls.Add(this.secondCity);
            this.Controls.Add(this.secondCityBoxBack);
            this.Controls.Add(this.firstCity);
            this.Controls.Add(this.firstCityBoxBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.changeCities);
            this.Controls.Add(this.timetableSearchResult1);
            this.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "search";
            this.Size = new System.Drawing.Size(708, 540);
            ((System.ComponentModel.ISupportInitialize)(this.firstCityError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCityError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCityBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstCityBoxBack)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exit;
        private timetableSearchResult timetableSearchResult1;
    }
}
