using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelEntity;

namespace TravelService
{
   public interface IGroupService
    {
        ICollection<Group_Register> GetAll(bool includeTourist = false);
        Group_Register Get(int id, bool includeTourist = false);
        int Insert(Group_Register group);
        int Update(Group_Register group);
        int Delete(int id);
    }
}
