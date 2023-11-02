using System.Reflection;

namespace WebCamp.Domain.Enums
{
	// https://learn.microsoft.com/pt-br/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/enumeration-classes-over-enum-types

	public class Enumeration
	{
		public int Id { get; private set; }
		public string Nome { get; private set; } = string.Empty;

		public Enumeration()
		{
		}

		public Enumeration(int id, string nome)
		{
			Id = id;
			Nome = nome;
		}

		public static IEnumerable<T> GetAll<T>() where T : Enumeration =>
			typeof(T).GetFields(BindingFlags.Public |
							BindingFlags.Static |
							BindingFlags.DeclaredOnly).Select(x => x.GetValue(null))
							.Cast<T>();
	}
}
