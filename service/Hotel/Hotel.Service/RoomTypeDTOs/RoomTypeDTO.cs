using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Hotel.Service.RoomTypeDTOs
{
    [DataContract]
    public class RoomTypeDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int Quentity { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public decimal Price { get; set; }
    }
}