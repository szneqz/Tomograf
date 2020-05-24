namespace Tomograf
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureIn = new System.Windows.Forms.PictureBox();
            this.pictureSinogram = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureOut = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.scrollProgress = new System.Windows.Forms.HScrollBar();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelStepProgress = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericRangeScan = new System.Windows.Forms.NumericUpDown();
            this.numericAmountDet = new System.Windows.Forms.NumericUpDown();
            this.numericAmountScans = new System.Windows.Forms.NumericUpDown();
            this.LabelError1 = new System.Windows.Forms.Label();
            this.labelMaxStep = new System.Windows.Forms.Label();
            this.buttonSaveSinogram = new System.Windows.Forms.Button();
            this.buttonSaveOutput = new System.Windows.Forms.Button();
            this.checkBoxFilter = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelRMSE = new System.Windows.Forms.Label();
            this.saveDicomButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.radioButtonGenderM = new System.Windows.Forms.RadioButton();
            this.radioButtonGenderF = new System.Windows.Forms.RadioButton();
            this.loadDicomButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSinogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRangeScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmountDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmountScans)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Obraz wejściowy";
            // 
            // pictureIn
            // 
            this.pictureIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureIn.Location = new System.Drawing.Point(16, 34);
            this.pictureIn.Name = "pictureIn";
            this.pictureIn.Size = new System.Drawing.Size(300, 300);
            this.pictureIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureIn.TabIndex = 1;
            this.pictureIn.TabStop = false;
            // 
            // pictureSinogram
            // 
            this.pictureSinogram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureSinogram.Location = new System.Drawing.Point(322, 34);
            this.pictureSinogram.Name = "pictureSinogram";
            this.pictureSinogram.Size = new System.Drawing.Size(300, 300);
            this.pictureSinogram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSinogram.TabIndex = 3;
            this.pictureSinogram.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sinogram";
            // 
            // pictureOut
            // 
            this.pictureOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureOut.Location = new System.Drawing.Point(628, 34);
            this.pictureOut.Name = "pictureOut";
            this.pictureOut.Size = new System.Drawing.Size(300, 300);
            this.pictureOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureOut.TabIndex = 5;
            this.pictureOut.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(625, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Obraz wyjściowy";
            // 
            // scrollProgress
            // 
            this.scrollProgress.Enabled = false;
            this.scrollProgress.LargeChange = 1;
            this.scrollProgress.Location = new System.Drawing.Point(120, 514);
            this.scrollProgress.Name = "scrollProgress";
            this.scrollProgress.Size = new System.Drawing.Size(176, 23);
            this.scrollProgress.TabIndex = 6;
            this.scrollProgress.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollProgress_Scroll);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(16, 340);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(109, 23);
            this.buttonLoad.TabIndex = 7;
            this.buttonLoad.Text = "Wczytaj obraz";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 514);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Krok tomografu";
            // 
            // labelStepProgress
            // 
            this.labelStepProgress.AutoSize = true;
            this.labelStepProgress.Location = new System.Drawing.Point(323, 520);
            this.labelStepProgress.Name = "labelStepProgress";
            this.labelStepProgress.Size = new System.Drawing.Size(16, 17);
            this.labelStepProgress.TabIndex = 9;
            this.labelStepProgress.Text = "0";
            // 
            // buttonStart
            // 
            this.buttonStart.Enabled = false;
            this.buttonStart.Location = new System.Drawing.Point(460, 514);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(162, 23);
            this.buttonStart.TabIndex = 10;
            this.buttonStart.Text = "Rozpocznij symulację";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Rozpiętość (kąt)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ilość detektorów";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ilość skanów";
            // 
            // numericRangeScan
            // 
            this.numericRangeScan.Location = new System.Drawing.Point(248, 370);
            this.numericRangeScan.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericRangeScan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericRangeScan.Name = "numericRangeScan";
            this.numericRangeScan.Size = new System.Drawing.Size(120, 22);
            this.numericRangeScan.TabIndex = 14;
            this.numericRangeScan.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // numericAmountDet
            // 
            this.numericAmountDet.Location = new System.Drawing.Point(248, 398);
            this.numericAmountDet.Maximum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.numericAmountDet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericAmountDet.Name = "numericAmountDet";
            this.numericAmountDet.Size = new System.Drawing.Size(120, 22);
            this.numericAmountDet.TabIndex = 15;
            this.numericAmountDet.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // numericAmountScans
            // 
            this.numericAmountScans.Location = new System.Drawing.Point(248, 426);
            this.numericAmountScans.Maximum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.numericAmountScans.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericAmountScans.Name = "numericAmountScans";
            this.numericAmountScans.Size = new System.Drawing.Size(120, 22);
            this.numericAmountScans.TabIndex = 16;
            this.numericAmountScans.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // LabelError1
            // 
            this.LabelError1.AutoSize = true;
            this.LabelError1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelError1.ForeColor = System.Drawing.Color.Red;
            this.LabelError1.Location = new System.Drawing.Point(132, 340);
            this.LabelError1.Name = "LabelError1";
            this.LabelError1.Size = new System.Drawing.Size(0, 17);
            this.LabelError1.TabIndex = 17;
            // 
            // labelMaxStep
            // 
            this.labelMaxStep.AutoSize = true;
            this.labelMaxStep.Location = new System.Drawing.Point(362, 520);
            this.labelMaxStep.Name = "labelMaxStep";
            this.labelMaxStep.Size = new System.Drawing.Size(40, 17);
            this.labelMaxStep.TabIndex = 18;
            this.labelMaxStep.Text = "/ 100";
            // 
            // buttonSaveSinogram
            // 
            this.buttonSaveSinogram.Enabled = false;
            this.buttonSaveSinogram.Location = new System.Drawing.Point(497, 340);
            this.buttonSaveSinogram.Name = "buttonSaveSinogram";
            this.buttonSaveSinogram.Size = new System.Drawing.Size(124, 23);
            this.buttonSaveSinogram.TabIndex = 21;
            this.buttonSaveSinogram.Text = "Zapisz sinogram";
            this.buttonSaveSinogram.UseVisualStyleBackColor = true;
            this.buttonSaveSinogram.Click += new System.EventHandler(this.buttonSaveSinogram_Click);
            // 
            // buttonSaveOutput
            // 
            this.buttonSaveOutput.Enabled = false;
            this.buttonSaveOutput.Location = new System.Drawing.Point(826, 340);
            this.buttonSaveOutput.Name = "buttonSaveOutput";
            this.buttonSaveOutput.Size = new System.Drawing.Size(102, 23);
            this.buttonSaveOutput.TabIndex = 22;
            this.buttonSaveOutput.Text = "Zapisz obraz";
            this.buttonSaveOutput.UseVisualStyleBackColor = true;
            this.buttonSaveOutput.Click += new System.EventHandler(this.buttonSaveOutput_Click);
            // 
            // checkBoxFilter
            // 
            this.checkBoxFilter.AutoSize = true;
            this.checkBoxFilter.Location = new System.Drawing.Point(408, 372);
            this.checkBoxFilter.Name = "checkBoxFilter";
            this.checkBoxFilter.Size = new System.Drawing.Size(124, 21);
            this.checkBoxFilter.TabIndex = 24;
            this.checkBoxFilter.Text = "Użyj filtrowania";
            this.checkBoxFilter.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(408, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "RMSE: ";
            // 
            // labelRMSE
            // 
            this.labelRMSE.AutoSize = true;
            this.labelRMSE.Location = new System.Drawing.Point(460, 400);
            this.labelRMSE.Name = "labelRMSE";
            this.labelRMSE.Size = new System.Drawing.Size(86, 17);
            this.labelRMSE.TabIndex = 27;
            this.labelRMSE.Text = "brak danych";
            // 
            // saveDicomButton
            // 
            this.saveDicomButton.Enabled = false;
            this.saveDicomButton.Location = new System.Drawing.Point(214, 480);
            this.saveDicomButton.Name = "saveDicomButton";
            this.saveDicomButton.Size = new System.Drawing.Size(160, 23);
            this.saveDicomButton.TabIndex = 28;
            this.saveDicomButton.Text = "Zapisz plik DICOM";
            this.saveDicomButton.UseVisualStyleBackColor = true;
            this.saveDicomButton.Click += new System.EventHandler(this.saveDicomButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loadDicomButton);
            this.panel1.Controls.Add(this.radioButtonGenderF);
            this.panel1.Controls.Add(this.radioButtonGenderM);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.dateTimePickerBirthDate);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.saveDicomButton);
            this.panel1.Location = new System.Drawing.Point(935, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 503);
            this.panel1.TabIndex = 29;
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(9, 29);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 17);
            this.label9.TabIndex = 30;
            this.label9.Text = "ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "Data urodzenia";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 17);
            this.label12.TabIndex = 34;
            this.label12.Text = "Imię i Nazwisko";
            // 
            // textBoxName
            // 
            this.textBoxName.Enabled = false;
            this.textBoxName.Location = new System.Drawing.Point(9, 74);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 33;
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Enabled = false;
            this.dateTimePickerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(9, 124);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerBirthDate.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 17);
            this.label13.TabIndex = 38;
            this.label13.Text = "Płeć";
            // 
            // radioButtonGenderM
            // 
            this.radioButtonGenderM.AutoSize = true;
            this.radioButtonGenderM.Checked = true;
            this.radioButtonGenderM.Enabled = false;
            this.radioButtonGenderM.Location = new System.Drawing.Point(12, 170);
            this.radioButtonGenderM.Name = "radioButtonGenderM";
            this.radioButtonGenderM.Size = new System.Drawing.Size(99, 21);
            this.radioButtonGenderM.TabIndex = 39;
            this.radioButtonGenderM.TabStop = true;
            this.radioButtonGenderM.Text = "Mężczyzna";
            this.radioButtonGenderM.UseVisualStyleBackColor = true;
            // 
            // radioButtonGenderF
            // 
            this.radioButtonGenderF.AutoSize = true;
            this.radioButtonGenderF.Enabled = false;
            this.radioButtonGenderF.Location = new System.Drawing.Point(12, 197);
            this.radioButtonGenderF.Name = "radioButtonGenderF";
            this.radioButtonGenderF.Size = new System.Drawing.Size(77, 21);
            this.radioButtonGenderF.TabIndex = 40;
            this.radioButtonGenderF.Text = "Kobieta";
            this.radioButtonGenderF.UseVisualStyleBackColor = true;
            // 
            // loadDicomButton
            // 
            this.loadDicomButton.Location = new System.Drawing.Point(214, 451);
            this.loadDicomButton.Name = "loadDicomButton";
            this.loadDicomButton.Size = new System.Drawing.Size(160, 23);
            this.loadDicomButton.TabIndex = 41;
            this.loadDicomButton.Text = "Wczytaj plik DICOM";
            this.loadDicomButton.UseVisualStyleBackColor = true;
            this.loadDicomButton.Click += new System.EventHandler(this.loadDicomButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 544);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelRMSE);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBoxFilter);
            this.Controls.Add(this.buttonSaveOutput);
            this.Controls.Add(this.buttonSaveSinogram);
            this.Controls.Add(this.labelMaxStep);
            this.Controls.Add(this.LabelError1);
            this.Controls.Add(this.numericAmountScans);
            this.Controls.Add(this.numericAmountDet);
            this.Controls.Add(this.numericRangeScan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelStepProgress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.scrollProgress);
            this.Controls.Add(this.pictureOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureSinogram);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureIn);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Symulator tomografu";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSinogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRangeScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmountDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmountScans)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureIn;
        private System.Windows.Forms.PictureBox pictureSinogram;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar scrollProgress;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelStepProgress;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericRangeScan;
        private System.Windows.Forms.NumericUpDown numericAmountDet;
        private System.Windows.Forms.NumericUpDown numericAmountScans;
        private System.Windows.Forms.Label LabelError1;
        private System.Windows.Forms.Label labelMaxStep;
        private System.Windows.Forms.Button buttonSaveSinogram;
        private System.Windows.Forms.Button buttonSaveOutput;
        private System.Windows.Forms.CheckBox checkBoxFilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelRMSE;
        private System.Windows.Forms.Button saveDicomButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.RadioButton radioButtonGenderF;
        private System.Windows.Forms.RadioButton radioButtonGenderM;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.Button loadDicomButton;
    }
}

