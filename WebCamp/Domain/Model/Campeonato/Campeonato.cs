using WebCamp.Domain.Model.BaseModels;

namespace WebCamp.Domain.Model.Campeonato
{
	public class Campeonato : BaseModel
	{
		public string Nome { get; private set; }
		public bool Finalizado { get; private set; }
	}
}
