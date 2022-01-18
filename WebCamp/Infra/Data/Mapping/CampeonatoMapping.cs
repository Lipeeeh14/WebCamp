using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCamp.Domain.Model.Campeonato;

namespace WebCamp.Infra.Data.Mapping
{
	public class CampeonatoMapping : IEntityTypeConfiguration<Campeonato>
	{
		public void Configure(EntityTypeBuilder<Campeonato> builder)
		{
			builder.ToTable("Campeonato");

			builder.HasKey(c => c.Id);

			builder.Property(c => c.Nome)
				.HasMaxLength(100)
				.IsRequired();
		}
	}
}
