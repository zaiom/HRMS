namespace HRMS_UI
{
    partial class RaportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            imieNazwiskoLabel = new Label();
            generujRaportBurron = new Button();
            zamknijButton = new Button();
            idPracownikaLabel = new Label();
            thisMonthZagadnieniaLabel = new Label();
            thisMonthZagadnieniaValue = new Label();
            overallZagadnieniaLabel = new Label();
            overallZagadnieniaValue = new Label();
            thisMonthTimeLabel = new Label();
            thisMonthTimeValue = new Label();
            overallTimeLabel = new Label();
            overallTimeValue = new Label();
            thisMonthZadaniaLabel = new Label();
            thisMonthZadaniaValue = new Label();
            overallZadaniaLabel = new Label();
            overallZadaniaValue = new Label();
            SuspendLayout();
            // 
            // imieNazwiskoLabel
            // 
            imieNazwiskoLabel.AutoSize = true;
            imieNazwiskoLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            imieNazwiskoLabel.Location = new Point(242, 33);
            imieNazwiskoLabel.Name = "imieNazwiskoLabel";
            imieNazwiskoLabel.Size = new Size(143, 25);
            imieNazwiskoLabel.TabIndex = 5;
            imieNazwiskoLabel.Text = "Imię i nazwisko";
            // 
            // generujRaportBurron
            // 
            generujRaportBurron.FlatAppearance.BorderColor = Color.Silver;
            generujRaportBurron.FlatAppearance.MouseDownBackColor = Color.Gray;
            generujRaportBurron.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            generujRaportBurron.FlatStyle = FlatStyle.Flat;
            generujRaportBurron.Location = new Point(116, 406);
            generujRaportBurron.Name = "generujRaportBurron";
            generujRaportBurron.Size = new Size(134, 41);
            generujRaportBurron.TabIndex = 6;
            generujRaportBurron.Text = "Generuj raport PDF";
            generujRaportBurron.UseVisualStyleBackColor = true;
            generujRaportBurron.Click += generujRaportBurron_Click;
            // 
            // zamknijButton
            // 
            zamknijButton.FlatAppearance.BorderColor = Color.Silver;
            zamknijButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            zamknijButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            zamknijButton.FlatStyle = FlatStyle.Flat;
            zamknijButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            zamknijButton.Location = new Point(454, 406);
            zamknijButton.Name = "zamknijButton";
            zamknijButton.Size = new Size(88, 43);
            zamknijButton.TabIndex = 45;
            zamknijButton.Text = "Zamknij";
            zamknijButton.UseVisualStyleBackColor = true;
            zamknijButton.Click += zamknijButton_Click;
            // 
            // idPracownikaLabel
            // 
            idPracownikaLabel.AutoSize = true;
            idPracownikaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idPracownikaLabel.Location = new Point(12, 36);
            idPracownikaLabel.Name = "idPracownikaLabel";
            idPracownikaLabel.Size = new Size(109, 21);
            idPracownikaLabel.TabIndex = 46;
            idPracownikaLabel.Text = "ID pracownika";
            // 
            // thisMonthZagadnieniaLabel
            // 
            thisMonthZagadnieniaLabel.AutoSize = true;
            thisMonthZagadnieniaLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            thisMonthZagadnieniaLabel.Location = new Point(21, 100);
            thisMonthZagadnieniaLabel.Name = "thisMonthZagadnieniaLabel";
            thisMonthZagadnieniaLabel.Size = new Size(261, 20);
            thisMonthZagadnieniaLabel.TabIndex = 47;
            thisMonthZagadnieniaLabel.Text = "Ilość zagadnień z bieżącego miesiąca:";
            // 
            // thisMonthZagadnieniaValue
            // 
            thisMonthZagadnieniaValue.AutoSize = true;
            thisMonthZagadnieniaValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            thisMonthZagadnieniaValue.Location = new Point(297, 100);
            thisMonthZagadnieniaValue.Name = "thisMonthZagadnieniaValue";
            thisMonthZagadnieniaValue.Size = new Size(62, 20);
            thisMonthZagadnieniaValue.TabIndex = 48;
            thisMonthZagadnieniaValue.Text = "<none>";
            // 
            // overallZagadnieniaLabel
            // 
            overallZagadnieniaLabel.AutoSize = true;
            overallZagadnieniaLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            overallZagadnieniaLabel.Location = new Point(21, 140);
            overallZagadnieniaLabel.Name = "overallZagadnieniaLabel";
            overallZagadnieniaLabel.Size = new Size(164, 20);
            overallZagadnieniaLabel.TabIndex = 49;
            overallZagadnieniaLabel.Text = "Łączna ilość zagadnień:";
            // 
            // overallZagadnieniaValue
            // 
            overallZagadnieniaValue.AutoSize = true;
            overallZagadnieniaValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            overallZagadnieniaValue.Location = new Point(203, 140);
            overallZagadnieniaValue.Name = "overallZagadnieniaValue";
            overallZagadnieniaValue.Size = new Size(62, 20);
            overallZagadnieniaValue.TabIndex = 50;
            overallZagadnieniaValue.Text = "<none>";
            // 
            // thisMonthTimeLabel
            // 
            thisMonthTimeLabel.AutoSize = true;
            thisMonthTimeLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            thisMonthTimeLabel.Location = new Point(21, 195);
            thisMonthTimeLabel.Name = "thisMonthTimeLabel";
            thisMonthTimeLabel.Size = new Size(288, 20);
            thisMonthTimeLabel.TabIndex = 51;
            thisMonthTimeLabel.Text = "Przepracowany czas w bieżącym miesiącu:";
            // 
            // thisMonthTimeValue
            // 
            thisMonthTimeValue.AutoSize = true;
            thisMonthTimeValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            thisMonthTimeValue.Location = new Point(323, 195);
            thisMonthTimeValue.Name = "thisMonthTimeValue";
            thisMonthTimeValue.Size = new Size(62, 20);
            thisMonthTimeValue.TabIndex = 52;
            thisMonthTimeValue.Text = "<none>";
            // 
            // overallTimeLabel
            // 
            overallTimeLabel.AutoSize = true;
            overallTimeLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            overallTimeLabel.Location = new Point(21, 235);
            overallTimeLabel.Name = "overallTimeLabel";
            overallTimeLabel.Size = new Size(193, 20);
            overallTimeLabel.TabIndex = 53;
            overallTimeLabel.Text = "Łączny przepracowany czas:";
            // 
            // overallTimeValue
            // 
            overallTimeValue.AutoSize = true;
            overallTimeValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            overallTimeValue.Location = new Point(229, 235);
            overallTimeValue.Name = "overallTimeValue";
            overallTimeValue.Size = new Size(62, 20);
            overallTimeValue.TabIndex = 54;
            overallTimeValue.Text = "<none>";
            // 
            // thisMonthZadaniaLabel
            // 
            thisMonthZadaniaLabel.AutoSize = true;
            thisMonthZadaniaLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            thisMonthZadaniaLabel.Location = new Point(21, 290);
            thisMonthZadaniaLabel.Name = "thisMonthZadaniaLabel";
            thisMonthZadaniaLabel.Size = new Size(232, 20);
            thisMonthZadaniaLabel.TabIndex = 55;
            thisMonthZadaniaLabel.Text = "Ilość zadań z bieżącego miesiąca:";
            // 
            // thisMonthZadaniaValue
            // 
            thisMonthZadaniaValue.AutoSize = true;
            thisMonthZadaniaValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            thisMonthZadaniaValue.Location = new Point(268, 290);
            thisMonthZadaniaValue.Name = "thisMonthZadaniaValue";
            thisMonthZadaniaValue.Size = new Size(62, 20);
            thisMonthZadaniaValue.TabIndex = 56;
            thisMonthZadaniaValue.Text = "<none>";
            // 
            // overallZadaniaLabel
            // 
            overallZadaniaLabel.AutoSize = true;
            overallZadaniaLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            overallZadaniaLabel.Location = new Point(21, 330);
            overallZadaniaLabel.Name = "overallZadaniaLabel";
            overallZadaniaLabel.Size = new Size(135, 20);
            overallZadaniaLabel.TabIndex = 57;
            overallZadaniaLabel.Text = "Łączna ilość zadań:";
            // 
            // overallZadaniaValue
            // 
            overallZadaniaValue.AutoSize = true;
            overallZadaniaValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            overallZadaniaValue.Location = new Point(171, 330);
            overallZadaniaValue.Name = "overallZadaniaValue";
            overallZadaniaValue.Size = new Size(62, 20);
            overallZadaniaValue.TabIndex = 58;
            overallZadaniaValue.Text = "<none>";
            // 
            // RaportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(669, 470);
            Controls.Add(overallZadaniaValue);
            Controls.Add(overallZadaniaLabel);
            Controls.Add(thisMonthZadaniaValue);
            Controls.Add(thisMonthZadaniaLabel);
            Controls.Add(overallTimeValue);
            Controls.Add(overallTimeLabel);
            Controls.Add(thisMonthTimeValue);
            Controls.Add(thisMonthTimeLabel);
            Controls.Add(overallZagadnieniaValue);
            Controls.Add(overallZagadnieniaLabel);
            Controls.Add(thisMonthZagadnieniaValue);
            Controls.Add(thisMonthZagadnieniaLabel);
            Controls.Add(idPracownikaLabel);
            Controls.Add(zamknijButton);
            Controls.Add(generujRaportBurron);
            Controls.Add(imieNazwiskoLabel);
            Name = "RaportForm";
            Text = "Raport";
            KeyDown += RaportForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label imieNazwiskoLabel;
        private Button generujRaportBurron;
        private Button zamknijButton;
        private Label idPracownikaLabel;
        private Label thisMonthZagadnieniaLabel;
        private Label thisMonthZagadnieniaValue;
        private Label overallZagadnieniaLabel;
        private Label overallZagadnieniaValue;
        private Label thisMonthTimeLabel;
        private Label thisMonthTimeValue;
        private Label overallTimeLabel;
        private Label overallTimeValue;
        private Label thisMonthZadaniaLabel;
        private Label thisMonthZadaniaValue;
        private Label overallZadaniaLabel;
        private Label overallZadaniaValue;
    }
}