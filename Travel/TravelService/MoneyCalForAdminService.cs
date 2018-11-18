using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelData;
using TravelEntity;

namespace TravelService
{
    class MoneyCalForAdminService : IMoneyCalForAdminService
    {
        private IMoneyCalForAdminDataAccess data;

        public MoneyCalForAdminService(IMoneyCalForAdminDataAccess data)
        {
            this.data = data;
        }

        public int Delete(int id)
        {
            return this.data.Delete(id);
        }

        public MoneyCalForAdmin Get(int id, bool includeTour = false)
        {
            return this.data.Get(id, includeTour);
        }

        public ICollection<MoneyCalForAdmin> GetAll(bool includeTour = false)
        {
            return this.data.GetAll(includeTour);
        }

        public int Insert(MoneyCalForAdmin mcal)
        {
            return this.data.Insert(mcal);
        }
    }
}
