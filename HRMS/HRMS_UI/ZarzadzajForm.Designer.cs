namespace HRMS_UI
{
    partial class ZarzadzajForm
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
            listaPracownikowListBox = new ListBox();
            zamknijButton = new Button();
            pracownikInfoLabel = new Label();
            dodajButton = new Button();
            modyfikujButton = new Button();
            usunButton = new Button();
            SuspendLayout();
            // 
            // listaPracownikowListBox
            // 
            listaPracownikowListBox.BackColor = Color.Azure;
            listaPracownikowListBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            listaPracownikowListBox.FormattingEnabled = true;
            listaPracownikowListBox.ItemHeight = 20;
            listaPracownikowListBox.Location = new Point(26, 22);
            listaPracownikowListBox.Name = "listaPracownikowListBox";
            listaPracownikowListBox.Size = new Size(344, 104);
            listaPracownikowListBox.TabIndex = 1;
            // 
            // zamknijButton
            // 
            zamknijButton.FlatAppearance.BorderColor = Color.Silver;
            zamknijButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            zamknijButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            zamknijButton.FlatStyle = FlatStyle.Flat;
            zamknijButton.Location = new Point(216, 359);
            zamknijButton.Name = "zamknijButton";
            zamknijButton.Size = new Size(92, 37);
            zamknijButton.TabIndex = 2;
            zamknijButton.Text = "Zamknij";
            zamknijButton.UseVisualStyleBackColor = true;
            zamknijButton.Click += zamknijButton_Click;
            // 
            // pracownikInfoLabel
            // 
            pracownikInfoLabel.AutoSize = true;
            pracownikInfoLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            pracownikInfoLabel.Location = new Point(26, 147);
            pracownikInfoLabel.Name = "pracownikInfoLabel";
            pracownikInfoLabel.Size = new Size(62, 20);
            pracownikInfoLabel.TabIndex = 3;
            pracownikInfoLabel.Text = "<none>";
            pracownikInfoLabel.Visible = false;
            // 
            // dodajButton
            // 
            dodajButton.FlatAppearance.BorderColor = Color.Silver;
            dodajButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            dodajButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            dodajButton.FlatStyle = FlatStyle.Flat;
            dodajButton.Location = new Point(400, 37);
            dodajButton.Name = "dodajButton";
            dodajButton.Size = new Size(79, 37);
            dodajButton.TabIndex = 4;
            dodajButton.Text = "Dodaj";
            dodajButton.UseVisualStyleBackColor = true;
            dodajButton.Click += dodajButton_Click;
            // 
            // modyfikujButton
            // 
            modyfikujButton.FlatAppearance.BorderColor = Color.Silver;
            modyfikujButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            modyfikujButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            modyfikujButton.FlatStyle = FlatStyle.Flat;
            modyfikujButton.Location = new Point(400, 174);
            modyfikujButton.Name = "modyfikujButton";
            modyfikujButton.Size = new Size(79, 37);
            modyfikujButton.TabIndex = 5;
            modyfikujButton.Text = "Modyfikuj";
            modyfikujButton.UseVisualStyleBackColor = true;
            modyfikujButton.Click += modyfikujButton_Click;
            // 
            // usunButton
            // 
            usunButton.FlatAppearance.BorderColor = Color.Silver;
            usunButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            usunButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            usunButton.FlatStyle = FlatStyle.Flat;
            usunButton.Location = new Point(400, 105);
            usunButton.Name = "usunButton";
            usunButton.Size = new Size(79, 37);
            usunButton.TabIndex = 6;
            usunButton.Text = "Usuń";
            usunButton.UseVisualStyleBackColor = true;
            usunButton.Click += usunButton_Click;
            // 
            // ZarzadzajForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(532, 413);
            Controls.Add(usunButton);
            Controls.Add(modyfikujButton);
            Controls.Add(dodajButton);
            Controls.Add(pracownikInfoLabel);
            Controls.Add(zamknijButton);
            Controls.Add(listaPracownikowListBox);
            Name = "ZarzadzajForm";
            Text = "Zarządzaj";
            KeyDown += ZarzadzajForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listaPracownikowListBox;
        private Button zamknijButton;
        private Label pracownikInfoLabel;
        private Button dodajButton;
        private Button modyfikujButton;
        private Button usunButton;
    }
}