namespace WebCamp.Domain.Models
{
	public class Time : BaseModel
	{
		public string Sigla { get; private set; } = string.Empty;
        public string? Apelido { get; private set; }

        public ICollection<Atleta> Atletas { get; private set; } = new List<Atleta>();

		public ICollection<CampeonatoTime> Campeonatos { get; private set; } = new List<CampeonatoTime>();

		public Time(string nome, string sigla, string? apelido = null) 
			: base(nome)
		{
			Sigla = sigla;
			Apelido = apelido;
		}
	}
}
