namespace WebCamp.ViewModels
{
	public record CampeonatoViewModel
	{
		public long Id { get; init; }
		public string Nome { get; init; } = string.Empty;
		public int TipoCampeonatoId { get; init; }
		public bool Ativo { get; init; }
        public DateTime DataInicio { get; init; }
        public DateTime? DataFim { get; init; }
	}
}
