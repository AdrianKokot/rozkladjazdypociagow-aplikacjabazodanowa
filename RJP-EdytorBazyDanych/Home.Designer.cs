namespace RJP_EdytorBazyDanych
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
            this.btnAddTimetable = new System.Windows.Forms.Button();
            this.btnEditTrain = new System.Windows.Forms.Button();
            this.btnEditStations = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stationEdit1 = new RJP_EdytorBazyDanych.stationEdit();
            this.trainEdit1 = new RJP_EdytorBazyDanych.trainEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddTimetable
            // 
            this.btnAddTimetable.BackColor = System.Drawing.Color.White;
            this.btnAddTimetable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTimetable.FlatAppearance.BorderSize = 0;
            this.btnAddTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTimetable.Font = new System.Drawing.Font("Google Sans", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnAddTimetable.ForeColor = System.Drawing.Color.Black;
            this.btnAddTimetable.Image = global::RJP_EdytorBazyDanych.Properties.Resources.bookmarkBlack;
            this.btnAddTimetable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTimetable.Location = new System.Drawing.Point(0, 327);
            this.btnAddTimetable.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddTimetable.Name = "btnAddTimetable";
            this.btnAddTimetable.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAddTimetable.Size = new System.Drawing.Size(252, 50);
            this.btnAddTimetable.TabIndex = 21;
            this.btnAddTimetable.Text = " Dodaj przejazd";
            this.btnAddTimetable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTimetable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddTimetable.UseVisualStyleBackColor = false;
            this.btnAddTimetable.Click += new System.EventHandler(this.BtnAddTimetable_Click);
            // 
            // btnEditTrain
            // 
            this.btnEditTrain.BackColor = System.Drawing.Color.White;
            this.btnEditTrain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditTrain.FlatAppearance.BorderSize = 0;
            this.btnEditTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTrain.Font = new System.Drawing.Font("Google Sans", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnEditTrain.ForeColor = System.Drawing.Color.Black;
            this.btnEditTrain.Image = global::RJP_EdytorBazyDanych.Properties.Resources.trainBlack;
            this.btnEditTrain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditTrain.Location = new System.Drawing.Point(0, 261);
            this.btnEditTrain.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditTrain.Name = "btnEditTrain";
            this.btnEditTrain.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEditTrain.Size = new System.Drawing.Size(252, 50);
            this.btnEditTrain.TabIndex = 20;
            this.btnEditTrain.Text = " Edytuj pociąg";
            this.btnEditTrain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditTrain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditTrain.UseVisualStyleBackColor = false;
            this.btnEditTrain.Click += new System.EventHandler(this.BtnEditTrain_Click);
            // 
            // btnEditStations
            // 
            this.btnEditStations.BackColor = System.Drawing.Color.White;
            this.btnEditStations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditStations.FlatAppearance.BorderSize = 0;
            this.btnEditStations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStations.Font = new System.Drawing.Font("Google Sans", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnEditStations.ForeColor = System.Drawing.Color.Black;
            this.btnEditStations.Image = global::RJP_EdytorBazyDanych.Properties.Resources.routeBlack;
            this.btnEditStations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditStations.Location = new System.Drawing.Point(0, 200);
            this.btnEditStations.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditStations.Name = "btnEditStations";
            this.btnEditStations.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEditStations.Size = new System.Drawing.Size(252, 50);
            this.btnEditStations.TabIndex = 18;
            this.btnEditStations.Text = " Edytuj stacje";
            this.btnEditStations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditStations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditStations.UseVisualStyleBackColor = false;
            this.btnEditStations.Click += new System.EventHandler(this.BtnEditStations_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Google Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Image = global::RJP_EdytorBazyDanych.Properties.Resources.rozkladJazdyColors2;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 135);
            this.label1.TabIndex = 16;
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
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // stationEdit1
            // 
            this.stationEdit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.stationEdit1.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.stationEdit1.Location = new System.Drawing.Point(252, 0);
            this.stationEdit1.Margin = new System.Windows.Forms.Padding(5);
            this.stationEdit1.Name = "stationEdit1";
            this.stationEdit1.Size = new System.Drawing.Size(708, 540);
            this.stationEdit1.TabIndex = 19;
            // 
            // trainEdit1
            // 
            this.trainEdit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.trainEdit1.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.trainEdit1.Location = new System.Drawing.Point(252, 0);
            this.trainEdit1.Margin = new System.Windows.Forms.Padding(6);
            this.trainEdit1.Name = "trainEdit1";
            this.trainEdit1.Size = new System.Drawing.Size(708, 540);
            this.trainEdit1.TabIndex = 22;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.trainEdit1);
            this.Controls.Add(this.btnAddTimetable);
            this.Controls.Add(this.btnEditTrain);
            this.Controls.Add(this.stationEdit1);
            this.Controls.Add(this.btnEditStations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Google Sans", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home";
            this.Text = "Edytor rozkładu jazdy pociągów";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEditStations;
        private stationEdit stationEdit1;
        private System.Windows.Forms.Button btnEditTrain;
        private System.Windows.Forms.Button btnAddTimetable;
        private trainEdit trainEdit1;
    }
}

