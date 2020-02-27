using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Entity_FirstApp
{
    class UserContext : DbContext
    {
        public UserContext()
            : base("DB_ForEntity") { }

            public DbSet<User> Users { get; set; }

    }
}
