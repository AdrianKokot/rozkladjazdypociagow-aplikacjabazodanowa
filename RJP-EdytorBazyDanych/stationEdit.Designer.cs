namespace RJP_EdytorBazyDanych
{
    partial class stationEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stationEdit));
            this.label4 = new System.Windows.Forms.Label();
            this.stationSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newStationName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.stationError = new System.Windows.Forms.ErrorProvider(this.components);
            this.newStationError = new System.Windows.Forms.ErrorProvider(this.components);
            this.secondCityBoxBack = new System.Windows.Forms.PictureBox();
            this.trainSearchBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.stationError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newStationError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCityBoxBack)).BeginInit();
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
            this.label4.Size = new System.Drawing.Size(256, 50);
            this.label4.TabIndex = 11;
            this.label4.Text = "Edycja stacji";
            // 
            // stationSelect
            // 
            this.stationSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.stationSelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.stationSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stationSelect.FormattingEnabled = true;
            this.stationSelect.Location = new System.Drawing.Point(105, 172);
            this.stationSelect.Margin = new System.Windows.Forms.Padding(0);
            this.stationSelect.Name = "stationSelect";
            this.stationSelect.Size = new System.Drawing.Size(316, 33);
            this.stationSelect.TabIndex = 17;
            this.stationSelect.SelectedIndexChanged += new System.EventHandler(this.StationSelect_SelectedIndexChanged);
            this.stationSelect.TextUpdate += new System.EventHandler(this.StationSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(66, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nazwa stacji";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(66, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nowa nazwa";
            // 
            // newStationName
            // 
            this.newStationName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.newStationName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.newStationName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newStationName.ForeColor = System.Drawing.Color.Black;
            this.newStationName.Location = new System.Drawing.Point(105, 281);
            this.newStationName.Margin = new System.Windows.Forms.Padding(0);
            this.newStationName.Name = "newStationName";
            this.newStationName.Size = new System.Drawing.Size(316, 25);
            this.newStationName.TabIndex = 23;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(193)))), ((int)(((byte)(61)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(66, 347);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(218, 43);
            this.btnSubmit.TabIndex = 24;
            this.btnSubmit.Text = "Zatwierdź";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // stationError
            // 
            this.stationError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.stationError.ContainerControl = this;
            this.stationError.Icon = ((System.Drawing.Icon)(resources.GetObject("stationError.Icon")));
            // 
            // newStationError
            // 
            this.newStationError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.newStationError.ContainerControl = this;
            this.newStationError.Icon = ((System.Drawing.Icon)(resources.GetObject("newStationError.Icon")));
            // 
            // secondCityBoxBack
            // 
            this.secondCityBoxBack.BackColor = System.Drawing.Color.White;
            this.secondCityBoxBack.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.secondCityBoxBack.Image = global::RJP_EdytorBazyDanych.Properties.Resources.pin;
            this.secondCityBoxBack.Location = new System.Drawing.Point(66, 272);
            this.secondCityBoxBack.Margin = new System.Windows.Forms.Padding(0);
            this.secondCityBoxBack.Name = "secondCityBoxBack";
            this.secondCityBoxBack.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.secondCityBoxBack.Size = new System.Drawing.Size(355, 43);
            this.secondCityBoxBack.TabIndex = 21;
            this.secondCityBoxBack.TabStop = false;
            // 
            // trainSearchBack
            // 
            this.trainSearchBack.BackColor = System.Drawing.Color.White;
            this.trainSearchBack.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trainSearchBack.Image = global::RJP_EdytorBazyDanych.Properties.Resources.pin;
            this.trainSearchBack.Location = new System.Drawing.Point(66, 167);
            this.trainSearchBack.Margin = new System.Windows.Forms.Padding(0);
            this.trainSearchBack.Name = "trainSearchBack";
            this.trainSearchBack.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.trainSearchBack.Size = new System.Drawing.Size(355, 43);
            this.trainSearchBack.TabIndex = 19;
            this.trainSearchBack.TabStop = false;
            // 
            // stationEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.newStationName);
            this.Controls.Add(this.secondCityBoxBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stationSelect);
            this.Controls.Add(this.trainSearchBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Google Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "stationEdit";
            this.Size = new System.Drawing.Size(708, 540);
            ((System.ComponentModel.ISupportInitialize)(this.stationError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newStationError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCityBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainSearchBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox stationSelect;
        private System.Windows.Forms.PictureBox trainSearchBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox secondCityBoxBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newStationName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ErrorProvider stationError;
        private System.Windows.Forms.ErrorProvider newStationError;
    }
}
