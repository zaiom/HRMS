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
            zarzadzajButton = new Button();
            menuLabel = new Label();
            menuStrip = new MenuStrip();
            idPracownikaToolStripMenuItem = new ToolStripMenuItem();
            wylogujToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
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
            uprawnieniaButton.Location = new Point(105, 120);
            uprawnieniaButton.Name = "uprawnieniaButton";
            uprawnieniaButton.Size = new Size(370, 80);
            uprawnieniaButton.TabIndex = 0;
            uprawnieniaButton.Text = "Uprawnienia";
            uprawnieniaButton.UseVisualStyleBackColor = true;
            uprawnieniaButton.Click += uprawnieniaButton_Click;
            // 
            // zadaniaButton
            // 
            zadaniaButton.FlatAppearance.BorderColor = Color.Silver;
            zadaniaButton.FlatAppearance.BorderSize = 0;
            zadaniaButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            zadaniaButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            zadaniaButton.FlatStyle = FlatStyle.Flat;
            zadaniaButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            zadaniaButton.Location = new Point(105, 230);
            zadaniaButton.Name = "zadaniaButton";
            zadaniaButton.Size = new Size(370, 80);
            zadaniaButton.TabIndex = 1;
            zadaniaButton.Text = "Zadania";
            zadaniaButton.UseVisualStyleBackColor = true;
            zadaniaButton.Click += zadaniaButton_Click;
            // 
            // zarzadzajButton
            // 
            zarzadzajButton.FlatAppearance.BorderColor = Color.Silver;
            zarzadzajButton.FlatAppearance.BorderSize = 0;
            zarzadzajButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            zarzadzajButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            zarzadzajButton.FlatStyle = FlatStyle.Flat;
            zarzadzajButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            zarzadzajButton.Location = new Point(105, 340);
            zarzadzajButton.Name = "zarzadzajButton";
            zarzadzajButton.Size = new Size(370, 80);
            zarzadzajButton.TabIndex = 2;
            zarzadzajButton.Text = "Zarządzaj";
            zarzadzajButton.UseVisualStyleBackColor = true;
            zarzadzajButton.Click += zarzadzajButton_Click;
            // 
            // menuLabel
            // 
            menuLabel.AutoSize = true;
            menuLabel.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuLabel.Location = new Point(245, 37);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(93, 40);
            menuLabel.TabIndex = 3;
            menuLabel.Text = "Menu";
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.White;
            menuStrip.Items.AddRange(new ToolStripItem[] { idPracownikaToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(564, 28);
            menuStrip.TabIndex = 4;
            // 
            // idPracownikaToolStripMenuItem
            // 
            idPracownikaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { wylogujToolStripMenuItem });
            idPracownikaToolStripMenuItem.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            idPracownikaToolStripMenuItem.ForeColor = Color.LightSeaGreen;
            idPracownikaToolStripMenuItem.Name = "idPracownikaToolStripMenuItem";
            idPracownikaToolStripMenuItem.Size = new Size(134, 24);
            idPracownikaToolStripMenuItem.Text = "<idPracownika>";
            // 
            // wylogujToolStripMenuItem
            // 
            wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            wylogujToolStripMenuItem.Size = new Size(135, 24);
            wylogujToolStripMenuItem.Text = "Wyloguj";
            wylogujToolStripMenuItem.Click += wylogujToolStripMenuItem_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(564, 466);
            Controls.Add(menuLabel);
            Controls.Add(zarzadzajButton);
            Controls.Add(zadaniaButton);
            Controls.Add(uprawnieniaButton);
            Controls.Add(menuStrip);
            Name = "MenuForm";
            Text = "Menu";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button uprawnieniaButton;
        private Button zadaniaButton;
        private Button zarzadzajButton;
        private Label menuLabel;
        private MenuStrip menuStrip;
        private ToolStripMenuItem idPracownikaToolStripMenuItem;
        private ToolStripMenuItem wylogujToolStripMenuItem;
    }
}