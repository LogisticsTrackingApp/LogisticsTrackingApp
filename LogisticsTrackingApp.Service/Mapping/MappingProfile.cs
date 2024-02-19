using AutoMapper;
using LogisticsTrackingApp.Core.Dtos.CustomerDtos;
using LogisticsTrackingApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsTrackingApp.Service.Mapping
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Customer,CreateCustomerDto>().ReverseMap();
			CreateMap<Customer,UpdateCustomerDto>().ReverseMap();
			CreateMap<Customer,ResultCustomerDto>().ReverseMap();

			CreateMap<Customer,CustomerWithShipmentDto>().ReverseMap();
		}
	}
}
