using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelEntity
{
   public class Group_Request
    {
        public int GroupReqId { get; set; }
        public int GroupId { get; set; }
        public int TouristId { get; set; }
        public Group Group { get; set; }
        public  ICollection<Group_Formed> Group_Formed { get; set; }
        public Tourist Tourist { get; set; }
    }
}
