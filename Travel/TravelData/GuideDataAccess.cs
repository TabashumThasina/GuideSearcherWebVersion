using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelEntity;

namespace TravelData
{
    class GuideDataAccess : IGuideDataAccess
    {
        private TravelContext context;
        public GuideDataAccess(TravelContext context)
        {
            this.context = context;
        }
        public int Delete(int id)
        {
            Guide guide = this.context.Guides.SingleOrDefault(x => x.GuideId == id);
            this.context.Guides.Remove(guide);
            return this.context.SaveChanges();
        }

        public Guide Get(int id)
        {
            return this.context.Guides.SingleOrDefault(x => x.GuideId == id);
        }

        public ICollection<Guide> GetAll()
        {
            return this.context.Guides.ToList();
        }

        public int Insert(Guide guide)
        {
            this.context.Guides.Add(guide);
            return this.context.SaveChanges();
        }

        public int Update(Guide guide)
        {
            Guide gd = this.context.Guides.SingleOrDefault(x => x.GuideId == guide.GuideId);
            gd.GuideEmail = guide.GuideEmail;
            gd.GuideAddress = guide.GuideAddress;
            gd.GuideContact = guide.GuideContact;
            gd.GuideLanguages = guide.GuideLanguages;
            gd.GuideStatus = guide.GuideStatus;
            gd.GuideArea = guide.GuideArea;
            gd.GuidePassword = guide.GuidePassword;
            return this.context.SaveChanges();
        }

        public bool ValidateCredentials(Guide guide)
        {
            Guide usr = this.context.Guides.SingleOrDefault(x => x.GuideUserName == guide.GuideUserName && x.GuidePassword == guide.GuidePassword);
            if (usr == null)
            {
                return false;
            }
            else
            {
                guide.GuideId = usr.GuideId;
                return true;
            }
        }
    }
}
