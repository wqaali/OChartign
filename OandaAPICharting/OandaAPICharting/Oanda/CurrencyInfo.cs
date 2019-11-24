using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OandaAPICharting.Oanda
{
    public class CurrencyInfo
    {
        public List<chartinfo> candles { get; set; }
        public string granularity { get; set; }
        public string instrument { get; set; }

        public class chartinfo
        {
            public bardata mid { get; set; }
            public string time { get; set; }
            public double volume { get; set; }
            public bool complete { get; set; }

            public class bardata
            {
                public string o { get; set; }
                public string h { get; set; }
                public string l { get; set; }
                public string c { get; set; }
            }
        }
    }
}
