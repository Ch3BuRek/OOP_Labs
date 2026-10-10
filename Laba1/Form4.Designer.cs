namespace Laba1_oop
{
    partial class Form4
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
            buttonBack = new Button();
            buttonYeah = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(12, 79);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(100, 50);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonYeah
            // 
            buttonYeah.Location = new Point(192, 79);
            buttonYeah.Name = "buttonYeah";
            buttonYeah.Size = new Size(100, 50);
            buttonYeah.TabIndex = 1;
            buttonYeah.Text = "Так";
            buttonYeah.UseVisualStyleBackColor = true;
            buttonYeah.Click += buttonYeah_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(370, 79);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(100, 50);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Відміна";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 203);
            Controls.Add(buttonCancel);
            Controls.Add(buttonYeah);
            Controls.Add(buttonBack);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonBack;
        private Button buttonYeah;
        private Button buttonCancel;
    }
}