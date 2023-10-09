﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureTemplate.Application.Persitence
{
    public interface IRepository<T>
    {
        Task AddAsync(T entity);
    }
}
