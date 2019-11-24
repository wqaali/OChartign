using OandaAPICharting.Oanda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace OandaAPICharting
{
    public partial class Form1 : Form
    {

        private CurrencyPairs currencypairs;
        private Login login;
        private Timeframes timeframes;
        //public event EventHandler Load;

        public Form1()
        {
            currencypairs = new CurrencyPairs();
            login = new Login();
            timeframes = new Timeframes();

            this.Load += new EventHandler(Form1_Load);
            this.Load += Form1_Load;

 
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PerTick.DataSource = new BindingSource(timeframes.Granularity, null);
            PerTick.DisplayMember = "Value";
            PerTick.ValueMember = "Key";

            comboBox1.DataSource = new BindingSource(currencypairs.currencylist, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";

            //PerTick.SelectedItem = null;
            //PerTick.SelectedText = "--select--";

            Start(sender, e);
        }

        private async void Start(object sender, EventArgs e)
        {
            while (true)
            {
                try
                {
                    string defaultCurrency = "EUR_USD";
                    string defaultTick = "D";

                    var newcurrency = comboBox1.SelectedValue;
                    var tick = PerTick.SelectedValue;

                    if (tick != null)
                    {
                        defaultTick = tick.ToString();
                    }

                    if (newcurrency != null)
                    {
                        defaultCurrency = newcurrency.ToString();
                    }

                    DataTable result = await login.GetOandaAPI(defaultCurrency, defaultTick);

                    //Chart chart1 = new Chart();
                    chart1.DataSource = result;
                    //chart1.Series.Add("Series1");
                    chart1.Series["Series1"].YValuesPerPoint = 4;
                    chart1.Series["Series1"].XValueMember = "time";
                    chart1.Series["Series1"].YValueMembers = "h,l,o,c";
                    chart1.Series["Series1"].ChartType = SeriesChartType.Candlestick;
                    chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "";                 
                }

                catch (Exception)
                {

                }
            }
        }
    }
}
