using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelData;
using TravelEntity;

namespace TravelService
{
    class TouristService : ITouristService
    {
        private ITouristDataAccess data;

        public TouristService(ITouristDataAccess data)
        {
            this.data = data;
        }

        public int Delete(int id)
        {
            return this.data.Delete(id);
        }

        public Tourist Get(int id)
        {
            return this.data.Get(id);
        }

        public ICollection<Tourist> GetAll()
        {
            return this.data.GetAll();
        }

        public int Insert(Tourist tourist)
        {
            return this.data.Insert(tourist);
        }

        public int Update(Tourist tourist)
        {
            return this.data.Update(tourist);
        }

        public bool ValidateCredentials(Tourist tourist)
        {
            return this.data.ValidateCredentials(tourist);
        }
    }
}
