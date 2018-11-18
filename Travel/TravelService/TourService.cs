using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelData;
using TravelEntity;

namespace TravelService
{
    class TourService : ITourService
    {
        private ITourDataAccess data;

        public TourService(ITourDataAccess data)
        {
            this.data = data;
        }

        public int Delete(int id)
        {
            return this.data.Delete(id);
        }

        public Tour Get(int id, bool includeGuide = false, bool includeGroup_Formed = false, bool includeGroup_Formed1 = false, bool includeGroup_Formed2 = false)
        {
            return this.data.Get(id, includeGuide, includeGroup_Formed, includeGroup_Formed1, includeGroup_Formed2);
        }

        public ICollection<Tour> GetAll(bool includeGuide = false, bool includeGroup_Formed = false, bool includeGroup_Formed1 = false, bool includeGroup_Formed2 = false)
        {
            return this.data.GetAll(includeGuide, includeGroup_Formed, includeGroup_Formed1, includeGroup_Formed2);
        }

        public int Insert(Tour tour)
        {
            return this.data.Insert(tour);
        }

        public int Update(Tour tour)
        {
            return this.data.Update(tour);
        }
    }
}
