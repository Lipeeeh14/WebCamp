using Microsoft.EntityFrameworkCore;
using WebCamp.Data.Mapping;
using WebCamp.Domain.Models;

namespace WebCamp.Data
{
	public class WebCampContext : DbContext
	{
		public WebCampContext(DbContextOptions options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.ApplyConfiguration(new TipoCampeonatoMapping());
			modelBuilder.ApplyConfiguration(new CampeonatoMapping());
			modelBuilder.ApplyConfiguration(new TimeMapping());
			modelBuilder.ApplyConfiguration(new AtletaMapping());
			modelBuilder.ApplyConfiguration(new CampeonatoTimeMapping());
		}

        public DbSet<Campeonato> Campeonato { get; set; }
        public DbSet<Time> Time { get; set; }
        public DbSet<Atleta> Atleta { get; set; }
        public DbSet<CampeonatoTime> CampeonatoTime { get; set; }
	}
}
