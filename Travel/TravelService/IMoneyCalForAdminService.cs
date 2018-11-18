using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelEntity;

namespace TravelService
{
    public interface IMoneyCalForAdminService
    {
        ICollection<MoneyCalForAdmin> GetAll(bool includeTour = false);
        MoneyCalForAdmin Get(int id, bool includeTour = false);
        int Insert(MoneyCalForAdmin mcal);
        int Delete(int id);
    }
}
