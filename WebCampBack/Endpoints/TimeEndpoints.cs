using WebCampBack.DTO_s;
using WebCampBack.Integration.Requests;
using WebCampBack.Integration.Services;

namespace WebCampBack.Endpoints
{
	public static class TimeEndpoints
	{
		public static void MapTimeEndpoints(this IEndpointRouteBuilder app) 
		{
			app.MapPost("time/v1/partida", async (PartidaDTO partidaDTO, SimuladorService simuladorService) =>
			{
				var simuladorDto = new PartidaApiRequest(partidaDTO.TimeMandante, partidaDTO.TimeVisitante);
				var result = await simuladorService.SimularPartida(simuladorDto);

				if (result == null) return Results.BadRequest();

				return Results.Ok(result);
			});
		}
	}
}
