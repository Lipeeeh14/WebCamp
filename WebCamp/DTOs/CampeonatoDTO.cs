namespace WebCamp.DTOs
{
	public record CampeonatoDTO
	{
        public long Id { get; init; }
		public string Nome { get; init; } = string.Empty;
		public int TipoCampeonatoId { get; init; }
		public bool Ativo { get; init; }
	}
}
