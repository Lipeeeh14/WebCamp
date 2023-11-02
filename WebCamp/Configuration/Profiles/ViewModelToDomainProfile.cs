using AutoMapper;
using WebCamp.Domain.Models;
using WebCamp.DTOs;

namespace WebCamp.Configuration.Profiles
{
	public class ViewModelToDomainProfile : Profile
	{
		public ViewModelToDomainProfile()
		{
			CreateMap<CampeonatoDTO, Campeonato>()
				.ReverseMap();
		}
	}
}
