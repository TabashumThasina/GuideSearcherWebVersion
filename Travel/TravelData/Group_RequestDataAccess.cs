using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelEntity;

namespace TravelData
{
    class Group_RequestDataAccess : IGroup_RequestDataAccess
    {
        private TravelContext context;
        public Group_RequestDataAccess(TravelContext context)
        {
            this.context = context;
        }
        public int Delete(int id)
        {
            Group_Request grp = this.context.Group_Request.SingleOrDefault(x => x.GroupReqId == id);
            this.context.Group_Request.Remove(grp);
            return this.context.SaveChanges();
        }

        public Group_Request Get(int id, bool includeGroup = false, bool includeTourist = false)
        {
            if (includeGroup)
            {
                return this.context.Group_Request.Include("Group").SingleOrDefault(x => x.GroupReqId == id);
            }
            else if(includeTourist)
            {
                return this.context.Group_Request.Include("Tourist").SingleOrDefault(x => x.GroupReqId == id);
            }
            else
            {
                return this.context.Group_Request.SingleOrDefault(x => x.GroupReqId == id);
            }
        }

        public ICollection<Group_Request> GetAll(bool includeGroup = false, bool includeTourist = false)
        {
            if (includeGroup)
            {
                return this.context.Group_Request.Include("Group").ToList();
            }
            else if(includeTourist)
            {
                return this.context.Group_Request.Include("Tourist").ToList();
            }
            else
            {
                return this.context.Group_Request.ToList();
            }
        }

        public int Insert(Group_Request group_req)
        {
            this.context.Group_Request.Add(group_req);
            return this.context.SaveChanges();
        }

        public int Update(Group_Request group_req)
        {
            Group_Request grp = this.context.Group_Request.SingleOrDefault(x => x.GroupReqId == group_req.GroupReqId);
            grp.GroupId = grp.GroupId;
            grp.TouristId = group_req.TouristId;
            return this.context.SaveChanges();
        }

       /* public bool ValidateCredentials(Group_Request group_req)
        {
            Group_Request grp = this.context.Group_Request.SingleOrDefault(x => x.GroupReqId == group_req.GroupReqId);
            if (grp == null)
            {
                return false;
            }
            else
            {
                group_req.GroupReqId = grp.GroupReqId;
                return true;
            }
        }*/
    }
}
