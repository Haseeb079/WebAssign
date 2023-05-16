using Microsoft.EntityFrameworkCore;

namespace Estore.Model
{
    public class DBConTextProd : DbContext
    {
        public DBConTextProd(DbContextOptions<DBConTextProd> options) : base(options)
        {

        }

        public DbSet<EstoreHome> esiteHomes { get; set; }
    }
}