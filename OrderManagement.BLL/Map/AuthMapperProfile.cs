using AutoMapper;
using OrderManagement.BLL.Models;
using OrderManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.BLL.Map
{
    public class AuthMapperProfile : Profile
    {
        public AuthMapperProfile()
        {
            CreateMap<OrderDto, Order>()
                .ForMember(dest => dest.Id,
                           opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name,
                           opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.StateId,
                           opt => opt.MapFrom(src => src.StateId))
                .ForMember(dest => dest.StateName,
                           opt => opt.MapFrom(src => src.State.Name))
                .ReverseMap();

            CreateMap<ElementTypeDto, ElementType>().ReverseMap();
            CreateMap<StateDto, State>().ReverseMap();
        }
    }
}
