using WebCampBack.Integration.Requests;
using WebCampBack.Integration.Responses;

namespace WebCampBack.Integration.Services.Interfaces
{
	public interface ISimuladorService
	{
		Task<PartidaApiResponse?> SimularPartida(PartidaApiRequest request);
	}
}
