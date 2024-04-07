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
            rodzajUmowyComboBox = new ComboBox();
            comboBox1 = new ComboBox();
            przyjmijButton = new Button();
            numerZagadnieniaLabel = new Label();
            nazwaZagadnieniaTextBox = new TextBox();
            zamknijButton = new Button();
            SuspendLayout();
            // 
            // rodzajUmowyComboBox
            // 
            rodzajUmowyComboBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rodzajUmowyComboBox.FormattingEnabled = true;
            rodzajUmowyComboBox.Location = new Point(49, 77);
            rodzajUmowyComboBox.Name = "rodzajUmowyComboBox";
            rodzajUmowyComboBox.Size = new Size(201, 28);
            rodzajUmowyComboBox.TabIndex = 78;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(49, 200);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(201, 28);
            comboBox1.TabIndex = 79;
            // 
            // przyjmijButton
            // 
            przyjmijButton.FlatAppearance.BorderColor = Color.Silver;
            przyjmijButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            przyjmijButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            przyjmijButton.FlatStyle = FlatStyle.Flat;
            przyjmijButton.Location = new Point(28, 248);
            przyjmijButton.Name = "przyjmijButton";
            przyjmijButton.Size = new Size(80, 38);
            przyjmijButton.TabIndex = 80;
            przyjmijButton.Text = "Przydziel";
            przyjmijButton.UseVisualStyleBackColor = true;
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
            nazwaZagadnieniaTextBox.Visible = false;
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
            Controls.Add(przyjmijButton);
            Controls.Add(comboBox1);
            Controls.Add(rodzajUmowyComboBox);
            Name = "PrzydzielZagadnienieForm";
            Text = "Przydziel zagadnienie";
            KeyDown += PrzydzielZagadnienieForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox rodzajUmowyComboBox;
        private ComboBox comboBox1;
        private Button przyjmijButton;
        private Label numerZagadnieniaLabel;
        private TextBox nazwaZagadnieniaTextBox;
        private Button zamknijButton;
    }
}