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
            idPracownikaTextBox = new TextBox();
            zamknijButton = new Button();
            nazwaZagadnieniaTextBox = new TextBox();
            SuspendLayout();
            // 
            // numerZagadnieniaComboBox
            // 
            numerZagadnieniaComboBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            numerZagadnieniaComboBox.FormattingEnabled = true;
            numerZagadnieniaComboBox.Location = new Point(67, 58);
            numerZagadnieniaComboBox.Name = "numerZagadnieniaComboBox";
            numerZagadnieniaComboBox.Size = new Size(201, 28);
            numerZagadnieniaComboBox.TabIndex = 78;
            numerZagadnieniaComboBox.SelectedIndexChanged += numerZagadnieniaComboBox_SelectedIndexChanged;
            // 
            // idPracownikaComboBox
            // 
            idPracownikaComboBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            idPracownikaComboBox.FormattingEnabled = true;
            idPracownikaComboBox.Location = new Point(67, 242);
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
            przydzielButton.Location = new Point(46, 290);
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
            numerZagadnieniaLabel.Location = new Point(30, 26);
            numerZagadnieniaLabel.Name = "numerZagadnieniaLabel";
            numerZagadnieniaLabel.Size = new Size(125, 17);
            numerZagadnieniaLabel.TabIndex = 81;
            numerZagadnieniaLabel.Text = "Numer zagadnienia:";
            // 
            // idPracownikaTextBox
            // 
            idPracownikaTextBox.BackColor = Color.White;
            idPracownikaTextBox.BorderStyle = BorderStyle.None;
            idPracownikaTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            idPracownikaTextBox.Location = new Point(30, 185);
            idPracownikaTextBox.Multiline = true;
            idPracownikaTextBox.Name = "idPracownikaTextBox";
            idPracownikaTextBox.Size = new Size(272, 41);
            idPracownikaTextBox.TabIndex = 82;
            idPracownikaTextBox.Text = "Identyfikator pracownika, któremu chcesz przydzielić zagadnienie:";
            // 
            // zamknijButton
            // 
            zamknijButton.FlatAppearance.BorderColor = Color.Silver;
            zamknijButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            zamknijButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            zamknijButton.FlatStyle = FlatStyle.Flat;
            zamknijButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            zamknijButton.Location = new Point(195, 290);
            zamknijButton.Name = "zamknijButton";
            zamknijButton.Size = new Size(73, 38);
            zamknijButton.TabIndex = 83;
            zamknijButton.Text = "Zamknij";
            zamknijButton.UseVisualStyleBackColor = true;
            zamknijButton.Click += zamknijButton_Click;
            // 
            // nazwaZagadnieniaTextBox
            // 
            nazwaZagadnieniaTextBox.BackColor = Color.White;
            nazwaZagadnieniaTextBox.BorderStyle = BorderStyle.None;
            nazwaZagadnieniaTextBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            nazwaZagadnieniaTextBox.Location = new Point(30, 106);
            nazwaZagadnieniaTextBox.Multiline = true;
            nazwaZagadnieniaTextBox.Name = "nazwaZagadnieniaTextBox";
            nazwaZagadnieniaTextBox.Size = new Size(272, 41);
            nazwaZagadnieniaTextBox.TabIndex = 84;
            nazwaZagadnieniaTextBox.Text = "<none>";
            nazwaZagadnieniaTextBox.Visible = false;
            // 
            // PrzydzielZagadnienieForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(323, 362);
            Controls.Add(nazwaZagadnieniaTextBox);
            Controls.Add(zamknijButton);
            Controls.Add(idPracownikaTextBox);
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
        private TextBox idPracownikaTextBox;
        private Button zamknijButton;
        private TextBox nazwaZagadnieniaTextBox;
    }
}