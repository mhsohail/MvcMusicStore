using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace MvcMusicStore.Models
{
    public class MusicStoreEntities : IdentityDbContext<ApplicationUser>
    {

        public MusicStoreEntities()
            : base("MusicStoreEntities", throwIfV1Schema: false)
        {
        }
        
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<IdentityUserLogin> UserLogins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}