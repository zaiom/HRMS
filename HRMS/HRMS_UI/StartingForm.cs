﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS_UI
{
    public partial class StartingForm : Form
    {
        public StartingForm()
        {
            InitializeComponent();
        }

        private void StartingForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                startButton.PerformClick();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            LogowanieForm form = new LogowanieForm();
            form.Show();
            this.Hide();                                                              // ukryj bieżące okno
        }
    }
}
