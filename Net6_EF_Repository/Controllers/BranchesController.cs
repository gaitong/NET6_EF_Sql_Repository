using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Net6_EF_Repository.Models;
using Net6_EF_Repository.Services;

namespace Net6_EF_Repository.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchesController : ControllerBase
    {
        private readonly IBranchesService _branchesService;

        public BranchesController(IBranchesService branchesService)
        {
            _branchesService = branchesService;
        }

        [HttpGet]
        public IEnumerable<Branches> GetAll()
        {
            return _branchesService.GetAll();
        }

        [HttpGet("{id}")]
        public Branches GetById(int id)
        {
            return _branchesService.GetById(id);
        }

        [HttpPost]
        public void Add(Branches branches)
        {
            _branchesService.Add(branches);
        }

        [HttpPut("{id}")]
        public void Update(int id, Branches branches)
        {
            _branchesService.Update(branches);

        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _branchesService.Delete(id);    
        }
    }
}
