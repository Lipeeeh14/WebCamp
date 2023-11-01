using WebCamp.Domain.Models;

namespace WebCamp.Domain.Enums
{
	public class Enumeration : BaseModel
	{
		public Enumeration(long id, string nome) 
			: base(id, nome)
		{
		}
	}
}
