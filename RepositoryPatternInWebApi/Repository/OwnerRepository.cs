using RepositoryPatternInWebApi.Contracts;
using RepositoryPatternInWebApi.Entities;
using RepositoryPatternInWebApi.Entities.Models;

namespace RepositoryPatternInWebApi.Repository
{
    public class OwnerRepository : RepositoryBase<Owner>, IOwnerRepository
    {
        public OwnerRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
