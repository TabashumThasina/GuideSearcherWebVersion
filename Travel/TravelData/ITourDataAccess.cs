using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelEntity;

namespace TravelData
{
  public  interface ITourDataAccess
    {
        ICollection<Tour> GetAll(bool includeGuide = false,bool includeGroup_Formed=false, bool includeGroup_Formed1 = false, bool includeGroup_Formed2 = false);
        Tour Get(int id, bool includeGuide = false, bool includeGroup_Formed = false, bool includeGroup_Formed1 = false, bool includeGroup_Formed2 = false);
        int Insert(Tour tour);
        int Update(Tour tour);
        int Delete(int id);
    }
}
