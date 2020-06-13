using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Brickster.V1
{
    public class Shop
    {
        #region what
        public string GetDetails(int itemId, string filter)
        {

#region fixinglater
            //web shit
            var client = new WebClient();
           string json = new WebClient().DownloadString("https://api.brick-hill.com/v1/shop/item?id=" + itemId);
           var machine = JsonConvert.DeserializeObject<List<ShopPost>>(json);
           // var shopMethod = JsonConvert.DeserializeObject<Post>(shopInfo);

            foreach (var data in machine)
            {

                    if (filter == "bits")
                    {
                        string bits = data.bits;
                        return bits;
                    }
                    else if (filter == "bucks")
                    {
                        string bucks = data.bucks;
                        return bucks;
                    }
                    else if (filter == "gay")
                    {
                        return filter;
                    }
                  //This is your missing statement
                // return "";

            }
            return "Invalid Input";

        }
        #endregion
        #endregion
        public string GetLatest(string itemFilter, string detailFilter)
        {
            //https://www.brick-hill.com/api/shop/main/all/updated/1/?page_size=1&bot_friendly
            //bot friendly must be enabled.
            string jes = new WebClient().DownloadString("https://www.brick-hill.com/api/shop/main/" + itemFilter + "/updated/1/?page_size=1&bot_friendly");
            var test = JsonConvert.DeserializeObject<List<ShopPost>>(jes);
            foreach (var data in test)
            {
                if (detailFilter == "name")
                {
                    return data.name;
                }
                else if (detailFilter == "bits")
                {
                    if (data.bits == "-1")
                    {
                        return "Offsale";
                    }
                    return data.bits;
                }
                else if (detailFilter == "bucks")
                {
                    if (data.bucks == "-1")
                    {
                        return "Offsale";
                    }
                    return data.bucks;
                }


            }
            return "Invalid Input";

        }
    }
}
