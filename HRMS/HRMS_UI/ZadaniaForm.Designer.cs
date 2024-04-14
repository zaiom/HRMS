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
            przyjmijButton = new Button();
            nazwaZagadnieniaTextBox = new TextBox();
            opisZagadnieniaTextBox = new TextBox();
            dodajLinkLabel = new LinkLabel();
            przydzielLinkLabel = new LinkLabel();
            zamknijButton = new Button();
            ostatnieZadaniaDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ostatnieZadaniaDataGridView).BeginInit();
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
            przyjmijButton.Click += przyjmijButton_Click;
            // 
            // nazwaZagadnieniaTextBox
            // 
            nazwaZagadnieniaTextBox.BackColor = Color.White;
            nazwaZagadnieniaTextBox.BorderStyle = BorderStyle.None;
            nazwaZagadnieniaTextBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
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
            // dodajLinkLabel
            // 
            dodajLinkLabel.AutoSize = true;
            dodajLinkLabel.Location = new Point(338, 285);
            dodajLinkLabel.Name = "dodajLinkLabel";
            dodajLinkLabel.Size = new Size(38, 15);
            dodajLinkLabel.TabIndex = 12;
            dodajLinkLabel.TabStop = true;
            dodajLinkLabel.Text = "Dodaj";
            dodajLinkLabel.LinkClicked += dodajLinkLabel_LinkClicked;
            // 
            // przydzielLinkLabel
            // 
            przydzielLinkLabel.AutoSize = true;
            przydzielLinkLabel.Location = new Point(338, 319);
            przydzielLinkLabel.Name = "przydzielLinkLabel";
            przydzielLinkLabel.Size = new Size(53, 15);
            przydzielLinkLabel.TabIndex = 13;
            przydzielLinkLabel.TabStop = true;
            przydzielLinkLabel.Text = "Przydziel";
            przydzielLinkLabel.Visible = false;
            przydzielLinkLabel.LinkClicked += przydzielLinkLabel_LinkClicked;
            // 
            // zamknijButton
            // 
            zamknijButton.FlatAppearance.BorderColor = Color.Silver;
            zamknijButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            zamknijButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            zamknijButton.FlatStyle = FlatStyle.Flat;
            zamknijButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            zamknijButton.Location = new Point(338, 523);
            zamknijButton.Name = "zamknijButton";
            zamknijButton.Size = new Size(88, 43);
            zamknijButton.TabIndex = 44;
            zamknijButton.Text = "Zamknij";
            zamknijButton.UseVisualStyleBackColor = true;
            zamknijButton.Click += zamknijButton_Click;
            // 
            // ostatnieZadaniaDataGridView
            // 
            ostatnieZadaniaDataGridView.AllowUserToResizeRows = false;
            ostatnieZadaniaDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            ostatnieZadaniaDataGridView.BackgroundColor = Color.White;
            ostatnieZadaniaDataGridView.BorderStyle = BorderStyle.None;
            ostatnieZadaniaDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ostatnieZadaniaDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            ostatnieZadaniaDataGridView.Location = new Point(24, 349);
            ostatnieZadaniaDataGridView.Name = "ostatnieZadaniaDataGridView";
            ostatnieZadaniaDataGridView.RowTemplate.Height = 25;
            ostatnieZadaniaDataGridView.Size = new Size(750, 150);
            ostatnieZadaniaDataGridView.TabIndex = 47;
            ostatnieZadaniaDataGridView.CellContentClick += ostatnieZadaniaDataGridView_CellContentClick;
            // 
            // ZadaniaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(786, 578);
            Controls.Add(ostatnieZadaniaDataGridView);
            Controls.Add(zamknijButton);
            Controls.Add(przydzielLinkLabel);
            Controls.Add(dodajLinkLabel);
            Controls.Add(opisZagadnieniaTextBox);
            Controls.Add(nazwaZagadnieniaTextBox);
            Controls.Add(przyjmijButton);
            Controls.Add(czasLabel);
            Controls.Add(opisLabel);
            Controls.Add(czasValue);
            Controls.Add(opisValue);
            Controls.Add(zagadnieniaListBox);
            Name = "ZadaniaForm";
            Text = "Zadania";
            KeyDown += ZadaniaForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)ostatnieZadaniaDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox zagadnieniaListBox;
        private TextBox opisValue;
        private TextBox czasValue;
        private Label opisLabel;
        private Label czasLabel;
        private Button przyjmijButton;
        private Label nazwaZagadnieniaLabel;
        private Label opisZagadnieniaLabel;
        private TextBox nazwaZagadnieniaTextBox;
        private TextBox opisZagadnieniaTextBox;
        private LinkLabel dodajLinkLabel;
        private LinkLabel przydzielLinkLabel;
        private Button zamknijButton;
        private DataGridView ostatnieZadaniaDataGridView;
    }
}