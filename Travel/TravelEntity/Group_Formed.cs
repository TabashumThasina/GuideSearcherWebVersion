using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelEntity
{
   public class Group_Formed
    {
        public int GroupFormedId { get; set; }
        public int GroupReqId { get; set; }
        public Group_Request Group_Request { get; set; }
        public ICollection<Tour> Tours { get; set; }
        public ICollection<Tour> Tours1 { get; set; }
        public ICollection<Tour> Tours2 { get; set; }
    }
}
