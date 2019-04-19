namespace RozkladJazdyPociagow_AplikacjaBazodanowa
{
    partial class Home
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.stationDetails1 = new RozkladJazdyPociagow_AplikacjaBazodanowa.stationDetails();
            this.trainRoute1 = new RozkladJazdyPociagow_AplikacjaBazodanowa.trainRoute();
            this.search1 = new RozkladJazdyPociagow_AplikacjaBazodanowa.search();
            this.companyTrains1 = new RozkladJazdyPociagow_AplikacjaBazodanowa.companyTrains();
            this.btnTrainsFacilitiesPanel = new System.Windows.Forms.Button();
            this.btnCompanyPanel = new System.Windows.Forms.Button();
            this.btnStationPanel = new System.Windows.Forms.Button();
            this.btnTrainPanel = new System.Windows.Forms.Button();
            this.btnSearchPanel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trainsFacilities1 = new RozkladJazdyPociagow_AplikacjaBazodanowa.trainsFacilities();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // stationDetails1
            // 
            this.stationDetails1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.stationDetails1.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.stationDetails1.Location = new System.Drawing.Point(252, 0);
            this.stationDetails1.Margin = new System.Windows.Forms.Padding(0);
            this.stationDetails1.Name = "stationDetails1";
            this.stationDetails1.Size = new System.Drawing.Size(708, 540);
            this.stationDetails1.TabIndex = 20;
            // 
            // trainRoute1
            // 
            this.trainRoute1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.trainRoute1.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.trainRoute1.Location = new System.Drawing.Point(252, 0);
            this.trainRoute1.Margin = new System.Windows.Forms.Padding(0);
            this.trainRoute1.Name = "trainRoute1";
            this.trainRoute1.Size = new System.Drawing.Size(708, 540);
            this.trainRoute1.TabIndex = 19;
            // 
            // search1
            // 
            this.search1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.search1.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.search1.Location = new System.Drawing.Point(252, 0);
            this.search1.Margin = new System.Windows.Forms.Padding(0);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(708, 540);
            this.search1.TabIndex = 18;
            // 
            // companyTrains1
            // 
            this.companyTrains1.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.companyTrains1.Location = new System.Drawing.Point(252, 0);
            this.companyTrains1.Margin = new System.Windows.Forms.Padding(0);
            this.companyTrains1.Name = "companyTrains1";
            this.companyTrains1.Size = new System.Drawing.Size(708, 540);
            this.companyTrains1.TabIndex = 22;
            // 
            // btnTrainsFacilitiesPanel
            // 
            this.btnTrainsFacilitiesPanel.BackColor = System.Drawing.Color.White;
            this.btnTrainsFacilitiesPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrainsFacilitiesPanel.FlatAppearance.BorderSize = 0;
            this.btnTrainsFacilitiesPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrainsFacilitiesPanel.Font = new System.Drawing.Font("Google Sans", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnTrainsFacilitiesPanel.ForeColor = System.Drawing.Color.Black;
            this.btnTrainsFacilitiesPanel.Image = global::RozkladJazdyPociagow_AplikacjaBazodanowa.Properties.Resources.bookmarkBlack;
            this.btnTrainsFacilitiesPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrainsFacilitiesPanel.Location = new System.Drawing.Point(0, 459);
            this.btnTrainsFacilitiesPanel.Margin = new System.Windows.Forms.Padding(0);
            this.btnTrainsFacilitiesPanel.Name = "btnTrainsFacilitiesPanel";
            this.btnTrainsFacilitiesPanel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnTrainsFacilitiesPanel.Size = new System.Drawing.Size(252, 50);
            this.btnTrainsFacilitiesPanel.TabIndex = 23;
            this.btnTrainsFacilitiesPanel.Text = " Udogodnienia pociągu";
            this.btnTrainsFacilitiesPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrainsFacilitiesPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrainsFacilitiesPanel.UseVisualStyleBackColor = false;
            this.btnTrainsFacilitiesPanel.Click += new System.EventHandler(this.BtnTrainsFacilitiesPanel_Click);
            // 
            // btnCompanyPanel
            // 
            this.btnCompanyPanel.BackColor = System.Drawing.Color.White;
            this.btnCompanyPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompanyPanel.FlatAppearance.BorderSize = 0;
            this.btnCompanyPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompanyPanel.Font = new System.Drawing.Font("Google Sans", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnCompanyPanel.ForeColor = System.Drawing.Color.Black;
            this.btnCompanyPanel.Image = global::RozkladJazdyPociagow_AplikacjaBazodanowa.Properties.Resources.staffBlack;
            this.btnCompanyPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompanyPanel.Location = new System.Drawing.Point(0, 393);
            this.btnCompanyPanel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCompanyPanel.Name = "btnCompanyPanel";
            this.btnCompanyPanel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCompanyPanel.Size = new System.Drawing.Size(252, 50);
            this.btnCompanyPanel.TabIndex = 21;
            this.btnCompanyPanel.Text = " Pociągi przewoźników";
            this.btnCompanyPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompanyPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompanyPanel.UseVisualStyleBackColor = false;
            this.btnCompanyPanel.Click += new System.EventHandler(this.btnCompanyPanel_Click);
            // 
            // btnStationPanel
            // 
            this.btnStationPanel.BackColor = System.Drawing.Color.White;
            this.btnStationPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStationPanel.FlatAppearance.BorderSize = 0;
            this.btnStationPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStationPanel.Font = new System.Drawing.Font("Google Sans", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnStationPanel.ForeColor = System.Drawing.Color.Black;
            this.btnStationPanel.Image = global::RozkladJazdyPociagow_AplikacjaBazodanowa.Properties.Resources.trainBlack;
            this.btnStationPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStationPanel.Location = new System.Drawing.Point(0, 327);
            this.btnStationPanel.Margin = new System.Windows.Forms.Padding(0);
            this.btnStationPanel.Name = "btnStationPanel";
            this.btnStationPanel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnStationPanel.Size = new System.Drawing.Size(252, 50);
            this.btnStationPanel.TabIndex = 17;
            this.btnStationPanel.Text = " Pociągi na stacji";
            this.btnStationPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStationPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStationPanel.UseVisualStyleBackColor = false;
            this.btnStationPanel.Click += new System.EventHandler(this.btnStationPanel_Click);
            // 
            // btnTrainPanel
            // 
            this.btnTrainPanel.BackColor = System.Drawing.Color.White;
            this.btnTrainPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrainPanel.FlatAppearance.BorderSize = 0;
            this.btnTrainPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrainPanel.Font = new System.Drawing.Font("Google Sans", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnTrainPanel.ForeColor = System.Drawing.Color.Black;
            this.btnTrainPanel.Image = global::RozkladJazdyPociagow_AplikacjaBazodanowa.Properties.Resources.routeBlack;
            this.btnTrainPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrainPanel.Location = new System.Drawing.Point(0, 261);
            this.btnTrainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.btnTrainPanel.Name = "btnTrainPanel";
            this.btnTrainPanel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnTrainPanel.Size = new System.Drawing.Size(252, 50);
            this.btnTrainPanel.TabIndex = 16;
            this.btnTrainPanel.Text = " Przebieg pociągu";
            this.btnTrainPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrainPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrainPanel.UseVisualStyleBackColor = false;
            this.btnTrainPanel.Click += new System.EventHandler(this.btnTrainPanel_Click);
            // 
            // btnSearchPanel
            // 
            this.btnSearchPanel.BackColor = System.Drawing.Color.White;
            this.btnSearchPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchPanel.FlatAppearance.BorderSize = 0;
            this.btnSearchPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPanel.Font = new System.Drawing.Font("Google Sans", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnSearchPanel.ForeColor = System.Drawing.Color.Black;
            this.btnSearchPanel.Image = global::RozkladJazdyPociagow_AplikacjaBazodanowa.Properties.Resources.searchBlack;
            this.btnSearchPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchPanel.Location = new System.Drawing.Point(0, 200);
            this.btnSearchPanel.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchPanel.Name = "btnSearchPanel";
            this.btnSearchPanel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSearchPanel.Size = new System.Drawing.Size(252, 50);
            this.btnSearchPanel.TabIndex = 5;
            this.btnSearchPanel.Text = " Wyszukaj połączenia";
            this.btnSearchPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchPanel.UseVisualStyleBackColor = false;
            this.btnSearchPanel.Click += new System.EventHandler(this.btnSearchPanel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Google Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Image = global::RozkladJazdyPociagow_AplikacjaBazodanowa.Properties.Resources.rozkladJazdyColors2;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 135);
            this.label1.TabIndex = 10;
            this.label1.Text = " Rozkład\r\n jazdy\r\n pociągów";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 540);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // trainsFacilities1
            // 
            this.trainsFacilities1.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.trainsFacilities1.Location = new System.Drawing.Point(252, 0);
            this.trainsFacilities1.Margin = new System.Windows.Forms.Padding(0);
            this.trainsFacilities1.Name = "trainsFacilities1";
            this.trainsFacilities1.Size = new System.Drawing.Size(708, 540);
            this.trainsFacilities1.TabIndex = 24;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.trainsFacilities1);
            this.Controls.Add(this.btnTrainsFacilitiesPanel);
            this.Controls.Add(this.companyTrains1);
            this.Controls.Add(this.btnCompanyPanel);
            this.Controls.Add(this.stationDetails1);
            this.Controls.Add(this.trainRoute1);
            this.Controls.Add(this.search1);
            this.Controls.Add(this.btnStationPanel);
            this.Controls.Add(this.btnTrainPanel);
            this.Controls.Add(this.btnSearchPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "Rozkład jazdy pociągów";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Button btnSearchPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTrainPanel;
        private System.Windows.Forms.Button btnStationPanel;
        private search search1;
        private trainRoute trainRoute1;
        private stationDetails stationDetails1;
        private System.Windows.Forms.Button btnCompanyPanel;
        private companyTrains companyTrains1;
        private System.Windows.Forms.Button btnTrainsFacilitiesPanel;
        private trainsFacilities trainsFacilities1;
    }
}

