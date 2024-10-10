namespace GameWebsite.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            :base(options)
        {   
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Device> devices { get; set; }
        public DbSet<GameDevice> gameDevices { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameDevice>()
                .HasKey(e => new { e.DeviceId, e.GameId });
        }
    }
}
