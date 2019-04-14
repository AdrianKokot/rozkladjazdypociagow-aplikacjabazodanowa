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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(search));
            this.firstCity = new System.Windows.Forms.TextBox();
            this.secondCity = new System.Windows.Forms.TextBox();
            this.changeCities = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dateDate = new System.Windows.Forms.DateTimePicker();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // firstCity
            // 
            this.firstCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.firstCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.firstCity.Location = new System.Drawing.Point(178, 168);
            this.firstCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstCity.Name = "firstCity";
            this.firstCity.Size = new System.Drawing.Size(148, 27);
            this.firstCity.TabIndex = 0;
            // 
            // secondCity
            // 
            this.secondCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.secondCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.secondCity.Location = new System.Drawing.Point(421, 168);
            this.secondCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.secondCity.Name = "secondCity";
            this.secondCity.Size = new System.Drawing.Size(148, 27);
            this.secondCity.TabIndex = 1;
            // 
            // changeCities
            // 
            this.changeCities.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeCities.FlatAppearance.BorderSize = 0;
            this.changeCities.Image = ((System.Drawing.Image)(resources.GetObject("changeCities.Image")));
            this.changeCities.Location = new System.Drawing.Point(361, 168);
            this.changeCities.Margin = new System.Windows.Forms.Padding(0);
            this.changeCities.Name = "changeCities";
            this.changeCities.Size = new System.Drawing.Size(30, 30);
            this.changeCities.TabIndex = 2;
            this.changeCities.UseVisualStyleBackColor = true;
            this.changeCities.Click += new System.EventHandler(this.changeCities_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(298, 256);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(163, 35);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Wyszukaj";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dateDate
            // 
            this.dateDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDate.Location = new System.Drawing.Point(287, 223);
            this.dateDate.Name = "dateDate";
            this.dateDate.Size = new System.Drawing.Size(106, 27);
            this.dateDate.TabIndex = 4;
            // 
            // dateTime
            // 
            this.dateTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTime.CustomFormat = " HH:mm";
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime.Location = new System.Drawing.Point(396, 223);
            this.dateTime.Margin = new System.Windows.Forms.Padding(0);
            this.dateTime.Name = "dateTime";
            this.dateTime.ShowUpDown = true;
            this.dateTime.Size = new System.Drawing.Size(70, 27);
            this.dateTime.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Stacja początkowa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Stacja końcowa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data i godzina odjazdu";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(3, 3);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(566, 128);
            this.output.TabIndex = 8;
            this.output.Text = "";
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.output);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.dateDate);
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
        private System.Windows.Forms.DateTimePicker dateDate;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox output;
    }
}
