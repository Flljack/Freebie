using Freebie.Models;

namespace Freebie.Repositories
{
    public class EfCoreUserRepository : EfCoreRepository<User, ApplicationContext>
    {
        public EfCoreUserRepository(ApplicationContext context) : base(context)
        {

        }
    }
}
    