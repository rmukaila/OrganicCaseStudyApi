using Microsoft.EntityFrameworkCore;

namespace OrganicCaseStudyApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
           
        public DbSet<OrganicApi> Paints { get; set; }
    }
}
