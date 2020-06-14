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
        public string GetLatest(string itemFilter, string detailFilter)
        {
            //https://www.brick-hill.com/api/shop/main/all/updated/1/?page_size=1&bot_friendly
            //bot friendly must be enabled.
            string jes = new WebClient().DownloadString("https://www.brick-hill.com/api/shop/main/" + itemFilter + "/updated/1/?page_size=1&bot_friendly");
            var test = JsonConvert.DeserializeObject<List<ShopPost>>(jes);
            foreach (var data in test)
            {
                switch (detailFilter)
                {
                    case "name":
                        return data.name;
                    case "bits":
                        if (data.bits == "-1")
                        {
                            return "Offsale";
                        }
                        return data.bits;
                    case "bucks":
                        if (data.bucks == "-1")
                        {
                            return "Offsale";
                        }
                        return data.bucks;
                    case "id":
                        return data.id.ToString();
                    case "description":
                        return data.description.ToString();
                    case "thumbnail":
                        return data.thumbnail;
                    case "special":
                        return data.special.ToString();
                    case "special_edition":
                        return data.special_edition.ToString();
                    case "is_special":
                        return data.is_special.ToString();


                }
            }
            return "Invalid Input";
        }
    }
        #region what
        // public string GetDetails(int itemId, string filter)

        //public string GetDetails()
        //{
           // return "Invalid Input";
            #region fixinglater
            //web shit
            // var client = new WebClient();
            // string json = new WebClient().DownloadString("https://api.brick-hill.com/v1/shop/item?id=" + itemId);
            // var machine = JsonConvert.DeserializeObject<List<ShopPost>>(json);
            // var shopMethod = JsonConvert.DeserializeObject<Post>(shopInfo);

            //foreach (var data in machine)
            //{

            //        if (filter == "bits")
            //       {
            //           string bits = data.bits;
            //           return bits;
            //       }
            //       else if (filter == "bucks")
            //       {
            //           string bucks = data.bucks;
            //           return bucks;
            //      }
            //      else if (filter == "gay")
            //      {
            //           return filter;
        }
        //This is your missing statement
        // return "";

        //}
    //}
    #endregion
    #endregion
    
    
    
