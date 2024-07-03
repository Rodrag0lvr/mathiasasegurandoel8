using EntityFrameworkCore.CreatedUpdatedDate.Extensions;
using Microsoft.EntityFrameworkCore;
using org.higx.platform.u202210587.Hign.Personnel.Domain.Model.Aggregates;
using org.higx.platform.u202210587.Hign.Personnel.Domain.Model.ValueObjects;
using org.higx.platform.u202210587.Shared_web.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions;

namespace org.higx.platform.u202210587.Shared_web.Shared.Infrastructure.Persistence.EFC.Configuration
{
    public class AppDbContext : DbContext
    {    public DbSet<Examiner?> Examiners { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }
        

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.AddCreatedUpdatedInterceptor();
            base.OnConfiguring(builder);
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Examiner>().ToTable("Examiner");
            builder.Entity<Examiner>().HasKey(e => e.id);
            builder.Entity<Examiner>().Property(e => e.id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Examiner>().Property(f => f.firstName);
            builder.Entity<Examiner>().Property(f => f.lastName);
            builder.Entity<Examiner>().OwnsOne(i => i.nationalProviderIdentifier,
                ai =>
                {
                    ai.WithOwner().HasForeignKey("Id");
                });
            builder.UseSnakeCaseNamingConvention();
        }
    }
}