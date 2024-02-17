namespace HRMS_UI
{
    partial class UprawnieniaForm
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
            pracownicyListBox = new ListBox();
            zaawansowaneLinkLabel = new LinkLabel();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            pracownikLabel = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // pracownicyListBox
            // 
            pracownicyListBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            pracownicyListBox.FormattingEnabled = true;
            pracownicyListBox.ItemHeight = 20;
            pracownicyListBox.Location = new Point(40, 28);
            pracownicyListBox.Name = "pracownicyListBox";
            pracownicyListBox.Size = new Size(240, 304);
            pracownicyListBox.TabIndex = 0;
            // 
            // zaawansowaneLinkLabel
            // 
            zaawansowaneLinkLabel.AutoSize = true;
            zaawansowaneLinkLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            zaawansowaneLinkLabel.Location = new Point(518, 114);
            zaawansowaneLinkLabel.Name = "zaawansowaneLinkLabel";
            zaawansowaneLinkLabel.Size = new Size(111, 20);
            zaawansowaneLinkLabel.TabIndex = 1;
            zaawansowaneLinkLabel.TabStop = true;
            zaawansowaneLinkLabel.Text = "Zaawansowane";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(300, 155);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(148, 24);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Dodawanie zadań";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(300, 200);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(184, 24);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "Dostęp do bazy danych";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.Location = new Point(300, 110);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(182, 24);
            checkBox3.TabIndex = 4;
            checkBox3.Text = "Modyfikacja zagadnień";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // pracownikLabel
            // 
            pracownikLabel.AutoSize = true;
            pracownikLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            pracownikLabel.Location = new Point(300, 46);
            pracownikLabel.Name = "pracownikLabel";
            pracownikLabel.Size = new Size(81, 25);
            pracownikLabel.TabIndex = 5;
            pracownikLabel.Text = "<none>";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.Silver;
            button1.FlatAppearance.MouseDownBackColor = Color.Gray;
            button1.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(409, 278);
            button1.Name = "button1";
            button1.Size = new Size(157, 37);
            button1.TabIndex = 6;
            button1.Text = "Zastosuj i zamknij";
            button1.UseVisualStyleBackColor = true;
            // 
            // UprawnieniaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(669, 380);
            Controls.Add(button1);
            Controls.Add(pracownikLabel);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(zaawansowaneLinkLabel);
            Controls.Add(pracownicyListBox);
            Name = "UprawnieniaForm";
            Text = "Uprawnienia";
            Load += UprawnieniaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox pracownicyListBox;
        private LinkLabel zaawansowaneLinkLabel;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Label pracownikLabel;
        private Button button1;
    }
}