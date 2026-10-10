using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laba1_oop
{
    public partial class Form2 : Form
    {
        public int TrackValue { get; private set; }

        public Form2()
        {
            InitializeComponent();
        }
        private void trackLbl_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackLbl.Text = trackBar1.Value.ToString();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            TrackValue = trackBar1.Value;
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
