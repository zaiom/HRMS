namespace HRMS_UI
{
    partial class PrzydzielZagadnienieForm
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
            numerZagadnieniaComboBox = new ComboBox();
            idPracownikaComboBox = new ComboBox();
            przydzielButton = new Button();
            numerZagadnieniaLabel = new Label();
            nazwaZagadnieniaTextBox = new TextBox();
            zamknijButton = new Button();
            SuspendLayout();
            // 
            // numerZagadnieniaComboBox
            // 
            numerZagadnieniaComboBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            numerZagadnieniaComboBox.FormattingEnabled = true;
            numerZagadnieniaComboBox.Location = new Point(49, 77);
            numerZagadnieniaComboBox.Name = "numerZagadnieniaComboBox";
            numerZagadnieniaComboBox.Size = new Size(201, 28);
            numerZagadnieniaComboBox.TabIndex = 78;
            // 
            // idPracownikaComboBox
            // 
            idPracownikaComboBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            idPracownikaComboBox.FormattingEnabled = true;
            idPracownikaComboBox.Location = new Point(49, 200);
            idPracownikaComboBox.Name = "idPracownikaComboBox";
            idPracownikaComboBox.Size = new Size(201, 28);
            idPracownikaComboBox.TabIndex = 79;
            // 
            // przydzielButton
            // 
            przydzielButton.FlatAppearance.BorderColor = Color.Silver;
            przydzielButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            przydzielButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            przydzielButton.FlatStyle = FlatStyle.Flat;
            przydzielButton.Location = new Point(28, 248);
            przydzielButton.Name = "przydzielButton";
            przydzielButton.Size = new Size(80, 38);
            przydzielButton.TabIndex = 80;
            przydzielButton.Text = "Przydziel";
            przydzielButton.UseVisualStyleBackColor = true;
            przydzielButton.Click += przydzielButton_Click;
            // 
            // numerZagadnieniaLabel
            // 
            numerZagadnieniaLabel.AutoSize = true;
            numerZagadnieniaLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            numerZagadnieniaLabel.Location = new Point(12, 36);
            numerZagadnieniaLabel.Name = "numerZagadnieniaLabel";
            numerZagadnieniaLabel.Size = new Size(125, 17);
            numerZagadnieniaLabel.TabIndex = 81;
            numerZagadnieniaLabel.Text = "Numer zagadnienia:";
            // 
            // nazwaZagadnieniaTextBox
            // 
            nazwaZagadnieniaTextBox.BackColor = Color.White;
            nazwaZagadnieniaTextBox.BorderStyle = BorderStyle.None;
            nazwaZagadnieniaTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            nazwaZagadnieniaTextBox.Location = new Point(12, 143);
            nazwaZagadnieniaTextBox.Multiline = true;
            nazwaZagadnieniaTextBox.Name = "nazwaZagadnieniaTextBox";
            nazwaZagadnieniaTextBox.Size = new Size(272, 41);
            nazwaZagadnieniaTextBox.TabIndex = 82;
            nazwaZagadnieniaTextBox.Text = "Identyfikator pracownika, któremu chcesz przydzielić zagadnienie:";
            // 
            // zamknijButton
            // 
            zamknijButton.FlatAppearance.BorderColor = Color.Silver;
            zamknijButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            zamknijButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            zamknijButton.FlatStyle = FlatStyle.Flat;
            zamknijButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            zamknijButton.Location = new Point(177, 248);
            zamknijButton.Name = "zamknijButton";
            zamknijButton.Size = new Size(73, 38);
            zamknijButton.TabIndex = 83;
            zamknijButton.Text = "Zamknij";
            zamknijButton.UseVisualStyleBackColor = true;
            zamknijButton.Click += zamknijButton_Click;
            // 
            // PrzydzielZagadnienieForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(289, 307);
            Controls.Add(zamknijButton);
            Controls.Add(nazwaZagadnieniaTextBox);
            Controls.Add(numerZagadnieniaLabel);
            Controls.Add(przydzielButton);
            Controls.Add(idPracownikaComboBox);
            Controls.Add(numerZagadnieniaComboBox);
            Name = "PrzydzielZagadnienieForm";
            Text = "Przydziel zagadnienie";
            KeyDown += PrzydzielZagadnienieForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox numerZagadnieniaComboBox;
        private ComboBox idPracownikaComboBox;
        private Button przydzielButton;
        private Label numerZagadnieniaLabel;
        private TextBox nazwaZagadnieniaTextBox;
        private Button zamknijButton;
    }
}