using Microsoft.EntityFrameworkCore;
using Ui.Data.Model;

namespace Ui.Data.Persistence
{
    public class TutorContext : DbContext
    {
        public TutorContext(DbContextOptions<TutorContext> options) : base(options) { }

        public DbSet<NationalName> NationalNames { get; set; }
    }
}
