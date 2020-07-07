﻿using DmLib.Window;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace OnTopper
{
    public partial class TransparencyForm : Form
    {
        public ushort previous = 100;
        public ushort current = 100;

        public event EventHandler SetOpacityEvent;

        public TransparencyForm()
        {
            InitializeComponent();
        }

        public void ShowDialogWithTopMostState(bool topMost)
        {
            this.TopMost = topMost;
            this.ShowDialog();
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            numericUpDown.Value = trackBar.Value;
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            trackBar.Value = (int)numericUpDown.Value;
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            previous = current;
            this.current = (ushort)trackBar.Value;
             
            this.Close();
        }
    }
}
