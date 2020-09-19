using Freebie.Models;

namespace Freebie.Repositories
{
    public class EfCoreCategoryRepository : EfCoreRepository<Category, ApplicationContext>
    {
        public EfCoreCategoryRepository(ApplicationContext context) : base(context)
        {

        }
    }
}
    