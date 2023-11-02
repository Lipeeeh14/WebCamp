using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCamp.Domain.Enums;

namespace WebCamp.Data.Mapping
{
	public class TipoCampeonatoMapping : IEntityTypeConfiguration<TipoCampeonatoEnum>
	{
		public void Configure(EntityTypeBuilder<TipoCampeonatoEnum> builder)
		{
			builder.ToTable("TipoCampeonato");

			builder.Property(x => x.Nome)
				.HasMaxLength(40)
				.IsRequired();
		}
	}
}
