using AutoMapper;
using SolExamen2.DataAccess.DBEntities;
using SolExamen2.Models;

namespace SolExamen2.Profiles
{
    public class AlumnoProfile : Profile
    {
        public AlumnoProfile()
        {
            CreateMap<AlumnoEntity, AlumnoModel>().ReverseMap();
        }
    }
}

