using System.Xml.Linq;

namespace Laba1_oop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            DialogResult result = form2.ShowDialog();

            if (result == DialogResult.Yes)
            {
                labelRes.Text = form2.TrackValue.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool loop = true;
            bool formOpened = true;

            while (loop)
            {
                if (formOpened)
                {
                    Form3 form3 = new Form3();
                    DialogResult result = form3.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        formOpened = false;
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        loop = false;
                    }
                }
                else
                {
                    Form4 form4 = new Form4();

                    DialogResult result = form4.ShowDialog();
                    if (result == DialogResult.Retry)
                    {
                        formOpened = true;
                    }
                    else if (result == DialogResult.Yes)
                    {
                        loop = false;
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        loop = false;
                    }

                }
            }
        }

        private void labelRes_Click(object sender, EventArgs e)
        {

        }
    }
}
