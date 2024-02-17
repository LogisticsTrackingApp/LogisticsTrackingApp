using LogisticsTrackingApp.Core.Models.BaseEntities;
using LogisticsTrackingApp.Core.Repositories;
using LogisticsTrackingApp.Core.Services;
using LogisticsTrackingApp.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsTrackingApp.Service.Services
{
	public class GenericService<T> : IGenericService<T> where T : BaseEntity
	{
	 private readonly IGenericRepository<T> _repository;
		private readonly IUnitOfWork _unitOfWork;

		public GenericService(IGenericRepository<T> repository, IUnitOfWork unitOfWork)
		{
			_repository = repository;
			_unitOfWork = unitOfWork;
		}

		public async Task<T> DeleteAsync(T entity)
		{
			await _repository.AddAsync(entity);
			await _unitOfWork.CommitAsync();
			return entity;
		}

		public async Task<IEnumerable<T>> GetAllAsync()
		{
			return await _repository.GetAllAsync();
		}

		public async Task<T> GetIdAsync(int id)
		{
			return await _repository.GetIdAsync(id);
		}

		public async Task<T> InsertAsync(T entity)
		{
			await _repository.AddAsync(entity);
			await _unitOfWork.CommitAsync();
			return entity;
		}

		public async Task<T> UpdateAsync(T entity)
		{
			_repository.Update(entity);
			await _unitOfWork.CommitAsync();
			return entity;
		}
	}
}
