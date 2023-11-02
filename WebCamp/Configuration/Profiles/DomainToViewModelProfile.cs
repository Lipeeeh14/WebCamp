using AutoMapper;
using WebCamp.Domain.Enums;
using WebCamp.Domain.Models;
using WebCamp.ViewModels;

namespace WebCamp.Configuration.Profiles
{
	public class DomainToViewModelProfile : Profile
	{
		public DomainToViewModelProfile()
		{
			CreateMap<Campeonato, CampeonatoViewModel>()
				.ReverseMap();

			CreateMap<TipoCampeonatoEnum, TipoCampeonatoViewModel>()
				.ReverseMap();
		}
	}
}
