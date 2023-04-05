using Microsoft.EntityFrameworkCore;

namespace Horizon2000Rest.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }


    }
}
