namespace WebCampBack.Integration.Responses
{
	public record PartidaApiResponse
	{
		public string Resultado { get; init; } = string.Empty;
        public int GolsTimeMandante { get; init; }
        public int GolsTimeVisitante { get; init; }
	}
}
