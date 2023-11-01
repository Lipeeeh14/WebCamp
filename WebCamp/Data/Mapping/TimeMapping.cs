using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCamp.Domain.Models;

namespace WebCamp.Data.Mapping
{
	public class TimeMapping : IEntityTypeConfiguration<Time>
	{
		public void Configure(EntityTypeBuilder<Time> builder)
		{
			builder.ToTable(nameof(Time));

			builder.HasKey(x => x.Id);

			builder.Property(x => x.Nome)
				.HasMaxLength(80)
				.IsRequired();

			builder.Property(x => x.Sigla)
				.HasMaxLength(4)
				.IsRequired();

			builder.Property(x => x.Apelido)
				.HasMaxLength(20)
				.IsRequired(false);

			builder.HasMany(x => x.Atletas)
				.WithOne(y => y.Time)
				.HasForeignKey(x => x.TimeId)
				.IsRequired();

			builder.HasMany(x => x.Campeonatos)
				.WithOne(y => y.Time)
				.HasForeignKey(y => y.TimeId)
				.IsRequired(false);
		}
	}
}
