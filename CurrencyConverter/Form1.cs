using System;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from = FromCurr.SelectedItem.ToString();
            string to = ToCurr.SelectedItem.ToString();
            double amount;

            if (!double.TryParse(AmountToConvert.Text, out amount))
            {
                MessageBox.Show("Please enter a valid amount to convert", "Error", MessageBoxButtons.OK);
                return;
            }

            double exchangerate;

            try
            {
                exchangerate = getExchangerate(from, to);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Internel Error", "Error - API Error", MessageBoxButtons.OK);
                return;
            }

            double convertedAmt = amount * exchangerate;
            AmountDisplay.Text = "Converted amount: " + convertedAmt.ToString("F2") + to;
            RateDisplay.Text = $"Conversion rate: 1{from} = {1 * exchangerate}{to}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToCurr.SelectedItem = "USD";
        }

        private double getExchangerate(string from, string to)
        {
            string json;
            using (var client = new WebClient())
            {
                json = client.DownloadString($"https://api.exchangerate-api.com/v4/latest/{from}");
            }
            var data = JObject.Parse(json);
            var rate = (double)data["rates"][to];   

            return rate;

        }
    }
}