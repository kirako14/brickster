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
        public string UserInfo(int id,string filter)
        {
            //https://brick-hill.trade/api/extension/user/
            var client = new WebClient();
            var link = client.DownloadString("https://brick-hill.trade/api/extension/user/" + id);
            BHTPost data = JsonConvert.DeserializeObject<BHTPost>(link);
            //username = usertoIDMethod.Username;
            if (filter == "value")
                {
                    return data.value;
                }
                else if (filter == "average")
                {
                    return data.average.ToString();
                }
                else if (filter == "rank")
                {
                    return data.rank;
                }
                else if (filter == "specials")
                {
                    return data.specials;
                }
            
            return "Invalid Input";
        }
    }
}
