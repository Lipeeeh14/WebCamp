namespace WebCamp.Domain.Models
{
	public class CampeonatoTime
	{
		public long CampeonatoId { get; private set; }
        public Campeonato? Campeonato { get; private set; }

        public long TimeId { get; private set; }
        public Time? Time { get; private set; }
    }
}
