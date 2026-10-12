using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        double toplamGelir = 0;

        public Form1()
        {
            InitializeComponent();

           
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button2.Click += new System.EventHandler(this.button2_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBox1.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBox2.Text))
            {
                MessageBox.Show("Zehmet olmasa xanalari doldur", "Xeberdarliq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int count;
            double price;

           
            bool isCountValid = int.TryParse(maskedTextBox1.Text, out count);
            bool isPriceValid = double.TryParse(maskedTextBox2.Text, out price);

            if (!isCountValid || !isPriceValid)
            {
                MessageBox.Show("Say ve qiymeti duzgun daxil edin", "Xeberdarliq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (count <= 0 || price <= 0)
            {
                MessageBox.Show("Menfive ya sifir olazSs", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            double result = count * price;

            
            dataGridView1.Rows.Add(textBox1.Text, count.ToString(), price.ToString(), result.ToString("F2"));

            
            toplamGelir += result;
            label4.Text = "Total pay" + toplamGelir.ToString("F2");

            
            textBox1.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();

            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cavab = MessageBox.Show("Close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cavab == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}