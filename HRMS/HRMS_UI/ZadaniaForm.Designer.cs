namespace HRMS_UI
{
    partial class ZadaniaForm
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
            zagadnieniaListBox = new ListBox();
            opisValue = new TextBox();
            czasValue = new TextBox();
            opisLabel = new Label();
            czasLabel = new Label();
            ostatnieZadaniaListBox = new ListBox();
            przyjmijButton = new Button();
            dodajButton = new Button();
            nazwaZagadnieniaTextBox = new TextBox();
            opisZagadnieniaTextBox = new TextBox();
            SuspendLayout();
            // 
            // zagadnieniaListBox
            // 
            zagadnieniaListBox.BackColor = Color.Azure;
            zagadnieniaListBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            zagadnieniaListBox.FormattingEnabled = true;
            zagadnieniaListBox.ItemHeight = 20;
            zagadnieniaListBox.Location = new Point(40, 33);
            zagadnieniaListBox.Name = "zagadnieniaListBox";
            zagadnieniaListBox.Size = new Size(272, 124);
            zagadnieniaListBox.TabIndex = 0;
            zagadnieniaListBox.SelectedIndexChanged += zagadnieniaListBox_SelectedIndexChanged;
            // 
            // opisValue
            // 
            opisValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            opisValue.Location = new Point(339, 57);
            opisValue.Multiline = true;
            opisValue.Name = "opisValue";
            opisValue.Size = new Size(411, 202);
            opisValue.TabIndex = 1;
            opisValue.Text = "Rozbudowa bazy danych";
            // 
            // czasValue
            // 
            czasValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            czasValue.Location = new Point(491, 290);
            czasValue.Name = "czasValue";
            czasValue.Size = new Size(114, 27);
            czasValue.TabIndex = 2;
            // 
            // opisLabel
            // 
            opisLabel.AutoSize = true;
            opisLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            opisLabel.Location = new Point(338, 20);
            opisLabel.Name = "opisLabel";
            opisLabel.Size = new Size(54, 25);
            opisLabel.TabIndex = 3;
            opisLabel.Text = "Opis:";
            // 
            // czasLabel
            // 
            czasLabel.AutoSize = true;
            czasLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            czasLabel.Location = new Point(430, 289);
            czasLabel.Name = "czasLabel";
            czasLabel.Size = new Size(55, 25);
            czasLabel.TabIndex = 4;
            czasLabel.Text = "Czas:";
            // 
            // ostatnieZadaniaListBox
            // 
            ostatnieZadaniaListBox.BackColor = Color.LightCyan;
            ostatnieZadaniaListBox.FormattingEnabled = true;
            ostatnieZadaniaListBox.ItemHeight = 15;
            ostatnieZadaniaListBox.Location = new Point(40, 360);
            ostatnieZadaniaListBox.Name = "ostatnieZadaniaListBox";
            ostatnieZadaniaListBox.Size = new Size(710, 109);
            ostatnieZadaniaListBox.TabIndex = 5;
            // 
            // przyjmijButton
            // 
            przyjmijButton.FlatAppearance.BorderColor = Color.Silver;
            przyjmijButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            przyjmijButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            przyjmijButton.FlatStyle = FlatStyle.Flat;
            przyjmijButton.Location = new Point(641, 285);
            przyjmijButton.Name = "przyjmijButton";
            przyjmijButton.Size = new Size(109, 38);
            przyjmijButton.TabIndex = 6;
            przyjmijButton.Text = "Przyjmij";
            przyjmijButton.UseVisualStyleBackColor = true;
            // 
            // dodajButton
            // 
            dodajButton.FlatAppearance.BorderColor = Color.Silver;
            dodajButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            dodajButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            dodajButton.FlatStyle = FlatStyle.Flat;
            dodajButton.Location = new Point(338, 285);
            dodajButton.Name = "dodajButton";
            dodajButton.Size = new Size(74, 38);
            dodajButton.TabIndex = 7;
            dodajButton.Text = "Dodaj";
            dodajButton.UseVisualStyleBackColor = true;
            dodajButton.Visible = false;
            // 
            // nazwaZagadnieniaTextBox
            // 
            nazwaZagadnieniaTextBox.BackColor = Color.White;
            nazwaZagadnieniaTextBox.BorderStyle = BorderStyle.None;
            nazwaZagadnieniaTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            nazwaZagadnieniaTextBox.Location = new Point(40, 172);
            nazwaZagadnieniaTextBox.Multiline = true;
            nazwaZagadnieniaTextBox.Name = "nazwaZagadnieniaTextBox";
            nazwaZagadnieniaTextBox.Size = new Size(272, 41);
            nazwaZagadnieniaTextBox.TabIndex = 10;
            nazwaZagadnieniaTextBox.Text = "<none>";
            nazwaZagadnieniaTextBox.Visible = false;
            // 
            // opisZagadnieniaTextBox
            // 
            opisZagadnieniaTextBox.BackColor = Color.White;
            opisZagadnieniaTextBox.BorderStyle = BorderStyle.None;
            opisZagadnieniaTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            opisZagadnieniaTextBox.Location = new Point(40, 218);
            opisZagadnieniaTextBox.Multiline = true;
            opisZagadnieniaTextBox.Name = "opisZagadnieniaTextBox";
            opisZagadnieniaTextBox.Size = new Size(272, 125);
            opisZagadnieniaTextBox.TabIndex = 11;
            opisZagadnieniaTextBox.Text = "<none>";
            opisZagadnieniaTextBox.Visible = false;
            // 
            // ZadaniaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(786, 493);
            Controls.Add(opisZagadnieniaTextBox);
            Controls.Add(nazwaZagadnieniaTextBox);
            Controls.Add(dodajButton);
            Controls.Add(przyjmijButton);
            Controls.Add(ostatnieZadaniaListBox);
            Controls.Add(czasLabel);
            Controls.Add(opisLabel);
            Controls.Add(czasValue);
            Controls.Add(opisValue);
            Controls.Add(zagadnieniaListBox);
            Name = "ZadaniaForm";
            Text = "Zadania";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox zagadnieniaListBox;
        private TextBox opisValue;
        private TextBox czasValue;
        private Label opisLabel;
        private Label czasLabel;
        private ListBox ostatnieZadaniaListBox;
        private Button przyjmijButton;
        private Button dodajButton;
        private Label nazwaZagadnieniaLabel;
        private Label opisZagadnieniaLabel;
        private TextBox nazwaZagadnieniaTextBox;
        private TextBox opisZagadnieniaTextBox;
    }
}