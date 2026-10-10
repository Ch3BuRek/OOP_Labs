namespace Laba1_oop
{
    partial class Form2
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
            trackBar1 = new TrackBar();
            trackLbl = new Label();
            buttonYes = new Button();
            buttonNo = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(12, 59);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(450, 56);
            trackBar1.TabIndex = 0;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // trackLbl
            // 
            trackLbl.AutoSize = true;
            trackLbl.Location = new Point(229, 36);
            trackLbl.Name = "trackLbl";
            trackLbl.Size = new Size(17, 20);
            trackLbl.TabIndex = 1;
            trackLbl.Text = "0";
            trackLbl.Click += trackLbl_Click;
            // 
            // buttonYes
            // 
            buttonYes.Location = new Point(110, 121);
            buttonYes.Name = "buttonYes";
            buttonYes.Size = new Size(94, 29);
            buttonYes.TabIndex = 2;
            buttonYes.Text = "Так";
            buttonYes.UseVisualStyleBackColor = true;
            buttonYes.Click += buttonYes_Click;
            // 
            // buttonNo
            // 
            buttonNo.Location = new Point(266, 121);
            buttonNo.Name = "buttonNo";
            buttonNo.Size = new Size(94, 29);
            buttonNo.TabIndex = 3;
            buttonNo.Text = "Ні";
            buttonNo.UseVisualStyleBackColor = true;
            buttonNo.Click += buttonNo_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 203);
            Controls.Add(buttonNo);
            Controls.Add(buttonYes);
            Controls.Add(trackLbl);
            Controls.Add(trackBar1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBar1;
        private Label trackLbl;
        private Button buttonYes;
        private Button buttonNo;
    }
}