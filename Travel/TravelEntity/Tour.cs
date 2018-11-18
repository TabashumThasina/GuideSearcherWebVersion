using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelEntity
{
    public class Tour
    {
        public int TourId { get; set; }
        public int GuideId { get; set; }
        public int GroupFormedId { get; set; }
        public Nullable<int> GroupFormedId1 { get; set; }
        public Nullable<int> GroupFormedId2 { get; set; }
        public double MoneyCal { get; set; }
        public Group_Formed Group_Formed { get; set; }
        public Group_Formed Group_Formed1 { get; set; }
        public Group_Formed Group_Formed2 { get; set; }
        public Guide Guide { get; set; }
        public ICollection<MoneyCalAdmin> MoneyCalAdmins { get; set; }
        public ICollection<MoneyCalGuide> MoneyCalGuides { get; set; }
    }
}
