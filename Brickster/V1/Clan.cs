using Brickster.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Brickster.V1
{
    public class Clan
    //https://api.brick-hill.com/v1/clan/ranks?id=1
    {
        public string ClanInfo(int id, string filter)
        {
            var client = new WebClient();
            var clanInfo = client.DownloadString("https://api.brick-hill.com/v1/clan/clan?id=" + id);
            ClanPost clanMethod = JsonConvert.DeserializeObject<ClanPost>(clanInfo);

            switch (filter)
            {
                case "name":
                    return clanMethod.name;
                case "id":
                    return clanMethod.id.ToString();
                case "creationdate":
                    return clanMethod.created_at;
                case "tag":
                    return clanMethod.tag;
                case "title":
                    return clanMethod.title;
            }
            return "Invalid input";

        }
    }
}
