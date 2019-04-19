namespace RozkladJazdyPociagow_AplikacjaBazodanowa
{
    partial class trainsFacilities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trainsFacilities));
            this.trainSearch = new System.Windows.Forms.ComboBox();
            this.trainSearchBack = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.trainSearchError = new System.Windows.Forms.ErrorProvider(this.components);
            this.stationDetailsResult1 = new RozkladJazdyPociagow_AplikacjaBazodanowa.stationDetailsResult();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trainSearchBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainSearchError)).BeginInit();
            this.SuspendLayout();
            // 
            // trainSearch
            // 
            this.trainSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.trainSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.trainSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trainSearch.FormattingEnabled = true;
            this.trainSearch.Location = new System.Drawing.Point(105, 172);
            this.trainSearch.Margin = new System.Windows.Forms.Padding(0);
            this.trainSearch.Name = "trainSearch";
            this.trainSearch.Size = new System.Drawing.Size(316, 33);
            this.trainSearch.TabIndex = 22;
            this.trainSearch.Validating += new System.ComponentModel.CancelEventHandler(this.TrainSearch_Validating);
            // 
            // trainSearchBack
            // 
            this.trainSearchBack.BackColor = System.Drawing.Color.White;
            this.trainSearchBack.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trainSearchBack.Image = global::RozkladJazdyPociagow_AplikacjaBazodanowa.Properties.Resources.pin;
            this.trainSearchBack.Location = new System.Drawing.Point(66, 167);
            this.trainSearchBack.Margin = new System.Windows.Forms.Padding(0);
            this.trainSearchBack.Name = "trainSearchBack";
            this.trainSearchBack.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.trainSearchBack.Size = new System.Drawing.Size(355, 43);
            this.trainSearchBack.TabIndex = 26;
            this.trainSearchBack.TabStop = false;
            this.trainSearchBack.Click += new System.EventHandler(this.TrainSearchBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(66, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nazwa pociągu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(193)))), ((int)(((byte)(61)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(66, 242);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(218, 43);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Wyszukaj";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Google Sans", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(63, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(454, 50);
            this.label4.TabIndex = 24;
            this.label4.Text = "Udogodnienia pociągu";
            // 
            // trainSearchError
            // 
            this.trainSearchError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.trainSearchError.ContainerControl = this;
            this.trainSearchError.Icon = ((System.Drawing.Icon)(resources.GetObject("trainSearchError.Icon")));
            // 
            // stationDetailsResult1
            // 
            this.stationDetailsResult1.AutoScroll = true;
            this.stationDetailsResult1.AutoScrollMargin = new System.Drawing.Size(0, 28);
            this.stationDetailsResult1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.stationDetailsResult1.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.stationDetailsResult1.Location = new System.Drawing.Point(0, 0);
            this.stationDetailsResult1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.stationDetailsResult1.Name = "stationDetailsResult1";
            this.stationDetailsResult1.Size = new System.Drawing.Size(708, 478);
            this.stationDetailsResult1.TabIndex = 27;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(193)))), ((int)(((byte)(61)))));
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(66, 483);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(279, 43);
            this.exit.TabIndex = 28;
            this.exit.Text = "Ponowne wyszukiwanie";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Visible = false;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // trainsFacilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.exit);
            this.Controls.Add(this.trainSearch);
            this.Controls.Add(this.trainSearchBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stationDetailsResult1);
            this.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "trainsFacilities";
            this.Size = new System.Drawing.Size(708, 540);
            ((System.ComponentModel.ISupportInitialize)(this.trainSearchBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainSearchError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox trainSearch;
        private System.Windows.Forms.PictureBox trainSearchBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider trainSearchError;
        private stationDetailsResult stationDetailsResult1;
        private System.Windows.Forms.Button exit;
    }
}
