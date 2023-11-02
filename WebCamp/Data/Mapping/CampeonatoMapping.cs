using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCamp.Domain.Enums;
using WebCamp.Domain.Models;

namespace WebCamp.Data.Mapping
{
	public class CampeonatoMapping : IEntityTypeConfiguration<Campeonato>
	{
		public void Configure(EntityTypeBuilder<Campeonato> builder)
		{
			builder.ToTable(nameof(Campeonato));

			builder.HasKey(x => x.Id);

			builder.Property(x => x.Nome)
				.HasMaxLength(100)
				.IsRequired();

			builder.HasMany(x => x.Times)
				.WithOne(y => y.Campeonato)
				.HasForeignKey(y => y.CampeonatoId)
				.IsRequired(false);
		}
	}
}
