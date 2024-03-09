namespace HRMS_UI
{
    partial class StartingForm
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
            startButton = new Button();
            headerLabel = new Label();
            pictureBox1 = new PictureBox();
            textLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.FlatAppearance.BorderColor = Color.Silver;
            startButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            startButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            startButton.Location = new Point(362, 450);
            startButton.Name = "startButton";
            startButton.Size = new Size(180, 66);
            startButton.TabIndex = 6;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.Location = new Point(302, 28);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(289, 47);
            headerLabel.TabIndex = 7;
            headerLabel.Text = "Witamy w HRMS!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.home__1_;
            pictureBox1.Location = new Point(383, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 126);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textLabel.Location = new Point(203, 304);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(495, 37);
            textLabel.TabIndex = 9;
            textLabel.Text = "Wybierz przycisk Start, aby kontynuować";
            // 
            // StartingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(902, 574);
            Controls.Add(textLabel);
            Controls.Add(pictureBox1);
            Controls.Add(headerLabel);
            Controls.Add(startButton);
            Name = "StartingForm";
            Text = "Witamy!";
            KeyDown += StartingForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private Label headerLabel;
        private PictureBox pictureBox1;
        private Label textLabel;
    }
}