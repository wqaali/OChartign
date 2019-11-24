using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OandaAPICharting.Oanda
{
    public class CurrencyPairs
    {
        public Dictionary<string, string> currencylist { get; private set; }


        public CurrencyPairs()
        {
            currencylist = new Dictionary<string, string>();

            currencylist.Add("AUD_CAD", "AUDCAD");
            currencylist.Add("AUD_CHF", "AUDCHF");
            currencylist.Add("AUD_JPY", "AUDJPY");
            currencylist.Add("AUD_NZD", "AUDNZD");
            currencylist.Add("AUD_USD", "AUDUSD");
            currencylist.Add("CAD_CHF", "CADCHF");
            currencylist.Add("CAD_JPY", "CADJPY");
            currencylist.Add("CHF_JPY", "CHFJPY");
            currencylist.Add("EUR_AUD", "EURAUD");
            currencylist.Add("EUR_CAD", "EURCAD");
            currencylist.Add("EUR_CHF", "EURCHF");
            currencylist.Add("EUR_GBP", "EURGBP");
            currencylist.Add("EUR_JPY", "EURJPY");
            currencylist.Add("EUR_NZD", "EURNZD");
            currencylist.Add("EUR_USD", "EURUSD");
            currencylist.Add("GBP_AUD", "GBPAUD");
            currencylist.Add("GBP_CAD", "GBPCAD");
            currencylist.Add("GBP_CHF", "GBPCHF");
            currencylist.Add("GBP_JPY", "GBPJPY");
            currencylist.Add("GBP_NZD", "GBPNZD");
            currencylist.Add("GBP_USD", "GBPUSD");
            currencylist.Add("NZD_CAD", "NZDCAD");
            currencylist.Add("NZD_CHF", "NZDCHF");
            currencylist.Add("NZD_JPY", "NZDJPY");
            currencylist.Add("NZD_USD", "NZDUSD");
            currencylist.Add("USD_CAD", "USDCAD");
            currencylist.Add("USD_CHF", "USDCHF");
            currencylist.Add("USD_JPY", "USDJPY");
        }
    }
}
