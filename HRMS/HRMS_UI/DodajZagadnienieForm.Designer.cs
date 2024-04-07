namespace HRMS_UI
{
    partial class DodajZagadnienieForm
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
            deadlineDateTimePicker = new DateTimePicker();
            nazwaZagadnieniaValue = new TextBox();
            deadlineLabel = new Label();
            opisLabel = new Label();
            nazwaLabel = new Label();
            opisValue = new TextBox();
            dodajButton = new Button();
            zamknijButton = new Button();
            SuspendLayout();
            // 
            // deadlineDateTimePicker
            // 
            deadlineDateTimePicker.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            deadlineDateTimePicker.Format = DateTimePickerFormat.Short;
            deadlineDateTimePicker.Location = new Point(89, 396);
            deadlineDateTimePicker.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            deadlineDateTimePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            deadlineDateTimePicker.Name = "deadlineDateTimePicker";
            deadlineDateTimePicker.Size = new Size(201, 27);
            deadlineDateTimePicker.TabIndex = 40;
            // 
            // nazwaZagadnieniaValue
            // 
            nazwaZagadnieniaValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nazwaZagadnieniaValue.Location = new Point(165, 39);
            nazwaZagadnieniaValue.Multiline = true;
            nazwaZagadnieniaValue.Name = "nazwaZagadnieniaValue";
            nazwaZagadnieniaValue.Size = new Size(309, 61);
            nazwaZagadnieniaValue.TabIndex = 38;
            // 
            // deadlineLabel
            // 
            deadlineLabel.AutoSize = true;
            deadlineLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deadlineLabel.Location = new Point(12, 400);
            deadlineLabel.Name = "deadlineLabel";
            deadlineLabel.Size = new Size(71, 21);
            deadlineLabel.TabIndex = 37;
            deadlineLabel.Text = "Deadline";
            // 
            // opisLabel
            // 
            opisLabel.AutoSize = true;
            opisLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            opisLabel.Location = new Point(12, 233);
            opisLabel.Name = "opisLabel";
            opisLabel.Size = new Size(45, 21);
            opisLabel.TabIndex = 36;
            opisLabel.Text = "Opis:";
            // 
            // nazwaLabel
            // 
            nazwaLabel.AutoSize = true;
            nazwaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nazwaLabel.Location = new Point(12, 57);
            nazwaLabel.Name = "nazwaLabel";
            nazwaLabel.Size = new Size(147, 21);
            nazwaLabel.TabIndex = 35;
            nazwaLabel.Text = "Nazwa zagadnienia:";
            // 
            // opisValue
            // 
            opisValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            opisValue.Location = new Point(63, 151);
            opisValue.Multiline = true;
            opisValue.Name = "opisValue";
            opisValue.Size = new Size(411, 202);
            opisValue.TabIndex = 41;
            // 
            // dodajButton
            // 
            dodajButton.FlatAppearance.BorderColor = Color.Silver;
            dodajButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            dodajButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            dodajButton.FlatStyle = FlatStyle.Flat;
            dodajButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dodajButton.Location = new Point(86, 464);
            dodajButton.Name = "dodajButton";
            dodajButton.Size = new Size(88, 43);
            dodajButton.TabIndex = 42;
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
            zamknijButton.Location = new Point(405, 464);
            zamknijButton.Name = "zamknijButton";
            zamknijButton.Size = new Size(88, 43);
            zamknijButton.TabIndex = 43;
            zamknijButton.Text = "Zamknij";
            zamknijButton.UseVisualStyleBackColor = true;
            zamknijButton.Click += zamknijButton_Click;
            // 
            // DodajZagadnienieForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(572, 535);
            Controls.Add(zamknijButton);
            Controls.Add(dodajButton);
            Controls.Add(opisValue);
            Controls.Add(deadlineDateTimePicker);
            Controls.Add(nazwaZagadnieniaValue);
            Controls.Add(deadlineLabel);
            Controls.Add(opisLabel);
            Controls.Add(nazwaLabel);
            Name = "DodajZagadnienieForm";
            Text = "Dodaj zagadnienie";
            KeyDown += DodajZagadnienieForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker deadlineDateTimePicker;
        private TextBox nazwaZagadnieniaValue;
        private Label deadlineLabel;
        private Label opisLabel;
        private Label nazwaLabel;
        private TextBox opisValue;
        private Button dodajButton;
        private Button zamknijButton;
    }
}