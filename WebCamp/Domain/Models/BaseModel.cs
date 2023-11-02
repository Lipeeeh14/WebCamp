namespace WebCamp.Domain.Models
{
	public class BaseModel
	{
        public long Id { get; private set; }
        public string Nome { get; private set; } = string.Empty;

		public BaseModel()
		{
		}

		public BaseModel(long id, string nome)
		{
			Id = id;
			Nome = nome;
		}

		public BaseModel(string nome)
		{
			Nome = nome;
		}

		public void AtualizarNome(string nome) => Nome = nome;
	}
}
