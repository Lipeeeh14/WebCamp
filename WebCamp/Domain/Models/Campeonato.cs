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

		public void AtualizarCampeonato(string nome, bool ativo, int tipoCampeonatoId)
		{
			AtualizarNome(nome);
			Ativo = ativo;
			TipoCampeonatoId = tipoCampeonatoId;
		}

		public void FinalizarCampeonato() 
		{
			DataFim = DateTime.Now;
			Ativo = false;
		}
	}
}
