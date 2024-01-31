using RepositoryPatternInWebApi.Contracts;
using RepositoryPatternInWebApi.Entities;
using RepositoryPatternInWebApi.Entities.Models;

namespace RepositoryPatternInWebApi.Repository
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
