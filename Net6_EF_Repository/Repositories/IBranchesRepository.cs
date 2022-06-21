using Net6_EF_Repository.Models;

namespace Net6_EF_Repository.Repositories
{
    public interface IBranchesRepository
    {
        IEnumerable<Branches> GetAll();
        Branches GetById(int id);
        void Add(Branches branches);
        void Update(Branches branches);
        void Delete(int id);
    }
}
