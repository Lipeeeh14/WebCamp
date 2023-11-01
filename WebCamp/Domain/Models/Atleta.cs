namespace WebCamp.Domain.Models
{
	public class Atleta : BaseModel
	{
        public int Numero { get; private set; }
        public string Posicao { get; private set; } = string.Empty;
		public DateTime DataNascimento { get; private set; }

        public long TimeId { get; private set; }
        public Time? Time { get; private set; }

        public Atleta(int numero, string posicao, 
			DateTime dataNascimento, string nome, long timeId) 
			: base(nome)
		{
			Numero = numero;
			Posicao = posicao;
			DataNascimento = dataNascimento;
			TimeId = timeId;
		}
	}
}
