using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelData;
using TravelEntity;

namespace TravelService
{
    class GroupService : IGroupService
    {
        private IGroupDataAccess data;

        public GroupService(IGroupDataAccess data)
        {
            this.data = data;
        }

        public int Delete(int id)
        {
            return this.data.Delete(id);
        }

        public Group_Register Get(int id, bool includeTourist = false)
        {
            return this.data.Get(id, includeTourist);
        }

        public ICollection<Group_Register> GetAll(bool includeTourist = false)
        {
            return this.data.GetAll(includeTourist);
        }

        public int Insert(Group_Register group)
        {
            return this.data.Insert(group);
        }

        public int Update(Group_Register group)
        {
            return this.data.Update(group);
        }
    }
}
