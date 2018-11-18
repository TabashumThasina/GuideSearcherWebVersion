using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelEntity
{
    public class Rating
    {
        public int RatingId { get; set; }
        public int GuideId { get; set; }
        public int NoOfTour { get; set; }
        public double Bonus { get; set; }
        public Guide Guide { get; set; }
    }
}
