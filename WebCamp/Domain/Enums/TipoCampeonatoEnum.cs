namespace WebCamp.Domain.Enums
{
	public class TipoCampeonatoEnum : Enumeration
	{
		public TipoCampeonatoEnum(long id, string nome) : base(id, nome)
		{
		}

		public static TipoCampeonatoEnum MataMata = new TipoCampeonatoEnum(1, "Mata-Mata");
		public static TipoCampeonatoEnum PontosCorridos = new TipoCampeonatoEnum(2, "Pontos Corridos");
	}
}
