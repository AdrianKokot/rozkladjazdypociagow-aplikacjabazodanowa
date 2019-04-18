namespace RozkladJazdyPociagow_AplikacjaBazodanowa
{
    partial class trainRoute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trainRoute));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorTrain = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.stationSearch = new System.Windows.Forms.ComboBox();
            this.trainSearch = new System.Windows.Forms.ComboBox();
            this.errorStation = new System.Windows.Forms.ErrorProvider(this.components);
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trainSearchBack = new System.Windows.Forms.PictureBox();
            this.trainRouteResult1 = new RozkladJazdyPociagow_AplikacjaBazodanowa.trainRouteResult();
            ((System.ComponentModel.ISupportInitialize)(this.errorTrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainSearchBack)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Google Sans", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(63, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 50);
            this.label4.TabIndex = 11;
            this.label4.Text = "Przebieg pociągu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(66, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nazwa pociągu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorTrain
            // 
            this.errorTrain.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorTrain.ContainerControl = this;
            this.errorTrain.Icon = ((System.Drawing.Icon)(resources.GetObject("errorTrain.Icon")));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(66, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nazwa trasy";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(193)))), ((int)(((byte)(61)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(66, 347);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(218, 43);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Wyszukaj";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // stationSearch
            // 
            this.stationSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.stationSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.stationSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stationSearch.FormattingEnabled = true;
            this.stationSearch.Location = new System.Drawing.Point(105, 277);
            this.stationSearch.Margin = new System.Windows.Forms.Padding(0);
            this.stationSearch.Name = "stationSearch";
            this.stationSearch.Size = new System.Drawing.Size(316, 33);
            this.stationSearch.TabIndex = 2;
            this.stationSearch.Validating += new System.ComponentModel.CancelEventHandler(this.stationSearch_Validating);
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
            this.trainSearch.TabIndex = 1;
            this.trainSearch.SelectedIndexChanged += new System.EventHandler(this.trainSearch_SelectedIndexChanged);
            this.trainSearch.Validating += new System.ComponentModel.CancelEventHandler(this.trainSearch_Validating);
            // 
            // errorStation
            // 
            this.errorStation.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorStation.ContainerControl = this;
            this.errorStation.Icon = ((System.Drawing.Icon)(resources.GetObject("errorStation.Icon")));
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(193)))), ((int)(((byte)(61)))));
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(67, 458);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(218, 43);
            this.exit.TabIndex = 4;
            this.exit.Text = "Powrót";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Visible = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox1.Image = global::RozkladJazdyPociagow_AplikacjaBazodanowa.Properties.Resources.pin;
            this.pictureBox1.Location = new System.Drawing.Point(66, 272);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.pictureBox1.Size = new System.Drawing.Size(355, 43);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // trainSearchBack
            // 
            this.trainSearchBack.BackColor = System.Drawing.Color.White;
            this.trainSearchBack.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trainSearchBack.Image = global::RozkladJazdyPociagow_AplikacjaBazodanowa.Properties.Resources.trainBlack;
            this.trainSearchBack.Location = new System.Drawing.Point(66, 167);
            this.trainSearchBack.Margin = new System.Windows.Forms.Padding(0);
            this.trainSearchBack.Name = "trainSearchBack";
            this.trainSearchBack.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.trainSearchBack.Size = new System.Drawing.Size(355, 43);
            this.trainSearchBack.TabIndex = 16;
            this.trainSearchBack.TabStop = false;
            this.trainSearchBack.Click += new System.EventHandler(this.trainSearchBack_Click);
            // 
            // trainRouteResult1
            // 
            this.trainRouteResult1.AutoScroll = true;
            this.trainRouteResult1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.trainRouteResult1.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.trainRouteResult1.Location = new System.Drawing.Point(0, 0);
            this.trainRouteResult1.Margin = new System.Windows.Forms.Padding(6);
            this.trainRouteResult1.Name = "trainRouteResult1";
            this.trainRouteResult1.Size = new System.Drawing.Size(708, 540);
            this.trainRouteResult1.TabIndex = 23;
            this.trainRouteResult1.Visible = false;
            // 
            // trainRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.exit);
            this.Controls.Add(this.trainSearch);
            this.Controls.Add(this.stationSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trainSearchBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trainRouteResult1);
            this.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "trainRoute";
            this.Size = new System.Drawing.Size(708, 540);
            ((System.ComponentModel.ISupportInitialize)(this.errorTrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainSearchBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox trainSearchBack;
        private System.Windows.Forms.ErrorProvider errorTrain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox stationSearch;
        private System.Windows.Forms.ComboBox trainSearch;
        private System.Windows.Forms.ErrorProvider errorStation;
        private trainRouteResult trainRouteResult1;
        private System.Windows.Forms.Button exit;
    }
}
