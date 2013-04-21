using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebMatrix.WebData.Repositories
{
	public interface IRepository<T, TKey> : IDisposable
		where T : class
	{
		IQueryable<T> GetAll();
		T Get(TKey key);
		void Add(T item);
		void Remove(T item);
		void SaveChanges();
	}
}
