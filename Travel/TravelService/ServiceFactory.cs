using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelData;

namespace TravelService
{
    public abstract class ServiceFactory
    {
        public static IGroupService GetGroupService()
        {
            return new GroupService(DataAccessFactory.GetGroupDataAccess());
        }
        public static IGroup_FormedService GetGroup_FormedService()
        {
            return new Group_FormedService(DataAccessFactory.GetGroup_FormedDataAccess());
        }
        public static IGroup_RequestService GetGroup_RequestService()
        {
            return new Group_RequestService(DataAccessFactory.GetGroup_RequestDataAccess());
        }
        public static IGuideService GetGuideService()
        {
            return new GuideService(DataAccessFactory.GetGuideDataAccess());
        }
        public static IMoneyCalForAdminService GetMoneyCalAdminService()
        {
            return new MoneyCalForAdminService(DataAccessFactory.GetMoneyCalAdminDataAccess());
        }
        public static IMoneyCalForGuideService GetMoneyCalGuideService()
        {
            return new MoneyCalGuideService(DataAccessFactory.GetMoneyCalGuideDataAccess());
        }
       
        public static ITourService GetTourService()
        {
            return new TourService(DataAccessFactory.GetTourDataAccess());
        }
        public static ITouristService GetTouristService()
        {
            return new TouristService(DataAccessFactory.GetTouristDataAccess());
        }
        public static IAdminService GetAdminService()
        {
            return new AdminService(DataAccessFactory.GetAdminDataAccess());
        }

    }
}
