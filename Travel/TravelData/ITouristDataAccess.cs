using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelEntity;

namespace TravelData
{
   public interface ITouristDataAccess
    {
        ICollection<Tourist> GetAll();
        Tourist Get(int id);
        int Insert(Tourist tourist);
        int Update(Tourist tourist);
        int Delete(int id);
        bool ValidateCredentials(Tourist tourist);
    }
}
