namespace RozkladJazdyPociagow_AplikacjaBazodanowa
{
    partial class stationDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stationDetails));
            this.stationSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.stationSearchError = new System.Windows.Forms.ErrorProvider(this.components);
            this.exit = new System.Windows.Forms.Button();
            this.stationSearchBack = new System.Windows.Forms.PictureBox();
            this.stationDetailsResult1 = new RozkladJazdyPociagow_AplikacjaBazodanowa.stationDetailsResult();
            ((System.ComponentModel.ISupportInitialize)(this.stationSearchError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationSearchBack)).BeginInit();
            this.SuspendLayout();
            // 
            // stationSearch
            // 
            this.stationSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.stationSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.stationSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stationSearch.FormattingEnabled = true;
            this.stationSearch.Location = new System.Drawing.Point(105, 172);
            this.stationSearch.Margin = new System.Windows.Forms.Padding(0);
            this.stationSearch.Name = "stationSearch";
            this.stationSearch.Size = new System.Drawing.Size(316, 33);
            this.stationSearch.TabIndex = 17;
            this.stationSearch.Validating += new System.ComponentModel.CancelEventHandler(this.stationSearch_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(66, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nazwa stacji";
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
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Wyszukaj";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Google Sans", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(63, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 50);
            this.label4.TabIndex = 19;
            this.label4.Text = "Pociągi na stacji";
            // 
            // stationSearchError
            // 
            this.stationSearchError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.stationSearchError.ContainerControl = this;
            this.stationSearchError.Icon = ((System.Drawing.Icon)(resources.GetObject("stationSearchError.Icon")));
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
            this.exit.TabIndex = 23;
            this.exit.Text = "Ponowne wyszukiwanie";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Visible = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // stationSearchBack
            // 
            this.stationSearchBack.BackColor = System.Drawing.Color.White;
            this.stationSearchBack.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stationSearchBack.Image = global::RozkladJazdyPociagow_AplikacjaBazodanowa.Properties.Resources.pin;
            this.stationSearchBack.Location = new System.Drawing.Point(66, 167);
            this.stationSearchBack.Margin = new System.Windows.Forms.Padding(0);
            this.stationSearchBack.Name = "stationSearchBack";
            this.stationSearchBack.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.stationSearchBack.Size = new System.Drawing.Size(355, 43);
            this.stationSearchBack.TabIndex = 21;
            this.stationSearchBack.TabStop = false;
            this.stationSearchBack.Click += new System.EventHandler(this.stationSearchBack_Click);
            // 
            // stationDetailsResult1
            // 
            this.stationDetailsResult1.AutoScroll = true;
            this.stationDetailsResult1.AutoScrollMargin = new System.Drawing.Size(0, 28);
            this.stationDetailsResult1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.stationDetailsResult1.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.stationDetailsResult1.Location = new System.Drawing.Point(0, 0);
            this.stationDetailsResult1.Margin = new System.Windows.Forms.Padding(6);
            this.stationDetailsResult1.Name = "stationDetailsResult1";
            this.stationDetailsResult1.Size = new System.Drawing.Size(708, 478);
            this.stationDetailsResult1.TabIndex = 22;
            this.stationDetailsResult1.Visible = false;
            // 
            // stationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.exit);
            this.Controls.Add(this.stationSearch);
            this.Controls.Add(this.stationSearchBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stationDetailsResult1);
            this.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "stationDetails";
            this.Size = new System.Drawing.Size(708, 540);
            ((System.ComponentModel.ISupportInitialize)(this.stationSearchError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationSearchBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox stationSearch;
        private System.Windows.Forms.PictureBox stationSearchBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider stationSearchError;
        private stationDetailsResult stationDetailsResult1;
        private System.Windows.Forms.Button exit;
    }
}
