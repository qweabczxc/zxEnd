using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AppDBContextFactory : IDesignTimeDbContextFactory<AppDBContext>
    {
        public AppDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDBContext>();
            var connectionString = "User id=postgres; port=5432; host=localhost; database=zxISTU; password=root;";
            optionsBuilder.UseNpgsql(connectionString);

            return new AppDBContext(optionsBuilder.Options);
        }
    }
}
