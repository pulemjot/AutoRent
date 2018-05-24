using System.Data.Entity;

namespace AutoRent.Database {
    class AppDbContext : DbContext {
        public AppDbContext() : base(("Server=hq-s-sql.sysadmins.lv;Database=Autorent;User Id=srpuser; Password=P@ssw0rd")) {

        }
        public DbSet<ClientEntity> Clients { get; set; }
        public DbSet<CarEntity> Cars { get; set; }
        public DbSet<CarRent> Rents { get; set; }
        public DbSet<Operator> Operators { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CarRent>()
                .HasRequired(x => x.Client)
                .WithMany(x => x.Rents)
                .WillCascadeOnDelete(false);
        }
    }
}
