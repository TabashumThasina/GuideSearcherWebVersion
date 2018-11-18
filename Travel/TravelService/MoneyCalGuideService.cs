using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelData;
using TravelEntity;

namespace TravelService
{
    class MoneyCalGuideService : IMoneyCalForGuideService
    {
        private IMoneyCalForGuideDataAccess data;

        public MoneyCalGuideService(IMoneyCalForGuideDataAccess data)
        {
            this.data = data;
        }

        public int Delete(int id)
        {
            return this.data.Delete(id);
        }

        public MoneyCalForGuide Get(int id, bool includeTour = false)
        {
            return this.data.Get(id, includeTour);
        }

        public ICollection<MoneyCalForGuide> GetAll(bool includeTour = false)
        {
            return this.data.GetAll(includeTour);
        }

        public int Insert(MoneyCalForGuide mcal)
        {
            return this.data.Insert(mcal);
        }
    }
}
