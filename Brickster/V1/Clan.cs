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
            if(filter == "name")
            {
                return clanMethod.name;
            }
            else if (filter == "id")
            {
                return clanMethod.id;
            }
            if (filter == "creationdate")
            {
                return clanMethod.created_at;
            }
            if (filter == "tag")
            {
                return clanMethod.tag;
            }
            if (filter == "title")
            {
                return clanMethod.title;
            }
            return "Invalid input";

        }
    }
}
