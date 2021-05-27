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

        private double ExtractFxRate(string quotes)
        {
            String Currency = toCurrency.Text;
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


        private void calculate_Click(object sender, EventArgs e)
        {
            String url = "https://openexchangerates.org/api/latest.json?app_id=5891c536b91c48fcb68983823cf0166b";
            try
            {
                using (System.Net.WebClient client = new WebClient())
                {
                    String quotes = client.DownloadString(url);
                    double FxRate = ExtractFxRate(quotes); 
                    double usd = System.Convert.ToDouble(amountUsd.Text);
                    result.Text = (FxRate * usd).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(System.Environment.StackTrace);
            }

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void amountUsd_TextChanged(object sender, EventArgs e)
        {

        }

        private void toCurrency_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_Click(object sender, EventArgs e)
        {

        }
    }
}
