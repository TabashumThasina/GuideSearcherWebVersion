using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelEntity;

namespace TravelData
{
    class TravelContext : DbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<Group_Formed> Group_Formed { get; set; }
        public DbSet<Group_Request> Group_Request { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<MoneyCalAdmin> MoneyCalAdmins { get; set; }
        public DbSet<MoneyCalGuide> MoneyCalGuides { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<Tourist> Tourists { get; set; }
    }
}
