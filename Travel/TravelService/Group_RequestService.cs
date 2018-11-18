using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelData;
using TravelEntity;

namespace TravelService
{
    class Group_RequestService : IGroup_RequestService
    {
        private IGroup_RequestDataAccess data;

        public Group_RequestService(IGroup_RequestDataAccess data)
        {
            this.data = data;
        }

        public int Delete(int id)
        {
            return this.data.Delete(id);
        }

        public Group_Request Get(int id, bool includeGroup = false, bool includeTourist = false)
        {
            return this.data.Get(id, includeGroup,includeTourist);
        }

        public ICollection<Group_Request> GetAll(bool includeGroup = false, bool includeTourist = false)
        {
            return this.data.GetAll(includeGroup, includeTourist);
        }

        public int Insert(Group_Request group_req)
        {
            return this.data.Insert(group_req);
        }

        public int Update(Group_Request group_req)
        {
            return this.data.Update(group_req);
        }
    }
}
