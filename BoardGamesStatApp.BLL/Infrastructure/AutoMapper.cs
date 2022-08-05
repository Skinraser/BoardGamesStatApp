using AutoMapper;
using BoardGamesStatApp.BLL.Dto;
using BoardGamesStatApp.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesStatApp.BLL
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
           CreateMap<BoardGame, BoardGameDto>().ReverseMap();
        }
    }
}
