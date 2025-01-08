using errors_check.Models;
using Microsoft.EntityFrameworkCore;

namespace errors_check
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {

        }

    }
}
