using Microsoft.EntityFrameworkCore;
using Net6_EF_Repository.Models;

namespace Net6_EF_Repository.Repositories
{
    public class BranchesRepository : IBranchesRepository
    {
        private readonly BranchMgmtContext _branchMgmtContext;

        public BranchesRepository(BranchMgmtContext branchMgmtContext)
        {
            _branchMgmtContext = branchMgmtContext;
        }

        public IEnumerable<Branches> GetAll()
        {
            return _branchMgmtContext.Branches.ToList();
        }

        public Branches GetById(int id)
        {
            return _branchMgmtContext.Branches.Find(id);
        }

        public void Add(Branches branches)
        {
            _branchMgmtContext.Branches.Add(branches);
            _branchMgmtContext.SaveChanges();
        }

        public void Update(Branches branches)
        {
            _branchMgmtContext.Entry(branches).State = EntityState.Modified;
            _branchMgmtContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var branch = _branchMgmtContext.Branches.Find(id);
            _branchMgmtContext.Branches.Remove(branch);
            _branchMgmtContext.SaveChanges();
        }
    }
}
