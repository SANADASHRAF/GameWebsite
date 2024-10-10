
using Microsoft.EntityFrameworkCore;

namespace CarWebsite.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            :base(options)
        {
            
        }
    }
}
