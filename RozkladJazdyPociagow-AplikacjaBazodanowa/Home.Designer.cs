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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSearchPanel = new System.Windows.Forms.Button();
            this.btnTrainPanel = new System.Windows.Forms.Button();
            this.btnStationPanel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.search1 = new RozkladJazdyPociagow_AplikacjaBazodanowa.search();
            this.timetableSearchResult1 = new RozkladJazdyPociagow_AplikacjaBazodanowa.timetableSearchResult();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 400);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox3.Location = new System.Drawing.Point(195, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(5, 400);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // btnSearchPanel
            // 
            this.btnSearchPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchPanel.FlatAppearance.BorderSize = 0;
            this.btnSearchPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPanel.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPanel.ForeColor = System.Drawing.Color.White;
            this.btnSearchPanel.Location = new System.Drawing.Point(15, 62);
            this.btnSearchPanel.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchPanel.Name = "btnSearchPanel";
            this.btnSearchPanel.Size = new System.Drawing.Size(180, 41);
            this.btnSearchPanel.TabIndex = 5;
            this.btnSearchPanel.Text = "Wyszukaj połączenia";
            this.btnSearchPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchPanel.UseVisualStyleBackColor = false;
            this.btnSearchPanel.Click += new System.EventHandler(this.btnSearchPanel_Click);
            // 
            // btnTrainPanel
            // 
            this.btnTrainPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTrainPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrainPanel.FlatAppearance.BorderSize = 0;
            this.btnTrainPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrainPanel.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainPanel.ForeColor = System.Drawing.Color.White;
            this.btnTrainPanel.Location = new System.Drawing.Point(15, 109);
            this.btnTrainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.btnTrainPanel.Name = "btnTrainPanel";
            this.btnTrainPanel.Size = new System.Drawing.Size(180, 41);
            this.btnTrainPanel.TabIndex = 6;
            this.btnTrainPanel.Text = "Przebieg pociągu";
            this.btnTrainPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrainPanel.UseVisualStyleBackColor = false;
            this.btnTrainPanel.Click += new System.EventHandler(this.btnTrainPanel_Click);
            // 
            // btnStationPanel
            // 
            this.btnStationPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStationPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStationPanel.FlatAppearance.BorderSize = 0;
            this.btnStationPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStationPanel.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStationPanel.ForeColor = System.Drawing.Color.White;
            this.btnStationPanel.Location = new System.Drawing.Point(15, 156);
            this.btnStationPanel.Margin = new System.Windows.Forms.Padding(0);
            this.btnStationPanel.Name = "btnStationPanel";
            this.btnStationPanel.Size = new System.Drawing.Size(180, 41);
            this.btnStationPanel.TabIndex = 7;
            this.btnStationPanel.Text = "Pociągi na stacji";
            this.btnStationPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStationPanel.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox4.Location = new System.Drawing.Point(195, 50);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(600, 5);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Google Sans", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(195, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "Rozkład jazdy pociągów";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(-37, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(231, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // search1
            // 
            this.search1.BackColor = System.Drawing.Color.LightGray;
            this.search1.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.search1.Location = new System.Drawing.Point(204, 58);
            this.search1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(575, 300);
            this.search1.TabIndex = 13;
            // 
            // timetableSearchResult1
            // 
            this.timetableSearchResult1.BackColor = System.Drawing.Color.LightGray;
            this.timetableSearchResult1.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timetableSearchResult1.Location = new System.Drawing.Point(204, 58);
            this.timetableSearchResult1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timetableSearchResult1.Name = "timetableSearchResult1";
            this.timetableSearchResult1.Size = new System.Drawing.Size(575, 300);
            this.timetableSearchResult1.TabIndex = 14;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.timetableSearchResult1);
            this.Controls.Add(this.search1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStationPanel);
            this.Controls.Add(this.btnTrainPanel);
            this.Controls.Add(this.btnSearchPanel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home";
            this.Text = "Rozkład jazdy pociągów";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        
        private System.Windows.Forms.Button btnSearchPanel;
        private System.Windows.Forms.Button btnTrainPanel;
        private System.Windows.Forms.Button btnStationPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private search search1;
        private timetableSearchResult timetableSearchResult1;
    }
}

