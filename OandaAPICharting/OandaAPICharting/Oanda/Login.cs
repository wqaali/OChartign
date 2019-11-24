using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OandaAPICharting.Oanda
{
    public class Login
    {
        public async Task<DataTable> GetOandaAPI(string currency, string tick)
        {
            // Login Info

            string url = "https://api-fxpractice.oanda.com/v3/instruments/"+currency+"/candles?count=100&price=M&granularity="+tick+"";
            string ACC_ID = "101-001-3854888-001";
            string token = "Bearer eccaf3ff5e81bf1dd69e539f44ee371a-5c27e8704102e60f7a0842c8cf1b8f18";

            // Request and Response

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            HttpResponseMessage response = await client.GetAsync(url);
            HttpContent content = response.Content;
            string mycontent = await content.ReadAsStringAsync();

            // Serialize and Deserialize the data, also save and read the file

            string result = JsonConvert.SerializeObject(mycontent);
            File.WriteAllText(@"content.json", mycontent);
            //Console.WriteLine("Stored!");
            result = String.Empty;
            result = File.ReadAllText(@"content.json");
            CurrencyInfo final = JsonConvert.DeserializeObject<CurrencyInfo>(result);

            DataTable datatable = new DataTable();
            datatable.Columns.Add("time", typeof(DateTime));
            datatable.Columns.Add("o", typeof(double));
            datatable.Columns.Add("h", typeof(double));
            datatable.Columns.Add("l", typeof(double));
            datatable.Columns.Add("c", typeof(double));


            for (int i = 0; i < final.candles.Count; i++)
            {
                DataRow dr = datatable.NewRow();
                dr["time"] = Convert.ToDateTime(final.candles[i].time);//.ToString("dd-MM-yyyy HH:mm:ss");
                dr["o"] = final.candles[i].mid.o;
                dr["h"] = final.candles[i].mid.h;
                dr["l"] = final.candles[i].mid.l;
                dr["c"] = final.candles[i].mid.c;
                datatable.Rows.Add(dr);

            }
            return datatable;
        }        
    }
}
