using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brickster.Data
{
    internal class UserPost
    {
        //maybe l8r add rewards filter stuff
        //User Lookup
        public int Id { get; set; }
        public int id { get; set; }

        public string Username { get; set; }
        public string img { get; set; }

        public string last_online { get; set; }

        public string created_at { get; set; }


    }
}
