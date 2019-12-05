using System;

namespace Dal
{
    public class DBContext: DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }
        public DbSet<Users> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-0V0QKG7G\SQLEXPRESS;Database=Shopping;Trusted_Connection=True;");
        }
    }
}
