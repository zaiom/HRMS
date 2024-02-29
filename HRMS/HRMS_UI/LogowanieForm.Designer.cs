namespace HRMS_UI
{
    partial class LogowanieForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginLabel = new Label();
            loginValue = new TextBox();
            hasloLabel = new Label();
            hasloValue = new TextBox();
            loginButton = new Button();
            SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginLabel.Location = new Point(132, 49);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(52, 21);
            loginLabel.TabIndex = 0;
            loginLabel.Text = "Login:";
            // 
            // loginValue
            // 
            loginValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginValue.Location = new Point(42, 82);
            loginValue.Name = "loginValue";
            loginValue.Size = new Size(226, 27);
            loginValue.TabIndex = 1;
            // 
            // hasloLabel
            // 
            hasloLabel.AutoSize = true;
            hasloLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hasloLabel.Location = new Point(132, 148);
            hasloLabel.Name = "hasloLabel";
            hasloLabel.Size = new Size(52, 21);
            hasloLabel.TabIndex = 2;
            hasloLabel.Text = "Hasło:";
            // 
            // hasloValue
            // 
            hasloValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            hasloValue.Location = new Point(42, 181);
            hasloValue.Name = "hasloValue";
            hasloValue.PasswordChar = '*';
            hasloValue.Size = new Size(226, 27);
            hasloValue.TabIndex = 3;
            // 
            // loginButton
            // 
            loginButton.FlatAppearance.BorderColor = Color.Silver;
            loginButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            loginButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.Location = new Point(114, 248);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(81, 36);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // LogowanieForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(306, 332);
            Controls.Add(loginButton);
            Controls.Add(hasloValue);
            Controls.Add(hasloLabel);
            Controls.Add(loginValue);
            Controls.Add(loginLabel);
            Name = "LogowanieForm";
            Text = "Logowanie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginLabel;
        private TextBox loginValue;
        private Label hasloLabel;
        private TextBox hasloValue;
        private Button loginButton;
    }
}