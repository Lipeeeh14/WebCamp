namespace WebCamp.Domain.Enums
{
	public class TipoCampeonatoEnum : Enumeration
	{
		public TipoCampeonatoEnum()
		{
		}

		public TipoCampeonatoEnum(int id, string nome) : base(id, nome)
		{
		}

		public static TipoCampeonatoEnum MataMata = new(1, "Mata-Mata");
		public static TipoCampeonatoEnum PontosCorridos = new(2, "Pontos Corridos");
	}
}
