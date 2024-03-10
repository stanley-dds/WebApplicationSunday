using Microsoft.EntityFrameworkCore;
using WebApplicationSunday.Models;

namespace WebApplicationSunday.Data
{
    public class ApplicationDbContext  : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //Dbset for data models 
        public DbSet<InformationModel> InformationModel { get; set; }

    }
}
