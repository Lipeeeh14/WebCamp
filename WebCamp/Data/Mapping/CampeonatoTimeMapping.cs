using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCamp.Domain.Models;

namespace WebCamp.Data.Mapping
{
	public class CampeonatoTimeMapping : IEntityTypeConfiguration<CampeonatoTime>
	{
		public void Configure(EntityTypeBuilder<CampeonatoTime> builder)
		{
			builder.ToTable(nameof(CampeonatoTime));

			builder.HasKey(x => new { x.TimeId, x.CampeonatoId });
		}
	}
}
