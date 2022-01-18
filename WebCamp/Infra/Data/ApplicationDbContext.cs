using Microsoft.EntityFrameworkCore;
using WebCamp.Domain.Model.Campeonato;
using WebCamp.Infra.Data.Mapping;

namespace WebCamp.Infra.Data
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Campeonato> Campeonatos { get; set; }

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			//builder.Ignore<Notification>();

			builder.ApplyConfiguration(new CampeonatoMapping());
		}
	}
}
