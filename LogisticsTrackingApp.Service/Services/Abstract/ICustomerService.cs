﻿using LogisticsTrackingApp.Core.Dtos.CustomerDtos;
using LogisticsTrackingApp.Core.Models;
using LogisticsTrackingApp.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsTrackingApp.Service.Services.Abstract
{
	public interface ICustomerService :IGenericService<Customer>
	{
		Task<List<CustomerWithShipmentDto>> GetCustomerWitShipment();

		//Task<IEnumerable<ResultCustomerDto>> GetAll();
		//Task<ResultCustomerDto> GetById(int Id);
		//Task CreateCustomer(CreateCustomerDto createCustomerDto);
		//Task<string> UpdateCustomer(UpdateCustomerDto updateCustomerDto );
		//Task<string> DeleteCustomer(int Id);
	}
}
