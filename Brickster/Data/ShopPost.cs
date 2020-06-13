using System.Runtime.Serialization;

namespace Brickster
{
    // [DataContract]
    internal class ShopPost
    {
        //[DataMember]
        public string name { get; set; }
        
        // [DataMember]
        public string description { get; set; }

        //[DataMember]
        public string bits { get; set; }

        // [DataMember]
        public string bucks { get; set; }

        //[DataMember]
        public string id { get; set; }

        // [DataMember]
        public bool is_special { get; set; }

        //[DataMember]
        public bool special_edition { get; set; }

        //[DataMember]
        public bool special { get; set; }
        public string thumbnail { get; set; }
    }
}
