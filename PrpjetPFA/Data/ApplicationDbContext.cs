using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PrpjetPFA.Models;

namespace PrpjetPFA.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Filiere>()
                .HasOne(h => h.Faculte)
                .WithMany(f => f.Filieres)
                .HasForeignKey(h => h.FaculteId);
            modelBuilder.Entity<Filiere>()
               .HasOne(h => h.EcolePrive)
               .WithMany(f => f.Filieres)
               .HasForeignKey(h => h.EcoleId);
            modelBuilder.Entity<Faculte>()
               .HasOne(h => h.Universite)
               .WithMany(f => f.Facultes)
               .HasForeignKey(h => h.UniversiteId);



            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Filiere> Filiere { get; set; }
         public DbSet<Universite> Universite { get; set; }
        public DbSet<Faculte> Faculte { get; set;}
        public DbSet<EcolePrive> EcolePrive { get; set; }
        

    }
}