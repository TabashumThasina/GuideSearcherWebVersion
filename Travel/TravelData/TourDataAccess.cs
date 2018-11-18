using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelEntity;

namespace TravelData
{
    class TourDataAccess : ITourDataAccess
    {
        private TravelContext context;
        public TourDataAccess(TravelContext context)
        {
            this.context = context;
        }

        public int Delete(int id)
        {
            Tour tour = this.context.Tours.SingleOrDefault(x => x.TourId == id);
            this.context.Tours.Remove(tour);
            return this.context.SaveChanges();
        }

        public Tour Get(int id, bool includeGuide = false, bool includeGroup_Formed = false, bool includeGroup_Formed1 = false, bool includeGroup_Formed2 = false)
        {
            if (includeGuide)
            {
                return this.context.Tours.Include("Guide").SingleOrDefault(x => x.TourId == id);
            }
            else if(includeGroup_Formed)
            {
                return this.context.Tours.Include("Group_Formed").SingleOrDefault(x => x.TourId == id);
            }
            else if(includeGroup_Formed1)
            {
                return this.context.Tours.Include("Group_Formed").SingleOrDefault(x => x.TourId == id);
            }
            else if(includeGroup_Formed2)
            {
                return this.context.Tours.Include("Group_Formed").SingleOrDefault(x => x.TourId == id);
            }
            else
            {
                return this.context.Tours.SingleOrDefault(x => x.TourId == id);
            }
        }

        public ICollection<Tour> GetAll(bool includeGuide = false, bool includeGroup_Formed = false, bool includeGroup_Formed1 = false, bool includeGroup_Formed2 = false)
        {
            if (includeGuide)
            {
                return this.context.Tours.Include("Guide").ToList();
            }
            else if (includeGroup_Formed)
            {
                return this.context.Tours.Include("Group_Formed").ToList();
            }
            else if (includeGroup_Formed1)
            {
                return this.context.Tours.Include("Group_Formed").ToList();
            }
            else if (includeGroup_Formed2)
            {
                return this.context.Tours.Include("Group_Formed").ToList();
            }
            else
            {
                return this.context.Tours.ToList();
            }
        }

        public int Insert(Tour tour)
        {
            this.context.Tours.Add(tour);
            return this.context.SaveChanges();
        }

        public int Update(Tour tour)
        {
            Tour tr = this.context.Tours.SingleOrDefault(x => x.TourId == tour.TourId);
            tr.GuideId = tour.GuideId;
            tr.GroupFormedId = tour.GroupFormedId;
            tr.GroupFormedId1 = tour.GroupFormedId1;
            tr.GroupFormedId2 = tour.GroupFormedId2;
            tr.MoneyCal = tour.MoneyCal;
            return this.context.SaveChanges();

        }
    }
}
