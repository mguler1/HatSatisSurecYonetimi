using AutoMapper;
using Dto;
using Entity.Concrete;

namespace UI.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<HatSatisEkleDto,HatSatis>().ReverseMap();
        }
       
    }
}
