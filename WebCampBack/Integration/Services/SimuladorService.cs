using Newtonsoft.Json;
using System.Text.Json.Serialization;
using WebCampBack.Integration.Requests;
using WebCampBack.Integration.Responses;
using WebCampBack.Integration.Services.Interfaces;

namespace WebCampBack.Integration.Services
{
	public class SimuladorService : ISimuladorService
	{
		private readonly HttpClient _httpClient;

		public SimuladorService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<PartidaApiResponse?> SimularPartida(PartidaApiRequest request)
		{
			var result = await _httpClient.PostAsJsonAsync($"/partida/simular", request);

			if (!result.IsSuccessStatusCode) return null;

			var response = result.Content.ReadAsStringAsync();

			return JsonConvert.DeserializeObject<PartidaApiResponse?>(response.Result);
		}
	}
}
