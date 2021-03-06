﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelEntity;

namespace TravelData
{
   public interface IGroup_RequestDataAccess
    {
        ICollection<Group_Request> GetAll(bool includeGroup = false,bool includeTourist=false);
        Group_Request Get(int id, bool includeGroup = false, bool includeTourist = false);
        int Insert(Group_Request group_req);
        int Update(Group_Request group_req);
        int Delete(int id);
      //  bool ValidateCredentials(Group_Request group_req);
    }
}
