using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCamp.Domain.Models;

namespace WebCamp.Data.Mapping
{
	public class AtletaMapping : IEntityTypeConfiguration<Atleta>
	{
		public void Configure(EntityTypeBuilder<Atleta> builder)
		{
			builder.ToTable(nameof(Atleta));

			builder.HasKey(x => x.Id);

			builder.Property(x => x.Nome)
				.HasMaxLength(40)
				.IsRequired();

			builder.Property(x => x.Posicao)
				.HasMaxLength(20)
				.IsRequired();

			builder.HasOne(x => x.Time)
				.WithMany(y => y.Atletas)
				.HasForeignKey(x => x.TimeId)
				.IsRequired();
		}
	}
}
