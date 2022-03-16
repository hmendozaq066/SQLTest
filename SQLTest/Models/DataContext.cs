using Microsoft.EntityFrameworkCore;

namespace SQLTest.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts) : base(opts) { }
    }
}
