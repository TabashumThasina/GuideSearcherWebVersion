using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelEntity;
using TravelData;
namespace TravelService
{
    public interface IAdminService
    {
        ICollection<Admin> GetAll();
        Admin Get(int id);
        int Insert(Admin admin);
       // int Update(AdminService admin);
        int Delete(int id);
        bool ValidateCredentials(Admin admin);
    }
}
