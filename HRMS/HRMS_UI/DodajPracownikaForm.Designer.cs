namespace HRMS_UI
{
    partial class DodajPracownikaForm
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
            dodajButton = new Button();
            zamknijButton = new Button();
            imieLabel = new Label();
            nazwiskoLabel = new Label();
            dataUrodzeniaLabel = new Label();
            wydzialLabel = new Label();
            rolaComboBox = new ComboBox();
            przelozonyLabel = new Label();
            numerKontaktowyLabel = new Label();
            emailLabel = new Label();
            rolaLabel = new Label();
            wydzialComboBox = new ComboBox();
            imieValue = new TextBox();
            danePracownikaLabel = new Label();
            daneUmowyLabel = new Label();
            numerKontaktowyValue = new TextBox();
            nazwiskoValue = new TextBox();
            rodzajUmowyLabel = new Label();
            pensjaLabel = new Label();
            dataZatrudnieniaLabel = new Label();
            dataKoncaUmowyLabel = new Label();
            emailValue = new TextBox();
            pensjaValue = new TextBox();
            dataUrodzeniaDateTimePicker = new DateTimePicker();
            dataZatrudnieniaDateTimePicker = new DateTimePicker();
            dataKoncaUmowyDateTimePicker = new DateTimePicker();
            daneLogowaniaLabel = new Label();
            loginLabel = new Label();
            hasloLabel = new Label();
            loginValue = new TextBox();
            hasloValue = new TextBox();
            rodzajUmowyComboBox = new ComboBox();
            przelozonyComboBox = new ComboBox();
            stanowiskoComboBox = new ComboBox();
            stanowiskoLabel = new Label();
            SuspendLayout();
            // 
            // dodajButton
            // 
            dodajButton.FlatAppearance.BorderColor = Color.Silver;
            dodajButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            dodajButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            dodajButton.FlatStyle = FlatStyle.Flat;
            dodajButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dodajButton.Location = new Point(210, 440);
            dodajButton.Name = "dodajButton";
            dodajButton.Size = new Size(88, 43);
            dodajButton.TabIndex = 5;
            dodajButton.Text = "Dodaj";
            dodajButton.UseVisualStyleBackColor = true;
            dodajButton.Click += dodajButton_Click;
            // 
            // zamknijButton
            // 
            zamknijButton.FlatAppearance.BorderColor = Color.Silver;
            zamknijButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            zamknijButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            zamknijButton.FlatStyle = FlatStyle.Flat;
            zamknijButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            zamknijButton.Location = new Point(570, 440);
            zamknijButton.Name = "zamknijButton";
            zamknijButton.Size = new Size(88, 43);
            zamknijButton.TabIndex = 6;
            zamknijButton.Text = "Zamknij";
            zamknijButton.UseVisualStyleBackColor = true;
            zamknijButton.Click += zamknijButton_Click;
            // 
            // imieLabel
            // 
            imieLabel.AutoSize = true;
            imieLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            imieLabel.Location = new Point(40, 69);
            imieLabel.Name = "imieLabel";
            imieLabel.Size = new Size(43, 21);
            imieLabel.TabIndex = 7;
            imieLabel.Text = "Imię:";
            // 
            // nazwiskoLabel
            // 
            nazwiskoLabel.AutoSize = true;
            nazwiskoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nazwiskoLabel.Location = new Point(40, 110);
            nazwiskoLabel.Name = "nazwiskoLabel";
            nazwiskoLabel.Size = new Size(80, 21);
            nazwiskoLabel.TabIndex = 9;
            nazwiskoLabel.Text = "Nazwisko:";
            // 
            // dataUrodzeniaLabel
            // 
            dataUrodzeniaLabel.AutoSize = true;
            dataUrodzeniaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataUrodzeniaLabel.Location = new Point(40, 151);
            dataUrodzeniaLabel.Name = "dataUrodzeniaLabel";
            dataUrodzeniaLabel.Size = new Size(118, 21);
            dataUrodzeniaLabel.TabIndex = 10;
            dataUrodzeniaLabel.Text = "Data urodzenia:";
            // 
            // wydzialLabel
            // 
            wydzialLabel.AutoSize = true;
            wydzialLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            wydzialLabel.Location = new Point(40, 192);
            wydzialLabel.Name = "wydzialLabel";
            wydzialLabel.Size = new Size(68, 21);
            wydzialLabel.TabIndex = 11;
            wydzialLabel.Text = "Wydział:";
            // 
            // rolaComboBox
            // 
            rolaComboBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rolaComboBox.FormattingEnabled = true;
            rolaComboBox.Location = new Point(183, 395);
            rolaComboBox.Name = "rolaComboBox";
            rolaComboBox.Size = new Size(201, 28);
            rolaComboBox.TabIndex = 12;
            // 
            // przelozonyLabel
            // 
            przelozonyLabel.AutoSize = true;
            przelozonyLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            przelozonyLabel.Location = new Point(9, 275);
            przelozonyLabel.Name = "przelozonyLabel";
            przelozonyLabel.Size = new Size(168, 17);
            przelozonyLabel.TabIndex = 13;
            przelozonyLabel.Text = "Identyfikator przelozonego:";
            // 
            // numerKontaktowyLabel
            // 
            numerKontaktowyLabel.AutoSize = true;
            numerKontaktowyLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            numerKontaktowyLabel.Location = new Point(40, 313);
            numerKontaktowyLabel.Name = "numerKontaktowyLabel";
            numerKontaktowyLabel.Size = new Size(137, 20);
            numerKontaktowyLabel.TabIndex = 14;
            numerKontaktowyLabel.Text = "Numer kontaktowy:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.Location = new Point(40, 354);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(49, 20);
            emailLabel.TabIndex = 15;
            emailLabel.Text = "Email:";
            // 
            // rolaLabel
            // 
            rolaLabel.AutoSize = true;
            rolaLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rolaLabel.Location = new Point(40, 395);
            rolaLabel.Name = "rolaLabel";
            rolaLabel.Size = new Size(42, 20);
            rolaLabel.TabIndex = 16;
            rolaLabel.Text = "Rola:";
            // 
            // wydzialComboBox
            // 
            wydzialComboBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            wydzialComboBox.FormattingEnabled = true;
            wydzialComboBox.Location = new Point(183, 190);
            wydzialComboBox.Name = "wydzialComboBox";
            wydzialComboBox.Size = new Size(250, 28);
            wydzialComboBox.TabIndex = 17;
            // 
            // imieValue
            // 
            imieValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            imieValue.Location = new Point(183, 67);
            imieValue.Name = "imieValue";
            imieValue.Size = new Size(201, 27);
            imieValue.TabIndex = 19;
            // 
            // danePracownikaLabel
            // 
            danePracownikaLabel.AutoSize = true;
            danePracownikaLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            danePracownikaLabel.Location = new Point(24, 23);
            danePracownikaLabel.Name = "danePracownikaLabel";
            danePracownikaLabel.Size = new Size(162, 25);
            danePracownikaLabel.TabIndex = 21;
            danePracownikaLabel.Text = "Dane pracownika:";
            // 
            // daneUmowyLabel
            // 
            daneUmowyLabel.AutoSize = true;
            daneUmowyLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            daneUmowyLabel.Location = new Point(455, 23);
            daneUmowyLabel.Name = "daneUmowyLabel";
            daneUmowyLabel.Size = new Size(215, 25);
            daneUmowyLabel.TabIndex = 22;
            daneUmowyLabel.Text = "Dane dotyczące umowy:";
            // 
            // numerKontaktowyValue
            // 
            numerKontaktowyValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            numerKontaktowyValue.Location = new Point(183, 313);
            numerKontaktowyValue.Name = "numerKontaktowyValue";
            numerKontaktowyValue.Size = new Size(201, 27);
            numerKontaktowyValue.TabIndex = 23;
            // 
            // nazwiskoValue
            // 
            nazwiskoValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nazwiskoValue.Location = new Point(183, 108);
            nazwiskoValue.Name = "nazwiskoValue";
            nazwiskoValue.Size = new Size(201, 27);
            nazwiskoValue.TabIndex = 24;
            // 
            // rodzajUmowyLabel
            // 
            rodzajUmowyLabel.AutoSize = true;
            rodzajUmowyLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rodzajUmowyLabel.Location = new Point(471, 69);
            rodzajUmowyLabel.Name = "rodzajUmowyLabel";
            rodzajUmowyLabel.Size = new Size(116, 21);
            rodzajUmowyLabel.TabIndex = 25;
            rodzajUmowyLabel.Text = "Rodzaj umowy:";
            // 
            // pensjaLabel
            // 
            pensjaLabel.AutoSize = true;
            pensjaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pensjaLabel.Location = new Point(471, 110);
            pensjaLabel.Name = "pensjaLabel";
            pensjaLabel.Size = new Size(57, 21);
            pensjaLabel.TabIndex = 26;
            pensjaLabel.Text = "Pensja:";
            // 
            // dataZatrudnieniaLabel
            // 
            dataZatrudnieniaLabel.AutoSize = true;
            dataZatrudnieniaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataZatrudnieniaLabel.Location = new Point(471, 151);
            dataZatrudnieniaLabel.Name = "dataZatrudnieniaLabel";
            dataZatrudnieniaLabel.Size = new Size(135, 21);
            dataZatrudnieniaLabel.TabIndex = 27;
            dataZatrudnieniaLabel.Text = "Data zatrudnienia:";
            // 
            // dataKoncaUmowyLabel
            // 
            dataKoncaUmowyLabel.AutoSize = true;
            dataKoncaUmowyLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataKoncaUmowyLabel.Location = new Point(471, 192);
            dataKoncaUmowyLabel.Name = "dataKoncaUmowyLabel";
            dataKoncaUmowyLabel.Size = new Size(146, 21);
            dataKoncaUmowyLabel.TabIndex = 28;
            dataKoncaUmowyLabel.Text = "Data końca umowy:";
            // 
            // emailValue
            // 
            emailValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            emailValue.Location = new Point(183, 354);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(201, 27);
            emailValue.TabIndex = 30;
            // 
            // pensjaValue
            // 
            pensjaValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            pensjaValue.Location = new Point(639, 108);
            pensjaValue.Name = "pensjaValue";
            pensjaValue.Size = new Size(201, 27);
            pensjaValue.TabIndex = 32;
            // 
            // dataUrodzeniaDateTimePicker
            // 
            dataUrodzeniaDateTimePicker.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataUrodzeniaDateTimePicker.Format = DateTimePickerFormat.Short;
            dataUrodzeniaDateTimePicker.Location = new Point(183, 149);
            dataUrodzeniaDateTimePicker.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dataUrodzeniaDateTimePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dataUrodzeniaDateTimePicker.Name = "dataUrodzeniaDateTimePicker";
            dataUrodzeniaDateTimePicker.Size = new Size(201, 27);
            dataUrodzeniaDateTimePicker.TabIndex = 34;
            // 
            // dataZatrudnieniaDateTimePicker
            // 
            dataZatrudnieniaDateTimePicker.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataZatrudnieniaDateTimePicker.Format = DateTimePickerFormat.Short;
            dataZatrudnieniaDateTimePicker.Location = new Point(639, 149);
            dataZatrudnieniaDateTimePicker.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dataZatrudnieniaDateTimePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dataZatrudnieniaDateTimePicker.Name = "dataZatrudnieniaDateTimePicker";
            dataZatrudnieniaDateTimePicker.Size = new Size(201, 27);
            dataZatrudnieniaDateTimePicker.TabIndex = 35;
            // 
            // dataKoncaUmowyDateTimePicker
            // 
            dataKoncaUmowyDateTimePicker.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataKoncaUmowyDateTimePicker.Format = DateTimePickerFormat.Short;
            dataKoncaUmowyDateTimePicker.Location = new Point(639, 190);
            dataKoncaUmowyDateTimePicker.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dataKoncaUmowyDateTimePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dataKoncaUmowyDateTimePicker.Name = "dataKoncaUmowyDateTimePicker";
            dataKoncaUmowyDateTimePicker.Size = new Size(201, 27);
            dataKoncaUmowyDateTimePicker.TabIndex = 36;
            // 
            // daneLogowaniaLabel
            // 
            daneLogowaniaLabel.AutoSize = true;
            daneLogowaniaLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            daneLogowaniaLabel.Location = new Point(455, 247);
            daneLogowaniaLabel.Name = "daneLogowaniaLabel";
            daneLogowaniaLabel.Size = new Size(153, 25);
            daneLogowaniaLabel.TabIndex = 37;
            daneLogowaniaLabel.Text = "Dane logowania:";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginLabel.Location = new Point(471, 293);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(52, 21);
            loginLabel.TabIndex = 38;
            loginLabel.Text = "Login:";
            // 
            // hasloLabel
            // 
            hasloLabel.AutoSize = true;
            hasloLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hasloLabel.Location = new Point(471, 334);
            hasloLabel.Name = "hasloLabel";
            hasloLabel.Size = new Size(52, 21);
            hasloLabel.TabIndex = 39;
            hasloLabel.Text = "Hasło:";
            // 
            // loginValue
            // 
            loginValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginValue.Location = new Point(543, 291);
            loginValue.Name = "loginValue";
            loginValue.Size = new Size(201, 27);
            loginValue.TabIndex = 40;
            // 
            // hasloValue
            // 
            hasloValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            hasloValue.Location = new Point(543, 332);
            hasloValue.Name = "hasloValue";
            hasloValue.Size = new Size(201, 27);
            hasloValue.TabIndex = 41;
            // 
            // rodzajUmowyComboBox
            // 
            rodzajUmowyComboBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rodzajUmowyComboBox.FormattingEnabled = true;
            rodzajUmowyComboBox.Location = new Point(639, 67);
            rodzajUmowyComboBox.Name = "rodzajUmowyComboBox";
            rodzajUmowyComboBox.Size = new Size(201, 28);
            rodzajUmowyComboBox.TabIndex = 42;
            // 
            // przelozonyComboBox
            // 
            przelozonyComboBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            przelozonyComboBox.FormattingEnabled = true;
            przelozonyComboBox.Location = new Point(183, 272);
            przelozonyComboBox.Name = "przelozonyComboBox";
            przelozonyComboBox.Size = new Size(201, 28);
            przelozonyComboBox.TabIndex = 43;
            // 
            // stanowiskoComboBox
            // 
            stanowiskoComboBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            stanowiskoComboBox.FormattingEnabled = true;
            stanowiskoComboBox.Location = new Point(183, 231);
            stanowiskoComboBox.Name = "stanowiskoComboBox";
            stanowiskoComboBox.Size = new Size(201, 28);
            stanowiskoComboBox.TabIndex = 44;
            // 
            // stanowiskoLabel
            // 
            stanowiskoLabel.AutoSize = true;
            stanowiskoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            stanowiskoLabel.Location = new Point(40, 231);
            stanowiskoLabel.Name = "stanowiskoLabel";
            stanowiskoLabel.Size = new Size(92, 21);
            stanowiskoLabel.TabIndex = 45;
            stanowiskoLabel.Text = "Stanowisko:";
            // 
            // DodajPracownikaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(868, 517);
            Controls.Add(stanowiskoLabel);
            Controls.Add(stanowiskoComboBox);
            Controls.Add(przelozonyComboBox);
            Controls.Add(rodzajUmowyComboBox);
            Controls.Add(hasloValue);
            Controls.Add(loginValue);
            Controls.Add(hasloLabel);
            Controls.Add(loginLabel);
            Controls.Add(daneLogowaniaLabel);
            Controls.Add(dataKoncaUmowyDateTimePicker);
            Controls.Add(dataZatrudnieniaDateTimePicker);
            Controls.Add(dataUrodzeniaDateTimePicker);
            Controls.Add(pensjaValue);
            Controls.Add(emailValue);
            Controls.Add(dataKoncaUmowyLabel);
            Controls.Add(dataZatrudnieniaLabel);
            Controls.Add(pensjaLabel);
            Controls.Add(rodzajUmowyLabel);
            Controls.Add(nazwiskoValue);
            Controls.Add(numerKontaktowyValue);
            Controls.Add(daneUmowyLabel);
            Controls.Add(danePracownikaLabel);
            Controls.Add(imieValue);
            Controls.Add(wydzialComboBox);
            Controls.Add(rolaLabel);
            Controls.Add(emailLabel);
            Controls.Add(numerKontaktowyLabel);
            Controls.Add(przelozonyLabel);
            Controls.Add(rolaComboBox);
            Controls.Add(wydzialLabel);
            Controls.Add(dataUrodzeniaLabel);
            Controls.Add(nazwiskoLabel);
            Controls.Add(imieLabel);
            Controls.Add(zamknijButton);
            Controls.Add(dodajButton);
            Name = "DodajPracownikaForm";
            Text = "Dodaj pracownika";
            KeyDown += DodajPracownikaForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button dodajButton;
        private Button zamknijButton;
        private Label imieLabel;
        private Label nazwiskoLabel;
        private Label dataUrodzeniaLabel;
        private Label wydzialLabel;
        private ComboBox rolaComboBox;
        private Label przelozonyLabel;
        private Label numerKontaktowyLabel;
        private Label emailLabel;
        private Label rolaLabel;
        private ComboBox wydzialComboBox;
        private TextBox imieValue;
        private Label danePracownikaLabel;
        private Label daneUmowyLabel;
        private TextBox numerKontaktowyValue;
        private TextBox nazwiskoValue;
        private Label rodzajUmowyLabel;
        private Label pensjaLabel;
        private Label dataZatrudnieniaLabel;
        private Label dataKoncaUmowyLabel;
        private TextBox emailValue;
        private TextBox pensjaValue;
        private DateTimePicker dataUrodzeniaDateTimePicker;
        private DateTimePicker dataZatrudnieniaDateTimePicker;
        private DateTimePicker dataKoncaUmowyDateTimePicker;
        private Label daneLogowaniaLabel;
        private Label loginLabel;
        private Label hasloLabel;
        private TextBox loginValue;
        private TextBox hasloValue;
        private ComboBox rodzajUmowyComboBox;
        private ComboBox przelozonyComboBox;
        private ComboBox stanowiskoComboBox;
        private Label stanowiskoLabel;
    }
}