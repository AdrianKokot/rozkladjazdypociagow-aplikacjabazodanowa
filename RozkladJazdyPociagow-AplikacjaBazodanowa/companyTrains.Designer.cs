namespace RozkladJazdyPociagow_AplikacjaBazodanowa
{
    partial class companyTrains
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(companyTrains));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.companySearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.companySearchBack = new System.Windows.Forms.PictureBox();
            this.stationDetailsResult1 = new RozkladJazdyPociagow_AplikacjaBazodanowa.stationDetailsResult();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companySearchBack)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Google Sans", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(63, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(442, 50);
            this.label4.TabIndex = 20;
            this.label4.Text = "Pociągi przewoźników";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(66, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nazwa przewoźnika";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // companySearch
            // 
            this.companySearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.companySearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.companySearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.companySearch.FormattingEnabled = true;
            this.companySearch.Location = new System.Drawing.Point(105, 172);
            this.companySearch.Margin = new System.Windows.Forms.Padding(0);
            this.companySearch.Name = "companySearch";
            this.companySearch.Size = new System.Drawing.Size(316, 33);
            this.companySearch.TabIndex = 23;
            this.companySearch.Validating += new System.ComponentModel.CancelEventHandler(this.companySearch_Validating);
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
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Wyszukaj";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            this.error.Icon = ((System.Drawing.Icon)(resources.GetObject("error.Icon")));
            // 
            // companySearchBack
            // 
            this.companySearchBack.BackColor = System.Drawing.Color.White;
            this.companySearchBack.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.companySearchBack.Image = global::RozkladJazdyPociagow_AplikacjaBazodanowa.Properties.Resources.pin;
            this.companySearchBack.Location = new System.Drawing.Point(66, 167);
            this.companySearchBack.Margin = new System.Windows.Forms.Padding(0);
            this.companySearchBack.Name = "companySearchBack";
            this.companySearchBack.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.companySearchBack.Size = new System.Drawing.Size(355, 43);
            this.companySearchBack.TabIndex = 22;
            this.companySearchBack.TabStop = false;
            this.companySearchBack.Click += new System.EventHandler(this.companySearchBack_Click);
            // 
            // stationDetailsResult1
            // 
            this.stationDetailsResult1.AutoScroll = true;
            this.stationDetailsResult1.AutoScrollMargin = new System.Drawing.Size(0, 28);
            this.stationDetailsResult1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.stationDetailsResult1.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.stationDetailsResult1.Location = new System.Drawing.Point(0, 0);
            this.stationDetailsResult1.Margin = new System.Windows.Forms.Padding(0);
            this.stationDetailsResult1.Name = "stationDetailsResult1";
            this.stationDetailsResult1.Size = new System.Drawing.Size(708, 478);
            this.stationDetailsResult1.TabIndex = 25;
            this.stationDetailsResult1.Visible = false;
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
            this.exit.TabIndex = 26;
            this.exit.Text = "Ponowne wyszukiwanie";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Visible = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // companyTrains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.exit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.companySearch);
            this.Controls.Add(this.companySearchBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stationDetailsResult1);
            this.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "companyTrains";
            this.Size = new System.Drawing.Size(708, 540);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companySearchBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox companySearchBack;
        private System.Windows.Forms.ComboBox companySearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ErrorProvider error;
        private stationDetailsResult stationDetailsResult1;
        private System.Windows.Forms.Button exit;
    }
}
