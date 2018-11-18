using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelData;
using TravelEntity;

namespace TravelService
{
    class GuideService : IGuideService
    {
        private IGuideDataAccess data;

        public GuideService(IGuideDataAccess data)
        {
            this.data = data;
        }

        public int Delete(int id)
        {
            return this.data.Delete(id);
        }

        public Guide Get(int id)
        {
            return this.data.Get(id);
        }

        public ICollection<Guide> GetAll()
        {
            return this.data.GetAll();
        }

        public int Insert(Guide guide)
        {
            return this.data.Insert(guide);
        }

        public int Update(Guide guide)
        {
            return this.data.Update(guide);
        }

        public bool ValidateCredentials(Guide guide)
        {
            return this.data.ValidateCredentials(guide);
        }
    }
}
