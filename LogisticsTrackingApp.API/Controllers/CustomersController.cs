using AutoMapper;
using LogisticsTrackingApp.Core.Dtos;
using LogisticsTrackingApp.Core.Dtos.CustomerDtos;
using LogisticsTrackingApp.Core.Models;
using LogisticsTrackingApp.Service.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LogisticsTrackingApp.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomersController : ControllerBase
	{
		private readonly ICustomerService _customerService;
		private readonly IMapper _mapper;

		public CustomersController(ICustomerService customerService, IMapper mapper)
		{
			_customerService = customerService;
			_mapper = mapper;
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var customers = await _customerService.GetAllAsync();
			return Ok(customers);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(int id)
		{
			var customer = await _customerService.GetIdAsync(id);
			var customersDto = _mapper.Map<ResultCustomerDto>(customer);
			return Ok(customersDto);
		}

		[HttpPost]
		public async Task<IActionResult> Add(CreateCustomerDto createCustomer)
		{
			var values =  _mapper.Map<CreateCustomerDto, Customer>(createCustomer);
		     await _customerService.InsertAsync(values);
			 return Ok("başarılı şekilde eklendi");


			//var values = await _customerService.InsertAsync(_mapper.Map<Customer>(createCustomer));
			//var customerDto = _mapper.Map<CreateCustomerDto>(customer);
			//return Ok(customerDto);
		}

		[HttpPut]
		public async Task<IActionResult> Update(UpdateCustomerDto updateCustomer)
		{
			await _customerService.UpdateAsync(_mapper.Map<Customer>(updateCustomer));

			return Ok();
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(int id)
		{
			var customer = await _customerService.GetIdAsync(id);
			await _customerService.DeleteAsync(customer);
			return Ok();


		}
	}
}
