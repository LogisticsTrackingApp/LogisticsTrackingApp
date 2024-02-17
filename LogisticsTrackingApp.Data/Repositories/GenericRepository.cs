﻿using LogisticsTrackingApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsTrackingApp.Data.Repositories
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{

		public Task<T> DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<T>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public Task<T> GetIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<T> InsertAsync(T entity)
		{
			throw new NotImplementedException();
		}

		public Task<T> UpdateAsync(T entity)
		{
			throw new NotImplementedException();
		}
	}
}
