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
    public class User
    {
        public string UserDetails(int userId, string filter)
        {
            //https://api.brick-hill.com/v1/user/profile?id=6765
            //gets details of the user.

            //string username = "0";

            var client = new WebClient();
            var link = client.DownloadString("https://api.brick-hill.com/v1/user/profile?id=" + userId);
            UserPost usertoIDMethod = JsonConvert.DeserializeObject<UserPost>(link);
            //username = usertoIDMethod.Username;

            switch (filter)
            {
                case "username":
                    return usertoIDMethod.Username;
                case "id":
                    return usertoIDMethod.id.ToString();
                case "lastonline":
                    return usertoIDMethod.last_online ;
                case "creationdate":
                    return usertoIDMethod.created_at;
                case "img":
                    return usertoIDMethod.img;

            }


            return "Invalid Input";
        }

        public string ToUsername(int userId)
        {
            //https://api.brick-hill.com/v1/user/profile?id=6765
            //gets details of the user.

            string username = "0";

            var client = new WebClient();
            var link = client.DownloadString("https://api.brick-hill.com/v1/user/profile?id=" + userId);
            UserPost usertoIDMethod = JsonConvert.DeserializeObject<UserPost>(link);
            username = usertoIDMethod.Username;
            return (username);
        }

        public string ToId(string username)
        {
            //https://api.brick-hill.com/v1/user/profile?id=6765
            //gets details of the user.

            string userId = "0";

            var client = new WebClient();
            var link = client.DownloadString("https://api.brick-hill.com/v1/user/id?username=" + username);
            UserPost usertoIDMethod = JsonConvert.DeserializeObject<UserPost>(link);
            userId = usertoIDMethod.id.ToString();
            return (userId);
        }
    }
}
