using Brickster.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Brickster.BHT
{
    public class BHT
    {
        public string UserInfo(int id, string filter)
        {
            //https://brick-hill.trade/api/extension/user/
            var client = new WebClient();
            var link = client.DownloadString("https://brick-hill.trade/api/extension/user/" + id.ToString()) ;
            BHTPost data = JsonConvert.DeserializeObject<BHTPost>(link);
            //username = usertoIDMethod.Username;
            switch (filter)
            {
                case "value":
                    return data.value;
                case "average":
                    return data.average;
                case "rank":
                    return data.rank;
                case "specials":
                    return data.specials;

            }
            return "Invalid Input";
        }
    }
}
