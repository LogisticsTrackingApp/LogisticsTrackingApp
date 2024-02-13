using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsTrackingApp.Core.Repositories
{
	public interface IGenericRepository<T> where T : class
	{

		Task<IEnumerable<T>> GetAllAsync();

		Task<T> GetIdAsync(int id);

		Task<T> InsertAsync(T entity);

		Task<T> UpdateAsync(T entity);

		Task<T> DeleteAsync(int id);

	}
}
