namespace HRMS_UI
{
    partial class MenuForm
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
            uprawnieniaButton = new Button();
            zadaniaButton = new Button();
            szczegolyButton = new Button();
            menuLabel = new Label();
            SuspendLayout();
            // 
            // uprawnieniaButton
            // 
            uprawnieniaButton.FlatAppearance.BorderColor = Color.Silver;
            uprawnieniaButton.FlatAppearance.BorderSize = 0;
            uprawnieniaButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            uprawnieniaButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            uprawnieniaButton.FlatStyle = FlatStyle.Flat;
            uprawnieniaButton.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            uprawnieniaButton.Location = new Point(49, 102);
            uprawnieniaButton.Name = "uprawnieniaButton";
            uprawnieniaButton.Size = new Size(367, 80);
            uprawnieniaButton.TabIndex = 0;
            uprawnieniaButton.Text = "Uprawnienia";
            uprawnieniaButton.UseVisualStyleBackColor = true;
            // 
            // zadaniaButton
            // 
            zadaniaButton.FlatAppearance.BorderColor = Color.Silver;
            zadaniaButton.FlatAppearance.BorderSize = 0;
            zadaniaButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            zadaniaButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            zadaniaButton.FlatStyle = FlatStyle.Flat;
            zadaniaButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            zadaniaButton.Location = new Point(49, 217);
            zadaniaButton.Name = "zadaniaButton";
            zadaniaButton.Size = new Size(367, 80);
            zadaniaButton.TabIndex = 1;
            zadaniaButton.Text = "Zadania";
            zadaniaButton.UseVisualStyleBackColor = true;
            zadaniaButton.Click += button2_Click;
            // 
            // szczegolyButton
            // 
            szczegolyButton.FlatAppearance.BorderColor = Color.Silver;
            szczegolyButton.FlatAppearance.BorderSize = 0;
            szczegolyButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            szczegolyButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            szczegolyButton.FlatStyle = FlatStyle.Flat;
            szczegolyButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            szczegolyButton.Location = new Point(49, 332);
            szczegolyButton.Name = "szczegolyButton";
            szczegolyButton.Size = new Size(367, 80);
            szczegolyButton.TabIndex = 2;
            szczegolyButton.Text = "Szczegóły";
            szczegolyButton.UseVisualStyleBackColor = true;
            // 
            // menuLabel
            // 
            menuLabel.AutoSize = true;
            menuLabel.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuLabel.Location = new Point(188, 32);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(93, 40);
            menuLabel.TabIndex = 3;
            menuLabel.Text = "Menu";
            menuLabel.Click += menuLabel_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(474, 425);
            Controls.Add(menuLabel);
            Controls.Add(szczegolyButton);
            Controls.Add(zadaniaButton);
            Controls.Add(uprawnieniaButton);
            Name = "MenuForm";
            Text = "Menu";
            Load += MenuForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button uprawnieniaButton;
        private Button zadaniaButton;
        private Button szczegolyButton;
        private Label menuLabel;
    }
}