﻿using System.Collections.Generic;

namespace CarStorageDAL.Repository
{
	public interface IRepository<TEntity> where TEntity : class
	{
		List<TEntity> Get();
		TEntity FindById(int id);

	}
}
