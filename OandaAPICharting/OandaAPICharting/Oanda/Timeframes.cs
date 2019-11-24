using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OandaAPICharting.Oanda
{
    public class Timeframes
    {
        public Dictionary<string, string> Granularity { get; private set; }
        public Timeframes()
        {
            Granularity = new Dictionary<string, string>();

            Granularity.Add("S5", "5 Seconds");
            Granularity.Add("S10", "10 Seconds");
            Granularity.Add("S15", "15 Seconds");
            Granularity.Add("S30", "30 Seconds");
            Granularity.Add("M1", "1 Minute");
            Granularity.Add("M2", "2 Minutes");
            Granularity.Add("M4", "4 Minutes");
            Granularity.Add("M5", "5 Minutes");
            Granularity.Add("M10", "10 Minutes");
            Granularity.Add("M15", "15 Minutes");
            Granularity.Add("M30", "30 Minutes");
            Granularity.Add("H1", "1 Hour");
            Granularity.Add("H2", "2 Hours");
            Granularity.Add("H3", "3 Hours");
            Granularity.Add("H4", "4 Hours");
            Granularity.Add("H6", "6 Hours");
            Granularity.Add("H8", "8 Hours");
            Granularity.Add("H12", "12 Hours");
            Granularity.Add("D", "1 Day");
            Granularity.Add("W", "1 Week");
            Granularity.Add("M", "1 Month");
        }
    }
}
