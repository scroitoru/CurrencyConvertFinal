using System;
using System.Windows.Forms;
using System.Configuration;
using System.Net;

namespace CurrencyConvertFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            String url = "https://openexchangerates.org/api/latest.json?app_id=5891c536b91c48fcb68983823cf0166b";
            try
            {
                using (System.Net.WebClient client = new WebClient())
                {
                    String quotes = client.DownloadString(url);
                    double FxRate = ExtractFxRate(quotes); lblFxRate.Text = FxRate.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private double ExtractFxRate(string quotes)
        {
            String Currency = haveCurrency.Text;
            int CurrencyOffset = quotes.IndexOf(Currency);           
            /* "ARS": 94.1244,  */
            String thisCurrency = quotes.Substring(CurrencyOffset + 6, 15);
            int ComaOffset = thisCurrency.IndexOf(',');
            String strFxRate = thisCurrency.Substring(0, ComaOffset);
            double dblFxRate = 0.0;
            if (!double.TryParse(strFxRate, out dblFxRate))
            {
                MessageBox.Show("Unable to parse " + strFxRate);
            }
            return dblFxRate;
        }

        private void tbCurrency_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
