using CRUD_WEB_API_DEMO.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_WEB_API_DEMO.Data
{
    public class RegistrationAPIDbContext : DbContext
    {
        public RegistrationAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<RegistrationModel> Contacts{ get; set; }
    }

}
