using Net6_EF_Repository.Models;
using Net6_EF_Repository.Repositories;

namespace Net6_EF_Repository.Services
{
    public class BranchesService : IBranchesService
    {
        private readonly IBranchesRepository _branchesRepository;

        //dependency injection

        //injection
        public BranchesService(IBranchesRepository branchesRepository)
        {
            //set dependency
            _branchesRepository = branchesRepository;
        }

        public IEnumerable<Branches> GetAll()
        {
            var branches = _branchesRepository.GetAll();
            var resp = branches.OrderByDescending(m => m.BranchName);
            return resp;
        }

        public Branches GetById(int id)
        {
            return _branchesRepository.GetById(id);
        }

        public void Add(Branches branches)
        {
            _branchesRepository.Add(branches);
        }

        public void Update(Branches branches)
        {
            _branchesRepository.Update(branches);
        }

        public void Delete(int id)
        {
            _branchesRepository.Delete(id);
        }


    }
}
