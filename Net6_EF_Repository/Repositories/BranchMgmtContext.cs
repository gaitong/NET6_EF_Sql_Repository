using Microsoft.EntityFrameworkCore;
using Net6_EF_Repository.Models;

namespace Net6_EF_Repository.Repositories
{
    public class BranchMgmtContext : DbContext
    {
        public BranchMgmtContext(DbContextOptions<BranchMgmtContext> options) : base(options)
        {

        }

        public DbSet<Branches> Branches { get; set; }
    }
}
