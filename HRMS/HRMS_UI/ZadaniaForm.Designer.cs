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
            zadaniaListBox = new ListBox();
            opisValue = new TextBox();
            czasValue = new TextBox();
            opisLabel = new Label();
            czasLabel = new Label();
            ostatnieZagadnieniaListBox = new ListBox();
            przyjmijButton = new Button();
            SuspendLayout();
            // 
            // zadaniaListBox
            // 
            zadaniaListBox.BackColor = Color.Azure;
            zadaniaListBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            zadaniaListBox.FormattingEnabled = true;
            zadaniaListBox.ItemHeight = 20;
            zadaniaListBox.Location = new Point(40, 33);
            zadaniaListBox.Name = "zadaniaListBox";
            zadaniaListBox.Size = new Size(272, 284);
            zadaniaListBox.TabIndex = 0;
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
            opisValue.TextChanged += textBox1_TextChanged;
            // 
            // czasValue
            // 
            czasValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            czasValue.Location = new Point(427, 290);
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
            czasLabel.Location = new Point(366, 289);
            czasLabel.Name = "czasLabel";
            czasLabel.Size = new Size(55, 25);
            czasLabel.TabIndex = 4;
            czasLabel.Text = "Czas:";
            // 
            // ostatnieZagadnieniaListBox
            // 
            ostatnieZagadnieniaListBox.BackColor = Color.LightCyan;
            ostatnieZagadnieniaListBox.FormattingEnabled = true;
            ostatnieZagadnieniaListBox.ItemHeight = 15;
            ostatnieZagadnieniaListBox.Location = new Point(40, 360);
            ostatnieZagadnieniaListBox.Name = "ostatnieZagadnieniaListBox";
            ostatnieZagadnieniaListBox.Size = new Size(710, 109);
            ostatnieZagadnieniaListBox.TabIndex = 5;
            // 
            // przyjmijButton
            // 
            przyjmijButton.FlatAppearance.BorderColor = Color.Silver;
            przyjmijButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            przyjmijButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            przyjmijButton.FlatStyle = FlatStyle.Flat;
            przyjmijButton.Location = new Point(611, 285);
            przyjmijButton.Name = "przyjmijButton";
            przyjmijButton.Size = new Size(109, 38);
            przyjmijButton.TabIndex = 6;
            przyjmijButton.Text = "Przyjmij";
            przyjmijButton.UseVisualStyleBackColor = true;
            // 
            // ZadaniaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(786, 493);
            Controls.Add(przyjmijButton);
            Controls.Add(ostatnieZagadnieniaListBox);
            Controls.Add(czasLabel);
            Controls.Add(opisLabel);
            Controls.Add(czasValue);
            Controls.Add(opisValue);
            Controls.Add(zadaniaListBox);
            Name = "ZadaniaForm";
            Text = "Zadania";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox zadaniaListBox;
        private TextBox opisValue;
        private TextBox czasValue;
        private Label opisLabel;
        private Label czasLabel;
        private ListBox ostatnieZagadnieniaListBox;
        private Button przyjmijButton;
    }
}