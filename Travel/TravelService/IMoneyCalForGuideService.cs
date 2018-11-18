using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelEntity;

namespace TravelService
{
  public interface IMoneyCalForGuideService
    {
        ICollection<MoneyCalForGuide> GetAll(bool includeTour = false);
        MoneyCalForGuide Get(int id, bool includeTour = false);
        int Insert(MoneyCalForGuide mcal);
        int Delete(int id);
    }
}
