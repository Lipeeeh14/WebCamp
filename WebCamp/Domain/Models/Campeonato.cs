using WebCamp.Domain.Enums;

namespace WebCamp.Domain.Models
{
	public class Campeonato : BaseModel
	{
		public bool Ativo { get; private set; } = true;
        public DateTime DataInicio { get; private set; } = DateTime.Now;
        public DateTime? DataFim { get; private set; }

        public int TipoCampeonatoId { get; private set; }
        public TipoCampeonatoEnum TipoCampeonato { get; private set; }

		public ICollection<CampeonatoTime> Times { get; private set; } = new List<CampeonatoTime>();

        public Campeonato() { }

		public Campeonato(string nome, bool ativo, int tipoCampeonatoId)
			: base(nome)
		{
			Ativo = ativo;
			TipoCampeonatoId = tipoCampeonatoId;
		}
	}
}
