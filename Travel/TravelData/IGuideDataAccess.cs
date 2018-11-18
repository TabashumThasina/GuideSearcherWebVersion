using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelEntity;

namespace TravelData
{
   public interface IGuideDataAccess
    {
        ICollection<Guide> GetAll();
        Guide Get(int id);
        int Insert(Guide guide);
        int Update(Guide guide);
        int Delete(int id);
        bool ValidateCredentials(Guide guide);
    }
}
