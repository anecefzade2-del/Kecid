using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Random_number
{
    public partial class Form1 : Form
    {
        int num;
        int cehd = 0;

        public Form1()
        {
            InitializeComponent();

            textBox1.Enabled = false;
            button1.Enabled = false;

            labelCehd.Text = "Cəhd sayı: 0";
        }

        private void yenioyunbtn_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            num = r.Next(0, 101);

            cehd = 0;

            textBox1.Enabled = true;
            button1.Enabled = true;

            textBox1.Clear();
            richTextBox1.Clear();

            labelCehd.Text = "Cəhd sayı: 0";

            errorProvider1.Clear();

            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim() == "")
            {
                errorProvider1.SetError(
                    textBox1,
                    "Ədəd daxil edin!"
                );

                return;
            }

            errorProvider1.Clear();

            int daxilEdilen;

            if (!int.TryParse(textBox1.Text, out daxilEdilen))
            {
                errorProvider1.SetError(
                    textBox1,
                    "Yalnız ədəd daxil edin!"
                );

                return;
            }


            if (daxilEdilen < 0 || daxilEdilen > 100)
            {
                errorProvider1.SetError(
                    textBox1,
                    "0-100 arasında ədəd daxil edin!"
                );

                return;
            }

 
            cehd++;

            labelCehd.Text = "Cəhd sayı: " + cehd;


            if (daxilEdilen == num)
            {
                richTextBox1.Text =
                    "TƏBRİKLƏR!\n\n" +
                    "Oyunu qazandınız!\n" +
                    "Cəhd sayı: " + cehd;

                textBox1.Enabled = false;
                button1.Enabled = false;
            }
            else
            {
                richTextBox1.Text =
                    "Daxil edilən ədəd yanlışdır!\n\n";

                if (daxilEdilen < num)
                {
                    richTextBox1.AppendText(
                        "Təsadüfi ədəddən kiçikdir."
                    );
                }
                else
                {
                    richTextBox1.AppendText(
                        "Təsadüfi ədəddən böyükdür."
                    );
                }
            }

            textBox1.Clear();
            textBox1.Focus();
        }
    }
}